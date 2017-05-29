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
    public partial class PhysicalEndurance : UserControl
    {
        int questionNr = 1;
        List<string> answers = new List<string>();
        public PhysicalEndurance(Form main)
        {
            InitializeComponent();
            FillQuestionAndAnswers();
            Parent = main;
        }
        private void FillQuestionAndAnswers()
        {
            List<string> list = new PhysicalTest().NewQuestion(questionNr);
            answersPanel.Controls.Clear();
            if (list.Count > 1)
            {
                question.Text = CutString(list[0]);
                question.Font = new Font("Times New Roman", 20);
                question.AutoSize = false;
                question.Size = new Size(400, 500);
                for (int i=1; i<list.Count; i++)
                {
                    CheckBox chkBox = new CheckBox();
                    chkBox.AutoSize = false;
                    chkBox.Size = new Size(400, 70);
                    chkBox.Font = new Font("Times New Roman", 14);
                    chkBox.Text = CutString(list[i]);
                    chkBox.Click += ChkBox_Click;
                    answersPanel.Controls.Add(chkBox);
                }
                questionNr++;
            }
            else
            {
                new Answer().Save(answers);
                new MainWindow(ParentForm).ShowMsg("Testas sėkmingai atliktas!", "Patvirtinimas");
                this.Dispose();
            }
        }
        private String CutString(string str)
        {

            for (int i = 0; i < str.Length/20; i++)
                str.Insert(i *20, Environment.NewLine);
            return str;
        }
        private void ChkBox_Click(object sender, EventArgs e)
        {
            foreach (CheckBox chkBox in answersPanel.Controls.OfType<CheckBox>())
            {
                if (chkBox != sender) chkBox.Checked = false;
            }
        }
        private CheckBox CheckedBox()
        {
            foreach(CheckBox chkBox in answersPanel.Controls.OfType<CheckBox>())
            {
                if (chkBox.Checked) return chkBox;
            }
            return null;
        }
        private void continueButton_Click(object sender, EventArgs e)
        {
            CheckBox chkBox;
            if ((chkBox = CheckedBox()) == null) ShowMsg("Nepasirinktas nei vienas atsakymas", "Klaida");
            else
            {
                answers.Add(question.Text);
                answers.Add(chkBox.Text);
                FillQuestionAndAnswers();
            }
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
