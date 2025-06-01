using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteAddUsers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FSWorker worker = new FSWorker("Users.db", true);
            DBWorkers dBWorker = new DBWorkers(worker.GetName);
            //Console.WriteLine(string user = "user"
            string name = "Александр";
            int age = 42;
            dBWorker.AddData(name, age);

        }
    }
}
