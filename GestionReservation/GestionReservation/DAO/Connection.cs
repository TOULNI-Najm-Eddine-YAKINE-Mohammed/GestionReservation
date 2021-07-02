using db = Npgsql;

namespace GestionReservation.DAO
{
    class Connection
    {
        public static db.NpgsqlConnection Cnx { get; set; }

        public static void MakeConnection()
        {
            string cnxStr = ""+
                "Server=127.0.0.1;" +
                "Port=5432;" +
                "Database=gestion_reservation;" +
                "User Id=postgres;" +
                "Password=yakine;";
            if(Cnx == null)
                Cnx = new db.NpgsqlConnection(cnxStr);
        }
    }
}
