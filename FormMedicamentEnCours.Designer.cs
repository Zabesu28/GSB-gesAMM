namespace PROJETgesAMM
{
    partial class FormMedicamentEnCours
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
            this.lvMedicament = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.cbMedicament = new System.Windows.Forms.ComboBox();
            this.lvEtapes = new System.Windows.Forms.ListView();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.Norme = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // lvMedicament
            // 
            this.lvMedicament.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvMedicament.Location = new System.Drawing.Point(12, 12);
            this.lvMedicament.Name = "lvMedicament";
            this.lvMedicament.Size = new System.Drawing.Size(407, 294);
            this.lvMedicament.TabIndex = 0;
            this.lvMedicament.UseCompatibleStateImageBehavior = false;
            this.lvMedicament.View = System.Windows.Forms.View.Details;
            this.lvMedicament.SelectedIndexChanged += new System.EventHandler(this.lvMedicament_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Dépôt légal";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nom commercial";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Famille";
            this.columnHeader3.Width = 100;
            // 
            // cbMedicament
            // 
            this.cbMedicament.FormattingEnabled = true;
            this.cbMedicament.Location = new System.Drawing.Point(445, 12);
            this.cbMedicament.Name = "cbMedicament";
            this.cbMedicament.Size = new System.Drawing.Size(151, 28);
            this.cbMedicament.TabIndex = 1;
            this.cbMedicament.SelectedIndexChanged += new System.EventHandler(this.cbMedicament_SelectedIndexChanged);
            // 
            // lvEtapes
            // 
            this.lvEtapes.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lvEtapes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.Norme,
            this.columnHeader8});
            this.lvEtapes.Location = new System.Drawing.Point(620, 12);
            this.lvEtapes.Name = "lvEtapes";
            this.lvEtapes.Size = new System.Drawing.Size(664, 352);
            this.lvEtapes.TabIndex = 2;
            this.lvEtapes.UseCompatibleStateImageBehavior = false;
            this.lvEtapes.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Etape numéro";
            this.columnHeader4.Width = 90;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Nom";
            this.columnHeader5.Width = 90;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Date Décision";
            this.columnHeader6.Width = 120;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Décision";
            this.columnHeader7.Width = 120;
            // 
            // Norme
            // 
            this.Norme.Text = "Norme";
            this.Norme.Width = 90;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Date Norme";
            this.columnHeader8.Width = 120;
            // 
            // FormMedicamentEnCours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 552);
            this.Controls.Add(this.lvEtapes);
            this.Controls.Add(this.cbMedicament);
            this.Controls.Add(this.lvMedicament);
            this.Name = "FormMedicamentEnCours";
            this.Text = "FormMedicamentEnCours";
            this.Load += new System.EventHandler(this.FormMedicamentEnCours_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ListView lvMedicament;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ComboBox cbMedicament;
        private ListView lvEtapes;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader Norme;
        private ColumnHeader columnHeader8;
    }
}