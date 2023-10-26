using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ДЗ_7._1
{
    internal class Network: Employee
    {
        public Network(string name, Employee supervisor)
        {
            Name = name;
            Supervisor = supervisor;
        }

        public override bool TakeTask(string task)
        {
            if (Supervisor != null && Supervisor.TakeTask(task))
            {
                Console.WriteLine($"{Name} берет задачу: {task}");
                return true;
            }
            else
            {
                Console.WriteLine($"{Name} не может взять задачу");
                return false;
            }
        }
    }
}
