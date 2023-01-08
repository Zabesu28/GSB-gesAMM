namespace PROJETgesAMM
{
    partial class frmMedAutoriseFam
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
            this.lvFamille = new System.Windows.Forms.ListView();
            this.codeFam = new System.Windows.Forms.ColumnHeader();
            this.designationMed = new System.Windows.Forms.ColumnHeader();
            this.nbMedAuto = new System.Windows.Forms.ColumnHeader();
            this.lvMedAutoriser = new System.Windows.Forms.ListView();
            this.depotLegal = new System.Windows.Forms.ColumnHeader();
            this.nomCommerce = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // lvFamille
            // 
            this.lvFamille.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.codeFam,
            this.designationMed,
            this.nbMedAuto});
            this.lvFamille.Location = new System.Drawing.Point(12, 12);
            this.lvFamille.Name = "lvFamille";
            this.lvFamille.Size = new System.Drawing.Size(697, 426);
            this.lvFamille.TabIndex = 0;
            this.lvFamille.UseCompatibleStateImageBehavior = false;
            this.lvFamille.View = System.Windows.Forms.View.Details;
            this.lvFamille.SelectedIndexChanged += new System.EventHandler(this.lvFamille_SelectedIndexChanged);
            // 
            // codeFam
            // 
            this.codeFam.Text = "Code Famille";
            this.codeFam.Width = 150;
            // 
            // designationMed
            // 
            this.designationMed.Text = "Désignation Medicament";
            this.designationMed.Width = 250;
            // 
            // nbMedAuto
            // 
            this.nbMedAuto.Text = "nombre médicament autorisé";
            this.nbMedAuto.Width = 300;
            // 
            // lvMedAutoriser
            // 
            this.lvMedAutoriser.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.depotLegal,
            this.nomCommerce});
            this.lvMedAutoriser.Location = new System.Drawing.Point(747, 12);
            this.lvMedAutoriser.Name = "lvMedAutoriser";
            this.lvMedAutoriser.Size = new System.Drawing.Size(555, 426);
            this.lvMedAutoriser.TabIndex = 1;
            this.lvMedAutoriser.UseCompatibleStateImageBehavior = false;
            this.lvMedAutoriser.View = System.Windows.Forms.View.Details;
            // 
            // depotLegal
            // 
            this.depotLegal.Text = "Dépot légal";
            this.depotLegal.Width = 200;
            // 
            // nomCommerce
            // 
            this.nomCommerce.Text = "Nom Commercial";
            this.nomCommerce.Width = 300;
            // 
            // frmMedAutoriseFam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 450);
            this.Controls.Add(this.lvMedAutoriser);
            this.Controls.Add(this.lvFamille);
            this.Name = "frmMedAutoriseFam";
            this.Text = "frmMedAutoriseFam";
            this.Load += new System.EventHandler(this.frmMedAutoriseFam_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ListView lvFamille;
        private ColumnHeader codeFam;
        private ColumnHeader designationMed;
        private ColumnHeader nbMedAuto;
        private ListView lvMedAutoriser;
        private ColumnHeader depotLegal;
        private ColumnHeader nomCommerce;
    }
}