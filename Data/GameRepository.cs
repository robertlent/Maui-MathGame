using Maui_MathApp.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maui_MathApp.Data
{
    public class GameRepository
    {
        string _dbPath;
        private SQLiteConnection connection;

        public GameRepository(string dbPath)
        {
            _dbPath = dbPath;
        }

        public void Init()
        {
            connection = new SQLiteConnection(_dbPath);
            connection.CreateTable<Game>();
        }

        public List<Game> GetAllGames()
        {
            Init();

            return connection.Table<Game>().ToList();
        }

        public void Add(Game game)
        {
            connection = new SQLiteConnection(_dbPath);
            connection.Insert(game);
        }

        public void Delete(int id)
        {
            connection = new SQLiteConnection(_dbPath);
            connection.Delete(new Game { Id = id });
        }
    }
}
