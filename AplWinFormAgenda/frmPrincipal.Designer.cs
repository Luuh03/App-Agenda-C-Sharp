namespace AplWinFormAgenda
{
    partial class frmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pessoasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compromissosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDeCompromissosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aplicativosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.microsoftWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.microsoftExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharProgramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslblMensagem = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslblData = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslblHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.tmrTempo = new System.Windows.Forms.Timer(this.components);
            this.prcExecutor = new System.Diagnostics.Process();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SkyBlue;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.aplicativosToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(716, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pessoasToolStripMenuItem,
            this.compromissosToolStripMenuItem,
            this.usuáriosToolStripMenuItem,
            this.tiposDeCompromissosToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(93, 27);
            this.cadastrosToolStripMenuItem.Text = "Registros";
            // 
            // pessoasToolStripMenuItem
            // 
            this.pessoasToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pessoasToolStripMenuItem.Name = "pessoasToolStripMenuItem";
            this.pessoasToolStripMenuItem.Size = new System.Drawing.Size(275, 28);
            this.pessoasToolStripMenuItem.Text = "Pessoas";
            this.pessoasToolStripMenuItem.Click += new System.EventHandler(this.pessoasToolStripMenuItem_Click);
            // 
            // compromissosToolStripMenuItem
            // 
            this.compromissosToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.compromissosToolStripMenuItem.Name = "compromissosToolStripMenuItem";
            this.compromissosToolStripMenuItem.Size = new System.Drawing.Size(275, 28);
            this.compromissosToolStripMenuItem.Text = "Compromissos";
            this.compromissosToolStripMenuItem.Click += new System.EventHandler(this.compromissosToolStripMenuItem_Click);
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(275, 28);
            this.usuáriosToolStripMenuItem.Text = "Usuários";
            this.usuáriosToolStripMenuItem.Click += new System.EventHandler(this.usuáriosToolStripMenuItem_Click);
            // 
            // tiposDeCompromissosToolStripMenuItem
            // 
            this.tiposDeCompromissosToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tiposDeCompromissosToolStripMenuItem.Name = "tiposDeCompromissosToolStripMenuItem";
            this.tiposDeCompromissosToolStripMenuItem.Size = new System.Drawing.Size(275, 28);
            this.tiposDeCompromissosToolStripMenuItem.Text = "Tipos de Compromissos";
            this.tiposDeCompromissosToolStripMenuItem.Click += new System.EventHandler(this.tiposDeCompromissosToolStripMenuItem_Click);
            // 
            // aplicativosToolStripMenuItem
            // 
            this.aplicativosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.microsoftWordToolStripMenuItem,
            this.microsoftExcelToolStripMenuItem,
            this.calculadoraToolStripMenuItem});
            this.aplicativosToolStripMenuItem.Name = "aplicativosToolStripMenuItem";
            this.aplicativosToolStripMenuItem.Size = new System.Drawing.Size(105, 27);
            this.aplicativosToolStripMenuItem.Text = "Aplicativos";
            // 
            // microsoftWordToolStripMenuItem
            // 
            this.microsoftWordToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.microsoftWordToolStripMenuItem.Name = "microsoftWordToolStripMenuItem";
            this.microsoftWordToolStripMenuItem.Size = new System.Drawing.Size(211, 28);
            this.microsoftWordToolStripMenuItem.Text = "Microsoft Word";
            this.microsoftWordToolStripMenuItem.Click += new System.EventHandler(this.microsoftWordToolStripMenuItem_Click);
            // 
            // microsoftExcelToolStripMenuItem
            // 
            this.microsoftExcelToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.microsoftExcelToolStripMenuItem.Name = "microsoftExcelToolStripMenuItem";
            this.microsoftExcelToolStripMenuItem.Size = new System.Drawing.Size(211, 28);
            this.microsoftExcelToolStripMenuItem.Text = "Microsoft Excel";
            this.microsoftExcelToolStripMenuItem.Click += new System.EventHandler(this.microsoftExcelToolStripMenuItem_Click);
            // 
            // calculadoraToolStripMenuItem
            // 
            this.calculadoraToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            this.calculadoraToolStripMenuItem.Size = new System.Drawing.Size(211, 28);
            this.calculadoraToolStripMenuItem.Text = "Calculadora";
            this.calculadoraToolStripMenuItem.Click += new System.EventHandler(this.calculadoraToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fecharProgramaToolStripMenuItem});
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(52, 27);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // fecharProgramaToolStripMenuItem
            // 
            this.fecharProgramaToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.fecharProgramaToolStripMenuItem.Name = "fecharProgramaToolStripMenuItem";
            this.fecharProgramaToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.fecharProgramaToolStripMenuItem.Text = "Fechar programa";
            this.fecharProgramaToolStripMenuItem.Click += new System.EventHandler(this.fecharProgramaToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslblMensagem,
            this.tsslblData,
            this.tsslblHora});
            this.statusStrip1.Location = new System.Drawing.Point(0, 424);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(716, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslblMensagem
            // 
            this.tsslblMensagem.AutoSize = false;
            this.tsslblMensagem.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tsslblMensagem.Name = "tsslblMensagem";
            this.tsslblMensagem.Size = new System.Drawing.Size(265, 20);
            // 
            // tsslblData
            // 
            this.tsslblData.AutoSize = false;
            this.tsslblData.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tsslblData.Name = "tsslblData";
            this.tsslblData.Size = new System.Drawing.Size(120, 20);
            // 
            // tsslblHora
            // 
            this.tsslblHora.AutoSize = false;
            this.tsslblHora.Name = "tsslblHora";
            this.tsslblHora.Size = new System.Drawing.Size(120, 20);
            // 
            // tmrTempo
            // 
            this.tmrTempo.Enabled = true;
            this.tmrTempo.Interval = 1;
            this.tmrTempo.Tick += new System.EventHandler(this.tmrTempo_Tick);
            // 
            // prcExecutor
            // 
            this.prcExecutor.StartInfo.Domain = "";
            this.prcExecutor.StartInfo.LoadUserProfile = false;
            this.prcExecutor.StartInfo.Password = null;
            this.prcExecutor.StartInfo.StandardErrorEncoding = null;
            this.prcExecutor.StartInfo.StandardOutputEncoding = null;
            this.prcExecutor.StartInfo.UserName = "";
            this.prcExecutor.SynchronizingObject = this;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(716, 450);
            this.ControlBox = false;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "Agenda Eletrônica";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pessoasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compromissosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aplicativosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem microsoftWordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem microsoftExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculadoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fecharProgramaToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslblMensagem;
        private System.Windows.Forms.ToolStripStatusLabel tsslblData;
        private System.Windows.Forms.ToolStripStatusLabel tsslblHora;
        private System.Windows.Forms.Timer tmrTempo;
        private System.Diagnostics.Process prcExecutor;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiposDeCompromissosToolStripMenuItem;
    }
}