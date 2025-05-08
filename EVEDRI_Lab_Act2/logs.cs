using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spire.Xls;

namespace EVEDRI_Lab_Act2
{
    internal class logs
    {
        Workbook book = new Workbook();

        public void insertLogs(string user, string message)
        {          
            book.LoadFromFile(@"C:\Users\ACT-STUDENT\source\repos\EVEDRI_Lab_Act2\Book1.xlsx");

            Worksheet sh = book.Worksheets[1];
            int r = sh.Rows.Length;
            sh.Range[r, 1].Value = user;
            sh.Range[r, 2].Value = message;
            sh.Range[r, 3].Value = DateTime.Now.ToString("MM/dd/yyyy");
            sh.Range[r, 4].Value = DateTime.Now.ToString("hh:mm:ss tt");
            book.SaveToFile(@"C:\Users\ACT-STUDENT\Downloads\EVEDRI_Lab_Act2\Book1.xlsx");
        }
    }
}
