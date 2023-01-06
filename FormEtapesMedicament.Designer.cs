namespace PROJETgesAMM
{
    partial class FormEtapesMedicament
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
            this.cbMedicament = new System.Windows.Forms.ComboBox();
            this.lvEtapes = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.Norme = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbMedicament
            // 
            this.cbMedicament.FormattingEnabled = true;
            this.cbMedicament.Location = new System.Drawing.Point(874, 103);
            this.cbMedicament.Name = "cbMedicament";
            this.cbMedicament.Size = new System.Drawing.Size(151, 28);
            this.cbMedicament.TabIndex = 0;
            this.cbMedicament.SelectedIndexChanged += new System.EventHandler(this.cbMedicament_SelectedIndexChanged);
            // 
            // lvEtapes
            // 
            this.lvEtapes.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lvEtapes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.Norme,
            this.columnHeader6});
            this.lvEtapes.Location = new System.Drawing.Point(52, 68);
            this.lvEtapes.Name = "lvEtapes";
            this.lvEtapes.Size = new System.Drawing.Size(697, 369);
            this.lvEtapes.TabIndex = 1;
            this.lvEtapes.UseCompatibleStateImageBehavior = false;
            this.lvEtapes.View = System.Windows.Forms.View.Details;
            this.lvEtapes.SelectedIndexChanged += new System.EventHandler(this.lvEtapes_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Etape numéro";
            this.columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nom";
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Date Décision";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Décision";
            this.columnHeader4.Width = 120;
            // 
            // Norme
            // 
            this.Norme.Text = "Norme";
            this.Norme.Width = 90;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Date Norme";
            this.columnHeader6.Width = 120;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(902, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Médicament";
            // 
            // FormEtapesMedicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1145, 519);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvEtapes);
            this.Controls.Add(this.cbMedicament);
            this.Name = "FormEtapesMedicament";
            this.Text = "FormEtapesMedicament";
            this.Load += new System.EventHandler(this.FormEtapesMedicament_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbMedicament;
        private ListView lvEtapes;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader Norme;
        private ColumnHeader columnHeader6;
        private Label label1;
    }
}