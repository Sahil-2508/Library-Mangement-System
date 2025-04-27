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
    public class Memberclass
    {
        public string MemberName;
        public int MemberID;
        public string JoinDate;
        public List<penelty>? Lpenelty = [];
        public void Borrow_Addbook(penelty penelty1)
        {
            Lpenelty.Add(penelty1);

        }
        public void DisplayAllMemberInfo()
        {
            var list = DB_source.LMembers;
            foreach (var Members in list)
            {
                DisplayMembers(Members);
            }

        }
        public void DisplayMembers(Memberclass Members)
        {
            Console.WriteLine(" MemberName : " + Members.MemberName  + " MemberID : " + Members.MemberID + " JoinDate: " + Members.JoinDate );
        }
        public void AddMember()
        {
            Memberclass memberclass = new Memberclass();

            Console.WriteLine("Enter member name ");
            memberclass.MemberName = Console.ReadLine();

            Console.WriteLine("Enter member ID");
            memberclass.MemberID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Join Date");
            memberclass.JoinDate = Console.ReadLine();

            
            DB_source.Addmember1(memberclass);
        }
        public void Update_Members()
        {
            DisplayAllMemberInfo();

            Console.WriteLine("Enter Member Id which you want to update ");
            int id = Convert.ToInt32(Console.ReadLine());

            Memberclass memberclass1 = new Memberclass();   
            Console.WriteLine("Enter Update Member Name");
            memberclass1.MemberName = Console.ReadLine();
            Console.WriteLine("Enter Update Member ID");
            memberclass1.MemberID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Update Member Date");
            memberclass1.JoinDate = Console.ReadLine();
            Console.WriteLine("Suceesfully Upadted Member");

            DB_source.DeleteMember(id);
            DB_source.Addmember1(memberclass1);
        }
        public void DeleteMember()
        {

            DisplayAllMemberInfo();

            Console.WriteLine("Enter Member Id to delete");
            int id = Convert.ToInt32(Console.ReadLine());
            DB_source.DeleteMember(id);
            Console.WriteLine("Succesfully Deleted");
        }

        public void DisplayBookList()
        {


            Console.WriteLine("Enter Member Name");
            var memeber1 = Console.ReadLine();

            foreach (var member in DB_source.LMembers)
            {
                if (member.MemberName == memeber1)
                {
                    foreach (var book in member.Lpenelty)
                    {
                        int penelty = (System.DateTime.Today - book.Return_Date).Days * 10;
                        Console.WriteLine("Book Name: " + book.Book_Name + " Borrow date: " + book.Borrow_Date + " Return date: " + book.Return_Date + " Penelty: " + penelty);
                    }

                }
            }
        }


    }
        
}
       