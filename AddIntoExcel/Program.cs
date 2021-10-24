using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace AddIntoExcel
{
    class Program
    {
        public static string excelFilePath = @"C:\Users\suhail\source\repos\AISurvey\AddIntoExcel\Book2.xlsx";
        public static string jsonFilePath = @"C:\Users\suhail\source\repos\AISurvey\AddIntoExcel\Survey2-Titum-2021-10-22-19-00-28.json";

        static void Main(string[] args)
        {
            AddNewRowsToExcelFile();
        }

        private static void AddNewRowsToExcelFile()
        {

            Excel.Application xlApp = new Excel.Application();

            Excel.Workbook xlWorkBook = xlApp.Workbooks.Open(excelFilePath, 0, false, 5, "", "", false,
                Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "", true, false, 0, true, false, false);
            Excel.Worksheet xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            Excel.Range xlRange = xlWorkSheet.UsedRange;
            int rowNumber = xlRange.Rows.Count + 1;


            //Read JSON File and Do the updates
            // Loop for reading all the files
            using (StreamReader r = new StreamReader(jsonFilePath))
            {
                string json = r.ReadToEnd();
                List<Root> items = JsonConvert.DeserializeObject<List<Root>>(json);
                Root[] itemsArray = items.ToArray();
                xlWorkSheet.Cells[rowNumber, 1] = itemsArray[0].RespondentName ?? itemsArray[0].RespondentName;
                xlWorkSheet.Cells[rowNumber, 2] = itemsArray[1].Member ?? itemsArray[1].Member;
                xlWorkSheet.Cells[rowNumber, 3] = itemsArray[1]._2_1 ?? itemsArray[1]._2_1;
                xlWorkSheet.Cells[rowNumber, 4] = itemsArray[1]._2_2 ?? itemsArray[1]._2_2;
                xlWorkSheet.Cells[rowNumber, 5] = itemsArray[1]._2_3 ?? itemsArray[1]._2_3;


            }


            // Disable file override confirmaton message  
            xlApp.DisplayAlerts = false;
            xlWorkBook.Save();
            xlWorkBook.Close();
            xlApp.Quit();

            Marshal.ReleaseComObject(xlWorkSheet);
            Marshal.ReleaseComObject(xlWorkBook);
            Marshal.ReleaseComObject(xlApp);

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\nRecords Added successfully...");
            Console.BackgroundColor = ConsoleColor.Black;
        }
        public class Employee
        {
            public int ID { get; set; }
            public string Name { get; set; }
        }
    }
}
