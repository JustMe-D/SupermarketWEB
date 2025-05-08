namespace SupermarketWEB.Models
{
    public class Customer
    { 
        public int Id { get; set; } 
        public string document_number { get; set; } 
        public string first_name { get; set; } 
        public string last_name { get; set; } 
        public string? address { get; set; }
        public DateTime? birthday { get; set; }
        public string? phone_number { get; set; }
        public string? email { get; set; }
    }
}
