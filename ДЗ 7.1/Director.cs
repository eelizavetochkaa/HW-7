using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ДЗ_7._1
{
    internal class Director: Employee
    {
        public Director(string name)
        {
            Name = name;
        }

        public override bool TakeTask(string task)
        {
            Console.WriteLine($"{Name} берет задачу: {task}");
            return true;
        }
    }
}
