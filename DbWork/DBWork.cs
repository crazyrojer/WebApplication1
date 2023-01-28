using Npgsql;
using System.Data.Common;

namespace DbWork
{
    public static class DBWork
    {
        private static NpgsqlConnection npgSqlConnection = new NpgsqlConnection("Server=localhost;Port=5432;Username=postgres;Password=postgres;Database=homework;");
        
        public static void AddUser(User user)
        {
            npgSqlConnection.Open();
            NpgsqlCommand npgSqlCommand = new NpgsqlCommand($"INSERT INTO users VALUES ({user.Id}, '{user.Name}', {user.Kaka})", npgSqlConnection);
            int count = npgSqlCommand.ExecuteNonQuery();
            npgSqlConnection.Close();
        }

        public static void DeleteUser(User user) 
        {
            npgSqlConnection.Open();
            NpgsqlCommand npgSqlCommand = new NpgsqlCommand($"DELETE FROM users WHERE user_id = {user.Id}", npgSqlConnection);
            int count = npgSqlCommand.ExecuteNonQuery();
            npgSqlConnection.Close();
        }
         public static void ChangeUser(User user)
         {
            npgSqlConnection.Open();
            NpgsqlCommand npgSqlCommand = new NpgsqlCommand($"UPDATE users SET user_name = '{user.Name}' WHERE user_id = {user.Id}", npgSqlConnection);
            int count = npgSqlCommand.ExecuteNonQuery();
            npgSqlConnection.Close();
         }

        public static void AddKaka(User user)
        {
            npgSqlConnection.Open();
            NpgsqlCommand npgSqlCommand = new NpgsqlCommand($"UPDATE users SET user_kakah = user_kakah + {user.Kaka} WHERE user_id = {user.Id}", npgSqlConnection);
            int count = npgSqlCommand.ExecuteNonQuery();
            npgSqlConnection.Close();
        }

        public static List<User> GetUsers()
        {
            List<User> users = new List<User>();
            npgSqlConnection.Open();
            NpgsqlCommand npgSqlCommand = new NpgsqlCommand("SELECT * FROM users", npgSqlConnection);
            NpgsqlDataReader npgSqlDataReader = npgSqlCommand.ExecuteReader();
            foreach (DbDataRecord dbDataRecord in npgSqlDataReader)
            {
                users.Add(new User(Convert.ToInt32(dbDataRecord["user_id"]), dbDataRecord["user_name"].ToString(), Convert.ToInt32(dbDataRecord["user_kakah"])));
            }
            npgSqlConnection.Close();
            return users;
        }



    }
}
