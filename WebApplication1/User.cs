namespace WebApplication1
{
    public class User: IEntity
    {
        public int Id { get;  set; }
        public string Name { get;  set; }
        public int Kaka { get; set; }

        public User(int id, string name, int kaka)
        {
            Id= id;
            Name= name;
            Kaka= kaka;
        }

        public User(int id, string name)
        {
            Id = id;
            Name = name;
            Kaka = 0;
        }

        public User(int id)
        {
            Id = id;
            Name = "Adolf";
            Kaka = 0;
        }
    }
}
