using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class SetReaderTypeForm : Form
    {
        public SetReaderTypeForm()
        {
            InitializeComponent();
        }

        private async void SendRequestButton_Click(object sender, EventArgs e)
        {
            Product product = new Product
            {
                BLEEnabled = this.BLEEnabledBox.Checked,
                MifareEnabled = this.MifareEnabledBox.Checked,
                FSKEnabled = this.FSKEnabledBox.Checked,
                ASKEnabled = this.ASKEnabledBox.Checked

            };
            
            this.Close();
        }
    }


}
