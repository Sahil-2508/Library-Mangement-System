using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Libeary_Mangament;

namespace Libeary_Mangament
{
    public class Bookclass
    {
        public int BookId { get; set; }
        public string title { get; set; }
        public string Author { get; set; }
        public int ISBN { set; get; }
        public int Quantity { get; set; }


        public void AddBook1()
        {

            Bookclass bookclass = new Bookclass();

            Console.WriteLine("Enter Book Id");
            bookclass.BookId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter book title");
            bookclass.title = Console.ReadLine();

            Console.WriteLine("Enter book author name");
            bookclass.Author = Console.ReadLine();

            Console.WriteLine("Enter ISBN");
            bookclass.ISBN = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("quantity");
            bookclass.Quantity = Convert.ToInt32(Console.ReadLine());


            DB_source.Addbook1(bookclass);

        }
        public void DisplayAllBooks()
        {
            var list = DB_source.getAllBooks();
            foreach (var book in list) 
            {
                DisplayBook(book);
            }
        }

        public void DisplayBook(Bookclass book)
        {
            Console.WriteLine("Book Id: " + book.BookId + " title: " + book.title + " Author: " + book.Author + " ISBN: " + book.ISBN + "Quantity:" + book.Quantity);
        }

        public void Update_Book()
        {

            DisplayAllBooks();

            Bookclass bookclass1 = new Bookclass();

            Console.WriteLine("Enter book id which you want to update ");
            int id = Convert.ToInt32(Console.ReadLine());

            bookclass1.BookId = id;
            Console.WriteLine("Enter title");
            bookclass1.title = Console.ReadLine();
            Console.WriteLine("Enter Author");
            bookclass1.Author = Console.ReadLine();
            Console.WriteLine("Enter ISBN");
            bookclass1.ISBN = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Quantity");
            bookclass1.Quantity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sucessfully Updated Book");

            DB_source.DeleteBook(id);
            DB_source.Addbook1(bookclass1);



        }

       


        public void Delete_Book()
        {

            DisplayAllBooks();
           
            Console.WriteLine("Enter book Id to delete");
            int id = Convert.ToInt32(Console.ReadLine());
            DB_source.DeleteBook(id);
            Console.WriteLine("Succesfully Deleted");
        }

        internal void SearchBooks()
        {
            throw new NotImplementedException();
        }
    }

}

  public class Ebook : Bookclass
  {
    public string FileSize;
    public string Format;
  
  }








