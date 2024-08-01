namespace GestaoEquipamentos.WinFormsApp.ModuloFuncionarios
{
    partial class UserControlFuncionarios
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            adicionarToolStripMenuItem = new ToolStripMenuItem();
            editarToolStripMenuItem = new ToolStripMenuItem();
            removerToolStripMenuItem = new ToolStripMenuItem();
            listBoxFuncionarios = new ListBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { adicionarToolStripMenuItem, editarToolStripMenuItem, removerToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(682, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // adicionarToolStripMenuItem
            // 
            adicionarToolStripMenuItem.Name = "adicionarToolStripMenuItem";
            adicionarToolStripMenuItem.Size = new Size(70, 20);
            adicionarToolStripMenuItem.Text = "Adicionar";
            adicionarToolStripMenuItem.Click += adicionarToolStripMenuItem_Click;
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(49, 20);
            editarToolStripMenuItem.Text = "Editar";
            editarToolStripMenuItem.Click += editarToolStripMenuItem_Click;
            // 
            // removerToolStripMenuItem
            // 
            removerToolStripMenuItem.Name = "removerToolStripMenuItem";
            removerToolStripMenuItem.Size = new Size(66, 20);
            removerToolStripMenuItem.Text = "Remover";
            removerToolStripMenuItem.Click += removerToolStripMenuItem_Click;
            // 
            // listBoxFuncionarios
            // 
            listBoxFuncionarios.FormattingEnabled = true;
            listBoxFuncionarios.ItemHeight = 15;
            listBoxFuncionarios.Location = new Point(3, 34);
            listBoxFuncionarios.Name = "listBoxFuncionarios";
            listBoxFuncionarios.Size = new Size(676, 319);
            listBoxFuncionarios.TabIndex = 1;
            // 
            // UserControlFuncionarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listBoxFuncionarios);
            Controls.Add(menuStrip1);
            Name = "UserControlFuncionarios";
            Size = new Size(682, 356);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem adicionarToolStripMenuItem;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem removerToolStripMenuItem;
        private ListBox listBoxFuncionarios;
    }
}
