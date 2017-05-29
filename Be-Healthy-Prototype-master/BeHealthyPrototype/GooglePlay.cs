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
    public partial class GooglePlay : UserControl
    {
        PremiumVersionBooking previous;
        public GooglePlay(Form main, PremiumVersionBooking previous)
        {
            InitializeComponent();
            this.previous = previous;
            Parent = main;
        }

        private void payButton_Click(object sender, EventArgs e)
        {
            previous.ShowSuccessfullPayment();
            this.Dispose();
        }

        private void dontPayButton_Click(object sender, EventArgs e)
        {
            new MainWindow(this.ParentForm);
            this.Dispose();
        }
    }
}
