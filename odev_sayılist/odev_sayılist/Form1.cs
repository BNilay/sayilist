using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odev_sayılist
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int y = Convert.ToUInt16(textBox1.Text);
            int adet = 0;

            for (int i= 1; i <= y; i++)
            {
                if (i %5==0)
                {
                    listBox1.Items.Add(i);
                    adet++;
                    label2.Text = adet.ToString();
                }

            }

            

        }
    }
}
