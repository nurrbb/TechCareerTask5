namespace TechCareerTask5.Models
{
    public class Reservation : BaseModel
    {
        public int ClientId { get; set; }
        public int RoomId { get; set; }
      
        public object ReservationDate { get; internal set; }
    }
}
