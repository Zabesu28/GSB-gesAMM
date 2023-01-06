namespace PROJETgesAMM
{
    partial class Menu
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
            this.Affichage = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consulatationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.etapesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.etapesNorméesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.etapesEnCoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Affichage.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Affichage
            // 
            this.Affichage.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Affichage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.Affichage.Name = "contextMenuStrip1";
            this.Affichage.ShowCheckMargin = true;
            this.Affichage.Size = new System.Drawing.Size(145, 28);
            this.Affichage.Text = "Affichage";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(144, 24);
            this.toolStripMenuItem2.Text = "étapes";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(210, 26);
            this.toolStripMenuItem3.Text = "saisie d\'une étape";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.etapesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(940, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consulatationToolStripMenuItem,
            this.insertionToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(112, 24);
            this.toolStripMenuItem1.Text = "Médicaments";
            // 
            // consulatationToolStripMenuItem
            // 
            this.consulatationToolStripMenuItem.Name = "consulatationToolStripMenuItem";
            this.consulatationToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.consulatationToolStripMenuItem.Text = "Consulatation";
            this.consulatationToolStripMenuItem.Click += new System.EventHandler(this.consulatationToolStripMenuItem_Click);
            // 
            // insertionToolStripMenuItem
            // 
            this.insertionToolStripMenuItem.Name = "insertionToolStripMenuItem";
            this.insertionToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.insertionToolStripMenuItem.Text = "Insertion";
            this.insertionToolStripMenuItem.Click += new System.EventHandler(this.insertionToolStripMenuItem_Click);
            // 
            // etapesToolStripMenuItem
            // 
            this.etapesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultationToolStripMenuItem,
            this.etapesEnCoursToolStripMenuItem,
            this.etapesNorméesToolStripMenuItem});
            this.etapesToolStripMenuItem.Name = "etapesToolStripMenuItem";
            this.etapesToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.etapesToolStripMenuItem.Text = "Etapes ";
            // 
            // consultationToolStripMenuItem
            // 
            this.consultationToolStripMenuItem.Name = "consultationToolStripMenuItem";
            this.consultationToolStripMenuItem.Size = new System.Drawing.Size(315, 26);
            this.consultationToolStripMenuItem.Text = "Consultation";
            this.consultationToolStripMenuItem.Click += new System.EventHandler(this.consultationToolStripMenuItem_Click);
            // 
            // etapesNorméesToolStripMenuItem
            // 
            this.etapesNorméesToolStripMenuItem.Name = "etapesNorméesToolStripMenuItem";
            this.etapesNorméesToolStripMenuItem.Size = new System.Drawing.Size(315, 26);
            this.etapesNorméesToolStripMenuItem.Text = "Etapes normées";
            this.etapesNorméesToolStripMenuItem.Click += new System.EventHandler(this.etapesNorméesToolStripMenuItem_Click);
            // 
            // etapesEnCoursToolStripMenuItem
            // 
            this.etapesEnCoursToolStripMenuItem.Name = "etapesEnCoursToolStripMenuItem";
            this.etapesEnCoursToolStripMenuItem.Size = new System.Drawing.Size(315, 26);
            this.etapesEnCoursToolStripMenuItem.Text = "Etapes des médicaments en cours";
            this.etapesEnCoursToolStripMenuItem.Click += new System.EventHandler(this.etapesEnCoursToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 508);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.Affichage.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ContextMenuStrip contextMenuStrip3;
        private ToolStripMenuItem étapesToolStripMenuItem;
        private ToolStripMenuItem saisieDuneÉtapeToolStripMenuItem;
        private ContextMenuStrip Affichage;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ContextMenuStrip contextMenuStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem consulatationToolStripMenuItem;
        private ToolStripMenuItem insertionToolStripMenuItem;
        private ToolStripMenuItem etapesToolStripMenuItem;
        private ToolStripMenuItem etapesNorméesToolStripMenuItem;
        private ToolStripMenuItem consultationToolStripMenuItem;
        private ToolStripMenuItem etapesEnCoursToolStripMenuItem;
    }
}