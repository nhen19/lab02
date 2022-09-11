using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            BookList books = new BookList();
            Console.WriteLine(" ******* NHẬP DANH SÁCH *******");
            books.InputList();
            Console.WriteLine(" ******* XUẤT DANH SÁCH *******");
            books.ShowList(); 
            Console.WriteLine(" ******* SẮP XẾP DANH SÁCH THEO Title *******");
            books.Sort_Title();
            Console.WriteLine(" ******* SẮP XẾP DANH SÁCH THEO Năm xuất bản *******");
            books.Sort_Year();
            Console.WriteLine("[KẾT THÚC]");
            Console.ReadKey();
        }
    }
}
