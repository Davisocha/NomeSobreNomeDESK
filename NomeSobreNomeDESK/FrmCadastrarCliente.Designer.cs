namespace DaviAraujoSochaDesk
{
    partial class FrmCadastrarCliente
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
            txtNome = new TextBox();
            txtEmail = new TextBox();
            txttelefone = new TextBox();
            txtEndereco = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnCadastrarCliente = new Button();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(14, 24);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(181, 23);
            txtNome.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(227, 24);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(194, 23);
            txtEmail.TabIndex = 1;
            // 
            // txttelefone
            // 
            txttelefone.Location = new Point(14, 74);
            txttelefone.Name = "txttelefone";
            txttelefone.Size = new Size(147, 23);
            txttelefone.TabIndex = 2;
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(190, 74);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(231, 23);
            txtEndereco.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 6);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 5;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(227, 6);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 5;
            label2.Text = "E-mail";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 56);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 5;
            label3.Text = "Telefone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(190, 56);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 5;
            label4.Text = "Endereço";
            // 
            // btnCadastrarCliente
            // 
            btnCadastrarCliente.Location = new Point(14, 121);
            btnCadastrarCliente.Name = "btnCadastrarCliente";
            btnCadastrarCliente.Size = new Size(113, 23);
            btnCadastrarCliente.TabIndex = 6;
            btnCadastrarCliente.Text = "Cadastrar Cliente";
            btnCadastrarCliente.UseVisualStyleBackColor = true;
            btnCadastrarCliente.Click += btnCadastrarCliente_Click;
            // 
            // FrmCadastrarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(501, 176);
            Controls.Add(btnCadastrarCliente);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtEndereco);
            Controls.Add(txttelefone);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Name = "FrmCadastrarCliente";
            Text = "FrmCadastarCliente";
            Load += FrmCadastrarCliente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtEmail;
        private TextBox txttelefone;
        private TextBox txtEndereco;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnCadastrarCliente;
    }
}