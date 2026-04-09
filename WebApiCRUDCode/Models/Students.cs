namespace WebApiCRUDCode.Models
{
    public class Students
    {
        public int Id { get; set; }
        public string? StudentName { get; set; }
        public string? Class { get; set; }
        public int? Age { get; set; }

        public string? City { get; set; }
        public string? Email { get; set; }
        public string? FName { get; set; }
        public string? MName { get; set; }
        public DateTime? DOB { get; set; }
    }
}
