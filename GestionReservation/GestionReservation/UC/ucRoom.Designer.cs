
namespace GestionReservation.UC
{
    partial class ucRoom
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
            this.lblNum = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnRes = new System.Windows.Forms.Button();
            this.btnLib = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.BackColor = System.Drawing.Color.Navy;
            this.lblNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel1.SetColumnSpan(this.lblNum, 2);
            this.lblNum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNum.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum.ForeColor = System.Drawing.Color.White;
            this.lblNum.Location = new System.Drawing.Point(13, 13);
            this.lblNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(194, 54);
            this.lblNum.TabIndex = 0;
            this.lblNum.Text = "0";
            this.lblNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNum.Click += new System.EventHandler(this.lblNum_Click);
            this.lblNum.MouseLeave += new System.EventHandler(this.lblNum_MouseLeave);
            this.lblNum.MouseHover += new System.EventHandler(this.lblNum_MouseHover);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Controls.Add(this.lblNum, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnRes, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnLib, 2, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(222, 137);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnRes
            // 
            this.btnRes.BackColor = System.Drawing.Color.White;
            this.btnRes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRes.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btnRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRes.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRes.ForeColor = System.Drawing.Color.Black;
            this.btnRes.Location = new System.Drawing.Point(14, 76);
            this.btnRes.Name = "btnRes";
            this.btnRes.Size = new System.Drawing.Size(93, 48);
            this.btnRes.TabIndex = 1;
            this.btnRes.Text = "Réserver";
            this.btnRes.UseVisualStyleBackColor = false;
            this.btnRes.EnabledChanged += new System.EventHandler(this.btnColorChange);
            this.btnRes.Click += new System.EventHandler(this.btnRes_Click);
            this.btnRes.MouseLeave += new System.EventHandler(this.btnColorChange);
            this.btnRes.MouseHover += new System.EventHandler(this.btn_MouseHover);
            // 
            // btnLib
            // 
            this.btnLib.BackColor = System.Drawing.Color.White;
            this.btnLib.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLib.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLib.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btnLib.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLib.Font = new System.Drawing.Font("Bahnschrift", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLib.ForeColor = System.Drawing.Color.Black;
            this.btnLib.Location = new System.Drawing.Point(113, 76);
            this.btnLib.Name = "btnLib";
            this.btnLib.Size = new System.Drawing.Size(93, 48);
            this.btnLib.TabIndex = 2;
            this.btnLib.Text = "Libérer";
            this.btnLib.UseVisualStyleBackColor = false;
            this.btnLib.EnabledChanged += new System.EventHandler(this.btnColorChange);
            this.btnLib.Click += new System.EventHandler(this.btnLib_Click);
            this.btnLib.MouseLeave += new System.EventHandler(this.btnColorChange);
            this.btnLib.MouseHover += new System.EventHandler(this.btn_MouseHover);
            // 
            // ucRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ucRoom";
            this.Size = new System.Drawing.Size(222, 137);
            this.Load += new System.EventHandler(this.ucRoom_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnRes;
        private System.Windows.Forms.Button btnLib;
    }
}
