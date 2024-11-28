using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KaramovaInspectorLib;

namespace KaramovaTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FunctionInsp inspector = new FunctionInsp();

            Console.WriteLine(inspector.GetCarInspection());

            Console.WriteLine(inspector.GetInspector());

            try
            {
                inspector.SetInspector("Миронов А.В.");
                Console.WriteLine(inspector.GetInspector()); 
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

            string generatedNumber = inspector.GenerateNumber("1234", 'A', "75");
            Console.WriteLine(generatedNumber); 

            var workers = inspector.GetWorker();
            Console.WriteLine("Список сотрудников:");
            foreach (var worker in workers)
            {
                Console.WriteLine(worker);
            }

            try
            {
                inspector.AddWorker("Сидоров С.С.");
                Console.WriteLine("Сотрудник добавлен.");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
