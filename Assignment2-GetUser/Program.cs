
using System;
using System.IO;
using OfficeOpenXml;


//This is the first approach to solve the given problem. 
class Program
{
    static void Main(string[] args)
    {
        // Set the license context for EPPlus.
        ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        List<string> userList = new List<string>();
        string BackUppath = @"C:\Users\TE-203\Downloads\BackUpdata.xlsx";
        using (var worksheetdata = new ExcelPackage(new FileInfo(BackUppath)))
        {
                var backUpdataworksheet = worksheetdata.Workbook.Worksheets[0]; // Access the first worksheet
                var currentdataworksheet = worksheetdata.Workbook.Worksheets[1]; //Access the Second worksheet
              
                for (int i = 2; i <= backUpdataworksheet.Dimension.End.Row; i++)
                {
                    var BuserId = backUpdataworksheet.Cells[$"A{i}"].Text;
                    for (int j = 2; j <= currentdataworksheet.Dimension.End.Row; j++)
                    {
                        var cuserId = currentdataworksheet.Cells[$"A{j}"].Text;
                        if (BuserId == cuserId)
                        {
                            if (backUpdataworksheet.Cells[$"C{i}"].Text != currentdataworksheet.Cells[$"C{j}"].Text)
                            { 
                                userList.Add(backUpdataworksheet.Cells[$"D{i}"].Text +" "+ backUpdataworksheet.Cells[$"E{i}"].Text);
                            }
                            break;//nonkkff
                        }
                    }
                }    
        }
        int count = 1;
        foreach (var item in userList)
        {
            Console.WriteLine((count++)+"-> "+item);
        }
        Console.Read();
    }
}


