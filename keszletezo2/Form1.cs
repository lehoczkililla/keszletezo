using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hotcakes.CommerceDTO.v1;

namespace keszletezo2
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void letoltes_Click(object sender, EventArgs e)
        {
            Hova hova = new Hova();
            hova.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TablazatForm tablazatForm = new TablazatForm();
            tablazatForm.Show();
        }
    }
}
