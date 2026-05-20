using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using AdvancedLibrarySystem.Models;

namespace AdvancedLibrarySystem.DAL
{
    public class DatabaseHelper
    {
        private readonly string connectionString = @"Server=.\SQLEXPRESS;Database=LibraryDB;Integrated Security=True;TrustServerCertificate=True;";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

       //get all books from db
        public List<Book> GetAllBooks()
        {
            List<Book> bookList = new List<Book>();

            using (SqlConnection conn = GetConnection())
            {
                string query = "SELECT * FROM Books";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Book b = new Book();
                    b.BookID = Convert.ToInt32(reader["BookID"]);
                    b.Title = reader["Title"].ToString();
                    b.Author = reader["Author"].ToString();
                    b.Category = reader["Category"].ToString();
                    b.TotalCopies = Convert.ToInt32(reader["TotalCopies"]);
                    b.AvailableCopies = Convert.ToInt32(reader["AvailableCopies"]);

                    //add date automatically
                    if (reader["DateAdded"] != DBNull.Value)
                    {
                        b.DateAdded = Convert.ToDateTime(reader["DateAdded"]);
                    }

                    bookList.Add(b);
                }
            }
            return bookList;
        }

        
        public bool AuthenticateUser(string fullName, string password, string role)
        {
            using (SqlConnection conn = GetConnection())
            {
                string query = "SELECT COUNT(1) FROM Users WHERE FullName=@Name AND PasswordHash=@Pass AND Role=@Role";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Name", fullName);
                cmd.Parameters.AddWithValue("@Pass", password);
                cmd.Parameters.AddWithValue("@Role", role);

                conn.Open();
                int result = Convert.ToInt32(cmd.ExecuteScalar());
                return result > 0; 
            }
        }

        public bool RegisterUser(string fullName, string password, string role)
        {
            using (SqlConnection conn = GetConnection())
            {
                string query = "INSERT INTO Users (FullName, PasswordHash, Role) VALUES (@Name, @Pass, @Role)";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Name", fullName);
                cmd.Parameters.AddWithValue("@Pass", password);
                cmd.Parameters.AddWithValue("@Role", role);

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
        

        public bool AddBook(string title)
        {
            using (SqlConnection conn = GetConnection())
            {
                string query = "INSERT INTO Books (Title, Author, Category, TotalCopies, AvailableCopies) VALUES (@Title, 'Unknown', 'General', 1, 1)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Title", title);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool DeleteBook(int bookId)
        {
            using (SqlConnection conn = GetConnection())
            {
                string query = "DELETE FROM Books WHERE BookID = @ID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", bookId);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
        public int GetWishlistCount(string studentName)
        {
            using (System.Data.SqlClient.SqlConnection conn = GetConnection())
            {
                string query = "SELECT COUNT(1) FROM Wishlist WHERE StudentName = @Name";
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", studentName);
                conn.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public bool AddToWishlist(string studentName, int bookId)
        {
            using (System.Data.SqlClient.SqlConnection conn = GetConnection())
            {
                string query = "INSERT INTO Wishlist (StudentName, BookID) VALUES (@Name, @BookID)";
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", studentName);
                cmd.Parameters.AddWithValue("@BookID", bookId);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
        public List<Book> GetWishlistedBooks(string studentName)
        {
            List<Book> bookList = new List<Book>();

            using (System.Data.SqlClient.SqlConnection conn = GetConnection())
            {
                string query = @"
            SELECT b.* FROM Books b
            INNER JOIN Wishlist w ON b.BookID = w.BookID
            WHERE w.StudentName = @Name";

                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", studentName);

                conn.Open();
                System.Data.SqlClient.SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Book b = new Book();
                    b.BookID = Convert.ToInt32(reader["BookID"]);
                    b.Title = reader["Title"].ToString();
                    b.Author = reader["Author"].ToString();
                    b.Category = reader["Category"].ToString();
                    b.TotalCopies = Convert.ToInt32(reader["TotalCopies"]);
                    b.AvailableCopies = Convert.ToInt32(reader["AvailableCopies"]);

                    if (reader["DateAdded"] != DBNull.Value)
                    {
                        b.DateAdded = Convert.ToDateTime(reader["DateAdded"]);
                    }
                    bookList.Add(b);
                }
            }
            return bookList;
        }
        public bool RemoveFromWishlist(string studentName, int bookId)
        {
            using (System.Data.SqlClient.SqlConnection conn = GetConnection())
            {
                string query = "DELETE FROM Wishlist WHERE StudentName = @Name AND BookID = @BookID";
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", studentName);
                cmd.Parameters.AddWithValue("@BookID", bookId);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
        public bool IsBookInWishlist(string studentName, int bookId)
        {
            using (System.Data.SqlClient.SqlConnection conn = GetConnection())
            {
                string query = "SELECT COUNT(1) FROM Wishlist WHERE StudentName = @Name AND BookID = @BookID";
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", studentName);
                cmd.Parameters.AddWithValue("@BookID", bookId);

                conn.Open();

                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }
    }
}