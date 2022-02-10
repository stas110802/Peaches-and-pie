using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPega.Composition_and_aggregation
{
    public class Car
    {
        private Engine _engine;// двигатель
        private List<Wheel> _wheels;// список колес 
        private Freshener _freshener; // освежитель воздуха

        public Car(Freshener freshener)
        {
            // aggregation [агрегация]
            _freshener = freshener;// получаем обьект извне

            // composition [композиция]
            _engine = new Engine("Sport Engine");// сами создаем обьект
            _wheels = new List<Wheel>() 
            { 
                new Wheel(),
                new Wheel(),
            };
        }

        public void Drive()
        {
            _engine.Start();
            Parallel.ForEach(_wheels, x => x.Spin());
        }
    }
}

/*
    композиция - это когда обьект создается внутри класса
    агрегация - это когда в класс поступает готовый обьект откуда-то извне
*/