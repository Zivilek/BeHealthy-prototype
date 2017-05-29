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
    public partial class Help : UserControl
    {
        public Help(Form main)
        {
            InitializeComponent();
            this.Parent = main;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            new MainWindow(ParentForm);
            this.Dispose();
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() => {
                Client client = new Client().GetCurrent();
                Message msg = new Message("Pagalbos pranesimas nuo" + client.Name + " " + client.Surname, msgBox.Text, client);
                new Mailer().SendHelpMsg(msg);
            });
            new MainWindow(ParentForm).ShowMsg("Sėkmingai išsiųsta!", "Išsiųsta");
            this.Dispose();
        }
        public void ShowMsg(string msg, string title)
        {
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
