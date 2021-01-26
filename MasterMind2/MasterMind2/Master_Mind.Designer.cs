using System.Threading;
namespace MasterMind
{
    partial class Master_Mind
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
        public void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arxiuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaPartidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.definirNombreDeColorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.definitNombreDintentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.definirColorsDePartidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arxiuToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(919, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arxiuToolStripMenuItem
            // 
            this.arxiuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaPartidaToolStripMenuItem,
            this.opcionsToolStripMenuItem,
            this.sortirToolStripMenuItem});
            this.arxiuToolStripMenuItem.Name = "arxiuToolStripMenuItem";
            this.arxiuToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.arxiuToolStripMenuItem.Text = "Arxiu";
            // 
            // novaPartidaToolStripMenuItem
            // 
            this.novaPartidaToolStripMenuItem.Name = "novaPartidaToolStripMenuItem";
            this.novaPartidaToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.novaPartidaToolStripMenuItem.Text = "Nova Partida";
            // 
            // opcionsToolStripMenuItem
            // 
            this.opcionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.definirNombreDeColorsToolStripMenuItem,
            this.definitNombreDintentsToolStripMenuItem,
            this.definirColorsDePartidaToolStripMenuItem});
            this.opcionsToolStripMenuItem.Name = "opcionsToolStripMenuItem";
            this.opcionsToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.opcionsToolStripMenuItem.Text = "Opcions";
            // 
            // definirNombreDeColorsToolStripMenuItem
            // 
            this.definirNombreDeColorsToolStripMenuItem.Name = "definirNombreDeColorsToolStripMenuItem";
            this.definirNombreDeColorsToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.definirNombreDeColorsToolStripMenuItem.Text = "Definir nombre de colors";
            // 
            // definitNombreDintentsToolStripMenuItem
            // 
            this.definitNombreDintentsToolStripMenuItem.Name = "definitNombreDintentsToolStripMenuItem";
            this.definitNombreDintentsToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.definitNombreDintentsToolStripMenuItem.Text = "Definir nombre d\'intents";
            // 
            // definirColorsDePartidaToolStripMenuItem
            // 
            this.definirColorsDePartidaToolStripMenuItem.Name = "definirColorsDePartidaToolStripMenuItem";
            this.definirColorsDePartidaToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.definirColorsDePartidaToolStripMenuItem.Text = "Definir colors de partida";
            // 
            // sortirToolStripMenuItem
            // 
            this.sortirToolStripMenuItem.Name = "sortirToolStripMenuItem";
            this.sortirToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.sortirToolStripMenuItem.Text = "Sortir";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Location = new System.Drawing.Point(15, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 542);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Red;
            this.pictureBox1.Location = new System.Drawing.Point(611, 156);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 26);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Location = new System.Drawing.Point(311, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 542);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(607, 312);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(290, 118);
            this.panel3.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Combinació secreta:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(607, 188);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(290, 118);
            this.panel4.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Colors Disponibles:";
            // 
            // Master_Mind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 607);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Master_Mind";
            this.Text = "Master_Mind";
            this.Load += new System.EventHandler(this.Master_Mind_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arxiuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaPartidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem definirNombreDeColorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem definitNombreDintentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem definirColorsDePartidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
    }
}