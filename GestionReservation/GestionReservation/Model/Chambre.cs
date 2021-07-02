
namespace GestionReservation.Model
{
    class Chambre
    {
        public int Id { get; set; }
        public int Num { get; set; }

        public Chambre(int id, int num)
        {
            this.Id = id;
            this.Num = num;
        }
    }
}
