namespace PIM.View.Finanças
{
    partial class Grid_Contas_A_Pagar
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
            this.dataGridViewResultadoContasAPagar = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPesquisar = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxCredito = new System.Windows.Forms.CheckBox();
            this.checkBoxDinheiro = new System.Windows.Forms.CheckBox();
            this.checkBoxBoleto = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultadoContasAPagar)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewResultadoContasAPagar
            // 
            this.dataGridViewResultadoContasAPagar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResultadoContasAPagar.Location = new System.Drawing.Point(12, 104);
            this.dataGridViewResultadoContasAPagar.Name = "dataGridViewResultadoContasAPagar";
            this.dataGridViewResultadoContasAPagar.Size = new System.Drawing.Size(895, 422);
            this.dataGridViewResultadoContasAPagar.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pesquisar";
            // 
            // textBoxPesquisar
            // 
            this.textBoxPesquisar.Location = new System.Drawing.Point(12, 78);
            this.textBoxPesquisar.Name = "textBoxPesquisar";
            this.textBoxPesquisar.Size = new System.Drawing.Size(819, 20);
            this.textBoxPesquisar.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.checkBoxCredito);
            this.panel1.Controls.Add(this.checkBoxDinheiro);
            this.panel1.Controls.Add(this.checkBoxBoleto);
            this.panel1.Controls.Add(this.btnPesquisar);
            this.panel1.Controls.Add(this.dataGridViewResultadoContasAPagar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxPesquisar);
            this.panel1.Location = new System.Drawing.Point(12, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(922, 538);
            this.panel1.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "Filtros";
            // 
            // checkBoxCredito
            // 
            this.checkBoxCredito.AutoSize = true;
            this.checkBoxCredito.Location = new System.Drawing.Point(362, 22);
            this.checkBoxCredito.Name = "checkBoxCredito";
            this.checkBoxCredito.Size = new System.Drawing.Size(59, 17);
            this.checkBoxCredito.TabIndex = 46;
            this.checkBoxCredito.Text = "Crédito";
            this.checkBoxCredito.UseVisualStyleBackColor = true;
            // 
            // checkBoxDinheiro
            // 
            this.checkBoxDinheiro.AutoSize = true;
            this.checkBoxDinheiro.Location = new System.Drawing.Point(489, 22);
            this.checkBoxDinheiro.Name = "checkBoxDinheiro";
            this.checkBoxDinheiro.Size = new System.Drawing.Size(63, 17);
            this.checkBoxDinheiro.TabIndex = 45;
            this.checkBoxDinheiro.Text = "dinheiro";
            this.checkBoxDinheiro.UseVisualStyleBackColor = true;
            // 
            // checkBoxBoleto
            // 
            this.checkBoxBoleto.AutoSize = true;
            this.checkBoxBoleto.Location = new System.Drawing.Point(427, 22);
            this.checkBoxBoleto.Name = "checkBoxBoleto";
            this.checkBoxBoleto.Size = new System.Drawing.Size(56, 17);
            this.checkBoxBoleto.TabIndex = 44;
            this.checkBoxBoleto.Text = "Boleto";
            this.checkBoxBoleto.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 31);
            this.label2.TabIndex = 51;
            this.label2.Text = "Contas a Pagar";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.Blue;
            this.btnPesquisar.ForeColor = System.Drawing.Color.White;
            this.btnPesquisar.Image = global::PIM.Properties.Resources._1212562;
            this.btnPesquisar.Location = new System.Drawing.Point(832, 72);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 30);
            this.btnPesquisar.TabIndex = 43;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            // 
            // Grid_Contas_A_Pagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 603);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Name = "Grid_Contas_A_Pagar";
            this.Text = "Grid_Contas_A_Pagar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultadoContasAPagar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewResultadoContasAPagar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPesquisar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxCredito;
        private System.Windows.Forms.CheckBox checkBoxDinheiro;
        private System.Windows.Forms.CheckBox checkBoxBoleto;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label2;
    }
}