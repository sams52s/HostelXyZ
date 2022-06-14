using HostelXyZ.LoginRegistration.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace HostelXyZ.LoginRegistration.Service
{
    public static class AuthService
    {
        static SQLiteAsyncConnection db;
        static async Task Init()
        {
            if (db != null)
                return;

            // Get an absolute path to the database file
            var databasePath = Path.Combine(FileSystem.AppDataDirectory, "Hostel.db");

            db = new SQLiteAsyncConnection(databasePath);

            await db.CreateTableAsync<UserModel>();
        }
        public static async Task AddUser(string email, string password) {
            await Init();
            var image = "boy.png";
            var user = new UserModel
            {
                UserName=email,
                Email = email,
                Password = password,
                PhoneNumber= password,
                Image = image
            };

            var id = await db.InsertAsync(user);
        }
        public static async Task RemoveUser(int id)
        {
            await Init();

            await db.DeleteAsync<UserModel>(id);
        }
        public static async Task<IEnumerable<UserModel>> GetUser()
        {
            await Init();

            var user = await db.Table<UserModel>().ToListAsync();
            return user;
        }
    }
}
