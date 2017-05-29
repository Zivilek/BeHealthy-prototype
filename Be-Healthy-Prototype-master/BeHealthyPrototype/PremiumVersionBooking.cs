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
    public partial class PremiumVersionBooking : UserControl
    {
        Client client;
        public PremiumVersionBooking(Form main, List<Period> periods)
        {
            InitializeComponent();
            foreach(Period per in periods)
            {
                CheckBox chkBox = new CheckBox();
                chkBox.Click += ChkBox_Click;
                chkBox.AutoSize = false;
                chkBox.Size = new Size(400, 50);
                chkBox.Font = new Font("Times new roman", 15);
                chkBox.Text = per.ToString();
                chkBox.Tag = (Period) per;
                periodsPanel.Controls.Add(chkBox);
            }
            this.Parent = main;
        }
        private String CutString(string str)
        {

            for (int i = 0; i < str.Length / 20; i++)
                str.Insert(i * 20, Environment.NewLine);
            return str;
        }
        private void ChkBox_Click(object sender, EventArgs e)
        {
            foreach(CheckBox chkBox in periodsPanel.Controls.OfType<CheckBox>())
            {
                if (chkBox != sender) chkBox.Checked = false;
            }
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            client = new Client();
            if (!(client.CheckEmail(emailBox.Text))) ShowMsg("Email nėra registruotas vartotojas", "Klaida");
            else
            {
                client.Email = emailBox.Text;
                if (!PeriodSelected()) ShowMsg("Nepasirinktas joks laikotarpis", "Klaida");
                else
                {
                    Visible = false;
                    new GooglePlay(this.ParentForm, this);
                }
            }
            
        }
        private bool PeriodSelected()
        {
            foreach(CheckBox chkBox in periodsPanel.Controls.OfType<CheckBox>())
            {
                if (chkBox.Checked) return true;
            }
            return false;
        }
        private int GetCheckedBox()
        {
            foreach (CheckBox chkBox in periodsPanel.Controls.OfType<CheckBox>())
            {
                if (chkBox.Checked)
                {
                    return ((Period)chkBox.Tag).Month;
                }
            }
            return 0;
        }
        public void ShowSuccessfullPayment()
        {
            Visible = true;
            ShowMsg("Sėkmingai apmokėta!", "Apmokėta");
            new MainWindow(ParentForm);
            Task.Factory.StartNew(() => {
                new ActivationCode().GetNewActivationCode(client, GetCheckedBox());
            });
            this.Dispose();
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
