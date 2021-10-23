using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AISurvey
{

    public class Excel1
    {
        static string excelLocation = "C:\\Users\\suhail\\source\\repos\\AISurvey\\AISurvey\\Book1.xlsx";

        private static WorksheetPart GetWorksheetPartByName(SpreadsheetDocument document, string sheetName)
        {
            IEnumerable<Sheet> sheets = document.WorkbookPart.Workbook.GetFirstChild<Sheets>().
                            Elements<Sheet>().Where(s => s.Name == sheetName);
            if (sheets.Count() == 0)
            {
                return null;
            }
            string relationshipId = sheets.First().Id.Value;
            WorksheetPart worksheetPart = (WorksheetPart)document.WorkbookPart.GetPartById(relationshipId);
            return worksheetPart;
        }


        private static Cell GetCell(Worksheet worksheet, string columnName, uint rowIndex)
        {
            Row row;
            string cellReference = columnName + rowIndex;
            if (worksheet.Elements<Row>().Where(r => r.RowIndex == rowIndex).Count() != 0)
                row = worksheet.GetFirstChild<SheetData>().Elements<Row>().Where(r => r.RowIndex == rowIndex).FirstOrDefault();
            else
            {
                row = new Row() { RowIndex = rowIndex };
                worksheet.Append(row);
            }

            if (row == null)
                return null;

            if (row.Elements<Cell>().Where(c => c.CellReference.Value == cellReference).Count() > 0)
            {
                return row.Elements<Cell>().Where(c => c.CellReference.Value == cellReference).First();
            }
            else
            {
                Cell refCell = null;
                foreach (Cell cell in row.Elements<Cell>())
                {
                    if (string.Compare(cell.CellReference.Value, cellReference, true) > 0)
                    {
                        refCell = cell;
                        break;
                    }
                }
                Cell newCell = new Cell()
                {
                    CellReference = cellReference,
                    StyleIndex = (UInt32Value)1U

                };
                row.InsertBefore(newCell, refCell);
                worksheet.Save();
                return newCell;
            }
        }
        public static void UpdateCell(string text, uint rowIndex, string columnName)
        {
            using (SpreadsheetDocument spreadSheet = SpreadsheetDocument.Open(excelLocation, true))
            {
                WorksheetPart worksheetPart = GetWorksheetPartByName(spreadSheet, "Sheet1");
                if (worksheetPart != null)
                {
                    // Create new Worksheet
                    Worksheet worksheet = new Worksheet();
                    worksheetPart.Worksheet = worksheet;

                    // Create new SheetData
                    SheetData sheetData = new SheetData();

                    // Create new row
                    Row row = new Row() { RowIndex = rowIndex };

                    // Create new cell
                    Cell cell = new Cell() { CellReference = columnName + rowIndex, DataType = CellValues.Number, CellValue = new CellValue(text) };

                    // Append cell to row
                    row.Append(cell);

                    // Append row to sheetData
                    sheetData.Append(row);

                    // Append sheetData to worksheet
                    worksheet.Append(sheetData);

                    worksheetPart.Worksheet.Save();
                }
                spreadSheet.WorkbookPart.Workbook.Save();
                spreadSheet.Close();
            }

        }



    }
}
