using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities.reportes
{
    public class GeneraReporte
    {

        public static void BuildExcel(DataTable dataTable, string ExcelPath)
        {
            using (SpreadsheetDocument myWorkbook =
                SpreadsheetDocument.Create(ExcelPath,
                SpreadsheetDocumentType.Workbook))
            {
                // workbook Part
                WorkbookPart workbookPart = myWorkbook.AddWorkbookPart();
                var worksheetPart = workbookPart.AddNewPart<WorksheetPart>();
                string relId = workbookPart.GetIdOfPart(worksheetPart);

                // file Version
                var fileVersion = new FileVersion { ApplicationName = "Microsoft Office Excel" };

                // sheets               
                var sheets = new Sheets();
                var sheet = new Sheet { Name = dataTable.TableName, SheetId = 1, Id = relId };
                sheets.Append(sheet);

                // data
                SheetData sheetData = new SheetData(CreateSheetData(dataTable));

                // add the parts to the workbook and save
                var workbook = new Workbook();
                workbook.Append(fileVersion);
                workbook.Append(sheets);
                var worksheet = new Worksheet();
                worksheet.Append(sheetData);
                worksheetPart.Worksheet = worksheet;
                worksheetPart.Worksheet.Save();
                myWorkbook.WorkbookPart.Workbook = workbook;
                myWorkbook.WorkbookPart.Workbook.Save();
                myWorkbook.Close();
            }
        }

        private static List<OpenXmlElement> CreateSheetData(DataTable dataTable)
        {
            List<OpenXmlElement> elements = new List<OpenXmlElement>();

            // row header
            var rowHeader = new Row();
            Cell[] cellsHeader = new Cell[dataTable.Columns.Count];
            for (int i = 0; i < dataTable.Columns.Count; i++)
            {
                cellsHeader[i] = new Cell();
                cellsHeader[i].DataType = CellValues.String;
                cellsHeader[i].CellValue = new CellValue(dataTable.Columns[i].ColumnName);
            }
            rowHeader.Append(cellsHeader);
            elements.Add(rowHeader);

            // rows data
            foreach (DataRow rowDataTable in dataTable.Rows)
            {
                var row = new Row();
                Cell[] cells = new Cell[dataTable.Columns.Count];

                for (int i = 0; i < dataTable.Columns.Count; i++)
                {
                    cells[i] = new Cell();
                    cells[i].DataType = CellValues.String;
                    cells[i].CellValue = new CellValue((string)rowDataTable[i]);
                }
                row.Append(cells);
                elements.Add(row);
            }
            return elements;
        }
    }
}
