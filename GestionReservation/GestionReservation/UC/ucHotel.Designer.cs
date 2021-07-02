
namespace GestionReservation.UC
{
    partial class ucHotel
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblDtFrom = new System.Windows.Forms.Label();
            this.dtPickerFrom = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.layout = new System.Windows.Forms.TableLayoutPanel();
            this.layoutDt = new System.Windows.Forms.TableLayoutPanel();
            this.dtPickerTo = new System.Windows.Forms.DateTimePicker();
            this.lblDtTo = new System.Windows.Forms.Label();
            this.errorProv = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.layoutDt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProv)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDtFrom
            // 
            this.lblDtFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDtFrom.AutoSize = true;
            this.lblDtFrom.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtFrom.Location = new System.Drawing.Point(2, 7);
            this.lblDtFrom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDtFrom.Name = "lblDtFrom";
            this.lblDtFrom.Size = new System.Drawing.Size(124, 23);
            this.lblDtFrom.TabIndex = 3;
            this.lblDtFrom.Text = "Date from :";
            this.lblDtFrom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtPickerFrom
            // 
            this.dtPickerFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtPickerFrom.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPickerFrom.Location = new System.Drawing.Point(130, 6);
            this.dtPickerFrom.Margin = new System.Windows.Forms.Padding(2);
            this.dtPickerFrom.Name = "dtPickerFrom";
            this.dtPickerFrom.Size = new System.Drawing.Size(508, 26);
            this.dtPickerFrom.TabIndex = 4;
            this.dtPickerFrom.ValueChanged += new System.EventHandler(this.dtPicker_ValueChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.layout, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.layoutDt, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(718, 418);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // layout
            // 
            this.layout.ColumnCount = 1;
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 640F));
            this.layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout.Location = new System.Drawing.Point(38, 106);
            this.layout.Name = "layout";
            this.layout.RowCount = 1;
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layout.Size = new System.Drawing.Size(640, 286);
            this.layout.TabIndex = 5;
            // 
            // layoutDt
            // 
            this.layoutDt.ColumnCount = 2;
            this.layoutDt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layoutDt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.layoutDt.Controls.Add(this.dtPickerFrom, 1, 0);
            this.layoutDt.Controls.Add(this.dtPickerTo, 1, 1);
            this.layoutDt.Controls.Add(this.lblDtFrom, 0, 0);
            this.layoutDt.Controls.Add(this.lblDtTo, 0, 1);
            this.layoutDt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutDt.Location = new System.Drawing.Point(38, 23);
            this.layoutDt.Name = "layoutDt";
            this.layoutDt.RowCount = 2;
            this.layoutDt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutDt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutDt.Size = new System.Drawing.Size(640, 77);
            this.layoutDt.TabIndex = 6;
            // 
            // dtPickerTo
            // 
            this.dtPickerTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtPickerTo.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPickerTo.Location = new System.Drawing.Point(130, 44);
            this.dtPickerTo.Margin = new System.Windows.Forms.Padding(2);
            this.dtPickerTo.Name = "dtPickerTo";
            this.dtPickerTo.Size = new System.Drawing.Size(508, 26);
            this.dtPickerTo.TabIndex = 4;
            this.dtPickerTo.ValueChanged += new System.EventHandler(this.dtPicker_ValueChanged);
            // 
            // lblDtTo
            // 
            this.lblDtTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDtTo.AutoSize = true;
            this.lblDtTo.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtTo.Location = new System.Drawing.Point(2, 46);
            this.lblDtTo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDtTo.Name = "lblDtTo";
            this.lblDtTo.Size = new System.Drawing.Size(124, 23);
            this.lblDtTo.TabIndex = 3;
            this.lblDtTo.Text = "Date to :";
            this.lblDtTo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // errorProv
            // 
            this.errorProv.ContainerControl = this;
            // 
            // ucHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ucHotel";
            this.Size = new System.Drawing.Size(718, 418);
            this.Load += new System.EventHandler(this.ucHotel_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.layoutDt.ResumeLayout(false);
            this.layoutDt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblDtFrom;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblDtTo;
        private System.Windows.Forms.ErrorProvider errorProv;
        private System.Windows.Forms.DateTimePicker dtPickerFrom;
        private System.Windows.Forms.DateTimePicker dtPickerTo;
        private System.Windows.Forms.TableLayoutPanel layout;
        private System.Windows.Forms.TableLayoutPanel layoutDt;
    }
}
