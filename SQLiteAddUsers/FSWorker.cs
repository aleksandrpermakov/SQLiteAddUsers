using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteAddUsers
{
    internal class FSWorker
    {
        private string path = string.Empty;
        private string name;
        public string GetName { get { return name; } }
        public FSWorker(string name, bool InMyDocs = false)
        {
            this.name = name;
            if (InMyDocs)
            {
                path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); //ДЗ ТОП АКАДЕМИЯ\С#\sqlitestudio-3.3.3\SQLiteStudio
                
            }
            this.name = path + @"\ДЗ ТОП АКАДЕМИЯ\С#\sqlitestudio-3.3.3\SQLiteStudio" + "\\" + name; //путь до моего файла db
        }
    }
}
