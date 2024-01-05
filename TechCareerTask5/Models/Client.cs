namespace TechCareerTask5.Models
{
    public class Client : BaseModel
    {
        public int Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }

        public string Email { get; set; }
        public string Address { get; set; }
        public string CompanyId { get; set; }
    }
}
