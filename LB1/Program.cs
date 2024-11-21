namespace LB1
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // добавление данных
            using (ApplicationContext db = new ApplicationContext())
            {
                // создаем два объекта User
                User user1 = new User { Name = "Tom", Age = 33 };
                User user2 = new User { Name = "Alice", Age = 26 };

                // добавляем их в бд
                db.Users.AddRange(user1, user2);
                db.SaveChanges();
            }
            ApplicationConfiguration.Initialize();
            Application.Run(new FormMain());
        }
    }
}