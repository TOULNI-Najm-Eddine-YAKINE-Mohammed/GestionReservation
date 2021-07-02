using GestionReservation.DAO;
using GestionReservation.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GestionReservation.UC
{
    public partial class ucHotel : UserControl
    {
        public static ucHotel myself;

        public ucHotel()
        {
            InitializeComponent();
            myself = this;
        }

        private void ucHotel_Load(object sender, EventArgs e)
        {
            ChambreDAO chmbrDAO = new ChambreDAO();
            List<Chambre> chambres = chmbrDAO.GetAll();

            layout.ColumnStyles.Clear();
            layout.RowStyles.Clear();
            layout.Controls.Clear();

            double x = Math.Sqrt(chambres.Count);
            int r = (int)((x - (int)x) * 10);
            if (r >= 5)
            {
                layout.RowCount = (int)x + 1;
                layout.ColumnCount = (int)x + 1;
            }
            else if (r < 5 && r > 0)
            {
                layout.RowCount = (int)x + 1;
                layout.ColumnCount = (int)x;
            }
            else
            {
                layout.RowCount = (int)x;
                layout.ColumnCount = (int)x;
            }

            for (int i = 0; i < layout.RowCount; i++)
                layout.RowStyles.Add(new RowStyle(SizeType.Percent, 100 / layout.RowCount));
            for (int i = 0; i < layout.ColumnCount; i++)
                layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 / layout.ColumnCount));

            int k = 0;
            for (int i = 0; i < layout.RowCount; i++)
            {
                for (int j = 0; j < layout.RowCount; j++)
                {
                    if (k < chambres.Count)
                    {
                        ucRoom ucRoom = new ucRoom();
                        ucRoom.Dock = DockStyle.Fill;
                        ucRoom.Margin = new Padding(2);
                        ucRoom.Name = "ucRoom" + chambres[k].Num;
                        ucRoom.Num = chambres[k].Num;
                        ucRoom.Id = chambres[k].Id;
                        layout.Controls.Add(ucRoom, j, i);
                        k++;
                    }
                }
            }
            dtPickerFrom.MinDate = DateTime.Now;
            dtPickerTo.MinDate = DateTime.Now.AddDays(1);
        }

        private void dtPicker_ValueChanged(object sender, EventArgs e)
        {
            ChangeChambres();
        }

        public void ChangeChambres()
        {
            if (dtPickerTo.Value > dtPickerFrom.Value)
            {
                foreach (Control room in layout.Controls)
                {
                    ((ucRoom)room).btnResEnabled(true);
                    ((ucRoom)room).ShowStatus(((ucRoom)room).Id, dtPickerFrom.Value, dtPickerTo.Value);
                }
                errorProv.Clear();
            }
            else
            {
                foreach (Control room in layout.Controls)
                {
                    ((ucRoom)room).btnResEnabled(false);
                }
                errorProv.SetError(layoutDt, "Date_To doit être supérieur à Date_From");
            }
        }

        public DateTime getDateFrom()
        {
            return dtPickerFrom.Value;
        }

        public DateTime getDateTo()
        {
            return dtPickerTo.Value;
        }
    }
}
