namespace Form_BD
{
    partial class GerenciarChamados
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label1 = new Label();
            dgvChamados = new DataGridView();
            Acoes = new DataGridViewButtonColumn();
            Detalhes = new DataGridViewButtonColumn();
            CriarChamado = new Button();
            BTNatualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvChamados).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = Color.White;
            label1.Location = new Point(302, 9);
            label1.Name = "label1";
            label1.Size = new Size(385, 45);
            label1.TabIndex = 0;
            label1.Text = "CHAMADOS EM ABERTO:";
            // 
            // dgvChamados
            // 
            dgvChamados.AllowUserToAddRows = false;
            dgvChamados.BackgroundColor = Color.FromArgb(32, 33, 36);
            dgvChamados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChamados.Columns.AddRange(new DataGridViewColumn[] { Acoes, Detalhes });
            dgvChamados.Location = new Point(12, 189);
            dgvChamados.Name = "dgvChamados";
            dgvChamados.Size = new Size(966, 249);
            dgvChamados.TabIndex = 1;
            dgvChamados.CellContentClick += dgvChamados_CellContentClick;
            // 
            // Acoes
            // 
            Acoes.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            Acoes.DefaultCellStyle = dataGridViewCellStyle1;
            Acoes.HeaderText = "Ações";
            Acoes.MinimumWidth = 75;
            Acoes.Name = "Acoes";
            Acoes.Resizable = DataGridViewTriState.True;
            Acoes.Text = "Editar";
            Acoes.UseColumnTextForButtonValue = true;
            Acoes.Width = 75;
            // 
            // Detalhes
            // 
            Detalhes.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Detalhes.HeaderText = "Detalhes";
            Detalhes.MinimumWidth = 75;
            Detalhes.Name = "Detalhes";
            Detalhes.Text = "Detalhes";
            Detalhes.UseColumnTextForButtonValue = true;
            Detalhes.Width = 75;
            // 
            // CriarChamado
            // 
            CriarChamado.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            CriarChamado.Location = new Point(829, 148);
            CriarChamado.Name = "CriarChamado";
            CriarChamado.Size = new Size(149, 35);
            CriarChamado.TabIndex = 2;
            CriarChamado.Text = "Criar Chamado";
            CriarChamado.UseVisualStyleBackColor = true;
            CriarChamado.Click += CriarChamado_Click;
            // 
            // BTNatualizar
            // 
            BTNatualizar.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            BTNatualizar.Location = new Point(829, 107);
            BTNatualizar.Name = "BTNatualizar";
            BTNatualizar.Size = new Size(149, 35);
            BTNatualizar.TabIndex = 3;
            BTNatualizar.Text = "Atualizar";
            BTNatualizar.UseVisualStyleBackColor = true;
            BTNatualizar.Click += BTNatualizar_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 33, 36);
            ClientSize = new Size(990, 450);
            Controls.Add(BTNatualizar);
            Controls.Add(CriarChamado);
            Controls.Add(dgvChamados);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dgvChamados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvChamados;
        private Button CriarChamado;
        private Button BTNatualizar;
        private DataGridViewButtonColumn Acoes;
        private DataGridViewButtonColumn Detalhes;
    }
}