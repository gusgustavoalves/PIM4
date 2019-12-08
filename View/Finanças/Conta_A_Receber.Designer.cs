namespace PIM.View.Finanças
{
    partial class frmConta_A_Receber
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
            this.btnSair = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxCliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.textBoxFormaPagamento = new System.Windows.Forms.DomainUpDown();
            this.textBoxDataEmissao = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.textBoxObservacao = new System.Windows.Forms.RichTextBox();
            this.textBoxOcorrencia = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxVendedor = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxPortador = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxCategoria = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxNumeroDocumento = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxVencimento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxVencimentoOriginal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Red;
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(685, 26);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(52, 30);
            this.btnSair.TabIndex = 41;
            this.btnSair.Text = "X";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.textBoxCliente);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnPesquisar);
            this.panel1.Controls.Add(this.textBoxFormaPagamento);
            this.panel1.Controls.Add(this.textBoxDataEmissao);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.btnExcluir);
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.textBoxObservacao);
            this.panel1.Controls.Add(this.textBoxOcorrencia);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.textBoxVendedor);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.textBoxPortador);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.textBoxCategoria);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.textBoxNumeroDocumento);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.textBoxValor);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBoxVencimento);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxVencimentoOriginal);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 481);
            this.panel1.TabIndex = 40;
            // 
            // textBoxCliente
            // 
            this.textBoxCliente.Location = new System.Drawing.Point(12, 27);
            this.textBoxCliente.Name = "textBoxCliente";
            this.textBoxCliente.Size = new System.Drawing.Size(579, 20);
            this.textBoxCliente.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Cliente";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.Blue;
            this.btnPesquisar.ForeColor = System.Drawing.Color.White;
            this.btnPesquisar.Location = new System.Drawing.Point(493, 450);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 30);
            this.btnPesquisar.TabIndex = 42;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            // 
            // textBoxFormaPagamento
            // 
            this.textBoxFormaPagamento.Location = new System.Drawing.Point(12, 339);
            this.textBoxFormaPagamento.Name = "textBoxFormaPagamento";
            this.textBoxFormaPagamento.Size = new System.Drawing.Size(120, 20);
            this.textBoxFormaPagamento.TabIndex = 41;
            this.textBoxFormaPagamento.Text = "domainUpDown1";
            // 
            // textBoxDataEmissao
            // 
            this.textBoxDataEmissao.Location = new System.Drawing.Point(403, 88);
            this.textBoxDataEmissao.Name = "textBoxDataEmissao";
            this.textBoxDataEmissao.Size = new System.Drawing.Size(113, 20);
            this.textBoxDataEmissao.TabIndex = 40;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(400, 72);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(87, 13);
            this.label19.TabIndex = 39;
            this.label19.Text = "Data de Emissão";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(599, 10);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(123, 13);
            this.label18.TabIndex = 38;
            this.label18.Text = "( * ) Campos Obrigatórios";
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Red;
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(12, 450);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 30);
            this.btnExcluir.TabIndex = 37;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Green;
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(632, 450);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 30);
            this.btnSalvar.TabIndex = 36;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(11, 174);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 13);
            this.label17.TabIndex = 35;
            this.label17.Text = "Observação";
            // 
            // textBoxObservacao
            // 
            this.textBoxObservacao.Location = new System.Drawing.Point(12, 190);
            this.textBoxObservacao.Name = "textBoxObservacao";
            this.textBoxObservacao.Size = new System.Drawing.Size(504, 99);
            this.textBoxObservacao.TabIndex = 30;
            this.textBoxObservacao.Text = "";
            // 
            // textBoxOcorrencia
            // 
            this.textBoxOcorrencia.Location = new System.Drawing.Point(294, 389);
            this.textBoxOcorrencia.Name = "textBoxOcorrencia";
            this.textBoxOcorrencia.Size = new System.Drawing.Size(120, 20);
            this.textBoxOcorrencia.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(291, 373);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Ocorrência";
            // 
            // textBoxVendedor
            // 
            this.textBoxVendedor.Location = new System.Drawing.Point(12, 389);
            this.textBoxVendedor.Name = "textBoxVendedor";
            this.textBoxVendedor.Size = new System.Drawing.Size(262, 20);
            this.textBoxVendedor.TabIndex = 23;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 373);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 13);
            this.label15.TabIndex = 22;
            this.label15.Text = "Vendedor";
            // 
            // textBoxPortador
            // 
            this.textBoxPortador.Location = new System.Drawing.Point(154, 339);
            this.textBoxPortador.Name = "textBoxPortador";
            this.textBoxPortador.Size = new System.Drawing.Size(120, 20);
            this.textBoxPortador.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(151, 323);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Portador";
            // 
            // textBoxCategoria
            // 
            this.textBoxCategoria.Location = new System.Drawing.Point(294, 339);
            this.textBoxCategoria.Name = "textBoxCategoria";
            this.textBoxCategoria.Size = new System.Drawing.Size(222, 20);
            this.textBoxCategoria.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(291, 323);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Categoria";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 323);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "Forma de Pagamento";
            // 
            // textBoxNumeroDocumento
            // 
            this.textBoxNumeroDocumento.Location = new System.Drawing.Point(12, 136);
            this.textBoxNumeroDocumento.Name = "textBoxNumeroDocumento";
            this.textBoxNumeroDocumento.Size = new System.Drawing.Size(120, 20);
            this.textBoxNumeroDocumento.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Nº do Documento";
            // 
            // textBoxValor
            // 
            this.textBoxValor.Location = new System.Drawing.Point(297, 88);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(88, 20);
            this.textBoxValor.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(294, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Valor";
            // 
            // textBoxVencimento
            // 
            this.textBoxVencimento.Location = new System.Drawing.Point(154, 88);
            this.textBoxVencimento.Name = "textBoxVencimento";
            this.textBoxVencimento.Size = new System.Drawing.Size(125, 20);
            this.textBoxVencimento.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vencimento *";
            // 
            // textBoxVencimentoOriginal
            // 
            this.textBoxVencimentoOriginal.Location = new System.Drawing.Point(12, 88);
            this.textBoxVencimentoOriginal.Name = "textBoxVencimentoOriginal";
            this.textBoxVencimentoOriginal.Size = new System.Drawing.Size(120, 20);
            this.textBoxVencimentoOriginal.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Venc. Original";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 31);
            this.label2.TabIndex = 39;
            this.label2.Text = "Contas a Receber";
            // 
            // frmConta_A_Receber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 566);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConta_A_Receber";
            this.Text = "Contas a Receber";
            this.Load += new System.EventHandler(this.frmConta_A_Receber_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.RichTextBox textBoxObservacao;
        private System.Windows.Forms.TextBox textBoxOcorrencia;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxVendedor;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxPortador;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxNumeroDocumento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxValor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxVencimento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxVencimentoOriginal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDataEmissao;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBoxCategoria;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DomainUpDown textBoxFormaPagamento;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox textBoxCliente;
        private System.Windows.Forms.Label label5;
    }
}