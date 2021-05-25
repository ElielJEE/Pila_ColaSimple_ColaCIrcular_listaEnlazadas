
namespace Pilas_ColasSimples_ColasCirculares
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.PilasForm = new System.Windows.Forms.ToolStripMenuItem();
            this.ColasSimpleForm = new System.Windows.Forms.ToolStripMenuItem();
            this.ColasCircularesForm = new System.Windows.Forms.ToolStripMenuItem();
            this.notacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infijaAPosfijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infijaAPrefijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.posfijaAInfijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preifjaAInfijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(628, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PilasForm,
            this.ColasSimpleForm,
            this.ColasCircularesForm,
            this.notacionesToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(69, 20);
            this.toolStripMenuItem1.Text = "Opciones";
            // 
            // PilasForm
            // 
            this.PilasForm.Name = "PilasForm";
            this.PilasForm.Size = new System.Drawing.Size(180, 22);
            this.PilasForm.Text = "Pila";
            this.PilasForm.Click += new System.EventHandler(this.PilasForm_Click);
            // 
            // ColasSimpleForm
            // 
            this.ColasSimpleForm.Name = "ColasSimpleForm";
            this.ColasSimpleForm.Size = new System.Drawing.Size(180, 22);
            this.ColasSimpleForm.Text = "Colas Simple";
            this.ColasSimpleForm.Click += new System.EventHandler(this.ColasSimpleForm_Click);
            // 
            // ColasCircularesForm
            // 
            this.ColasCircularesForm.Name = "ColasCircularesForm";
            this.ColasCircularesForm.Size = new System.Drawing.Size(180, 22);
            this.ColasCircularesForm.Text = "Colas Circulares";
            this.ColasCircularesForm.Click += new System.EventHandler(this.ColasCircularesForm_Click);
            // 
            // notacionesToolStripMenuItem
            // 
            this.notacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infijaAPosfijaToolStripMenuItem,
            this.infijaAPrefijaToolStripMenuItem,
            this.posfijaAInfijaToolStripMenuItem,
            this.preifjaAInfijaToolStripMenuItem});
            this.notacionesToolStripMenuItem.Name = "notacionesToolStripMenuItem";
            this.notacionesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.notacionesToolStripMenuItem.Text = "Notaciones";
            // 
            // infijaAPosfijaToolStripMenuItem
            // 
            this.infijaAPosfijaToolStripMenuItem.Name = "infijaAPosfijaToolStripMenuItem";
            this.infijaAPosfijaToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.infijaAPosfijaToolStripMenuItem.Text = "Infija a Posfija";
            // 
            // infijaAPrefijaToolStripMenuItem
            // 
            this.infijaAPrefijaToolStripMenuItem.Name = "infijaAPrefijaToolStripMenuItem";
            this.infijaAPrefijaToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.infijaAPrefijaToolStripMenuItem.Text = "Infija a Prefija";
            // 
            // posfijaAInfijaToolStripMenuItem
            // 
            this.posfijaAInfijaToolStripMenuItem.Name = "posfijaAInfijaToolStripMenuItem";
            this.posfijaAInfijaToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.posfijaAInfijaToolStripMenuItem.Text = "Posfija a Infija";
            // 
            // preifjaAInfijaToolStripMenuItem
            // 
            this.preifjaAInfijaToolStripMenuItem.Name = "preifjaAInfijaToolStripMenuItem";
            this.preifjaAInfijaToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.preifjaAInfijaToolStripMenuItem.Text = "Preifja a Infija";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pilas_ColasSimples_ColasCirculares.Properties.Resources.wp5898790_90s_aesthetic_vaporwave_wallpapers;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(628, 335);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "FormMenu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem PilasForm;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ColasSimpleForm;
        private System.Windows.Forms.ToolStripMenuItem ColasCircularesForm;
        private System.Windows.Forms.ToolStripMenuItem notacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infijaAPosfijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infijaAPrefijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem posfijaAInfijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preifjaAInfijaToolStripMenuItem;
    }
}

