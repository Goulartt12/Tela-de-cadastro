namespace sla
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label2 = new Label();
            btnMin = new Button();
            btnClose = new Button();
            lblEmail = new Label();
            txtemail = new TextBox();
            label1 = new Label();
            txtsenha = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btnCadastro = new Button();
            checkSenha = new CheckBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnMin);
            panel1.Controls.Add(btnClose);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(586, 39);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(12, 5);
            label2.Name = "label2";
            label2.Size = new Size(99, 30);
            label2.TabIndex = 2;
            label2.Text = "Cadastro";
            // 
            // btnMin
            // 
            btnMin.Location = new Point(409, 12);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(34, 23);
            btnMin.TabIndex = 1;
            btnMin.Text = "-";
            btnMin.UseVisualStyleBackColor = true;
            btnMin.Click += btnMin_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(449, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(34, 23);
            btnClose.TabIndex = 0;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += button1_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.Location = new Point(30, 72);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(51, 21);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "Email:";
            lblEmail.Click += lblEmail_Click;
            // 
            // txtemail
            // 
            txtemail.Location = new Point(87, 74);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(243, 23);
            txtemail.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(25, 123);
            label1.Name = "label1";
            label1.Size = new Size(56, 21);
            label1.TabIndex = 3;
            label1.Text = "Senha:";
            // 
            // txtsenha
            // 
            txtsenha.Location = new Point(87, 123);
            txtsenha.Name = "txtsenha";
            txtsenha.Size = new Size(243, 23);
            txtsenha.TabIndex = 4;
            txtsenha.UseSystemPasswordChar = true;
            txtsenha.TextChanged += txtsenha_TextChanged;
            // 
            // btnCadastro
            // 
            btnCadastro.FlatStyle = FlatStyle.Flat;
            btnCadastro.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCadastro.Location = new Point(87, 169);
            btnCadastro.Name = "btnCadastro";
            btnCadastro.Size = new Size(110, 31);
            btnCadastro.TabIndex = 7;
            btnCadastro.Text = "Cadastrar";
            btnCadastro.TextAlign = ContentAlignment.MiddleLeft;
            btnCadastro.UseVisualStyleBackColor = true;
            btnCadastro.Click += btnCadastro_Click;
            // 
            // checkSenha
            // 
            checkSenha.AutoSize = true;
            checkSenha.Location = new Point(336, 127);
            checkSenha.Name = "checkSenha";
            checkSenha.Size = new Size(101, 19);
            checkSenha.TabIndex = 9;
            checkSenha.Text = "Mostrar senha";
            checkSenha.UseVisualStyleBackColor = true;
            checkSenha.CheckedChanged += checkSenha_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 244);
            Controls.Add(checkSenha);
            Controls.Add(btnCadastro);
            Controls.Add(txtsenha);
            Controls.Add(label1);
            Controls.Add(txtemail);
            Controls.Add(lblEmail);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnClose;
        private Button btnMin;
        private Label lblEmail;
        private TextBox txtemail;
        private Label label1;
        private TextBox txtsenha;
        private Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnCadastro;
        private CheckBox checkSenha;
    }
}