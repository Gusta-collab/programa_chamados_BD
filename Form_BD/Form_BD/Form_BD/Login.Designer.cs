namespace Form_BD
{
    partial class Login
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
            txtSenha = new TextBox();
            txtUser = new TextBox();
            label1 = new Label();
            label2 = new Label();
            BTNlogin = new Button();
            SuspendLayout();
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSenha.Location = new Point(119, 161);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(212, 35);
            txtSenha.TabIndex = 1;
            // 
            // txtUser
            // 
            txtUser.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUser.Location = new Point(119, 97);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(212, 35);
            txtUser.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(119, 73);
            label1.Name = "label1";
            label1.Size = new Size(69, 21);
            label1.TabIndex = 2;
            label1.Text = "Usuario.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(119, 137);
            label2.Name = "label2";
            label2.Size = new Size(58, 21);
            label2.TabIndex = 3;
            label2.Text = "Senha.";
            // 
            // BTNlogin
            // 
            BTNlogin.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            BTNlogin.Location = new Point(244, 202);
            BTNlogin.Name = "BTNlogin";
            BTNlogin.Size = new Size(87, 30);
            BTNlogin.TabIndex = 2;
            BTNlogin.Text = "Entrar";
            BTNlogin.UseVisualStyleBackColor = true;
            BTNlogin.Click += BTNlogin_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 33, 36);
            ClientSize = new Size(458, 284);
            Controls.Add(BTNlogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtUser);
            Controls.Add(txtSenha);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSenha;
        private TextBox txtUser;
        private Label label1;
        private Label label2;
        private Button BTNlogin;
    }
}