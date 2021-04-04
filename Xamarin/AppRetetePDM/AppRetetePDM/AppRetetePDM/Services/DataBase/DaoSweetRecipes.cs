using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.IO;
using AppRetetePDM.Classes.Recipe;

namespace AppRetetePDM.Services.DataBase
{
    public class DaoSweetRecipes
    {
        private DaoSweetRecipes()
        {
            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "app_recipes_db_1.db");
            _connection = new SQLiteConnection(dbPath);
            _connection.CreateTable<SweetsRecipe>();
        }

        static DaoSweetRecipes()
        {
            _instance = new DaoSweetRecipes();
        }

        public static DaoSweetRecipes Instance { get => _instance; }

        private readonly SQLiteConnection _connection;
        private static readonly DaoSweetRecipes _instance;

        public int AddRecipe(SweetsRecipe sweetsRecipe)
            => _connection.Insert(sweetsRecipe);

        public int AddListOfRecipes(List<SweetsRecipe> baseRecipes)
            => _connection.InsertAll(baseRecipes);

        public List<SweetsRecipe> GetAllSweetRecipes()
            => _connection.Query<SweetsRecipe>("SELECT * FROM SweetsRecipe");

        public int DeleteRecipe(SweetsRecipe sweetsRecipe)
            => _connection.Delete(sweetsRecipe);

        public int UpdateRecipe(SweetsRecipe sweetsRecipe)
            => _connection.Update(sweetsRecipe);
    }
}
