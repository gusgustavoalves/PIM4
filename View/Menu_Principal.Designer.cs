namespace PIM
{
    partial class frmSistema
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.financeiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contasAPagarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contasAReceberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Coleta = new System.Windows.Forms.ToolStripMenuItem();
            this.entregasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.conexaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testeDeConexaoComBancoDeDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueDePeçasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Sair = new System.Windows.Forms.ToolStripMenuItem();
            this.Panel_Sistema = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.financeiroToolStripMenuItem,
            this.ToolStripMenuItem_Coleta,
            this.entregasToolStripMenuItem1,
            this.estoqueDePeçasToolStripMenuItem,
            this.conexaoToolStripMenuItem,
            this.ToolStripMenuItem_Sair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1045, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.funcionarioToolStripMenuItem,
            this.usuarioToolStripMenuItem,
            this.veiculosToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // funcionarioToolStripMenuItem
            // 
            this.funcionarioToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.funcionarioToolStripMenuItem.Name = "funcionarioToolStripMenuItem";
            this.funcionarioToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.funcionarioToolStripMenuItem.Text = "Funcionario";
            this.funcionarioToolStripMenuItem.Click += new System.EventHandler(this.funcionarioToolStripMenuItem_Click);
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            this.usuarioToolStripMenuItem.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // veiculosToolStripMenuItem
            // 
            this.veiculosToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.veiculosToolStripMenuItem.Name = "veiculosToolStripMenuItem";
            this.veiculosToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.veiculosToolStripMenuItem.Text = "Veiculos";
            this.veiculosToolStripMenuItem.Click += new System.EventHandler(this.veiculosToolStripMenuItem_Click);
            // 
            // financeiroToolStripMenuItem
            // 
            this.financeiroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contasAPagarToolStripMenuItem,
            this.contasAReceberToolStripMenuItem});
            this.financeiroToolStripMenuItem.Name = "financeiroToolStripMenuItem";
            this.financeiroToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.financeiroToolStripMenuItem.Text = "Financeiro";
            // 
            // contasAPagarToolStripMenuItem
            // 
            this.contasAPagarToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.contasAPagarToolStripMenuItem.Name = "contasAPagarToolStripMenuItem";
            this.contasAPagarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.contasAPagarToolStripMenuItem.Text = "Contas a Pagar";
            this.contasAPagarToolStripMenuItem.Click += new System.EventHandler(this.contasAPagarToolStripMenuItem_Click);
            // 
            // contasAReceberToolStripMenuItem
            // 
            this.contasAReceberToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.contasAReceberToolStripMenuItem.Name = "contasAReceberToolStripMenuItem";
            this.contasAReceberToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.contasAReceberToolStripMenuItem.Text = "Contas a Receber";
            this.contasAReceberToolStripMenuItem.Click += new System.EventHandler(this.contasAReceberToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem_Coleta
            // 
            this.ToolStripMenuItem_Coleta.Name = "ToolStripMenuItem_Coleta";
            this.ToolStripMenuItem_Coleta.Size = new System.Drawing.Size(66, 24);
            this.ToolStripMenuItem_Coleta.Text = "Coleta";
            this.ToolStripMenuItem_Coleta.Click += new System.EventHandler(this.ToolStripMenuItem_Coleta_Click);
            // 
            // entregasToolStripMenuItem1
            // 
            this.entregasToolStripMenuItem1.Name = "entregasToolStripMenuItem1";
            this.entregasToolStripMenuItem1.Size = new System.Drawing.Size(80, 24);
            this.entregasToolStripMenuItem1.Text = "Entregas";
            this.entregasToolStripMenuItem1.Click += new System.EventHandler(this.entregasToolStripMenuItem1_Click);
            // 
            // conexaoToolStripMenuItem
            // 
            this.conexaoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testeDeConexaoComBancoDeDadosToolStripMenuItem});
            this.conexaoToolStripMenuItem.Name = "conexaoToolStripMenuItem";
            this.conexaoToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.conexaoToolStripMenuItem.Text = "Conexao";
            this.conexaoToolStripMenuItem.Click += new System.EventHandler(this.conexaoToolStripMenuItem_Click);
            // 
            // testeDeConexaoComBancoDeDadosToolStripMenuItem
            // 
            this.testeDeConexaoComBancoDeDadosToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.testeDeConexaoComBancoDeDadosToolStripMenuItem.Name = "testeDeConexaoComBancoDeDadosToolStripMenuItem";
            this.testeDeConexaoComBancoDeDadosToolStripMenuItem.Size = new System.Drawing.Size(353, 26);
            this.testeDeConexaoComBancoDeDadosToolStripMenuItem.Text = "Teste de conexao com Banco de Dados";
            this.testeDeConexaoComBancoDeDadosToolStripMenuItem.Click += new System.EventHandler(this.testeDeConexaoComBancoDeDadosToolStripMenuItem_Click);
            // 
            // estoqueDePeçasToolStripMenuItem
            // 
            this.estoqueDePeçasToolStripMenuItem.Name = "estoqueDePeçasToolStripMenuItem";
            this.estoqueDePeçasToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.estoqueDePeçasToolStripMenuItem.Text = "Estoque de Peças";
            this.estoqueDePeçasToolStripMenuItem.Click += new System.EventHandler(this.estoqueDePeçasToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem_Sair
            // 
            this.ToolStripMenuItem_Sair.Name = "ToolStripMenuItem_Sair";
            this.ToolStripMenuItem_Sair.Size = new System.Drawing.Size(48, 24);
            this.ToolStripMenuItem_Sair.Text = "Sair";
            this.ToolStripMenuItem_Sair.Click += new System.EventHandler(this.ToolStripMenuItem_Sair_Click);
            // 
            // Panel_Sistema
            // 
            this.Panel_Sistema.AccessibleRole = System.Windows.Forms.AccessibleRole.Document;
            this.Panel_Sistema.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_Sistema.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Panel_Sistema.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel_Sistema.Location = new System.Drawing.Point(0, 30);
            this.Panel_Sistema.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel_Sistema.Name = "Panel_Sistema";
            this.Panel_Sistema.Size = new System.Drawing.Size(1044, 660);
            this.Panel_Sistema.TabIndex = 1;
            this.Panel_Sistema.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // frmSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1045, 690);
            this.Controls.Add(this.Panel_Sistema);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(794, 478);
            this.Name = "frmSistema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Sistema_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.Panel Panel_Sistema;
        private System.Windows.Forms.ToolStripMenuItem conexaoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testeDeConexaoComBancoDeDadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Coleta;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Sair;
        private System.Windows.Forms.ToolStripMenuItem veiculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entregasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem funcionarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem financeiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contasAPagarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contasAReceberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estoqueDePeçasToolStripMenuItem;
    }
}

