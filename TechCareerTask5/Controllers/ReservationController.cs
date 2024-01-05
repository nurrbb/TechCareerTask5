using TechCareerTask5.Models;

namespace TechCareerTask5.Controllers
{
    public class ReservationController
    {
        private List<Client> clients = new List<Client>();
        private List<Room> rooms = new List<Room>();
        private List<Company> companies = new List<Company>();
        private List<Reservation> reservations = new List<Reservation>();
        public void AddCompany(Company company)
        {
            companies.Add(company);
        }

        public void RemoveCompany(int companyId)
        {
            var company = companies.FirstOrDefault(c => c.Id == companyId);
            if (company != null)
            {
                companies.Remove(company);
            }
        }

        public List<Company> GetAllCompanies()
        {
            return companies;
        }

        public void UpdateCompany(Company updatedCompany)
        {
            var company = companies.FirstOrDefault(c => c.Id == updatedCompany.Id);
            if (company != null)
            {
                company.Name = updatedCompany.Name;
                company.Address = updatedCompany.Address;
            }
        }
        public void AddClient(Client client)
        {
            clients.Add(client);
        }

        public void RemoveClient(int clientId)
        {
            var client = clients.FirstOrDefault(c => c.Id == clientId);
            if (client != null)
            {
                clients.Remove(client);
            }
        }

        public List<Client> GetAllClients()
        {
            return clients;
        }

        public void UpdateClient(Client updatedClient)
        {
            var client = clients.FirstOrDefault(c => c.Id == updatedClient.Id);
            if (client != null)
            {
                client.Name = updatedClient.Name;
                client.Surname = updatedClient.Surname;
                client.BirthDate = updatedClient.BirthDate;
                client.Address = updatedClient.Address;
                client.Email = updatedClient.Email;
                client.CompanyId = updatedClient.CompanyId;
            }
        }

        
        public void AddReservation(Reservation reservation)
        {
            reservations.Add(reservation);
        }

        public void RemoveReservation(int reservationId)
        {
            var reservation = reservations.FirstOrDefault(r => r.Id == reservationId);
            if (reservation != null)
            {
                reservations.Remove(reservation);
            }
        }

        public List<Reservation> GetAllReservations()
        {
            return reservations;
        }

        public void UpdateReservation(Reservation updatedReservation)
        {
            var reservation = reservations.FirstOrDefault(r => r.Id == updatedReservation.Id);
            if (reservation != null)
            {
                reservation.ClientId = updatedReservation.ClientId;
                reservation.RoomId = updatedReservation.RoomId;
                reservation.ReservationDate = updatedReservation.ReservationDate;
            }
        }
    }

}
