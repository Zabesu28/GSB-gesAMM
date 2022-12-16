namespace PROJETgesAMM
{
    partial class FormMedicamentsAjouter
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
            this.tbDepotLegal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbContreIndication = new System.Windows.Forms.TextBox();
            this.tbEffets = new System.Windows.Forms.TextBox();
            this.tbNomCommercial = new System.Windows.Forms.TextBox();
            this.tbComposition = new System.Windows.Forms.TextBox();
            this.tbCodeFamille = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbDepotLegal
            // 
            this.tbDepotLegal.Location = new System.Drawing.Point(174, 37);
            this.tbDepotLegal.Name = "tbDepotLegal";
            this.tbDepotLegal.Size = new System.Drawing.Size(275, 27);
            this.tbDepotLegal.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Depôt légal :";
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(532, 493);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(94, 29);
            this.btnAjouter.TabIndex = 2;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nom commercial :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbCodeFamille);
            this.groupBox1.Controls.Add(this.tbComposition);
            this.groupBox1.Controls.Add(this.tbNomCommercial);
            this.groupBox1.Controls.Add(this.tbEffets);
            this.groupBox1.Controls.Add(this.tbContreIndication);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnAjouter);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbDepotLegal);
            this.groupBox1.Location = new System.Drawing.Point(34, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1178, 548);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ajout médicament";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Code Famille :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Composition :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(588, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Effets :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(588, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Contre indication :";
            // 
            // tbContreIndication
            // 
            this.tbContreIndication.Location = new System.Drawing.Point(739, 275);
            this.tbContreIndication.Multiline = true;
            this.tbContreIndication.Name = "tbContreIndication";
            this.tbContreIndication.Size = new System.Drawing.Size(412, 178);
            this.tbContreIndication.TabIndex = 8;
            // 
            // tbEffets
            // 
            this.tbEffets.Location = new System.Drawing.Point(739, 37);
            this.tbEffets.Multiline = true;
            this.tbEffets.Name = "tbEffets";
            this.tbEffets.Size = new System.Drawing.Size(412, 178);
            this.tbEffets.TabIndex = 9;
            // 
            // tbNomCommercial
            // 
            this.tbNomCommercial.Location = new System.Drawing.Point(174, 146);
            this.tbNomCommercial.Name = "tbNomCommercial";
            this.tbNomCommercial.Size = new System.Drawing.Size(275, 27);
            this.tbNomCommercial.TabIndex = 10;
            // 
            // tbComposition
            // 
            this.tbComposition.Location = new System.Drawing.Point(174, 249);
            this.tbComposition.Name = "tbComposition";
            this.tbComposition.Size = new System.Drawing.Size(275, 27);
            this.tbComposition.TabIndex = 11;
            // 
            // tbCodeFamille
            // 
            this.tbCodeFamille.Location = new System.Drawing.Point(174, 351);
            this.tbCodeFamille.Name = "tbCodeFamille";
            this.tbCodeFamille.Size = new System.Drawing.Size(275, 27);
            this.tbCodeFamille.TabIndex = 12;
            // 
            // FormMedicamentsAjouter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 618);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormMedicamentsAjouter";
            this.Text = "Ajouter un nouveau médicament";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox tbDepotLegal;
        private Label label1;
        private Button btnAjouter;
        private Label label2;
        private GroupBox groupBox1;
        private TextBox tbCodeFamille;
        private TextBox tbComposition;
        private TextBox tbNomCommercial;
        private TextBox tbEffets;
        private TextBox tbContreIndication;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
    }
}