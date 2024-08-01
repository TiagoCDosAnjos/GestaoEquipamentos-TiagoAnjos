namespace GestaoEquipamentos.WinFormsApp
{
    partial class TelaPrincipalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipalForm));
            tableLayoutPanel1 = new TableLayoutPanel();
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            equipamentosToolStripMenuItem = new ToolStripMenuItem();
            tipoToolStripMenuItem = new ToolStripMenuItem();
            cSVToolStripMenuItem = new ToolStripMenuItem();
            fabricantesToolStripMenuItem = new ToolStripMenuItem();
            funcionariosToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            splitContainer1 = new SplitContainer();
            flowLayoutPanel1 = new FlowLayoutPanel();
            buttonEquipamentos = new Button();
            btnTipo = new Button();
            btnCSV = new Button();
            btnFabricantes = new Button();
            button1 = new Button();
            btnClientes = new Button();
            panelListControl = new Panel();
            tableLayoutPanel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(menuStrip1, 0, 0);
            tableLayoutPanel1.Controls.Add(splitContainer1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.3134327F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 87.68657F));
            tableLayoutPanel1.Size = new Size(884, 670);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.Fill;
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(884, 82);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { equipamentosToolStripMenuItem, tipoToolStripMenuItem, cSVToolStripMenuItem, fabricantesToolStripMenuItem, funcionariosToolStripMenuItem, clientesToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(50, 78);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // equipamentosToolStripMenuItem
            // 
            equipamentosToolStripMenuItem.Image = (Image)resources.GetObject("equipamentosToolStripMenuItem.Image");
            equipamentosToolStripMenuItem.Name = "equipamentosToolStripMenuItem";
            equipamentosToolStripMenuItem.Size = new Size(180, 22);
            equipamentosToolStripMenuItem.Text = "Equipamentos";
            equipamentosToolStripMenuItem.Click += equipamentosToolStripMenuItem_Click;
            // 
            // tipoToolStripMenuItem
            // 
            tipoToolStripMenuItem.Image = (Image)resources.GetObject("tipoToolStripMenuItem.Image");
            tipoToolStripMenuItem.Name = "tipoToolStripMenuItem";
            tipoToolStripMenuItem.Size = new Size(180, 22);
            tipoToolStripMenuItem.Text = "Tipo";
            tipoToolStripMenuItem.Click += tipoToolStripMenuItem_Click_1;
            // 
            // cSVToolStripMenuItem
            // 
            cSVToolStripMenuItem.Image = (Image)resources.GetObject("cSVToolStripMenuItem.Image");
            cSVToolStripMenuItem.Name = "cSVToolStripMenuItem";
            cSVToolStripMenuItem.Size = new Size(180, 22);
            cSVToolStripMenuItem.Text = "CSV";
            cSVToolStripMenuItem.Click += cSVToolStripMenuItem_Click;
            // 
            // fabricantesToolStripMenuItem
            // 
            fabricantesToolStripMenuItem.Image = (Image)resources.GetObject("fabricantesToolStripMenuItem.Image");
            fabricantesToolStripMenuItem.Name = "fabricantesToolStripMenuItem";
            fabricantesToolStripMenuItem.Size = new Size(180, 22);
            fabricantesToolStripMenuItem.Text = "Fabricantes";
            fabricantesToolStripMenuItem.Click += fabricantesToolStripMenuItem_Click;
            // 
            // funcionariosToolStripMenuItem
            // 
            funcionariosToolStripMenuItem.Image = (Image)resources.GetObject("funcionariosToolStripMenuItem.Image");
            funcionariosToolStripMenuItem.Name = "funcionariosToolStripMenuItem";
            funcionariosToolStripMenuItem.Size = new Size(180, 22);
            funcionariosToolStripMenuItem.Text = "Funcionarios";
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.Image = (Image)resources.GetObject("clientesToolStripMenuItem.Image");
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(180, 22);
            clientesToolStripMenuItem.Text = "Clientes";
            clientesToolStripMenuItem.Click += clientesToolStripMenuItem_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(3, 85);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(flowLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panelListControl);
            splitContainer1.Size = new Size(878, 582);
            splitContainer1.SplitterDistance = 186;
            splitContainer1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(buttonEquipamentos);
            flowLayoutPanel1.Controls.Add(btnTipo);
            flowLayoutPanel1.Controls.Add(btnCSV);
            flowLayoutPanel1.Controls.Add(btnFabricantes);
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(btnClientes);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(186, 582);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // buttonEquipamentos
            // 
            buttonEquipamentos.Image = (Image)resources.GetObject("buttonEquipamentos.Image");
            buttonEquipamentos.ImageAlign = ContentAlignment.MiddleLeft;
            buttonEquipamentos.Location = new Point(3, 3);
            buttonEquipamentos.Name = "buttonEquipamentos";
            buttonEquipamentos.Size = new Size(163, 76);
            buttonEquipamentos.TabIndex = 0;
            buttonEquipamentos.Text = "Equipamentos";
            buttonEquipamentos.TextAlign = ContentAlignment.MiddleRight;
            buttonEquipamentos.UseVisualStyleBackColor = true;
            buttonEquipamentos.Click += buttonEquipamentos_Click;
            // 
            // btnTipo
            // 
            btnTipo.Image = (Image)resources.GetObject("btnTipo.Image");
            btnTipo.ImageAlign = ContentAlignment.MiddleLeft;
            btnTipo.Location = new Point(3, 85);
            btnTipo.Name = "btnTipo";
            btnTipo.Size = new Size(163, 76);
            btnTipo.TabIndex = 1;
            btnTipo.Text = "Tipo";
            btnTipo.TextAlign = ContentAlignment.MiddleRight;
            btnTipo.UseVisualStyleBackColor = true;
            btnTipo.Click += btnTipo_Click;
            // 
            // btnCSV
            // 
            btnCSV.Image = (Image)resources.GetObject("btnCSV.Image");
            btnCSV.ImageAlign = ContentAlignment.MiddleLeft;
            btnCSV.Location = new Point(3, 167);
            btnCSV.Name = "btnCSV";
            btnCSV.Size = new Size(163, 76);
            btnCSV.TabIndex = 2;
            btnCSV.Text = "CSV";
            btnCSV.TextAlign = ContentAlignment.MiddleRight;
            btnCSV.UseVisualStyleBackColor = true;
            btnCSV.Click += btnCSV_Click;
            // 
            // btnFabricantes
            // 
            btnFabricantes.Image = (Image)resources.GetObject("btnFabricantes.Image");
            btnFabricantes.ImageAlign = ContentAlignment.MiddleLeft;
            btnFabricantes.Location = new Point(3, 249);
            btnFabricantes.Name = "btnFabricantes";
            btnFabricantes.Size = new Size(163, 76);
            btnFabricantes.TabIndex = 3;
            btnFabricantes.Text = "Fabricantes";
            btnFabricantes.TextAlign = ContentAlignment.MiddleRight;
            btnFabricantes.UseVisualStyleBackColor = true;
            btnFabricantes.Click += btnFabricantes_Click;
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(3, 331);
            button1.Name = "button1";
            button1.Size = new Size(163, 76);
            button1.TabIndex = 4;
            button1.Text = "Funcionarios";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnClientes
            // 
            btnClientes.Image = (Image)resources.GetObject("btnClientes.Image");
            btnClientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnClientes.Location = new Point(3, 413);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(163, 76);
            btnClientes.TabIndex = 6;
            btnClientes.Text = "Clientes";
            btnClientes.TextAlign = ContentAlignment.MiddleRight;
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // panelListControl
            // 
            panelListControl.Dock = DockStyle.Fill;
            panelListControl.Location = new Point(0, 0);
            panelListControl.Name = "panelListControl";
            panelListControl.Size = new Size(688, 582);
            panelListControl.TabIndex = 0;
            // 
            // TelaPrincipalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 670);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "TelaPrincipalForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestão de Equipamentos";
            FormClosing += TelaPrincipalForm_FormClosing;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem equipamentosToolStripMenuItem;
        private SplitContainer splitContainer1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button buttonEquipamentos;
        private Panel panelListControl;
        private Button btnTipo;
        private Button btnCSV;
        private Button btnFabricantes;
        private ToolStripMenuItem tipoToolStripMenuItem;
        private ToolStripMenuItem cSVToolStripMenuItem;
        private ToolStripMenuItem fabricantesToolStripMenuItem;
        private Button button1;
        private ToolStripMenuItem funcionariosToolStripMenuItem;
        private Button btnClientes;
        private ToolStripMenuItem clientesToolStripMenuItem;
    }
}