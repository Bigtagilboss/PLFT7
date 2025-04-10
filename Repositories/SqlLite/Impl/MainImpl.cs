using AmApp.AppContext;
using AmApp.Models.Identity;
using AmApp.Models.Main;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace AmApp.Repositories.SqlLite.Impl
{
    internal class MainImpl
    {
        public UserRole? userRole { get; set; }
        public List<Pasport> GetPasports(Pasport filter)
        {
            using var db = new AppDbContext();
            try
            {
                var pasports = db.Pasports.Where(p =>
                    p.Nplav.Contains(filter.Nplav) &&
                    p.Npart.Contains(filter.Npart) &&
                    p.CehId.Contains(filter.CehId)
                ).Include(p=>p.ceh)
                .Include(p => p.user)
                .Include(p => p.tek)
                .Include(p => p.splav).ToList();
                if (pasports.Any())
                {
                    return pasports;
                }
                else
                {
                    throw new Exception("Ничего не найдено");
                }
            }
            catch
            {
                throw;
            }
        }

        public List<Operation> GetOpers(Pasport pasport)
        {
            using var db = new AppDbContext();
            try
            {
                var result = db.Operations.Where(p=>p.PasportId == pasport.Id)
                    .Include(p => p.operRashod)
                    .Include(p => p.pasport)
                    .Include(p => p.tekOper)
                    .OrderBy(p=>p.Sort).ToList();

                return result;
            }
            catch
            {
                throw;
            }
        }
        public List<Zagot> GetZagots(Pasport pasport, Operation operation)
        {
            using var db = new AppDbContext();
            try
            {
                var zagots = db.Zagots.Where(p=>p.PasportId == pasport.Id).Include(p => p.zagotIn).Include(p => p.zagotOut).ToList();

                var maxOper = db.Operations.Where(p => p.PasportId == operation.PasportId)
                    .Include(p => p.operRashod).Where(p => p.operRashod != null).ToList()
                    .MaxBy(p => p.Sort);

                var result = zagots.Select(p =>
                {
                    p.LastOper = maxOper;
                    return p;
                }).ToList();

                return result;
            }
            catch
            {
                throw;
            }
        }

        public UserRole GetUserData(User user)
        {
            using var db = new AppDbContext();          
            try
            {
                var userRole = db.UserRoles.Where(p => p.UserId.Equals(user.Id)).Include(p => p.Role).Include(p => p.User).FirstOrDefault();

                return userRole;
            }
            catch
            {
                throw;
            }
        }

        public List<Ceh> GetCeh()
        {
            using var db = new AppDbContext();
            try
            {
                var result = db.Cehs.OrderBy(p => p.Name).ToList();
                return result;
            }
            catch
            {
                throw;
            }
        }

        public List<Tek> GetTeks(string cehId = "", string tekId = "")
        {
            using var db = new AppDbContext();
            try
            {
                var result = db.Teks.Where(p=>p.CehId.Contains(cehId) && p.Id.Contains(tekId)).ToList().Select(p =>
                {
                    p.tekOpers = db.TekOpers.Where(p2 => p2.TekId == p.Id).ToList();
                    return p;
                }).ToList();

                return result;
            }
            catch
            {
                throw;
            }
        }

        public List<Splav> GetSplavs()
        {
            using var db = new AppDbContext();
            try
            {
                var result = db.Splavs.ToList();
                return result;
            }
            catch
            {
                throw;
            }

        }

        public string GetNplav(string ceh)
        {
            using var db = new AppDbContext();
            try
            {
                var nplav = db.Nplavs.FirstOrDefault();
                if (nplav != null)
                {
                    db.Nplavs.Remove(nplav);
                    db.SaveChanges();
                    nplav.Nplav += 1;
                    db.Nplavs.Add(nplav);
                    db.SaveChanges();
                }
                else
                {
                    nplav = new NPlav { Nplav = 1000 };
                    nplav.Nplav += 1;
                    db.Nplavs.Add(nplav);
                    db.SaveChanges();
                }

                return $"{ceh}-{nplav.Nplav}";
            }
            catch
            {
                throw;
            }
        }

        public string CreatePasport(Pasport pasport)
        {
            using var db = new AppDbContext();
            try
            {
                if(db.Pasports.Any(p=>p.Nplav == pasport.Nplav))
                {
                    return "Такой номер плавки уже существует";
                }
                pasport.UserId = userRole.UserId;
                var tek = GetTeks(tekId: pasport.TekId).FirstOrDefault();
                db.Pasports.Add(pasport);
                var opers = tek.tekOpers.OrderBy(p=>p.OperName).Select(p=> new Operation { 
                    OperName = p.OperName, 
                    PasportId = pasport.Id, 
                    Sort = Convert.ToInt32(p.OperName.Substring(0, 1)),
                    TekOperId = p.Id
                });
                db.Operations.AddRange(opers);
                db.Zagots.Add(new Zagot
                {
                    Number = $"Заготовка - {pasport.Nplav}",
                    PasportId = pasport.Id,

                });
                db.SaveChanges();
                return "";
            }
            catch(Exception ex)
            {
                throw;
            }
        }
        
        public bool CheckRole(string MethodName)
        {
            using var db = new AppDbContext();
            try
            {
                return db.AuthorizeMethodRoles.Any(p => p.MethodName == "CreateWithoutRaskroy" && p.RoleId == userRole.RoleId) || userRole.Role.Name == "Admin";
            }
            catch
            {
                throw;
            }
        }

        public void CreateWithoutRaskroy(List<Zagot> zagots, Operation operation)
        {
            using var db = new AppDbContext();
            try
            {
                if (!CheckRole("CreateWithoutRaskroy") )
                {
                    throw new Exception("Нет прав на выполнение данной операции");
                }

                var operRashod = new OperRashod
                {
                    Id = Guid.NewGuid().ToString(),
                    OperId = operation.Id,
                    UserId = userRole.UserId
                };
                var factZagot = new FactZagot
                {
                    OperRashodId = operRashod.Id
                };
                var zagotIn = zagots.Select(p =>
                {
                    var zagotIn = new ZagotIn
                    {
                        ZagotId = p.Id,
                        OperRashodId = operRashod.Id
                    };
                    return zagotIn;
                });
                var zagotOut = zagots.Select(p =>
                {
                    var zagotOut = new ZagotOut
                    {
                        ZagotId = p.Id,
                        FactZagotId = factZagot.Id
                    };
                    return zagotOut;
                });

                db.OperRashods.Add(operRashod);
                db.FactZagots.Add(factZagot);
                db.ZagotsIn.AddRange(zagotIn);
                db.ZagotsOut.AddRange(zagotOut);

                db.SaveChanges();

            }
            catch
            {
                throw;
            }
        }
    
        public bool ClearOper(Operation operation)
        {
            using var db = new AppDbContext();
            try
            {
                var factZagot = db.FactZagots.Where(p => p.OperRashodId == operation.operRashod.Id);
                var operRashod = db.OperRashods.Where(p => p.Id == operation.operRashod.Id);
                var zagotIn = db.ZagotsIn.Where(p => operRashod.Any(a => a.Id == p.OperRashodId));
                var zagotOut = db.ZagotsOut.Where(p => factZagot.Any(a=>a.Id == p.FactZagotId));

                db.FactZagots.RemoveRange(factZagot);
                db.OperRashods.RemoveRange(operRashod);
                db.ZagotsIn.RemoveRange(zagotIn);
                db.ZagotsOut.RemoveRange(zagotOut);

                db.SaveChanges();
                return true;
            }
            catch
            {
                throw;
            }
        }

        public List<OperRashod> GetOperRashod(Operation operation)
        {
            using var db = new AppDbContext();
            try
            {
                var operRashod = db.OperRashods
                                                    .Where(p => p.Id == operation.operRashod.Id)
                                                    .Include(p => p.factZagot)
                                                    .Include(p => p.zagots).ThenInclude(p=>p.zagots)
                                                    .Include(navigationPropertyPath: p => p.factWorkers).ToList();
                
                foreach (var o in operRashod)
                {
                    foreach(var item in o.factWorkers)
                    {
                        item.globalOborud = db.GlobalOboruds.Where(p => p.Id == item.OborudId).FirstOrDefault();
                        item.user = db.Users.Where(p => p.Id == item.UserId).FirstOrDefault();
                    }
                }

                return operRashod;
            }
            catch
            {
                throw;
            }
        }
        public List<FactZagot> GetFactZagot(Operation operation)
        {
            using var db = new AppDbContext();
            try
            {
                var factZagots = db.FactZagots
                                                    .Where(p => p.OperRashodId == operation.operRashod.Id)
                                                    .Include(p=>p.zagots).ThenInclude(p => p.zagots).ToList();


                return factZagots;
            }
            catch
            {
                throw;
            }
        }

        public bool CreateFactWorker(FactWorker factWorker)
        {
            using var db = new AppDbContext();
            try
            {
                db.FactWorkers.Add(factWorker);

                db.SaveChanges();
                return true;
            }
            catch
            {
                throw;
            }
        }
        public bool DeleteFactWorker(FactWorker factWorker)
        {
            using var db = new AppDbContext();
            try
            {
                var findFactWorker = db.FactWorkers.Where(p=>p.Id == factWorker.Id);
                db.FactWorkers.RemoveRange(findFactWorker);

                db.SaveChanges();
                return true;
            }
            catch
            {
                throw;
            }
        }
        public List<User> GetUsers()
        {

            using var db = new AppDbContext();
            try
            {
                var users = db.Users.ToList();
                return users;
            }
            catch
            {
                throw;
            }
        }
        public List<GlobalOborud> GetOboruds(Operation operation)
        {

            using var db = new AppDbContext();
            try
            {
                var operOboruds = db.OperOboruds
                                                       .Where(p=>p.TekOperId == operation.TekOperId).ToList();

                var obors = db.GlobalOboruds.Where(p => operOboruds.Select(p2=>p2.OborudId).Contains(p.Id)).ToList();
                return obors;
            }
            catch
            {
                throw;
            }
        }
    }
}
