using GestionReservation.Model;
using System;
using System.Collections.Generic;
using System.Data;
using db = Npgsql;

namespace GestionReservation.DAO
{
    class ReservationDAO
    {
        private db.NpgsqlCommand cmd;
        private db.NpgsqlDataAdapter ada;

        public ReservationDAO()
        {
            Connection.MakeConnection();
        }

        public void liberer(int id_chambre, int id_client, DateTime dateFrom, DateTime dateTo)
        {
            DAO.Connection.Cnx.Open();
            cmd = new db.NpgsqlCommand(
                "delete from reservation where " +
                "id_chambre = "+id_chambre+" and id_client = "+id_client+"and(" +
                "(date_from <= '" + dateFrom + "' and date_to >= '" + dateFrom + "') or " +
                "(date_from <= '" + dateTo + "' and date_to >= '" + dateTo + "') or " +
                "(date_from >= '" + dateFrom + "' and date_to <= '" + dateTo + "'));",
                DAO.Connection.Cnx
            );
            cmd.ExecuteNonQuery();
            DAO.Connection.Cnx.Close();
        }

        public void reserver(DateTime date_from, DateTime date_to, int id_chambre, int id_client)
        {
            DAO.Connection.Cnx.Open();
            cmd = new db.NpgsqlCommand(
                "insert into reservation (date_from, date_to, id_chambre, id_client) values ('"
                + date_from + "', '" + date_to + "', '" + id_chambre + "', '" + id_client +"')",
                DAO.Connection.Cnx
            );
            cmd.ExecuteNonQuery();
            DAO.Connection.Cnx.Close();
        }

        public Reservation getOne(DateTime dateFrom, DateTime dateTo, int id_chambre, int id_client)
        {
            List<Reservation> list = new List<Reservation>();
            DAO.Connection.Cnx.Open();
            cmd = new db.NpgsqlCommand(
                "select * from reservation where " +
                "id_chambre = " + id_chambre + " and id_client = " + id_client + "and(" +
                "(date_from <= '" + dateFrom + "' and date_to >= '" + dateFrom + "') or " +
                "(date_from <= '" + dateTo + "' and date_to >= '" + dateTo + "') or " +
                "(date_from >= '" + dateFrom + "' and date_to <= '" + dateTo + "'));",
                DAO.Connection.Cnx
            );
            ada = new db.NpgsqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            DAO.Connection.Cnx.Close();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new Reservation(
                    0,
                    (DateTime)row["date_from"],
                    (DateTime)row["date_to"],
                    (int)row["id_chambre"],
                    (int)row["id_client"]
                ));
            }
            if (list.Count != 0)
                return list[0];
            return null;
        }
    }
}
