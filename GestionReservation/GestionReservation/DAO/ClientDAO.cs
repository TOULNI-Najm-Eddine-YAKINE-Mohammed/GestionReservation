using GestionReservation.Model;
using System.Collections.Generic;
using System.Data;
using db = Npgsql;

namespace GestionReservation.DAO
{
    class ClientDAO
    {
        private db.NpgsqlCommand cmd;
        private db.NpgsqlDataAdapter ada;

        public ClientDAO()
        {
            Connection.MakeConnection();
        }

        public void add(string name, string cin)
        {
            DAO.Connection.Cnx.Open();
            cmd = new db.NpgsqlCommand(
                "insert into client (name, cin) values ('" + name + "', '" + cin + "')",
                DAO.Connection.Cnx
            );
            cmd.ExecuteNonQuery();
            DAO.Connection.Cnx.Close();
        }

        public Client getById(int id)
        {
            List<Client> list = new List<Client>();
            DAO.Connection.Cnx.Open();
            cmd = new db.NpgsqlCommand("select * from client where id = " + id, DAO.Connection.Cnx);
            ada = new db.NpgsqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            DAO.Connection.Cnx.Close();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new Client((int)row["id"],(string)row["name"], (string)row["cin"]));
            }
            if (list.Count != 0)
                return list[0];
            return null;
        }

        public Client getByCinName(string cin, string name)
        {
            List<Client> list = new List<Client>();
            DAO.Connection.Cnx.Open();
            cmd = new db.NpgsqlCommand(
                "select * from client where cin = '" + cin + "' and name = '"+name+"'",
                DAO.Connection.Cnx);
            ada = new db.NpgsqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            DAO.Connection.Cnx.Close();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new Client((int)row["id"], (string)row["name"], (string)row["cin"]));
            }
            if (list.Count != 0)
                return list[0];
            return null;
        }
    }
}
