using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CW_Assembly_Resolve
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGozat_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog opf = new OpenFileDialog())
            {
                opf.Filter = "Dll Dosyaları | *.dll";
                opf.FilterIndex = 0;
                if (opf.ShowDialog() == DialogResult.OK)
                {
                    txtSikistirYol.Text = opf.FileName;
                }
            }
        }

        private void btnSikistir_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtSikistirYol.Text))
                AssemblyLoader.KutuphaneSikistir(txtSikistirYol.Text);
            else MessageBox.Show("Lütfen sıkıştırılmak istenen dosyayı seçiniz.","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void btnGozat1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog opf = new OpenFileDialog())
            {
                opf.Filter = "Sıkıştırılmış Dosyalar | *.0xCompressed";
                opf.FilterIndex = 0;
                if (opf.ShowDialog() == DialogResult.OK)
                {
                    txtAcYol.Text = opf.FileName;
                }
            }
        }

        private void btnCikart_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtAcYol.Text))
                AssemblyLoader.KutuphaneCikart(txtAcYol.Text);
            else MessageBox.Show("Lütfen çıkartılmak istenen dosyayı seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
