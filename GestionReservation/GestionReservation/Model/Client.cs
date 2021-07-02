
namespace GestionReservation.Model
{
    class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CIN { get; set; }

        public Client(int id, string name, string cIN)
        {
            Id = id;
            Name = name;
            CIN = cIN;
        }
    }
}
