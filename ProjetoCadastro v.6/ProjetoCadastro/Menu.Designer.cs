namespace ProjetoCadastro
{
    partial class Menu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarSexoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depósitoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesCadastradosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sexosCadastradosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agênciasCadastradasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contasCadastradasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.operaçõesToolStripMenuItem,
            this.relatóriosToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(14, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(434, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.contasToolStripMenuItem,
            this.cadastrarSexoToolStripMenuItem,
            this.contaToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 19);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clientesToolStripMenuItem.Text = "Cliente";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // contasToolStripMenuItem
            // 
            this.contasToolStripMenuItem.Name = "contasToolStripMenuItem";
            this.contasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.contasToolStripMenuItem.Text = "Agencia";
            this.contasToolStripMenuItem.Click += new System.EventHandler(this.contasToolStripMenuItem_Click);
            // 
            // cadastrarSexoToolStripMenuItem
            // 
            this.cadastrarSexoToolStripMenuItem.Name = "cadastrarSexoToolStripMenuItem";
            this.cadastrarSexoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadastrarSexoToolStripMenuItem.Text = "Sexo";
            this.cadastrarSexoToolStripMenuItem.Click += new System.EventHandler(this.cadastrarSexoToolStripMenuItem_Click);
            // 
            // contaToolStripMenuItem
            // 
            this.contaToolStripMenuItem.Name = "contaToolStripMenuItem";
            this.contaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.contaToolStripMenuItem.Text = "Conta";
            this.contaToolStripMenuItem.Click += new System.EventHandler(this.contaToolStripMenuItem_Click);
            // 
            // operaçõesToolStripMenuItem
            // 
            this.operaçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.depósitoToolStripMenuItem,
            this.saqueToolStripMenuItem});
            this.operaçõesToolStripMenuItem.Name = "operaçõesToolStripMenuItem";
            this.operaçõesToolStripMenuItem.Size = new System.Drawing.Size(75, 19);
            this.operaçõesToolStripMenuItem.Text = "Operações";
            // 
            // depósitoToolStripMenuItem
            // 
            this.depósitoToolStripMenuItem.Name = "depósitoToolStripMenuItem";
            this.depósitoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.depósitoToolStripMenuItem.Text = "Depósito";
            // 
            // saqueToolStripMenuItem
            // 
            this.saqueToolStripMenuItem.Name = "saqueToolStripMenuItem";
            this.saqueToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saqueToolStripMenuItem.Text = "Saque";
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesCadastradosToolStripMenuItem,
            this.sexosCadastradosToolStripMenuItem,
            this.agênciasCadastradasToolStripMenuItem,
            this.contasCadastradasToolStripMenuItem});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(71, 19);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // clientesCadastradosToolStripMenuItem
            // 
            this.clientesCadastradosToolStripMenuItem.Name = "clientesCadastradosToolStripMenuItem";
            this.clientesCadastradosToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.clientesCadastradosToolStripMenuItem.Text = "Clientes Cadastrados";
            this.clientesCadastradosToolStripMenuItem.Click += new System.EventHandler(this.clientesCadastradosToolStripMenuItem_Click);
            // 
            // sexosCadastradosToolStripMenuItem
            // 
            this.sexosCadastradosToolStripMenuItem.Name = "sexosCadastradosToolStripMenuItem";
            this.sexosCadastradosToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.sexosCadastradosToolStripMenuItem.Text = "Sexos Cadastrados";
            this.sexosCadastradosToolStripMenuItem.Click += new System.EventHandler(this.sexosCadastradosToolStripMenuItem_Click);
            // 
            // agênciasCadastradasToolStripMenuItem
            // 
            this.agênciasCadastradasToolStripMenuItem.Name = "agênciasCadastradasToolStripMenuItem";
            this.agênciasCadastradasToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.agênciasCadastradasToolStripMenuItem.Text = "Agências Cadastradas";
            this.agênciasCadastradasToolStripMenuItem.Click += new System.EventHandler(this.agênciasCadastradasToolStripMenuItem_Click);
            // 
            // contasCadastradasToolStripMenuItem
            // 
            this.contasCadastradasToolStripMenuItem.Name = "contasCadastradasToolStripMenuItem";
            this.contasCadastradasToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.contasCadastradasToolStripMenuItem.Text = "Contas Cadastradas";
            this.contasCadastradasToolStripMenuItem.Click += new System.EventHandler(this.contasCadastradasToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 19);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(434, 361);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu - Sistema de Cadastro";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operaçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depósitoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesCadastradosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarSexoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sexosCadastradosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agênciasCadastradasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contasCadastradasToolStripMenuItem;
    }
}

