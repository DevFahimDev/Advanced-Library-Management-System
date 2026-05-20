namespace AdvancedLibrarySystem.Models
{
    public class Fine
    {
        public int FineID { get; set; }
        public int StudentID { get; set; } 
        public decimal Amount { get; set; } 
        public string Status { get; set; } 
    }
}