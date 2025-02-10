using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_1.Singleton
{
    internal class SingletonRealExample
    {
        // Пример, где можно было бы реализовать Синглтон — соединение программы с базой данных
    }

    internal class DbConnection
    {
        private static DbConnection Connection;

        public string Configuration { get; private set; }

        protected DbConnection(string configuration)
        {
            Configuration = configuration;
        }

        /// <summary>
        /// Реализация Синглтона не позволяет нам плодить новые объекты, если объект уже существует
        /// </summary>
        public static DbConnection GetConnectionInstance(string dbServer)
        {
            if (Connection == null)
                Connection = new DbConnection(dbServer);
            return Connection;
        }
    }

    internal class Application
    {
        public DbConnection DbConnection { get; set; }
        public void Launch(string dbServer)
        {
            DbConnection = DbConnection.GetConnectionInstance(dbServer);
        }
    }
}
