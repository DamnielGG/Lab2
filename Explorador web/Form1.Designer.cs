
namespace Explorador_web
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.navegadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Inicio = new System.Windows.Forms.ToolStripMenuItem();
            this.haciaAtrásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.haciaAdelanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BotonIr = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.navegadorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1211, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // navegadorToolStripMenuItem
            // 
            this.navegadorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Inicio,
            this.haciaAtrásToolStripMenuItem,
            this.haciaAdelanteToolStripMenuItem});
            this.navegadorToolStripMenuItem.Name = "navegadorToolStripMenuItem";
            this.navegadorToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.navegadorToolStripMenuItem.Text = "Navegar";
            this.navegadorToolStripMenuItem.Click += new System.EventHandler(this.navegadorToolStripMenuItem_Click);
            // 
            // Inicio
            // 
            this.Inicio.Name = "Inicio";
            this.Inicio.Size = new System.Drawing.Size(192, 26);
            this.Inicio.Text = "Inicio";
            this.Inicio.Click += new System.EventHandler(this.inicioToolStripMenuItem_Click);
            // 
            // haciaAtrásToolStripMenuItem
            // 
            this.haciaAtrásToolStripMenuItem.Name = "haciaAtrásToolStripMenuItem";
            this.haciaAtrásToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.haciaAtrásToolStripMenuItem.Text = "Hacia atrás";
            // 
            // haciaAdelanteToolStripMenuItem
            // 
            this.haciaAdelanteToolStripMenuItem.Name = "haciaAdelanteToolStripMenuItem";
            this.haciaAdelanteToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.haciaAdelanteToolStripMenuItem.Text = "Hacia adelante";
            // 
            // BotonIr
            // 
            this.BotonIr.Location = new System.Drawing.Point(388, 32);
            this.BotonIr.Name = "BotonIr";
            this.BotonIr.Size = new System.Drawing.Size(75, 23);
            this.BotonIr.TabIndex = 1;
            this.BotonIr.Text = "Buscar";
            this.BotonIr.UseVisualStyleBackColor = true;
            this.BotonIr.Click += new System.EventHandler(this.BotonIr_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "",
            "https://www.youtube.com",
            "https://www.google.com/?hl=es",
            "http://www.google.com/search?q="});
            this.comboBox1.Location = new System.Drawing.Point(12, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(370, 24);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(0, 75);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1211, 452);
            this.webBrowser1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 528);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.BotonIr);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Explorador web";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem navegadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Inicio;
        private System.Windows.Forms.ToolStripMenuItem haciaAtrásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem haciaAdelanteToolStripMenuItem;
        private System.Windows.Forms.Button BotonIr;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

