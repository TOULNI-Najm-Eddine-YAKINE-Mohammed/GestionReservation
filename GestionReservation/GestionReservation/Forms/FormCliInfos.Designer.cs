
namespace GestionReservation
{
    partial class FormCliInfos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.layout = new System.Windows.Forms.TableLayoutPanel();
            this.btnVal = new System.Windows.Forms.Button();
            this.btnAnn = new System.Windows.Forms.Button();
            this.layoutCli = new System.Windows.Forms.TableLayoutPanel();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCin = new System.Windows.Forms.TextBox();
            this.lblCin = new System.Windows.Forms.Label();
            this.layoutDt = new System.Windows.Forms.TableLayoutPanel();
            this.lblDtTo = new System.Windows.Forms.Label();
            this.txtDtTo = new System.Windows.Forms.TextBox();
            this.lblDtFrom = new System.Windows.Forms.Label();
            this.txtDtFrom = new System.Windows.Forms.TextBox();
            this.errorProv = new System.Windows.Forms.ErrorProvider(this.components);
            this.layout.SuspendLayout();
            this.layoutCli.SuspendLayout();
            this.layoutDt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProv)).BeginInit();
            this.SuspendLayout();
            // 
            // layout
            // 
            this.layout.ColumnCount = 4;
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.layout.Controls.Add(this.btnVal, 1, 4);
            this.layout.Controls.Add(this.btnAnn, 2, 4);
            this.layout.Controls.Add(this.layoutCli, 1, 1);
            this.layout.Controls.Add(this.layoutDt, 1, 2);
            this.layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout.Location = new System.Drawing.Point(0, 0);
            this.layout.Name = "layout";
            this.layout.RowCount = 6;
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.layout.Size = new System.Drawing.Size(382, 239);
            this.layout.TabIndex = 0;
            // 
            // btnVal
            // 
            this.btnVal.BackColor = System.Drawing.Color.LightGray;
            this.btnVal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVal.Enabled = false;
            this.btnVal.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btnVal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVal.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVal.Location = new System.Drawing.Point(41, 179);
            this.btnVal.Name = "btnVal";
            this.btnVal.Size = new System.Drawing.Size(146, 29);
            this.btnVal.TabIndex = 0;
            this.btnVal.Text = "Valider";
            this.btnVal.UseVisualStyleBackColor = false;
            this.btnVal.EnabledChanged += new System.EventHandler(this.btnColorChange);
            this.btnVal.Click += new System.EventHandler(this.btnVal_Click);
            this.btnVal.MouseLeave += new System.EventHandler(this.btnColorChange);
            this.btnVal.MouseHover += new System.EventHandler(this.btn_MouseHover);
            // 
            // btnAnn
            // 
            this.btnAnn.BackColor = System.Drawing.Color.White;
            this.btnAnn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAnn.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btnAnn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnn.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnn.Location = new System.Drawing.Point(193, 179);
            this.btnAnn.Name = "btnAnn";
            this.btnAnn.Size = new System.Drawing.Size(146, 29);
            this.btnAnn.TabIndex = 1;
            this.btnAnn.Text = "Annuler";
            this.btnAnn.UseVisualStyleBackColor = false;
            this.btnAnn.Click += new System.EventHandler(this.btnAnn_Click);
            this.btnAnn.MouseLeave += new System.EventHandler(this.btnColorChange);
            this.btnAnn.MouseHover += new System.EventHandler(this.btn_MouseHover);
            // 
            // layoutCli
            // 
            this.layoutCli.ColumnCount = 2;
            this.layout.SetColumnSpan(this.layoutCli, 2);
            this.layoutCli.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.layoutCli.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.layoutCli.Controls.Add(this.lblName, 0, 0);
            this.layoutCli.Controls.Add(this.txtName, 1, 0);
            this.layoutCli.Controls.Add(this.txtCin, 1, 1);
            this.layoutCli.Controls.Add(this.lblCin, 0, 1);
            this.layoutCli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutCli.Location = new System.Drawing.Point(38, 23);
            this.layoutCli.Margin = new System.Windows.Forms.Padding(0);
            this.layoutCli.Name = "layoutCli";
            this.layoutCli.RowCount = 2;
            this.layoutCli.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutCli.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutCli.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutCli.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutCli.Size = new System.Drawing.Size(304, 71);
            this.layoutCli.TabIndex = 5;
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(3, 8);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(85, 18);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name :";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(94, 6);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(207, 23);
            this.txtName.TabIndex = 3;
            this.txtName.TextChanged += new System.EventHandler(this.textChanged);
            // 
            // txtCin
            // 
            this.txtCin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCin.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCin.Location = new System.Drawing.Point(94, 41);
            this.txtCin.Name = "txtCin";
            this.txtCin.Size = new System.Drawing.Size(207, 23);
            this.txtCin.TabIndex = 4;
            this.txtCin.TextChanged += new System.EventHandler(this.textChanged);
            // 
            // lblCin
            // 
            this.lblCin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCin.AutoSize = true;
            this.lblCin.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCin.Location = new System.Drawing.Point(3, 44);
            this.lblCin.Name = "lblCin";
            this.lblCin.Size = new System.Drawing.Size(85, 18);
            this.lblCin.TabIndex = 2;
            this.lblCin.Text = "CIN :";
            // 
            // layoutDt
            // 
            this.layoutDt.ColumnCount = 2;
            this.layout.SetColumnSpan(this.layoutDt, 2);
            this.layoutDt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.layoutDt.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.layoutDt.Controls.Add(this.lblDtTo, 0, 1);
            this.layoutDt.Controls.Add(this.txtDtTo, 1, 1);
            this.layoutDt.Controls.Add(this.lblDtFrom, 0, 0);
            this.layoutDt.Controls.Add(this.txtDtFrom, 1, 0);
            this.layoutDt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutDt.Location = new System.Drawing.Point(38, 94);
            this.layoutDt.Margin = new System.Windows.Forms.Padding(0);
            this.layoutDt.Name = "layoutDt";
            this.layoutDt.RowCount = 2;
            this.layoutDt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutDt.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutDt.Size = new System.Drawing.Size(304, 71);
            this.layoutDt.TabIndex = 6;
            this.layoutDt.Visible = false;
            // 
            // lblDtTo
            // 
            this.lblDtTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDtTo.AutoSize = true;
            this.lblDtTo.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtTo.Location = new System.Drawing.Point(3, 44);
            this.lblDtTo.Name = "lblDtTo";
            this.lblDtTo.Size = new System.Drawing.Size(85, 18);
            this.lblDtTo.TabIndex = 6;
            this.lblDtTo.Text = "Date to :";
            // 
            // txtDtTo
            // 
            this.txtDtTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDtTo.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDtTo.Location = new System.Drawing.Point(94, 41);
            this.txtDtTo.Name = "txtDtTo";
            this.txtDtTo.Size = new System.Drawing.Size(207, 23);
            this.txtDtTo.TabIndex = 8;
            // 
            // lblDtFrom
            // 
            this.lblDtFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDtFrom.AutoSize = true;
            this.lblDtFrom.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtFrom.Location = new System.Drawing.Point(3, 8);
            this.lblDtFrom.Name = "lblDtFrom";
            this.lblDtFrom.Size = new System.Drawing.Size(85, 18);
            this.lblDtFrom.TabIndex = 5;
            this.lblDtFrom.Text = "Date from :";
            // 
            // txtDtFrom
            // 
            this.txtDtFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDtFrom.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDtFrom.Location = new System.Drawing.Point(94, 6);
            this.txtDtFrom.Name = "txtDtFrom";
            this.txtDtFrom.Size = new System.Drawing.Size(207, 23);
            this.txtDtFrom.TabIndex = 7;
            // 
            // errorProv
            // 
            this.errorProv.ContainerControl = this;
            // 
            // FormCliInfos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(382, 239);
            this.Controls.Add(this.layout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCliInfos";
            this.Text = "Client";
            this.layout.ResumeLayout(false);
            this.layoutCli.ResumeLayout(false);
            this.layoutCli.PerformLayout();
            this.layoutDt.ResumeLayout(false);
            this.layoutDt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layout;
        private System.Windows.Forms.Button btnAnn;
        private System.Windows.Forms.Button btnVal;
        private System.Windows.Forms.TableLayoutPanel layoutCli;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCin;
        private System.Windows.Forms.Label lblCin;
        private System.Windows.Forms.TableLayoutPanel layoutDt;
        private System.Windows.Forms.Label lblDtTo;
        private System.Windows.Forms.TextBox txtDtTo;
        private System.Windows.Forms.Label lblDtFrom;
        private System.Windows.Forms.TextBox txtDtFrom;
        private System.Windows.Forms.ErrorProvider errorProv;
    }
}