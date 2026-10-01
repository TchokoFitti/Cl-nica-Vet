using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Http.Headers;
using System.Text;
using System.Windows.Forms;

namespace ClínicaVetForms
{
    public partial class FrmPaginaInicial : Form
    {
        public FrmPaginaInicial()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tutoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastrarTutor cadastrarTutor = new FrmCadastrarTutor();
            cadastrarTutor.TopLevel = false;
            cadastrarTutor.FormBorderStyle = FormBorderStyle.None;
            cadastrarTutor.Dock = DockStyle.Fill;
            pnlPaginaInicial.Controls.Clear();
            pnlPaginaInicial.Controls.Add(cadastrarTutor);
            cadastrarTutor.Show();
        }

        private void pnlPaginaInicial_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
