using System;

namespace GestionReservation.Model
{
    public class Reservation
    {
        public int Id { get; set; }
        public int Id_chambre { get; set; }
        public int Id_client { get; set; }
        public DateTime Date_from { get; set; }
        public DateTime Date_to { get; set; }

        public Reservation(int id, DateTime date_from, DateTime date_to, int id_chambre, int id_client)
        {
            Id = id;
            Date_from = date_from;
            Date_to = date_to;
            Id_chambre = id_chambre;
            Id_client = id_client;
        }
    }
}
