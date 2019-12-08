namespace PIM.View.Cadastros
{
    partial class frmConsulta_Veiculos
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
            this.dataGridViewResultadoConsulta = new System.Windows.Forms.DataGridView();
            this.checkBoxPlaca = new System.Windows.Forms.CheckBox();
            this.textBoxTextoParaProcura = new System.Windows.Forms.TextBox();
            this.checkBoxMarca = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.checkBoxModelo = new System.Windows.Forms.CheckBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxCor = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultadoConsulta)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewResultadoConsulta
            // 
            this.dataGridViewResultadoConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResultadoConsulta.Location = new System.Drawing.Point(17, 94);
            this.dataGridViewResultadoConsulta.Name = "dataGridViewResultadoConsulta";
            this.dataGridViewResultadoConsulta.Size = new System.Drawing.Size(759, 369);
            this.dataGridViewResultadoConsulta.TabIndex = 9;
            // 
            // checkBoxPlaca
            // 
            this.checkBoxPlaca.AutoSize = true;
            this.checkBoxPlaca.Location = new System.Drawing.Point(601, 15);
            this.checkBoxPlaca.Name = "checkBoxPlaca";
            this.checkBoxPlaca.Size = new System.Drawing.Size(53, 17);
            this.checkBoxPlaca.TabIndex = 16;
            this.checkBoxPlaca.Text = "Placa";
            this.checkBoxPlaca.UseVisualStyleBackColor = true;
            // 
            // textBoxTextoParaProcura
            // 
            this.textBoxTextoParaProcura.Location = new System.Drawing.Point(17, 68);
            this.textBoxTextoParaProcura.Name = "textBoxTextoParaProcura";
            this.textBoxTextoParaProcura.Size = new System.Drawing.Size(672, 20);
            this.textBoxTextoParaProcura.TabIndex = 10;
            // 
            // checkBoxMarca
            // 
            this.checkBoxMarca.AutoSize = true;
            this.checkBoxMarca.Location = new System.Drawing.Point(601, 38);
            this.checkBoxMarca.Name = "checkBoxMarca";
            this.checkBoxMarca.Size = new System.Drawing.Size(56, 17);
            this.checkBoxMarca.TabIndex = 15;
            this.checkBoxMarca.Text = "Marca";
            this.checkBoxMarca.UseVisualStyleBackColor = true;
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
            // checkBoxModelo
            // 
            this.checkBoxModelo.AutoSize = true;
            this.checkBoxModelo.Location = new System.Drawing.Point(696, 38);
            this.checkBoxModelo.Name = "checkBoxModelo";
            this.checkBoxModelo.Size = new System.Drawing.Size(61, 17);
            this.checkBoxModelo.TabIndex = 12;
            this.checkBoxModelo.Text = "Modelo";
            this.checkBoxModelo.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Red;
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(756, 14);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(52, 30);
            this.btnSair.TabIndex = 62;
            this.btnSair.Text = "X";
            this.btnSair.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.checkBoxCor);
            this.panel1.Controls.Add(this.dataGridViewResultadoConsulta);
            this.panel1.Controls.Add(this.checkBoxPlaca);
            this.panel1.Controls.Add(this.textBoxTextoParaProcura);
            this.panel1.Controls.Add(this.checkBoxMarca);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnPesquisar);
            this.panel1.Controls.Add(this.checkBoxModelo);
            this.panel1.Location = new System.Drawing.Point(12, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(796, 479);
            this.panel1.TabIndex = 61;
            // 
            // checkBoxCor
            // 
            this.checkBoxCor.AutoSize = true;
            this.checkBoxCor.Location = new System.Drawing.Point(696, 15);
            this.checkBoxCor.Name = "checkBoxCor";
            this.checkBoxCor.Size = new System.Drawing.Size(42, 17);
            this.checkBoxCor.TabIndex = 17;
            this.checkBoxCor.Text = "Cor";
            this.checkBoxCor.UseVisualStyleBackColor = true;
            // 
            // frmConsulta_Veiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 541);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.panel1);
            this.Name = "frmConsulta_Veiculos";
            this.Text = "Consulta_Veiculos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultadoConsulta)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewResultadoConsulta;
        private System.Windows.Forms.CheckBox checkBoxPlaca;
        private System.Windows.Forms.TextBox textBoxTextoParaProcura;
        private System.Windows.Forms.CheckBox checkBoxMarca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.CheckBox checkBoxModelo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBoxCor;
    }
}