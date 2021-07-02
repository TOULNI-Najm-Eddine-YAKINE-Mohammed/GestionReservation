
namespace GestionReservation
{
    partial class FormApp
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.ucHotel = new GestionReservation.UC.ucHotel();
            this.SuspendLayout();
            // 
            // ucHotel
            // 
            this.ucHotel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ucHotel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucHotel.Location = new System.Drawing.Point(0, 0);
            this.ucHotel.Margin = new System.Windows.Forms.Padding(1);
            this.ucHotel.Name = "ucHotel";
            this.ucHotel.Size = new System.Drawing.Size(743, 524);
            this.ucHotel.TabIndex = 0;
            // 
            // FormReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(743, 524);
            this.Controls.Add(this.ucHotel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormReservation";
            this.Text = "Reservation";
            this.ResumeLayout(false);

        }

        #endregion

        private UC.ucHotel ucHotel;
    }
}