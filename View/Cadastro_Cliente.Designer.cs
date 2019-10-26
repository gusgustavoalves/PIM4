namespace Trabalho21_10_2019_1ponto.View
{
    partial class Cadastro_Cliente
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_Cadastrar = new System.Windows.Forms.Button();
            this.button_Sair = new System.Windows.Forms.Button();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.txt_End = new System.Windows.Forms.TextBox();
            this.txt_CPF = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CPF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Endereço";
            // 
            // button_Cadastrar
            // 
            this.button_Cadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_Cadastrar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_Cadastrar.Location = new System.Drawing.Point(21, 268);
            this.button_Cadastrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Cadastrar.Name = "button_Cadastrar";
            this.button_Cadastrar.Size = new System.Drawing.Size(73, 24);
            this.button_Cadastrar.TabIndex = 3;
            this.button_Cadastrar.Text = "Cadastrar";
            this.button_Cadastrar.UseVisualStyleBackColor = false;
            this.button_Cadastrar.Click += new System.EventHandler(this.button_Cadastrar_Click);
            // 
            // button_Sair
            // 
            this.button_Sair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_Sair.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_Sair.Location = new System.Drawing.Point(112, 268);
            this.button_Sair.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Sair.Name = "button_Sair";
            this.button_Sair.Size = new System.Drawing.Size(73, 24);
            this.button_Sair.TabIndex = 4;
            this.button_Sair.Text = "Sair";
            this.button_Sair.UseVisualStyleBackColor = false;
            this.button_Sair.Click += new System.EventHandler(this.button_Sair_Click);
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(87, 14);
            this.txt_Nome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(259, 20);
            this.txt_Nome.TabIndex = 5;
            // 
            // txt_End
            // 
            this.txt_End.Location = new System.Drawing.Point(87, 116);
            this.txt_End.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_End.Name = "txt_End";
            this.txt_End.Size = new System.Drawing.Size(259, 20);
            this.txt_End.TabIndex = 7;
            // 
            // txt_CPF
            // 
            this.txt_CPF.BackColor = System.Drawing.Color.White;
            this.txt_CPF.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txt_CPF.Location = new System.Drawing.Point(87, 64);
            this.txt_CPF.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_CPF.Mask = "000.000.000-00";
            this.txt_CPF.Name = "txt_CPF";
            this.txt_CPF.Size = new System.Drawing.Size(105, 20);
            this.txt_CPF.TabIndex = 6;
            this.txt_CPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_CPF.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txt_CPF_MaskInputRejected_1);
            // 
            // Cadastro_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.txt_CPF);
            this.Controls.Add(this.txt_End);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.button_Sair);
            this.Controls.Add(this.button_Cadastrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Cadastro_Cliente";
            this.Text = "Cadastro De Cliente";
            this.Load += new System.EventHandler(this.Form_Cadastro_Cliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_Cadastrar;
        private System.Windows.Forms.Button button_Sair;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.TextBox txt_End;
        private System.Windows.Forms.MaskedTextBox txt_CPF;
    }
}