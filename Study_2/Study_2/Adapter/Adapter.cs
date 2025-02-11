using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_2.Adapter
{
    internal class Adapter
    {
        // АДАПТЕР(ADAPTER) - Очень распространенный паттерн, позволяющий работать вместе объектам с несовместимыми интерфейсами.
        // Применение:
        // Нам необходимо использовать уже имеющийся класс, но его интерфейс не соответствует нашим потребностям.
        // Нужно использовать существующий класс совместно с другими, интерфейсы которых не совместимы.
    }

    // Наш код, где необходимо использование класса-источника
    class Client
    {
        public void Request(DataSource dataSource)
        {
            dataSource.GetData();
        }
    }

    /// <summary>
    /// Класс - источник ресурса, к которому нужно подключиться
    /// </summary>
    class DataSource
    {
        public virtual void GetData()
        { }
    }

    /// <summary>
    /// Класс - потребитель ресурса
    /// </summary>
    class DataConsumer
    {
        public void GetSpecificData()
        { }
    }
    /// <summary>
    /// Адаптер для подключения
    /// </summary>
    class DataAdapter : DataSource
    {
        private DataConsumer _dataConsumer = new DataConsumer();

        // метод для получения ресурса
        public override void GetData()
        {
            _dataConsumer.GetSpecificData();
        }

        // Таким образом, наш Client ничего не знает о классе DataConsumer, он знает и использует только объекты DataSource.
        // Использование адаптера позволяет нам на клиенте использовать объекты DataConsumer как DataSource.
    }
}
