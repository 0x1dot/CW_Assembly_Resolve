using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AssemblyLoader.Attach();
        }
        private void btnUret_Click(object sender, EventArgs e)
        {
            TestLibrary.Sinifim sinifim = new TestLibrary.Sinifim();
            ArrayList arraylist = sinifim.sayiuret(int.Parse(txtBaslangic.Text),int.Parse(txtBitis.Text),int.Parse(txtAdet.Text));
            foreach (var item in arraylist)
            {
                listBox1.Items.Add(item);
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
