using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
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
            if (string.IsNullOrEmpty(pathBox.Text))
            {
                e.Cancel = true;
                // ha nem, írjuk ki a hibát
                errorProvider1.SetError(pathBox, "Kérem adja meg az elérési utat!");
            }
            if (!string.IsNullOrEmpty(pathBox.Text) && !Regex.IsMatch(pathBox.Text, "/"))
            {
                e.Cancel= true;
                errorProvider1.SetError(pathBox, "Kérem előre perjeleket (/) használjon!");
            }
            if (!string.IsNullOrEmpty(pathBox.Text) && Regex.IsMatch(pathBox.Text, "/") && !Regex.IsMatch(pathBox.Text, "/$"))
            {
                e.Cancel = true;
                errorProvider1.SetError(pathBox, "Kérem az elérési út végére is tegyen perjelet!");
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
