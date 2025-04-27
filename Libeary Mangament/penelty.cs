using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Libeary_Mangament
{
    public class penelty
    {
       public string Book_Name {  get; set; }
        public string Member_Name { get; set; }
        public DateTime Borrow_Date { get; set; }
        public DateTime Return_Date { get; set; }
         public int? penelty1 {  get; set; }



        public bool Check_Member(String Member_Name)
        {
            bool result = false;
            var member1 = DB_source.LMembers;
            foreach (var vmember in member1)
            {
                if (Member_Name == vmember.MemberName)
                {
                    result = true;

                    Console.WriteLine(" Member Is Found Transaction Proceed.");
                }

            }
            return result;
        }

        public void BorrowBookMember()
        {

            penelty penelty = new penelty();

            Console.WriteLine("Enter Book Name");
            penelty.Book_Name = Console.ReadLine();

            Console.WriteLine("Enter Member Name To Borrow Book ");
            penelty.Member_Name = Console.ReadLine();

            Console.WriteLine("Enter Borrow Book Date");
            penelty.Borrow_Date = Convert.ToDateTime(Console.ReadLine());

            penelty.Return_Date = penelty.Borrow_Date.AddDays(10);

            var book = DB_source.LBook;

            foreach (var vbook in book)
            {
                vbook.Quantity -= 1;
            }
            foreach (var member in DB_source.LMembers)
            {
                if (member.MemberName == penelty.Member_Name)
                {

                    member.Lpenelty.Add(penelty);
                }
               
            }

        }
        
        public void ReturnBookMember()
        {
            penelty penelty = new penelty();


            Console.WriteLine("Enter Book Name");
            penelty.Book_Name = Console.ReadLine();

            Console.WriteLine("Enter Member Name To Return Book ");
            penelty.Member_Name = Console.ReadLine();

            Console.WriteLine("Enter Return Book Date");
            penelty.Return_Date = Convert.ToDateTime(Console.ReadLine());

            var books = DB_source.LBook;
            var members = DB_source.LMembers;

            foreach (var member in members)
            {
                if (member.MemberName == penelty.Member_Name)
                {
                    foreach (var book in member.Lpenelty) { 
                        if(book.Book_Name == penelty.Book_Name)
                        {
                            member.Lpenelty.Remove(book);
                            break;
                        }
                    }
                }
            }

            foreach (var vbook in books)
            {
                if (vbook.title == penelty.Book_Name) {
                    vbook.Quantity += 1;
                    break;
                }
            }

        }

    }
   
}
