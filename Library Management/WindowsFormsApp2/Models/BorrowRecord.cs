using System;

namespace AdvancedLibrarySystem.Models
{
    public class BorrowRecord
    {
        public int RecordID { get; set; }
        public int StudentID { get; set; } 
        public int BookID { get; set; }    
        public DateTime BorrowDate { get; set; }
        public DateTime RefundDate { get; set; } 
        public string Status { get; set; } 
    }
}