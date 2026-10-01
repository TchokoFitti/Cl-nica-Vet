namespace ClínicaVetForms
{
    partial class FrmPaginaInicial
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
            menuStrip1 = new MenuStrip();
            tutoresToolStripMenuItem = new ToolStripMenuItem();
            tutorToolStripMenuItem = new ToolStripMenuItem();
            animalToolStripMenuItem = new ToolStripMenuItem();
            veterinárioToolStripMenuItem = new ToolStripMenuItem();
            consultasToolStripMenuItem = new ToolStripMenuItem();
            agendamentoToolStripMenuItem = new ToolStripMenuItem();
            buscaToolStripMenuItem = new ToolStripMenuItem();
            cancelamentoToolStripMenuItem = new ToolStripMenuItem();
            pnlPaginaInicial = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { tutoresToolStripMenuItem, consultasToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1092, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // tutoresToolStripMenuItem
            // 
            tutoresToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tutorToolStripMenuItem, animalToolStripMenuItem, veterinárioToolStripMenuItem });
            tutoresToolStripMenuItem.Name = "tutoresToolStripMenuItem";
            tutoresToolStripMenuItem.Size = new Size(66, 20);
            tutoresToolStripMenuItem.Text = "Cadastro";
            tutoresToolStripMenuItem.Click += tutoresToolStripMenuItem_Click;
            // 
            // tutorToolStripMenuItem
            // 
            tutorToolStripMenuItem.Name = "tutorToolStripMenuItem";
            tutorToolStripMenuItem.Size = new Size(180, 22);
            tutorToolStripMenuItem.Text = "Tutor";
            tutorToolStripMenuItem.Click += tutorToolStripMenuItem_Click;
            // 
            // animalToolStripMenuItem
            // 
            animalToolStripMenuItem.Name = "animalToolStripMenuItem";
            animalToolStripMenuItem.Size = new Size(180, 22);
            animalToolStripMenuItem.Text = "Animal";
            // 
            // veterinárioToolStripMenuItem
            // 
            veterinárioToolStripMenuItem.Name = "veterinárioToolStripMenuItem";
            veterinárioToolStripMenuItem.Size = new Size(180, 22);
            veterinárioToolStripMenuItem.Text = "Veterinário";
            // 
            // consultasToolStripMenuItem
            // 
            consultasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agendamentoToolStripMenuItem, buscaToolStripMenuItem, cancelamentoToolStripMenuItem });
            consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            consultasToolStripMenuItem.Size = new Size(71, 20);
            consultasToolStripMenuItem.Text = "Consultas";
            // 
            // agendamentoToolStripMenuItem
            // 
            agendamentoToolStripMenuItem.Name = "agendamentoToolStripMenuItem";
            agendamentoToolStripMenuItem.Size = new Size(151, 22);
            agendamentoToolStripMenuItem.Text = "Agendamento";
            // 
            // buscaToolStripMenuItem
            // 
            buscaToolStripMenuItem.Name = "buscaToolStripMenuItem";
            buscaToolStripMenuItem.Size = new Size(151, 22);
            buscaToolStripMenuItem.Text = "Busca";
            // 
            // cancelamentoToolStripMenuItem
            // 
            cancelamentoToolStripMenuItem.Name = "cancelamentoToolStripMenuItem";
            cancelamentoToolStripMenuItem.Size = new Size(151, 22);
            cancelamentoToolStripMenuItem.Text = "Cancelamento";
            // 
            // pnlPaginaInicial
            // 
            pnlPaginaInicial.BackColor = Color.Wheat;
            pnlPaginaInicial.Location = new Point(12, 37);
            pnlPaginaInicial.Name = "pnlPaginaInicial";
            pnlPaginaInicial.Size = new Size(1068, 555);
            pnlPaginaInicial.TabIndex = 1;
            pnlPaginaInicial.Paint += pnlPaginaInicial_Paint;
            // 
            // FrmPaginaInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(1092, 604);
            Controls.Add(pnlPaginaInicial);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MainMenuStrip = menuStrip1;
            Name = "FrmPaginaInicial";
            Text = "FrmPaginaInicial";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tutoresToolStripMenuItem;
        private ToolStripMenuItem tutorToolStripMenuItem;
        private ToolStripMenuItem animalToolStripMenuItem;
        private ToolStripMenuItem veterinárioToolStripMenuItem;
        private ToolStripMenuItem consultasToolStripMenuItem;
        private ToolStripMenuItem agendamentoToolStripMenuItem;
        private ToolStripMenuItem buscaToolStripMenuItem;
        private ToolStripMenuItem cancelamentoToolStripMenuItem;
        private Panel pnlPaginaInicial;
    }
}