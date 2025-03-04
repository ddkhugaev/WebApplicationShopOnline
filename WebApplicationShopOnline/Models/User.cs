namespace WebApplicationShopOnline.Models
{
    public class User
    {
        static int instanceCounter = 0;
        public int Id { get; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public User(string name, string surname, string login, string password)
        {
            Id = instanceCounter;
            Name = name;
            Surname = surname;
            Login = login;
            Password = password;
            instanceCounter++;
        }
        public override string ToString()
        {
            return $"Имя: {Name}\nФамилия: {Surname}\nЛогин: {Login}\nПароль: {Password}";
        }
    }
}
