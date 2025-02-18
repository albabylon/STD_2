using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_4_GenerativeP.Builder
{
    internal class Builder
    {
    }

    /// <summary>
    /// Абстрактный интерфейс строителя
    /// </summary>
    interface IBuilder
    {
        void FirstStage();
        void SecondStage();
        void ThirdStage();
        Product GetBuildingResult();
    }

    /// <summary>
    /// Реализация продукта - сложного объекта
    /// </summary>
    class Product
    {
        // список частей, из которых состоит объект
        List<object> parts = new List<object>();

        /// Метод для поэтапного процесса создания
        public void Add(string part)
        {
            parts.Add(part);
        }
    }

    /// <summary>
    ///  Реализация строителя конкретного продукта
    /// </summary>
    class ProductBuilder : IBuilder
    {
        Product product = new Product();

        // 1-й этап
        public void FirstStage()
        {
            product.Add("Part one");
        }

        // 2-й этап
        public void SecondStage()
        {
            product.Add("Part two");
        }

        // 3-й этап
        public void ThirdStage()
        {
            product.Add("Part three");
        }

        // 4-й этап
        public Product GetBuildingResult()
        {
            return product;
        }
    }

    /// <summary>
    /// Объект, инкапсулирующий процесс строительства
    /// </summary>
    class BuildManager
    {
        IBuilder Builder;
        public BuildManager(IBuilder builder)
        {
            Builder = builder;
        }
        public void StartBuildingProcess()
        {
            Builder.FirstStage();
            Builder.SecondStage();
            Builder.ThirdStage();
        }
    }


    class Client
    {
        void Main()
        {
            // инициализация строителя
            IBuilder builder = new ProductBuilder();
            // Создаем менеджера, который будет рулить процессом
            BuildManager buildManager = new BuildManager(builder);

            //  Стартуем и получаем результат
            buildManager.StartBuildingProcess();
            Product product = builder.GetBuildingResult();
        }
    }
}
