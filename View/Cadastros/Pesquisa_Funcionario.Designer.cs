namespace PIM.View.Cadastros
{
    partial class frmPesquisa_Funcionario
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.checkBox2Codigo = new System.Windows.Forms.CheckBox();
            this.checkBox1Nome = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTextoParaProcura = new System.Windows.Forms.TextBox();
            this.dataGridViewResultadoConsulta = new System.Windows.Forms.DataGridView();
            this.btnSair = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultadoConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.btnPesquisar);
            this.panel1.Controls.Add(this.checkBox2Codigo);
            this.panel1.Controls.Add(this.checkBox1Nome);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxTextoParaProcura);
            this.panel1.Controls.Add(this.dataGridViewResultadoConsulta);
            this.panel1.Location = new System.Drawing.Point(16, 59);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1035, 524);
            this.panel1.TabIndex = 0;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.Blue;
            this.btnPesquisar.ForeColor = System.Drawing.Color.White;
            this.btnPesquisar.Location = new System.Drawing.Point(917, 82);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(100, 26);
            this.btnPesquisar.TabIndex = 14;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            // 
            // checkBox2Codigo
            // 
            this.checkBox2Codigo.AutoSize = true;
            this.checkBox2Codigo.Location = new System.Drawing.Point(917, 18);
            this.checkBox2Codigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox2Codigo.Name = "checkBox2Codigo";
            this.checkBox2Codigo.Size = new System.Drawing.Size(74, 21);
            this.checkBox2Codigo.TabIndex = 13;
            this.checkBox2Codigo.Text = "Código";
            this.checkBox2Codigo.UseVisualStyleBackColor = true;
            // 
            // checkBox1Nome
            // 
            this.checkBox1Nome.AutoSize = true;
            this.checkBox1Nome.Location = new System.Drawing.Point(917, 47);
            this.checkBox1Nome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox1Nome.Name = "checkBox1Nome";
            this.checkBox1Nome.Size = new System.Drawing.Size(67, 21);
            this.checkBox1Nome.TabIndex = 12;
            this.checkBox1Nome.Text = "Nome";
            this.checkBox1Nome.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Texto para procura";
            // 
            // textBoxTextoParaProcura
            // 
            this.textBoxTextoParaProcura.Location = new System.Drawing.Point(12, 84);
            this.textBoxTextoParaProcura.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxTextoParaProcura.Name = "textBoxTextoParaProcura";
            this.textBoxTextoParaProcura.Size = new System.Drawing.Size(895, 22);
            this.textBoxTextoParaProcura.TabIndex = 10;
            // 
            // dataGridViewResultadoConsulta
            // 
            this.dataGridViewResultadoConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResultadoConsulta.Location = new System.Drawing.Point(12, 116);
            this.dataGridViewResultadoConsulta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewResultadoConsulta.Name = "dataGridViewResultadoConsulta";
            this.dataGridViewResultadoConsulta.RowHeadersWidth = 51;
            this.dataGridViewResultadoConsulta.Size = new System.Drawing.Size(1012, 390);
            this.dataGridViewResultadoConsulta.TabIndex = 9;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Red;
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(981, 15);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(69, 37);
            this.btnSair.TabIndex = 60;
            this.btnSair.Text = "X";
            this.btnSair.UseVisualStyleBackColor = false;
            // 
            // frmPesquisa_Funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 597);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPesquisa_Funcionario";
            this.Text = "Pesquisa_Funcionario";
            this.Load += new System.EventHandler(this.frmPesquisa_Funcionario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultadoConsulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.CheckBox checkBox2Codigo;
        private System.Windows.Forms.CheckBox checkBox1Nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTextoParaProcura;
        private System.Windows.Forms.DataGridView dataGridViewResultadoConsulta;
        private System.Windows.Forms.Button btnSair;
    }
}