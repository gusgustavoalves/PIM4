namespace PIM.View.Cadastros
{
    partial class frmPesquisa_cliente_Fornecedores
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
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.checkBoxFantasia = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTextoParaProcura = new System.Windows.Forms.TextBox();
            this.dataGridViewResultadoConsulta = new System.Windows.Forms.DataGridView();
            this.checkBoxCodigo = new System.Windows.Forms.CheckBox();
            this.checkBoxRazaoSocial = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultadoConsulta)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.Blue;
            this.btnPesquisar.ForeColor = System.Drawing.Color.White;
            this.btnPesquisar.Location = new System.Drawing.Point(696, 67);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 21);
            this.btnPesquisar.TabIndex = 14;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            // 
            // checkBoxFantasia
            // 
            this.checkBoxFantasia.AutoSize = true;
            this.checkBoxFantasia.Location = new System.Drawing.Point(696, 38);
            this.checkBoxFantasia.Name = "checkBoxFantasia";
            this.checkBoxFantasia.Size = new System.Drawing.Size(66, 17);
            this.checkBoxFantasia.TabIndex = 12;
            this.checkBoxFantasia.Text = "Fantasia";
            this.checkBoxFantasia.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Texto para procura";
            // 
            // textBoxTextoParaProcura
            // 
            this.textBoxTextoParaProcura.Location = new System.Drawing.Point(17, 68);
            this.textBoxTextoParaProcura.Name = "textBoxTextoParaProcura";
            this.textBoxTextoParaProcura.Size = new System.Drawing.Size(672, 20);
            this.textBoxTextoParaProcura.TabIndex = 10;
            // 
            // dataGridViewResultadoConsulta
            // 
            this.dataGridViewResultadoConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResultadoConsulta.Location = new System.Drawing.Point(17, 94);
            this.dataGridViewResultadoConsulta.Name = "dataGridViewResultadoConsulta";
            this.dataGridViewResultadoConsulta.Size = new System.Drawing.Size(759, 369);
            this.dataGridViewResultadoConsulta.TabIndex = 9;
            // 
            // checkBoxCodigo
            // 
            this.checkBoxCodigo.AutoSize = true;
            this.checkBoxCodigo.Location = new System.Drawing.Point(601, 15);
            this.checkBoxCodigo.Name = "checkBoxCodigo";
            this.checkBoxCodigo.Size = new System.Drawing.Size(59, 17);
            this.checkBoxCodigo.TabIndex = 16;
            this.checkBoxCodigo.Text = "Código";
            this.checkBoxCodigo.UseVisualStyleBackColor = true;
            // 
            // checkBoxRazaoSocial
            // 
            this.checkBoxRazaoSocial.AutoSize = true;
            this.checkBoxRazaoSocial.Location = new System.Drawing.Point(601, 38);
            this.checkBoxRazaoSocial.Name = "checkBoxRazaoSocial";
            this.checkBoxRazaoSocial.Size = new System.Drawing.Size(89, 17);
            this.checkBoxRazaoSocial.TabIndex = 15;
            this.checkBoxRazaoSocial.Text = "Razão Social";
            this.checkBoxRazaoSocial.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.dataGridViewResultadoConsulta);
            this.panel1.Controls.Add(this.checkBoxCodigo);
            this.panel1.Controls.Add(this.textBoxTextoParaProcura);
            this.panel1.Controls.Add(this.checkBoxRazaoSocial);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnPesquisar);
            this.panel1.Controls.Add(this.checkBoxFantasia);
            this.panel1.Location = new System.Drawing.Point(12, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(796, 479);
            this.panel1.TabIndex = 18;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Red;
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(756, 21);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(52, 30);
            this.btnSair.TabIndex = 60;
            this.btnSair.Text = "X";
            this.btnSair.UseVisualStyleBackColor = false;
            // 
            // frmPesquisa_cliente_Fornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 547);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.panel1);
            this.Name = "frmPesquisa_cliente_Fornecedores";
            this.Text = "Pesquisa_cliente_Fornecedores";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultadoConsulta)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.CheckBox checkBoxFantasia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTextoParaProcura;
        private System.Windows.Forms.DataGridView dataGridViewResultadoConsulta;
        private System.Windows.Forms.CheckBox checkBoxCodigo;
        private System.Windows.Forms.CheckBox checkBoxRazaoSocial;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSair;
    }
}