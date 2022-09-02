/******************************************************************************************/
/* 
 * Autor: Ichim Ioana
 * Comentarii: Radion Claudia
*/
/******************************************************************************************/

using System;
using System.Runtime.InteropServices;
using Microsoft.Office.Interop.Excel;

/*! \namespace ExcelData
 */
namespace ExcelData
{
    /* ! \class ExcelContent
     *   \brief Clasă pentru procesarea fișierului Excel
     */
    public class ExcelContent
    {  
        /* Membrii privați ai clasei* */
        private Application _excelApp;
        private Workbook _excelWorkbook;
        private _Worksheet _excelWorksheet;
        private Range _excelRange;
        /* Metodă publică ExcelContent pentru deschiderea fișierului Excel */
        public ExcelContent(string path, int sheet)
        {
            _excelApp = new Application();
            _excelWorkbook = _excelApp.Workbooks.Open(@path);
            _excelWorksheet = _excelWorkbook.Sheets[sheet];
            _excelRange = _excelWorksheet.UsedRange;
      
        }
        /* Metodă publică pentru citirea din fișierul Excel */
        public string ReadCell(int row, int column)
        {
            if (row <= _excelRange.Rows.Count && column <= _excelRange.Columns.Count)
                return _excelRange.Cells[row, column].Value.ToString();
            else
                throw new Exception("EXCEL: Index in afara intervalului");
        }
        /* Metodă publică pentru închiderea fișierului Excel */
        public void CloseExcelFile()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();

            Marshal.ReleaseComObject(_excelRange);
            Marshal.ReleaseComObject(_excelWorksheet);

            _excelWorkbook.Close();
            Marshal.ReleaseComObject(_excelWorkbook);

            _excelApp.Quit();
            Marshal.ReleaseComObject(_excelApp);
        }
    }
}
