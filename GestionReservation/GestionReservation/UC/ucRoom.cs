using GestionReservation.DAO;
using GestionReservation.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GestionReservation.UC
{
    public partial class ucRoom : UserControl
    {
        public int Num { get; set; }
        public int Id { get; set; }
        public int Id_client { get; set; }
        private ReservationDAO resDAO;
        private ChambreDAO chmbrDAO;

        public ucRoom()
        {
            InitializeComponent();
        }

        private void ucRoom_Load(object sender, EventArgs e)
        {
            lblNum.Text = Num.ToString();
            resDAO = new ReservationDAO();
            chmbrDAO = new ChambreDAO();
        }

        public void ShowStatus(int id, DateTime dateFrom, DateTime dateTo)
        {
            int res = chmbrDAO.IsReserved(id, dateFrom, dateTo);
            if (res != 0)
            {
                this.Id_client = res;
                this.BackColor = Color.Salmon;
                lblNum.Cursor = Cursors.Hand;
                btnRes.Enabled = false;
                btnLib.Enabled = true;
                return;
            }
            this.Id_client = 0;
            this.BackColor = Color.AliceBlue;
            lblNum.Cursor = Cursors.Arrow;
            btnRes.Enabled = true;
            btnLib.Enabled = false;
        }

        private void lblNum_Click(object sender, EventArgs e)
        {
            if (chmbrDAO.IsReserved(this.Id, ucHotel.myself.getDateFrom(), ucHotel.myself.getDateTo()) != 0)
            {
                FormCliInfos f = new FormCliInfos(
                    resDAO.getOne(
                        ucHotel.myself.getDateFrom(),
                        ucHotel.myself.getDateTo(),
                        this.Id,
                        this.Id_client
                    )
                );
                f.ShowDialog(FormApp.myself);
            }
        }

        private void btnRes_Click(object sender, EventArgs e)
        {
            FormCliInfos f = new FormCliInfos(
                new Reservation(0,ucHotel.myself.getDateFrom(), ucHotel.myself.getDateTo(), this.Id,0)
            );
            f.ShowDialog(this.ParentForm);
        }

        private void btnLib_Click(object sender, EventArgs e)
        {
            resDAO.liberer(this.Id, this.Id_client, ucHotel.myself.getDateFrom(), ucHotel.myself.getDateTo());
            ShowStatus(this.Id, ucHotel.myself.getDateFrom(), ucHotel.myself.getDateTo());
        }

        public void btnResEnabled(bool b)
        {
            btnRes.Enabled = b;
        }

        private void lblNum_MouseHover(object sender, EventArgs e)
        {
            if (chmbrDAO.IsReserved(this.Id, ucHotel.myself.getDateFrom(), ucHotel.myself.getDateTo())!=0)
                lblNum.BackColor = Color.RoyalBlue;
        }

        private void lblNum_MouseLeave(object sender, EventArgs e)
        {
            if (chmbrDAO.IsReserved(this.Id, ucHotel.myself.getDateFrom(), ucHotel.myself.getDateTo()) != 0)
                lblNum.BackColor = Color.Navy;
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
