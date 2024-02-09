using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace NuclearReactor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            startButton.Visible = false;
            reactor1Image.BackColor = Color.Red;
            reactor2Image.BackColor = Color.Red;
            reactorstableLabel.BackColor = Color.White;
            reactorstableLabel.Text = "Reactor Unstable";
            reactorstableLabel.ForeColor = Color.Red;
            this.BackColor = Color.Black;

            Refresh();
            Thread.Sleep(1000);

            reactor1Image.BackColor = Color.White;
            reactor2Image.BackColor = Color.White;
            reactorstableLabel.BackColor = Color.Red;
            reactorstableLabel.ForeColor= Color.White;
           
            Refresh();
            Thread.Sleep(1000);

            reactor1Image.BackColor = Color.Red;
            reactor2Image.BackColor = Color.Red;
            reactorstableLabel.BackColor = Color.White;
            reactorstableLabel.ForeColor = Color.Red;
           
            Refresh();
            Thread.Sleep(1000);

            reactor1Image.BackColor = Color.White;
            reactor2Image.BackColor = Color.White;
            reactorstableLabel.BackColor = Color.Red;
            reactorstableLabel.ForeColor = Color.White;
        }
    }
}
