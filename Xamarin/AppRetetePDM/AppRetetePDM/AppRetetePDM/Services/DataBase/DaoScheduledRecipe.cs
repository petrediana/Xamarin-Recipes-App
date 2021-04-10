using AppRetetePDM.Classes.ScheduledRecipe;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AppRetetePDM.Services.DataBase
{
    public class DaoScheduledRecipe
    {
        private DaoScheduledRecipe()
        {
            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "app_recipes_db_1.db");
            _connection = new SQLiteConnection(dbPath);
            _connection.CreateTable<ScheduledRecipe>();
        }

        static DaoScheduledRecipe()
        {
            _instance = new DaoScheduledRecipe();
        }

        public static DaoScheduledRecipe Instance { get => _instance; }

        private readonly SQLiteConnection _connection;
        private static readonly DaoScheduledRecipe _instance;

        public List<ScheduledRecipe> GetAllScheduledRecipes()
            => _connection.Query<ScheduledRecipe>("SELECT * FROM ScheduledRecipe");

        public int AddRecipe(ScheduledRecipe scheduledRecipe)
            => _connection.Insert(scheduledRecipe);
    }
}
