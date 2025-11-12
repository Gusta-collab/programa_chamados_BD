namespace Form_BD
{
    partial class editarChamado
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
            TBSetor = new TextBox();
            TBColbaborador = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            TBCausa = new TextBox();
            BTNsalvar = new Button();
            BTNexcluir = new Button();
            SuspendLayout();
            // 
            // TBSetor
            // 
            TBSetor.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            TBSetor.Location = new Point(148, 11);
            TBSetor.Name = "TBSetor";
            TBSetor.Size = new Size(175, 29);
            TBSetor.TabIndex = 1;
            // 
            // TBColbaborador
            // 
            TBColbaborador.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            TBColbaborador.Location = new Point(148, 51);
            TBColbaborador.Name = "TBColbaborador";
            TBColbaborador.Size = new Size(175, 29);
            TBColbaborador.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(75, 18);
            label2.Name = "label2";
            label2.Size = new Size(65, 21);
            label2.TabIndex = 4;
            label2.Text = "SETOR :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(5, 58);
            label3.Name = "label3";
            label3.Size = new Size(135, 21);
            label3.TabIndex = 5;
            label3.Text = "COLABORADOR :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(70, 97);
            label4.Name = "label4";
            label4.Size = new Size(70, 21);
            label4.TabIndex = 7;
            label4.Text = "CAUSA :";
            // 
            // TBCausa
            // 
            TBCausa.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            TBCausa.Location = new Point(148, 91);
            TBCausa.Name = "TBCausa";
            TBCausa.Size = new Size(175, 29);
            TBCausa.TabIndex = 6;
            // 
            // BTNsalvar
            // 
            BTNsalvar.BackColor = Color.RoyalBlue;
            BTNsalvar.FlatStyle = FlatStyle.Flat;
            BTNsalvar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            BTNsalvar.Location = new Point(148, 131);
            BTNsalvar.Name = "BTNsalvar";
            BTNsalvar.Size = new Size(175, 34);
            BTNsalvar.TabIndex = 8;
            BTNsalvar.Text = "Salvar";
            BTNsalvar.UseVisualStyleBackColor = false;
            BTNsalvar.Click += BTNsalvar_Click;
            // 
            // BTNexcluir
            // 
            BTNexcluir.BackColor = Color.Brown;
            BTNexcluir.FlatStyle = FlatStyle.Flat;
            BTNexcluir.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            BTNexcluir.Location = new Point(148, 171);
            BTNexcluir.Name = "BTNexcluir";
            BTNexcluir.Size = new Size(175, 34);
            BTNexcluir.TabIndex = 9;
            BTNexcluir.Text = "Excluir";
            BTNexcluir.UseVisualStyleBackColor = false;
            BTNexcluir.Click += BTNexcluir_Click;
            // 
            // editarChamado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 33, 36);
            ClientSize = new Size(335, 217);
            Controls.Add(BTNexcluir);
            Controls.Add(BTNsalvar);
            Controls.Add(label4);
            Controls.Add(TBCausa);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(TBColbaborador);
            Controls.Add(TBSetor);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "editarChamado";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox TBSetor;
        private TextBox TBColbaborador;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox TBCausa;
        private Button BTNsalvar;
        private Button BTNexcluir;
    }
}