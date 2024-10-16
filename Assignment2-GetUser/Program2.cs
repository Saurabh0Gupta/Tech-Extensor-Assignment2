//This is second approach in which I used class and object;;

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.IO;
//using OfficeOpenXml;

//namespace Assignment2_GetUser
//{
//    class UserInfo
//    {
//        public string userId { get; set; }
//        public string hashPw { get; set; }
//        public string name { get; set; }
//    }
//    internal class Program2
//    {

//        static void Main(string[] args)
//        {
//            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
//            string BackUppath = @"C:\Users\TE-203\Downloads\BackUpdata.xlsx";
//            List<UserInfo> backUplist = new List<UserInfo>();
//            List<UserInfo> currentlist = new List<UserInfo>();
//            List<string> ansList = new List<string>();

//            using (var workSheet = new ExcelPackage(new FileInfo(BackUppath)))
//            {
//                var backUpdataworksheet = workSheet.Workbook.Worksheets[0];
//                var currentdataworksheet = workSheet.Workbook.Worksheets[1];
//                for (int i = 2; i <= backUpdataworksheet.Dimension.End.Row; i++)
//                {
//                    backUplist.Add(new UserInfo
//                    {
//                        userId = backUpdataworksheet.Cells[$"A{i}"].Text,
//                        hashPw = backUpdataworksheet.Cells[$"C{i}"].Text,
//                        name = backUpdataworksheet.Cells[$"D{i}"].Text
//                    });
//                }
//                Console.WriteLine(backUpdataworksheet.Dimension.End.Row);
//                Console.WriteLine(currentdataworksheet.Dimension.End.Row);
//                for (int j = 2; j <= currentdataworksheet.Dimension.End.Row; j++)
//                {
//                    currentlist.Add(new UserInfo
//                    {
//                        userId = currentdataworksheet.Cells[$"A{j}"].Text,
//                        hashPw = currentdataworksheet.Cells[$"C{j}"].Text,
//                        name = currentdataworksheet.Cells[$"D{j}"].Text
//                    });
//                }

//            }

//            Console.WriteLine(backUplist.Count);
//            Console.WriteLine(currentlist.Count);
//            for (int i = 0; i < backUplist.Count; i++)
//            {
//                for (int j = 0; j < currentlist.Count; j++)
//                {
//                    if (backUplist[i].userId == currentlist[j].userId)
//                    {
//                        if (backUplist[i].hashPw != currentlist[j].hashPw)
//                        {
//                            ansList.Add(backUplist[i].name);
//                        }
//                    }
//                }
//            }
//            int count = 1;
//            foreach (var item in ansList)
//            {

//                Console.WriteLine((count++) + "-> " + item);
//            }

//            Console.Read();

//        }
//    }
//}
