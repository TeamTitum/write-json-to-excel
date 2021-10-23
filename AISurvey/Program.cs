using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Excel = Microsoft.Office.Interop.Excel;

namespace AISurvey
{
    class Program
    {
        static void DisplayInExcel(IEnumerable<Account> accounts)
        {
            var excelApp = new Excel.Application();
            // Make the object visible.
            excelApp.Visible = true;

            // Create a new, empty workbook and add it to the collection returned
            // by property Workbooks. The new workbook becomes the active workbook.
            // Add has an optional parameter for specifying a praticular template.
            // Because no argument is sent in this example, Add creates a new workbook.
            excelApp.Workbooks.Add();

            // This example uses a single workSheet. The explicit type casting is
            // removed in a later procedure.
            Excel._Worksheet workSheet = (Excel.Worksheet)excelApp.ActiveSheet;

            // Establish column headings in cells A1 and B1.
            workSheet.Cells[1, "A"] = "ID Number";
            workSheet.Cells[1, "B"] = "Current Balance";

            var row = 1;
            foreach (var acct in accounts)
            {
                row++;
                workSheet.Cells[row, "A"] = acct.ID;
                workSheet.Cells[row, "B"] = acct.Balance;
            }
        }
        static void Main(string[] args)
        {

            // Create a list of accounts.
            var bankAccounts = new List<Account> {
    new Account {
                  ID = 345678,
                  Balance = 541.27
                },
    new Account {
                  ID = 1230221,
                  Balance = -127.44
                }
};


            // Display the list in an Excel spreadsheet.
            DisplayInExcel(bankAccounts);
            //Excel.UpdateCell("20", 1, "A");
            //Excel.UpdateCell("80", 3, "B");
            //Excel.UpdateCell("80", 2, "C");
            //Excel.UpdateCell("20", 3, "C");



            //Survey survey = new Survey();
            //using (StreamReader r = new StreamReader("C:\\Users\\suhail\\source\\repos\\AISurvey\\AISurvey\\Survey2-Titum-2021-10-22-19-00-28.json"))
            //{
            //    string json = r.ReadToEnd();
            //    List<Root> items = JsonConvert.DeserializeObject<List<Root>>(json);
            //    Root[] itemsArray = items.ToArray();

            //    survey._respondentName = itemsArray[0]._respondentName;
            //    if (itemsArray[1] != null)
            //    {
            //        Excel.UpdateCell(itemsArray[1]._2_1 ?? itemsArray[1]._2_1, 1, "A");

            //    }
            //    if (itemsArray[2] != null)
            //    {
            //        Excel.UpdateCell(itemsArray[2]._2_1 ?? itemsArray[1]._2_1, 1, "B");

            //    }



            //}
        }
    }
}
//}