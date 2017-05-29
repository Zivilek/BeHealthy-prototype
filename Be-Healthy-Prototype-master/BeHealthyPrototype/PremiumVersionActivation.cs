using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeHealthyPrototype
{
    public partial class PremiumVersionActivation : UserControl
    {
        public PremiumVersionActivation(Form main)
        {
            InitializeComponent();
            Parent = main;
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            if (new ActivationCode().Check(new ActivationCode(activationBox.Text)))
            {
                new MainWindow(ParentForm).ShowMsg("Premium versija pratęsta iki" + new Client().GetCurrent().PremiumExpireDate.ToString("yyyy.MM.dd"), "Pratęsta!");
                this.Dispose();
            }
            else ShowMsg("Blogas aktyvacijos kodas", "Klaida");
        }
        private void ShowMsg(string msg, string title)
        {
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            new MainWindow(ParentForm);
            this.Dispose();
        }
    }
}
