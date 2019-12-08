namespace PIM.View.Entregas
{
    partial class frmPesquisa_Entregas
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
            this.dataGridViewResultadoConsultasEntregas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPesquisar = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxNfe = new System.Windows.Forms.CheckBox();
            this.checkBoxNumeroEntrega = new System.Windows.Forms.CheckBox();
            this.checkBoxEmpresa = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultadoConsultasEntregas)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewResultadoConsultasEntregas
            // 
            this.dataGridViewResultadoConsultasEntregas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResultadoConsultasEntregas.Location = new System.Drawing.Point(12, 104);
            this.dataGridViewResultadoConsultasEntregas.Name = "dataGridViewResultadoConsultasEntregas";
            this.dataGridViewResultadoConsultasEntregas.Size = new System.Drawing.Size(895, 422);
            this.dataGridViewResultadoConsultasEntregas.TabIndex = 2;
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
            this.panel1.Controls.Add(this.checkBoxNfe);
            this.panel1.Controls.Add(this.checkBoxNumeroEntrega);
            this.panel1.Controls.Add(this.checkBoxEmpresa);
            this.panel1.Controls.Add(this.btnPesquisar);
            this.panel1.Controls.Add(this.dataGridViewResultadoConsultasEntregas);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxPesquisar);
            this.panel1.Location = new System.Drawing.Point(12, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(922, 539);
            this.panel1.TabIndex = 50;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 31);
            this.label2.TabIndex = 51;
            this.label2.Text = "Entregas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(309, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 25);
            this.label3.TabIndex = 53;
            this.label3.Text = "Filtros";
            // 
            // checkBoxNfe
            // 
            this.checkBoxNfe.AutoSize = true;
            this.checkBoxNfe.Location = new System.Drawing.Point(379, 27);
            this.checkBoxNfe.Name = "checkBoxNfe";
            this.checkBoxNfe.Size = new System.Drawing.Size(46, 17);
            this.checkBoxNfe.TabIndex = 52;
            this.checkBoxNfe.Text = "NFe";
            this.checkBoxNfe.UseVisualStyleBackColor = true;
            // 
            // checkBoxNumeroEntrega
            // 
            this.checkBoxNumeroEntrega.AutoSize = true;
            this.checkBoxNumeroEntrega.Location = new System.Drawing.Point(517, 27);
            this.checkBoxNumeroEntrega.Name = "checkBoxNumeroEntrega";
            this.checkBoxNumeroEntrega.Size = new System.Drawing.Size(93, 17);
            this.checkBoxNumeroEntrega.TabIndex = 51;
            this.checkBoxNumeroEntrega.Text = "Nº de Entrega";
            this.checkBoxNumeroEntrega.UseVisualStyleBackColor = true;
            // 
            // checkBoxEmpresa
            // 
            this.checkBoxEmpresa.AutoSize = true;
            this.checkBoxEmpresa.Location = new System.Drawing.Point(444, 27);
            this.checkBoxEmpresa.Name = "checkBoxEmpresa";
            this.checkBoxEmpresa.Size = new System.Drawing.Size(67, 17);
            this.checkBoxEmpresa.TabIndex = 50;
            this.checkBoxEmpresa.Text = "Empresa";
            this.checkBoxEmpresa.UseVisualStyleBackColor = true;
            // 
            // frmPesquisa_Entregas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 603);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Name = "frmPesquisa_Entregas";
            this.Text = "Pesquisa Entregas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultadoConsultasEntregas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewResultadoConsultasEntregas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPesquisar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxNfe;
        private System.Windows.Forms.CheckBox checkBoxNumeroEntrega;
        private System.Windows.Forms.CheckBox checkBoxEmpresa;
    }
}