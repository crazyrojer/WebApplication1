namespace WebApplication1
{
    public class UserHub
    {
        public List<User> users { get; private set; }

        public UserHub()
        {
            users = new List<User>()
            {
                new User(1, "Vlad"),
                new User(2, "Andrey"),
                new User(3, "Vlad"),
                new User(4, "Nastya"),
                new User(5, "Nastya"),
                new User(6, "Sasha"),
            };
        }
        public void AddUser(string name, int id)
        {
            users.Add(new User(id, name));
        }

        public void RemoveUser(int id)
        {
            foreach (var item in users.ToList())
            {
                if (item.Id == id)
                {
                    users.Remove(item);
                }
            }
        }

        public void ChangeUser(int id, string name)
        {
            foreach (var item in users.ToList())
            {
                if (item.Id == id)
                {
                    item.Name = name;
                }
            }
        }

    }
}
