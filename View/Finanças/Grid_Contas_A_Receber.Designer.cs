namespace PIM.View.Finanças
{
    partial class frmGridContas_A_Receber
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPesquisar = new System.Windows.Forms.TextBox();
            this.dataGridViewResultadoContasARecebr = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxNfe = new System.Windows.Forms.CheckBox();
            this.checkBoxDinheiro = new System.Windows.Forms.CheckBox();
            this.checkBoxBoleto = new System.Windows.Forms.CheckBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultadoContasARecebr)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PESQUISAR";
            // 
            // textBoxPesquisar
            // 
            this.textBoxPesquisar.Location = new System.Drawing.Point(12, 78);
            this.textBoxPesquisar.Name = "textBoxPesquisar";
            this.textBoxPesquisar.Size = new System.Drawing.Size(1201, 20);
            this.textBoxPesquisar.TabIndex = 1;
            // 
            // dataGridViewResultadoContasARecebr
            // 
            this.dataGridViewResultadoContasARecebr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResultadoContasARecebr.Location = new System.Drawing.Point(12, 104);
            this.dataGridViewResultadoContasARecebr.Name = "dataGridViewResultadoContasARecebr";
            this.dataGridViewResultadoContasARecebr.Size = new System.Drawing.Size(1303, 469);
            this.dataGridViewResultadoContasARecebr.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.checkBoxNfe);
            this.panel1.Controls.Add(this.checkBoxDinheiro);
            this.panel1.Controls.Add(this.checkBoxBoleto);
            this.panel1.Controls.Add(this.btnPesquisar);
            this.panel1.Controls.Add(this.dataGridViewResultadoContasARecebr);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxPesquisar);
            this.panel1.Location = new System.Drawing.Point(12, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1336, 685);
            this.panel1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 25);
            this.label3.TabIndex = 49;
            this.label3.Text = "Filtros";
            // 
            // checkBoxNfe
            // 
            this.checkBoxNfe.AutoSize = true;
            this.checkBoxNfe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxNfe.Location = new System.Drawing.Point(77, 7);
            this.checkBoxNfe.Name = "checkBoxNfe";
            this.checkBoxNfe.Size = new System.Drawing.Size(66, 17);
            this.checkBoxNfe.TabIndex = 46;
            this.checkBoxNfe.Text = "Crédito";
            this.checkBoxNfe.UseVisualStyleBackColor = true;
            // 
            // checkBoxDinheiro
            // 
            this.checkBoxDinheiro.AutoSize = true;
            this.checkBoxDinheiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDinheiro.Location = new System.Drawing.Point(204, 7);
            this.checkBoxDinheiro.Name = "checkBoxDinheiro";
            this.checkBoxDinheiro.Size = new System.Drawing.Size(71, 17);
            this.checkBoxDinheiro.TabIndex = 45;
            this.checkBoxDinheiro.Text = "dinheiro";
            this.checkBoxDinheiro.UseVisualStyleBackColor = true;
            // 
            // checkBoxBoleto
            // 
            this.checkBoxBoleto.AutoSize = true;
            this.checkBoxBoleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxBoleto.Location = new System.Drawing.Point(142, 7);
            this.checkBoxBoleto.Name = "checkBoxBoleto";
            this.checkBoxBoleto.Size = new System.Drawing.Size(62, 17);
            this.checkBoxBoleto.TabIndex = 44;
            this.checkBoxBoleto.Text = "Boleto";
            this.checkBoxBoleto.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.Blue;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.Color.White;
            this.btnPesquisar.Image = global::PIM.Properties.Resources._1212562;
            this.btnPesquisar.Location = new System.Drawing.Point(1219, 72);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(96, 30);
            this.btnPesquisar.TabIndex = 43;
            this.btnPesquisar.Text = "PESQUISAR";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 31);
            this.label2.TabIndex = 49;
            this.label2.Text = "Contas a Receber";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1080, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 50;
            this.button1.Text = "EXCLUIR";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(1187, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 30);
            this.button2.TabIndex = 51;
            this.button2.Text = "+ INCLUIR CONTA";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // frmGridContas_A_Receber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "frmGridContas_A_Receber";
            this.Text = "Grid_Contas_A_Receber";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultadoContasARecebr)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPesquisar;
        private System.Windows.Forms.DataGridView dataGridViewResultadoContasARecebr;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.CheckBox checkBoxDinheiro;
        private System.Windows.Forms.CheckBox checkBoxBoleto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxNfe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}