namespace PROJETgesAMM
{
    partial class FormAfficherHistorique
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
            this.lvHisto = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // lvHisto
            // 
            this.lvHisto.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvHisto.Location = new System.Drawing.Point(60, 55);
            this.lvHisto.Name = "lvHisto";
            this.lvHisto.Size = new System.Drawing.Size(883, 377);
            this.lvHisto.TabIndex = 0;
            this.lvHisto.UseCompatibleStateImageBehavior = false;
            this.lvHisto.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nom de l\'étape";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Utilisateur";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Date Modification";
            this.columnHeader3.Width = 125;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ancien libelle";
            this.columnHeader4.Width = 125;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Nouveau libelle";
            this.columnHeader5.Width = 125;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Ancienne date norme";
            this.columnHeader6.Width = 125;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Nouvelle date norme";
            this.columnHeader7.Width = 125;
            // 
            // FormAfficherHistorique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 572);
            this.Controls.Add(this.lvHisto);
            this.Name = "FormAfficherHistorique";
            this.Text = "FormAfficherHistorique";
            this.Load += new System.EventHandler(this.FormAfficherHistorique_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ListView lvHisto;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
    }
}