using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДЗ_7._1
{
    internal class Employee
    {
        public string Name { get; set; }
        public Employee Supervisor { get; set; }

        public virtual bool TakeTask(string task)
        {
            Console.WriteLine($"{Name} не может взять задачу");
            return false;
        }
    }
}
