using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ДЗ_7._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Director semyon = new Director("Семен");
            FinanceDirector rashid = new FinanceDirector("Рашид", semyon);
            AutomationDirector ilham = new AutomationDirector("О Ильхам", semyon);
            ITDirector orkadiy = new ITDirector("Оркадий", ilham);
            Employee volodya = new Employee { Name = "Володя", Supervisor = orkadiy };
            Network systemSector = new Network("Сектор системщиков", volodya);
            Employee ilyas = new Employee { Name = "Ильшат", Supervisor = systemSector };
            Employee ivanych = new Employee { Name = "Иваныч", Supervisor = systemSector };
            Employee ilya = new Employee { Name = "Илья", Supervisor = ivanych };
            Employee vitya = new Employee { Name = "Витя", Supervisor = ivanych };
            Employee zhenya = new Employee { Name = "Женя", Supervisor = ivanych };
            Developer developmentSector = new Developer("Сектор разработчиков", volodya);
            Employee sergey = new Employee { Name = "Сергей", Supervisor = developmentSector };
            Employee lyaysan = new Employee { Name = "Ляйсан", Supervisor = sergey };
            Employee marat = new Employee { Name = "Марат", Supervisor = lyaysan };
            Employee dina = new Employee { Name = "Дина", Supervisor = lyaysan };
            Employee ildar = new Employee { Name = "Ильдар", Supervisor = lyaysan };
            Employee anton = new Employee { Name = "Антон", Supervisor = lyaysan };

            // Назначаем задачи
            rashid.TakeTask("Задача для бухгалтерии");
            orkadiy.TakeTask("Задача для отдела информационных технологий");
            systemSector.TakeTask("Задача для сектора системщиков");
            developmentSector.TakeTask("Задача для сектора разработчиков");
            lyaysan.TakeTask("Задача для Ляйсан");

            Console.ReadLine();

        }
    }
}
