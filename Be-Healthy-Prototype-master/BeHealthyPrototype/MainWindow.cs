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
    public partial class MainWindow : UserControl
    {
        public MainWindow(Form main)
        {
            InitializeComponent();
            this.Parent = main;
        }

        private void activBookButton_Click(object sender, EventArgs e)
        {
            new PremiumVersionBooking(this.ParentForm, new Period().GetPeriods());
            this.Dispose();
        }

        private void activatePremiumButton_Click(object sender, EventArgs e)
        {
            new PremiumVersionActivation(ParentForm);
            this.Dispose();
        }
        public void ShowMsg(string msg, string title)
        {
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void uploadButton_Click(object sender, EventArgs e)
        {
            ShowMsg("Šis prototipas šios funkcijos nepalaiko", "Klaida");
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            ShowMsg("Šis prototipas šios funkcijos nepalaiko", "Klaida");
        }

        private void getProgramButton_Click(object sender, EventArgs e)
        {
            ShowMsg("Šis prototipas šios funkcijos nepalaiko", "Klaida");
        }

        private void calcKMIbutton_Click(object sender, EventArgs e)
        {
            ShowMsg("Šis prototipas šios funkcijos nepalaiko", "Klaida");
        }

        private void enterLevelButton_Click(object sender, EventArgs e)
        {
            new PhysicalEndurance(ParentForm);
            this.Dispose();
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            new Help(ParentForm);
            this.Dispose();
        }
    }
}
