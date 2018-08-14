namespace wfaLuriaBHClient
{
    partial class FrmPrincipal
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
            this.funcionárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bancoDeHorasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lançamentoDeBancoDeHorasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.envioDeEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funcionárioToolStripMenuItem,
            this.bancoDeHorasToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(945, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // funcionárioToolStripMenuItem
            // 
            this.funcionárioToolStripMenuItem.Name = "funcionárioToolStripMenuItem";
            this.funcionárioToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.funcionárioToolStripMenuItem.Text = "Funcionário";
            this.funcionárioToolStripMenuItem.Click += new System.EventHandler(this.funcionárioToolStripMenuItem_Click);
            // 
            // bancoDeHorasToolStripMenuItem
            // 
            this.bancoDeHorasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lançamentoDeBancoDeHorasToolStripMenuItem,
            this.envioDeEmailToolStripMenuItem});
            this.bancoDeHorasToolStripMenuItem.Name = "bancoDeHorasToolStripMenuItem";
            this.bancoDeHorasToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.bancoDeHorasToolStripMenuItem.Text = "Banco de horas";
            // 
            // lançamentoDeBancoDeHorasToolStripMenuItem
            // 
            this.lançamentoDeBancoDeHorasToolStripMenuItem.Name = "lançamentoDeBancoDeHorasToolStripMenuItem";
            this.lançamentoDeBancoDeHorasToolStripMenuItem.Size = new System.Drawing.Size(292, 26);
            this.lançamentoDeBancoDeHorasToolStripMenuItem.Text = "Lançamento de Banco de horas";
            // 
            // envioDeEmailToolStripMenuItem
            // 
            this.envioDeEmailToolStripMenuItem.Name = "envioDeEmailToolStripMenuItem";
            this.envioDeEmailToolStripMenuItem.Size = new System.Drawing.Size(292, 26);
            this.envioDeEmailToolStripMenuItem.Text = "Envio de e-mail";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 439);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NotifierBH";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem funcionárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bancoDeHorasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lançamentoDeBancoDeHorasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem envioDeEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}

