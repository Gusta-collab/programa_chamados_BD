namespace Form_BD
{
    partial class CriarChamado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Paleta de Cores Harmoniosa e Simples
        private readonly System.Drawing.Color COR_DESTAQUE_PRINCIPAL = System.Drawing.Color.FromArgb(29, 53, 87); // Azul Marinho
        private readonly System.Drawing.Color COR_FUNDO_PAGINA = System.Drawing.Color.FromArgb(245, 247, 250); // Cinza Claro (Fundo)
        private readonly System.Drawing.Color COR_TEXTO_PADRAO = System.Drawing.Color.FromArgb(51, 51, 51); // Cinza Escuro

        // Variáveis Auxiliares (Necessário para as Labels e o Botão)
        private System.Windows.Forms.Label lblSetorNome;
        private System.Windows.Forms.Label lblColaboradorNome;

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
            txtCausa = new TextBox();
            titulo = new Label();
            txtSetor = new ComboBox();
            lblColaboradorNome = new Label();
            txtColaborador = new TextBox();
            lblSetorNome = new Label();
            label1 = new Label();
            Salvar = new Button();
            SuspendLayout();
            // 
            // txtCausa
            // 
            txtCausa.BackColor = Color.FromArgb(32, 33, 36);
            txtCausa.BorderStyle = BorderStyle.FixedSingle;
            txtCausa.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            txtCausa.ForeColor = Color.FromArgb(232, 234, 237);
            txtCausa.Location = new Point(8, 220);
            txtCausa.Multiline = true;
            txtCausa.Name = "txtCausa";
            txtCausa.Size = new Size(795, 196);
            txtCausa.TabIndex = 3;
            txtCausa.Text = "sem internet.";
            // 
            // titulo
            // 
            titulo.AutoSize = true;
            titulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            titulo.ForeColor = Color.FromArgb(232, 234, 237);
            titulo.Location = new Point(8, 9);
            titulo.Name = "titulo";
            titulo.Size = new Size(276, 30);
            titulo.TabIndex = 1;
            titulo.Text = "REGISTRO DE PROBLEMA";
            // 
            // txtSetor
            // 
            txtSetor.BackColor = Color.FromArgb(66, 66, 66);
            txtSetor.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            txtSetor.ForeColor = Color.White;
            txtSetor.FormattingEnabled = true;
            txtSetor.Items.AddRange(new object[] { "Usinagem", "Administração", "Assistência", "Montagem", "Logística", "TI", "Projeto", "Eletromédico"});
            txtSetor.Location = new Point(12, 144);
            txtSetor.Name = "txtSetor";
            txtSetor.Size = new Size(246, 33);
            txtSetor.TabIndex = 2;
            // 
            // lblColaboradorNome
            // 
            lblColaboradorNome.AutoSize = true;
            lblColaboradorNome.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            lblColaboradorNome.ForeColor = Color.FromArgb(232, 234, 237);
            lblColaboradorNome.Location = new Point(12, 52);
            lblColaboradorNome.Name = "lblColaboradorNome";
            lblColaboradorNome.Size = new Size(124, 25);
            lblColaboradorNome.TabIndex = 3;
            lblColaboradorNome.Text = "Colaborador:";
            // 
            // txtColaborador
            // 
            txtColaborador.BackColor = Color.FromArgb(66, 66, 66);
            txtColaborador.BorderStyle = BorderStyle.None;
            txtColaborador.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            txtColaborador.ForeColor = Color.White;
            txtColaborador.Location = new Point(12, 80);
            txtColaborador.Name = "txtColaborador";
            txtColaborador.Size = new Size(246, 25);
            txtColaborador.TabIndex = 1;
            // 
            // lblSetorNome
            // 
            lblSetorNome.AutoSize = true;
            lblSetorNome.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            lblSetorNome.ForeColor = Color.FromArgb(232, 234, 237);
            lblSetorNome.Location = new Point(12, 119);
            lblSetorNome.Name = "lblSetorNome";
            lblSetorNome.Size = new Size(63, 25);
            lblSetorNome.TabIndex = 5;
            lblSetorNome.Text = "Setor:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(232, 234, 237);
            label1.Location = new Point(12, 192);
            label1.Name = "label1";
            label1.Size = new Size(219, 25);
            label1.TabIndex = 6;
            label1.Text = "Descrição do problema :";
            // 
            // Salvar
            // 
            Salvar.BackColor = Color.RoyalBlue;
            Salvar.FlatStyle = FlatStyle.Popup;
            Salvar.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            Salvar.ForeColor = Color.White;
            Salvar.Location = new Point(712, 179);
            Salvar.Name = "Salvar";
            Salvar.Size = new Size(88, 35);
            Salvar.TabIndex = 4;
            Salvar.Text = "Salvar";
            Salvar.UseVisualStyleBackColor = false;
            Salvar.Click += Salvar_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 33, 36);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(812, 428);
            Controls.Add(Salvar);
            Controls.Add(label1);
            Controls.Add(lblSetorNome);
            Controls.Add(txtColaborador);
            Controls.Add(lblColaboradorNome);
            Controls.Add(txtSetor);
            Controls.Add(titulo);
            Controls.Add(txtCausa);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            MaximizeBox = false;
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro de Problema";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        // Variáveis de Componente (usando seus nomes solicitados)
        private System.Windows.Forms.TextBox txtCausa;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.ComboBox txtSetor;
        private System.Windows.Forms.TextBox txtColaborador;
        private Label label1;
        private Button Salvar;
    }
}