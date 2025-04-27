using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Libeary_Mangament
{
    public class Transactionclass
    {
        //private const decimal PenaltyRatePerDay = 1.0m;

        //public void Borrow_Transaction()
        //{
        //    string BorrowBookMember;

        //    string BorrwBookName;

        //    DateTime borrow_date;


        //    Transactionclass transactionclass = new Transactionclass();

        //    Console.WriteLine(" Borrwo book Member ");
        //    BorrowBookMember = Console.ReadLine();

        //    Console.WriteLine("Borrwo book Name To Borrow ");
        //    BorrwBookName = Console.ReadLine();


        //    Console.WriteLine("Enter Date ");
        //    borrow_date = Convert.ToDateTime(Console.ReadLine());

            //bool IsMember = Check_Member(BorrowBookMember);

            //var book = DB_source.LBook;

            //foreach (var Vbook in book)
            //{
            //    if (IsMember && BorrwBookName == Vbook.title)
            //    {
            //        Vbook.Quantity -= 1;
            //        DateTime dueDate = borrow_date.AddDays(10);
            //        Console.WriteLine();
            //    }


            //}
    }


       

        //public void Return_Transaction()
        //{
        //    string ReturnBookMember;
        //    string ReturnBookName;
        //    DateTime Return_Date;

        //    Transactionclass ReturnTransaction = new Transactionclass();

        //    DateTime dueDate = Book.Return_Date;


        //    Console.WriteLine("Enter Member Returning the Book: ");
        //    ReturnBookMember = Console.ReadLine();


        //    Console.WriteLine("Enter Book Name to Return: ");
        //    ReturnBookName = Console.ReadLine();


        //    Console.WriteLine("Enter Date: ");
        //    Return_Date = Convert.ToDateTime(Console.ReadLine());


        //    bool IsMember = Check_Member(ReturnBookMember);


        //    var book = DB_source.LBook;
        //    bool bookFound = false;
        //    foreach (var Vbook in book)
        //    {
        //        if (IsMember && ReturnBookName == Vbook.title)
        //        {
        //            Vbook.Quantity += 1;

        //            if (Return_Date > dueDate) 
        //            {
        //                int overdueDays = (Return_Date - dueDate).Days;
        //                decimal penaltyAmount = overdueDays * PenaltyRatePerDay;

        //            }
        //        }
        //    }

        //    //if (!IsMember)
        //    //{
        //    //    Console.WriteLine("Invalid member Transaction cannot proceed.");
        //    //    return;
        //    //}
  
        //}

            //public void ProcessTransaction()
            //{
            //Console.WriteLine("Choose transaction: (1) Borrow  (2) Return");
            //string choice = Console.ReadLine();

            //     if (choice == "1")
            //     {

            //         Borrow_Transaction();

            //     }
            //     else if (choice == "2")
            //     {
            //         //Return_Transaction();
            //     }
            //   else
            //   {
            //      Console.WriteLine("Invalid choice.");
            //   }
            //}

}


