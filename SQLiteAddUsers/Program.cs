using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteAddTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //FSWorker worker = new FSWorker("Users.db", true);
            //DBWorkers dBWorker = new DBWorkers(worker.GetName);
            ////Console.WriteLine(string user = "user"
            //string name = "Александр";
            //int age = 42;
            //dBWorker.AddData(name, age);
            string time_stamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.f");
            Console.WriteLine(time_stamp);
            string comment = "Прошло 30мин , как я делаю домашку";
            FSWorker workerTime = new FSWorker("Time.db", true);
            DBWorkers dBWorker = new DBWorkers(workerTime.GetName);
            dBWorker.AddDataTime(time_stamp, comment);

        }
    }
}
