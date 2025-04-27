// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using Libeary_Mangament;


Bookclass obj1 = new Bookclass();
LibraryClass obj = new LibraryClass();
penelty obj2 = new penelty();

for (; ; )
{
    Console.WriteLine("Welcome to Library Mangment System");
    Console.WriteLine("please select operation");
    Console.WriteLine(" 1.Book \n 2.Search Book \n 3.Member \n 4.BorrowBookMember \n 5.ReturnBookMember \n 6.Exit \n ");
    int selection1 = Convert.ToInt32(Console.ReadLine());

    switch (selection1)
    {
        
        case 1:
            Selected_Book();
            break;

        case 2:
            obj1.SearchBooks();
            break;
        case 3:
            Selected_Members();
            break;
        case 4:
            obj2.BorrowBookMember();
            break;
        case 5:
            obj2.ReturnBookMember();
            break;
        case 6:
            Console.WriteLine("Exit");
            break;
        

    }

}

void Selected_Book()
{
    Console.WriteLine("plz select your options");
    Console.WriteLine(" 1.Add Book \n 2.Update_Book \n 3.Delete Book \n 4.Display all books \n");
    int Selected_Book = Convert.ToInt32(Console.ReadLine());
    Bookclass book = new Bookclass();
    switch (Selected_Book)
    {
        case 1:
            book.AddBook1();
            break;
        case 2:
            book.Update_Book();
            break;
        case 3:
            book.Delete_Book();
            break;
        case 4:
            book.DisplayAllBooks();
            break;
    }
}

void Selected_Members()
{
    Console.WriteLine("plz select your options");
    Console.WriteLine(" 1.Add Member \n 2.Update Member \n 3.Delete Member \n 4.Display all Members info \n 5. Display list of books borrow by member \n");
    int Selected_Members = Convert.ToInt32(Console.ReadLine());
    Memberclass members = new Memberclass();
    switch (Selected_Members)
    {
        case 1:
            members.AddMember();
            break;
        case 2:
            members.Update_Members();
            break;
        case 3:
            members.DeleteMember();
            break;
        case 4:
            members.DisplayAllMemberInfo();
            break;
        case 5:
            members.DisplayBookList();
            break;
    }
}











