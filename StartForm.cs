using AmApp.AppContext;
using AmApp.Ext;
using AmApp.Models.Identity;
using AmApp.Models.Main;
using AmApp.Pages;
using Microsoft.EntityFrameworkCore;

namespace AmApp;

public partial class StartForm : Form
{
    public StartForm()
    {
        InitializeComponent();

        // CreateData(); // Стартовый метод для создания минимальных примерочных данных
    }


    public void CreateData()
    {
        using (var db = new AppDbContext())
        {
            db.Database.EnsureDeleted();
            db.Database.EnsureCreated();
            try
            {
                var users = new List<User>(){
                    new User { UserName = "Ivan_Petrov", PasswordHash = "k9T5mP".CreateMD5(), FIO = "Иван Петров"},
                    new User { UserName = "Anna_Smirnova", PasswordHash = "bH6jL3".CreateMD5(), FIO = "Анна Смирнова"},
                    new User { UserName = "Sergei_Kuznetsov", PasswordHash = "pO1nQ2".CreateMD5(), FIO = "Сергей Кузнецов"},
                    new User { UserName = "Marina_Popova", PasswordHash = "zX4cA7".CreateMD5(), FIO = "Марина Попова"},
                    new User { UserName = "Andrei_Sokolov", PasswordHash = "dS8wE1".CreateMD5(), FIO = "Андрей Соколов"},
                    new User { UserName = "Admin", PasswordHash = "qwerty12345".CreateMD5(), FIO = "Чачин Алексей"},
                };

                var roles = new List<Role>(){
                    new Role{ Name = "Worker" },
                    new Role{ Name = "Master" },
                    new Role{ Name = "Admin" },
                };

                var userRoles = new List<UserRole>();

                foreach (var item in users)
                {
                    if (item != users.Last())
                    {
                        userRoles.Add(new UserRole
                        {
                            UserId = item.Id,
                            RoleId = roles[(users.IndexOf(item) % 2 == 0 ? 1 : 0)].Id
                        });
                    }
                    else
                    {
                        userRoles.Add(new UserRole
                        {
                            UserId = item.Id,
                            RoleId = roles[2].Id
                        });
                    }
                }

                var authorizeMethodRoles = new List<AuthorizeMethodRole>()
                {
                    new AuthorizeMethodRole
                    {
                        RoleId = roles[1].Id,
                        MethodName = "CreateWithoutRaskroy"
                    }
                };



                var cehs = new List<Ceh>(){
                        new Ceh{ Name = "01"},
                        new Ceh{ Name = "02"},
                        new Ceh{ Name = "03"},
                        new Ceh{ Name = "04"}
                    };
                var splavs = new List<Splav>()
                {
                    new Splav{ Name = "TiNi6"}
                };

                var teks = new List<Tek>();

                foreach (var item in cehs)
                {
                    teks.Add(new Tek
                    {
                        Code = $"{item.Name}-{splavs[0].Name}",
                        CehId = item.Id
                    });
                }

                var operTek = new List<TekOper>();

                operTek.AddRange([
                        new TekOper{ TekId = teks[0].Id, OperName = $"1 - Погрузка" },
                        new TekOper{ TekId = teks[0].Id, OperName = $"2 - Плавление" },
                        new TekOper{ TekId = teks[0].Id, OperName = $"3 - Выгрузка" },
                        new TekOper{ TekId = teks[0].Id, OperName = $"4 - Сдача" },

                        new TekOper{ TekId = teks[1].Id, OperName = $"1 - Получение" },
                        new TekOper{ TekId = teks[1].Id, OperName = $"2 - Погрузка" },
                        new TekOper{ TekId = teks[1].Id, OperName = $"3 - Плавление" },
                        new TekOper{ TekId = teks[1].Id, OperName = $"4 - Прессование" },
                        new TekOper{ TekId = teks[1].Id, OperName = $"5 - Выгрузка" },
                        new TekOper{ TekId = teks[1].Id, OperName = $"6 - Сдача" },

                        new TekOper{ TekId = teks[2].Id, OperName = $"1 - Получение" },
                        new TekOper{ TekId = teks[2].Id, OperName = $"2 - Погрузка" },
                        new TekOper{ TekId = teks[2].Id, OperName = $"3 - Измерение" },
                        new TekOper{ TekId = teks[2].Id, OperName = $"4 - Приварка" },
                        new TekOper{ TekId = teks[2].Id, OperName = $"5 - Выгрузка" },
                        new TekOper{ TekId = teks[2].Id, OperName = $"6 - Сдача" },

                        new TekOper{ TekId = teks[3].Id, OperName = $"1 - Получение" },
                        new TekOper{ TekId = teks[3].Id, OperName = $"2 - Погрузка" },
                        new TekOper{ TekId = teks[3].Id, OperName = $"3 - Обработка" },
                        new TekOper{ TekId = teks[3].Id, OperName = $"3 - Взвешивание" },
                        new TekOper{ TekId = teks[3].Id, OperName = $"4 - Выгрузка" },
                        new TekOper{ TekId = teks[3].Id, OperName = $"5 - Сдача" },
                    ]
                );

                var oboruds = new List<GlobalOborud>
                {
                    new GlobalOborud{ Name = "Пресс №1"},
                    new GlobalOborud{ Name = "Пресс №2"},
                    new GlobalOborud{ Name = "Печь №1"},
                    new GlobalOborud{ Name = "Печь №2"},
                    new GlobalOborud{ Name = "Подъемный кран"},
                    new GlobalOborud{ Name = "Токарный станок №1"},
                    new GlobalOborud{ Name = "Токарный станок №2"},
                    new GlobalOborud{ Name = "Токарный станок №3"},
                    new GlobalOborud{ Name = "Сварочный автомат №1"},
                    new GlobalOborud{ Name = "Сварочный автомат №2"},
                    new GlobalOborud{ Name = "Сварочный автомат №3"},
                    new GlobalOborud{ Name = "Сварочный автомат №4"},
                    new GlobalOborud{ Name = "Эстакада поверки"},
                };

                var operOboruds = new List<OperOborud>();

                foreach(var item in operTek)
                {
                    if (item.OperName.Contains("Погрузка") || item.OperName.Contains("Выгрузка"))
                    {
                        var oborArray =
                            oboruds.Where(p => p.Name.Contains("Подъемный кран"))
                                    .Select(p => new OperOborud
                                    {
                                        OborudId = p.Id,
                                        TekOperId = item.Id
                                    });

                        operOboruds.AddRange(oborArray);
                    }

                    if (item.OperName.Contains("Плавление"))
                    {
                        var oborArray =
                            oboruds.Where(p => p.Name.Contains("Печь"))
                                    .Select(p => new OperOborud
                                    {
                                        OborudId = p.Id,
                                        TekOperId = item.Id
                                    });

                        operOboruds.AddRange(oborArray);
                    }

                    if (item.OperName.Contains("Прессование"))
                    {
                        var oborArray =
                            oboruds.Where(p => p.Name.Contains("Пресс"))
                                    .Select(p => new OperOborud
                                    {
                                        OborudId = p.Id,
                                        TekOperId = item.Id
                                    });

                        operOboruds.AddRange(oborArray);
                    }

                    if (item.OperName.Contains("Обработка"))
                    {
                        var oborArray =
                            oboruds.Where(p => p.Name.Contains("Токарный станок") || p.Name.Contains("Сварочный автомат"))
                                    .Select(p => new OperOborud
                                    {
                                        OborudId = p.Id,
                                        TekOperId = item.Id
                                    });

                        operOboruds.AddRange(oborArray);
                    }

                    if (item.OperName.Contains("Измерение"))
                    {
                        var oborArray =
                            oboruds.Where(p => p.Name.Contains("Эстакада поверки"))
                                    .Select(p => new OperOborud
                                    {
                                        OborudId = p.Id,
                                        TekOperId = item.Id
                                    });

                        operOboruds.AddRange(oborArray);
                    }
                }

                db.GlobalOboruds.AddRange(oboruds);

                db.OperOboruds.AddRange(operOboruds);

                db.Splavs.AddRange(splavs);

                db.Cehs.AddRange(cehs);

                db.Teks.AddRange(teks);

                db.TekOpers.AddRange(operTek);

                db.Users.AddRange(users);

                db.Roles.AddRange(roles);

                db.UserRoles.AddRange(userRoles);

                db.SaveChanges();

                MessageBox.Show("Успешное создание данных");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

    private void AuthorizeBtn_Click(object sender, EventArgs e)
    {
        var userName = Login.Text;
        var password = Password.Text;

        if (!string.IsNullOrWhiteSpace(userName) && !string.IsNullOrWhiteSpace(password))
        {
            using (var db = new AppDbContext())
            {
                var user = db.Users.Where(p => p.UserName.ToUpper().Equals(userName.ToUpper()) && p.PasswordHash.Equals(password.CreateMD5())).FirstOrDefault();
                if (user != null)
                {
                    PasportsForm pasportsForm = new PasportsForm(user);
                    this.Hide();
                    pasportsForm.Closed += (s, args) => this.Close();
                    pasportsForm.Show();
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль!");
                }
            }
        }
        else
        {
            MessageBox.Show("Пустой логин или пароль!");
        }
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }
}
