using GestionReservation.Model;
using System;
using System.Collections.Generic;
using System.Data;
using db = Npgsql;

namespace GestionReservation.DAO
{
    class ChambreDAO
    {
        private db.NpgsqlCommand cmd;
        private db.NpgsqlDataAdapter ada;

        public ChambreDAO()
        {
            Connection.MakeConnection();
        }

        public List<Chambre> GetAll()
        {
            List <Chambre> list = new List<Chambre>();
            DAO.Connection.Cnx.Open();
            cmd = new db.NpgsqlCommand("select * from chambre", DAO.Connection.Cnx);
            ada = new db.NpgsqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            DAO.Connection.Cnx.Close();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new Chambre((int)row["id"], (int)row["num"]));
            }
            return list;
        }

        public int IsReserved(int id, DateTime dateFrom, DateTime dateTo)
        {
            List<DataRow> list = new List<DataRow>();
            DAO.Connection.Cnx.Open();
            cmd = new db.NpgsqlCommand(
                "select * from reservation where id_chambre = "+id+" and (" +
                "(date_from <= '"+dateFrom+"' and date_to >= '"+dateFrom+"') or "+
                "(date_from <= '" + dateTo + "' and date_to >= '" + dateTo + "') or "+
                "(date_from >= '" + dateFrom + "' and date_to <= '" + dateTo + "'));",
                DAO.Connection.Cnx
            );
            ada = new db.NpgsqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            DAO.Connection.Cnx.Close();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(row);
            }
            if (list.Count != 0)
                return (int)list[0]["id_client"];
            return 0;
        }
    }
}
