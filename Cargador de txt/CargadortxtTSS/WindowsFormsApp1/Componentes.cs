using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Componentes
    {
        public string[] TextoToArray(string dir)
        {

            string[] rows = File.ReadAllLines(dir);
            return rows;
        }
    }
}
