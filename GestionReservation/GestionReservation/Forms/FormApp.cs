using System.Windows.Forms;

namespace GestionReservation
{
    public partial class FormApp : Form
    {
        public static Form myself;

        public FormApp()
        {
            InitializeComponent();
            this.CenterToScreen();
            myself = this;
        }
    }
}
