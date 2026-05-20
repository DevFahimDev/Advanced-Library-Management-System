using System.Collections.Generic;
using AdvancedLibrarySystem.Models;
using AdvancedLibrarySystem.DAL;

namespace AdvancedLibrarySystem.BLL
{
    public class LibraryManager
    {
        public List<Book> FetchBooksForDisplay()
        {
            DatabaseHelper db = new DatabaseHelper();
            return db.GetAllBooks();
        }

        public bool Login(string fullName, string password, string role)
        {
            DatabaseHelper db = new DatabaseHelper();
            return db.AuthenticateUser(fullName, password, role);
        }

       
        public bool RegisterNewUser(string fullName, string password, string role)
        {
            DatabaseHelper db = new DatabaseHelper();
            return db.RegisterUser(fullName, password, role);
        }
        public bool AddNewBook(string title)
        {
            DatabaseHelper db = new DatabaseHelper();
            return db.AddBook(title);
        }

        public bool RemoveBook(int bookId)
        {
            DatabaseHelper db = new DatabaseHelper();
            return db.DeleteBook(bookId);
        }
        public string AddBookToWishlist(string studentName, int bookId)
        {
            DatabaseHelper db = new DatabaseHelper();

            
            if (db.IsBookInWishlist(studentName, bookId))
            {
                return "Duplicate Entry: You have already added this exact book to your wishlist!";
            }

            
            int currentCount = db.GetWishlistCount(studentName);
            if (currentCount >= 3)
            {
                return "Limit Reached: You can only have 3 books in your wishlist at a time.";
            }

            
            bool success = db.AddToWishlist(studentName, bookId);
            return success ? "Success" : "Database error while adding to wishlist.";
        }
        public List<Book> FetchWishlistForDisplay(string studentName)
        {
            DatabaseHelper db = new DatabaseHelper();
            return db.GetWishlistedBooks(studentName);
        }
        public bool RemoveBookFromWishlist(string studentName, int bookId)
        {
            DatabaseHelper db = new DatabaseHelper();
            return db.RemoveFromWishlist(studentName, bookId);
        }
    }
}