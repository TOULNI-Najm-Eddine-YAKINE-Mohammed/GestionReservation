using GestionReservation.DAO;
using GestionReservation.Model;
using GestionReservation.UC;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GestionReservation
{
    public partial class FormCliInfos : Form
    {

        private ClientDAO cliDAO;
        private ReservationDAO resDAO;
        private Reservation res;

        public FormCliInfos(Reservation res)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.ShowInTaskbar = false;
            this.Location = new Point(
                FormApp.myself.Location.X + (FormApp.myself.Width/4),
                FormApp.myself.Location.Y + (FormApp.myself.Height/4)
            );

            cliDAO = new ClientDAO();
            resDAO = new ReservationDAO();
            this.res = res;
            if(res.Id_client != 0)
            {
                Client cli = cliDAO.getById(res.Id_client);
                txtCin.Text = cli.CIN;
                txtName.Text = cli.Name;
                txtDtFrom.Text = res.Date_from.ToString();
                txtDtTo.Text = res.Date_to.ToString();
                txtCin.Enabled = false;
                txtName.Enabled = false;
                txtDtFrom.Enabled = false;
                txtDtTo.Enabled = false;
                btnVal.Visible = false;
                layoutDt.Visible = true;
                this.Text = "Chambre " + res.Id_chambre;
            }
            else
            {
                layout.RowStyles[2].Height = 0F;
                layoutDt.Visible = false;
                this.Text = "Client";
            }
        }

        private void btnVal_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string cin = txtCin.Text;
            Client cli = cliDAO.getByCinName(cin, name);
            if (cli == null)
            {
                cliDAO.add(name, cin);
                cli = cliDAO.getByCinName(cin, name);
            }
            resDAO.reserver(res.Date_from, res.Date_to, res.Id_chambre, cli.Id);
            this.Dispose();
            ucHotel.myself.ChangeChambres();
        }

        private void btnAnn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void textChanged(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() != "" && txtCin.Text.Trim() != "")
            {
                btnVal.Enabled = true;
                errorProv.Clear();
            }
            else
            {
                btnVal.Enabled = false;
                errorProv.SetError(layoutCli, "Les deux champes sont obligatoires");
            }
        }

        private void btn_MouseHover(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.SteelBlue;
        }

        private void btnColorChange(object sender, EventArgs e)
        {
            if (((Button)sender).Enabled)
                ((Button)sender).BackColor = Color.White;
            else
                ((Button)sender).BackColor = Color.LightGray;
        }
    }
}
