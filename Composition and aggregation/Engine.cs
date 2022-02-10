using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPega.Composition_and_aggregation
{
    public class Engine
    {
        public Engine(string typeEngine)
        {
            TypeEngine = typeEngine;
        }

        /// <summary>
        /// Тип двигателя
        /// </summary>
        public string TypeEngine { get; set; }
        
        public void Start()
        {
            Console.WriteLine("Engine started");
        }
    }
}
