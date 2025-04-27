using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace Libeary_Mangament
{
    public class DB_source
    {
        public static List<Bookclass> LBook = [];
        public static List<Memberclass> LMembers = [];
        public static List<Transactionclass> LTransaction = [];


        public static void Addbook1(Bookclass book1)
        {

            try
            {
                string connString = ConfigurationManager.ConnectionStrings["Connect"].ConnectionString;
                using (SqlConnection con = new SqlConnection(connString))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("SP_InsertBook", con))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Book_Id", book1.BookId);
                        cmd.Parameters.AddWithValue("@Title", book1.title);
                        cmd.Parameters.AddWithValue("@Author", book1.Author);
                        cmd.Parameters.AddWithValue("@ISBN", book1.ISBN);
                        cmd.Parameters.AddWithValue("@Quantity", book1.Quantity);

                        cmd.BeginExecuteNonQuery();

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }
        public static void Update_Book()
        {
            try
            {
               string connString = ConfigurationManager.ConnectionStrings["Connect"].ConnectionString;
                using(SqlConnection con = new SqlConnection(connString))
                {
                    con.Open();
                    using(SqlCommand cmd = new SqlCommand("sp_UpdateBook", con))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Book_Id", bookId);
                        cmd.Parameters.AddWithValue("@Title", book1.title);
                        cmd.Parameters.AddWithValue("@Author", book1.Author);
                        cmd.Parameters.AddWithValue("@ISBN", book1.ISBN);
                        cmd.Parameters.AddWithValue("@Quantity", book1.Quantity);

                    }
                }


            }
            catch
            { 

            }

        }


      public static void Addmember1(Memberclass member1)
       {
            try
            {
                string connString = ConfigurationManager.ConnectionStrings["Connect"].ConnectionString;
                using (SqlConnection con = new SqlConnection(connString))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("SP_insertMember", con))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@@MemberID",member1.MemberID);
                        cmd.Parameters.AddWithValue("@MemberName", member1.MemberName);
                        cmd.Parameters.AddWithValue("@JoinDate",member1.JoinDate);
                        cmd.BeginExecuteNonQuery();

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);


            }


      }
        public static List<Bookclass> getAllBooks()
        {
            List<Bookclass> books = new List<Bookclass>();
            try
            {
                string connString = ConfigurationManager.ConnectionStrings["Connect"].ConnectionString;
                using (SqlConnection con = new SqlConnection(connString))
                {
                    con.Open();
                    using (SqlCommand commnad = new SqlCommand("getAllBooks", con))
                    {
                        commnad.CommandType = System.Data.CommandType.StoredProcedure;
                        SqlDataReader reader =  commnad.ExecuteReader();

                        while (reader.Read()) { 
                            Bookclass bookclass = new Bookclass();
                            bookclass.BookId = Convert.ToInt32(reader["Id"]);
                            bookclass.title = reader["Title"].ToString();
                            bookclass.Author = reader["author"].ToString();
                            bookclass.ISBN = Convert.ToInt32(reader["ISBN"]);
                            bookclass.Quantity = Convert.ToInt32(reader["Quantity"]);

                            books.Add(bookclass);
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            return books;

        }



   public static void Addtransaction1(Transactionclass Transaction1)
        {
            LTransaction.Add(Transaction1);
        }

        public static void DeleteBook(int id)
        {
            foreach (var book in LBook)
            {
                if (book.BookId == id)
                {
                    LBook.Remove(book);
                    break;
                }
            }
        }

        public static void DeleteMember(int Id)
        {
            foreach (var member in LMembers)
            {
                if (member.MemberID == Id)
                {
                    LMembers.Remove(member);
                    break;
                }

            }
        }
   




    }

}       
      



    

