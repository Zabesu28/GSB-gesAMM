namespace PROJETgesAMM
{
    partial class FormEtapeNormees
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
            this.lvEtapeNormee = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.tbNorme = new System.Windows.Forms.TextBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.lbDateNormee = new System.Windows.Forms.Label();
            this.lbNorme = new System.Windows.Forms.Label();
            this.dtpDateNormee = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lvEtapeNormee
            // 
            this.lvEtapeNormee.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvEtapeNormee.Location = new System.Drawing.Point(176, 30);
            this.lvEtapeNormee.Name = "lvEtapeNormee";
            this.lvEtapeNormee.Size = new System.Drawing.Size(519, 279);
            this.lvEtapeNormee.TabIndex = 0;
            this.lvEtapeNormee.UseCompatibleStateImageBehavior = false;
            this.lvEtapeNormee.View = System.Windows.Forms.View.Details;
            this.lvEtapeNormee.SelectedIndexChanged += new System.EventHandler(this.lvEtapeNormee_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Numéro Etape";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Norme";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Date de la norme";
            this.columnHeader3.Width = 200;
            // 
            // tbNorme
            // 
            this.tbNorme.Location = new System.Drawing.Point(298, 470);
            this.tbNorme.Name = "tbNorme";
            this.tbNorme.Size = new System.Drawing.Size(250, 27);
            this.tbNorme.TabIndex = 4;
            this.tbNorme.TextChanged += new System.EventHandler(this.tbNorme_TextChanged);
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(603, 468);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(94, 29);
            this.btnValider.TabIndex = 5;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // lbDateNormee
            // 
            this.lbDateNormee.AutoSize = true;
            this.lbDateNormee.Location = new System.Drawing.Point(188, 379);
            this.lbDateNormee.Name = "lbDateNormee";
            this.lbDateNormee.Size = new System.Drawing.Size(91, 20);
            this.lbDateNormee.TabIndex = 6;
            this.lbDateNormee.Text = "Date Norme";
            // 
            // lbNorme
            // 
            this.lbNorme.AutoSize = true;
            this.lbNorme.Location = new System.Drawing.Point(201, 473);
            this.lbNorme.Name = "lbNorme";
            this.lbNorme.Size = new System.Drawing.Size(55, 20);
            this.lbNorme.TabIndex = 7;
            this.lbNorme.Text = "Norme";
            // 
            // dtpDateNormee
            // 
            this.dtpDateNormee.Location = new System.Drawing.Point(298, 375);
            this.dtpDateNormee.Name = "dtpDateNormee";
            this.dtpDateNormee.Size = new System.Drawing.Size(250, 27);
            this.dtpDateNormee.TabIndex = 8;
            // 
            // FormEtapeNormees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 552);
            this.Controls.Add(this.dtpDateNormee);
            this.Controls.Add(this.lbNorme);
            this.Controls.Add(this.lbDateNormee);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.tbNorme);
            this.Controls.Add(this.lvEtapeNormee);
            this.Name = "FormEtapeNormees";
            this.Text = "FormEtapeNormees";
            this.Load += new System.EventHandler(this.FormEtapeNormees_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView lvEtapeNormee;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader3;
        private TextBox tbNorme;
        private Button btnValider;
        private Label lbDateNormee;
        private Label lbNorme;
        private DateTimePicker dtpDateNormee;
    }
}