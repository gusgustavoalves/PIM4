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
            this.dataGridViewResultadoConsulta = new System.Windows.Forms.DataGridView();
            this.textBoxTextoParaProcura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultadoConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewResultadoConsulta
            // 
            this.dataGridViewResultadoConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResultadoConsulta.Location = new System.Drawing.Point(12, 55);
            this.dataGridViewResultadoConsulta.Name = "dataGridViewResultadoConsulta";
            this.dataGridViewResultadoConsulta.Size = new System.Drawing.Size(759, 383);
            this.dataGridViewResultadoConsulta.TabIndex = 0;
            // 
            // textBoxTextoParaProcura
            // 
            this.textBoxTextoParaProcura.Location = new System.Drawing.Point(12, 29);
            this.textBoxTextoParaProcura.Name = "textBoxTextoParaProcura";
            this.textBoxTextoParaProcura.Size = new System.Drawing.Size(759, 20);
            this.textBoxTextoParaProcura.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Texto para procura";
            // 
            // frmPesquisa_cliente_Fornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTextoParaProcura);
            this.Controls.Add(this.dataGridViewResultadoConsulta);
            this.Name = "frmPesquisa_cliente_Fornecedores";
            this.Text = "Pesquisa_cliente_Fornecedores";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultadoConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewResultadoConsulta;
        private System.Windows.Forms.TextBox textBoxTextoParaProcura;
        private System.Windows.Forms.Label label1;
    }
}