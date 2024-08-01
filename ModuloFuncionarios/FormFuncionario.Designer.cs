namespace GestaoEquipamentos.WinFormsApp.ModuloFuncionarios
{
    partial class FormFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFuncionario));
            btnAdicionar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtNome = new TextBox();
            dateTimeInicio = new DateTimePicker();
            txtFuncao = new TextBox();
            txtEmail = new TextBox();
            txtTelefone = new TextBox();
            txtDepartamento = new TextBox();
            txtSupervisor = new TextBox();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(321, 222);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 0;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 20);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 1;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 47);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 2;
            label2.Text = "Data de Inicio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 76);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 3;
            label3.Text = "Função";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 103);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 4;
            label4.Text = "E-mail";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 132);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 5;
            label5.Text = "Telefone";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 161);
            label6.Name = "label6";
            label6.Size = new Size(85, 15);
            label6.TabIndex = 6;
            label6.Text = "departamento ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 190);
            label7.Name = "label7";
            label7.Size = new Size(61, 15);
            label7.TabIndex = 7;
            label7.Text = "supervisor";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(121, 12);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(275, 23);
            txtNome.TabIndex = 8;
            // 
            // dateTimeInicio
            // 
            dateTimeInicio.Location = new Point(121, 39);
            dateTimeInicio.Name = "dateTimeInicio";
            dateTimeInicio.Size = new Size(275, 23);
            dateTimeInicio.TabIndex = 9;
            // 
            // txtFuncao
            // 
            txtFuncao.Location = new Point(121, 68);
            txtFuncao.Name = "txtFuncao";
            txtFuncao.Size = new Size(275, 23);
            txtFuncao.TabIndex = 10;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(121, 95);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(275, 23);
            txtEmail.TabIndex = 11;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(121, 124);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(275, 23);
            txtTelefone.TabIndex = 12;
            // 
            // txtDepartamento
            // 
            txtDepartamento.Location = new Point(121, 153);
            txtDepartamento.Name = "txtDepartamento";
            txtDepartamento.Size = new Size(275, 23);
            txtDepartamento.TabIndex = 13;
            // 
            // txtSupervisor
            // 
            txtSupervisor.Location = new Point(121, 182);
            txtSupervisor.Name = "txtSupervisor";
            txtSupervisor.Size = new Size(275, 23);
            txtSupervisor.TabIndex = 14;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 259);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(424, 22);
            statusStrip1.TabIndex = 15;
            statusStrip1.Text = "statusStripErros";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(0, 17);
            // 
            // FormFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 281);
            Controls.Add(statusStrip1);
            Controls.Add(txtSupervisor);
            Controls.Add(txtDepartamento);
            Controls.Add(txtTelefone);
            Controls.Add(txtEmail);
            Controls.Add(txtFuncao);
            Controls.Add(dateTimeInicio);
            Controls.Add(txtNome);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAdicionar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormFuncionario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro Funcionários";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdicionar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtNome;
        private DateTimePicker dateTimeInicio;
        private TextBox txtFuncao;
        private TextBox txtEmail;
        private TextBox txtTelefone;
        private TextBox txtDepartamento;
        private TextBox txtSupervisor;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
    }
}