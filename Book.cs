using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace lab02
{
    public class Book : IBook
    {
        private string title;
        private string author;
        private string publisher;
        private string isbn;
        private int year;
        private ArrayList chapter = new ArrayList();

        public Book()
        {

        }
        public void InputRand()
        {
            title = Abc123();
            author = Abc123();
            publisher = Abc123();
            isbn = Abc123();
            year= new Random().Next(1900,2023);
        }
        private string Abc123()
        {
            Thread.Sleep(10);
            Random rand = new Random();
            StringBuilder sb = new StringBuilder();
            int n = rand.Next(3, 19);
            for (int i = 0; i < n; i++)
            {
                char c = (char)rand.Next(97,123);
                sb.Append(c);
            }
            n = rand.Next(0, 7);
            for (int i = 0; i < n; i++)
            {
                char c = (char)rand.Next(48, 58);
                sb.Append(c);
            }
            return sb.ToString();
        }
        public string this[int index]
        {
            get
            {
                if(index >= 0 && index < chapter.Count)
                    return chapter[index].ToString();
                else throw new IndexOutOfRangeException();
            }
            set
            {
                if (index >= 0 && index < chapter.Count)
                    chapter[index] = value;
                else if (index == chapter.Count)
                    chapter.Add(value);
                else throw new IndexOutOfRangeException();
            }
        }

        public string Title { get => title; set => title = value; }
        public string Author { get => author; set => author = value; }
        public string Publisher { get => publisher; set => publisher = value; }
        public string ISBN { get => isbn; set => isbn = value; }
        public int Year { get => year; set => year = value; }

        public void Show()
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("{0,-15}{1}","Tựa sách: ",title);
            Console.WriteLine("{0,-15}{1}","Tác giả: ",author);
            Console.WriteLine("{0,-15}{1}","Nhà xuất bản: ",publisher);
            Console.WriteLine( "{0,-15}{1}","Năm xuất bản: ",year);
            Console.WriteLine("{0,-15}{1}","Số hiệu ISBN: ", isbn);
            Console.WriteLine("Danh mục các chương:");
            if (chapter.Count == 0) Console.WriteLine("Không có.");
            else for(int i = 0; i < chapter.Count; i++)
            {
                Console.WriteLine("{0,7} {1}","["+(i+1)+"]",chapter[i]);  
            }
            Console.WriteLine("----------------------------------");
        }
        public void Input()
        {
            Console.Write("Nhập tựa sách: ");
            Title = Console.ReadLine();
            Console.Write("Nhập tên tác giả: ");
            Author = Console.ReadLine();
            Console.Write("Nhập nhà xuất bản: ");
            Publisher = Console.ReadLine();
            Console.Write("Nhập năm xuất bản: ");
            Year=int.Parse(Console.ReadLine());
            Console.Write("Nhập số hiệu ISBN: ");
            ISBN = Console.ReadLine();
            Console.WriteLine("Nhập các chương sách (nhập chương trống để thoát): ");
            int i = 1;
            do
            {
                Console.Write("\tChương {0}: ",i++);
                string s=Console.ReadLine();
                if ( s.Length==0) break; else chapter.Add(s);
            }while(true);
        }

        
    }
    public class BookList
    {
        private ArrayList books = new ArrayList();
        public void AddBook()
        {
            Book book = new Book();
            //book.Input();
            book.InputRand();
            books.Add(book);
        }
        public void InputList()
        {
            do
            {
                Console.WriteLine(" *** Nhập vào thông tin sách mới (nhấn N để thoát)");
                Console.Write("\t[Y]/[N]: ");
                string OK = Console.ReadLine();
                if (OK == "N" || OK == "n") break;
                AddBook();
            } while (true);
        }
        public void ShowList()
        {
            foreach (Book book in books) book.Show();
        }
        public void Sort_Title()
        {
            books.Sort(new CompareTitle());
            ShowList();
        }
        public void Sort_Year()
        {
            books.Sort(new CompareYear());
            ShowList();
        }
        public void Sort_Author()
        {
            books.Sort(new CompareAuthor());
            ShowList();
        }
        public void Sort_Publisher()
        {
            books.Sort(new ComparePublisher());
            ShowList();
        }
    }

}
