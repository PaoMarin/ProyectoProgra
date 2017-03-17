namespace Tiempos.View
{
    partial class frmPrincipal
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
            this.apuestaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apuestaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.jugadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sorteoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ganadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.apuestaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(632, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // apuestaToolStripMenuItem
            // 
            this.apuestaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.apuestaToolStripMenuItem1,
            this.jugadoresToolStripMenuItem,
            this.consultaToolStripMenuItem,
            this.sorteoToolStripMenuItem,
            this.ganadoresToolStripMenuItem});
            this.apuestaToolStripMenuItem.Name = "apuestaToolStripMenuItem";
            this.apuestaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.apuestaToolStripMenuItem.Text = "Menu";
            this.apuestaToolStripMenuItem.Click += new System.EventHandler(this.apuestaToolStripMenuItem_Click);
            // 
            // apuestaToolStripMenuItem1
            // 
            this.apuestaToolStripMenuItem1.Name = "apuestaToolStripMenuItem1";
            this.apuestaToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.apuestaToolStripMenuItem1.Text = "Apuesta";
            this.apuestaToolStripMenuItem1.Click += new System.EventHandler(this.apuestaToolStripMenuItem1_Click);
            // 
            // jugadoresToolStripMenuItem
            // 
            this.jugadoresToolStripMenuItem.Name = "jugadoresToolStripMenuItem";
            this.jugadoresToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.jugadoresToolStripMenuItem.Text = "Jugadores";
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.consultaToolStripMenuItem.Text = "Consulta Caja";
            // 
            // sorteoToolStripMenuItem
            // 
            this.sorteoToolStripMenuItem.Name = "sorteoToolStripMenuItem";
            this.sorteoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sorteoToolStripMenuItem.Text = "Sorteo";
            // 
            // ganadoresToolStripMenuItem
            // 
            this.ganadoresToolStripMenuItem.Name = "ganadoresToolStripMenuItem";
            this.ganadoresToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ganadoresToolStripMenuItem.Text = "Ganadores";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.Name = "frmPrincipal";
            this.Text = "MDIParent1";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem apuestaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apuestaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem jugadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sorteoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ganadoresToolStripMenuItem;
    }
}



