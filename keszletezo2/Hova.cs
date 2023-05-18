using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace keszletezo2
{
    public partial class Hova : Form
    {
        public Hova()
        {
            InitializeComponent();
        }

        public void pathBox_Validating(object sender, CancelEventArgs e)
        {
            //nézzük meg, hogy megadták-e az elérési utat
            if (!ellenoriz(pathBox.Text))
            {
                e.Cancel = true;
                // ha nem, írjuk ki a hibát
                errorProvider1.SetError(pathBox, "Kérem adja meg az elérési utat!");
            }
        }

        public void pathBox_Validated(object sender, EventArgs e)
        {
            //ha igen, állítsuk vissza, hogy ne legyen hibaüzenet
            errorProvider1.SetError(pathBox, "");


        }


        private bool ellenoriz(string path)
        {
            return !string.IsNullOrEmpty(path);
        }

        private void ok_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
