using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atv_DS_3
{
    public partial class frmATV_2 : Form
    {
        public frmATV_2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int mes1, mes2, mes3, mes4, mes5, mes6, conta;

            mes1 = int.Parse(txtMês_1.Text);
            mes2 = int.Parse(txtMês_2.Text);
            mes3 = int.Parse(txtMês_3.Text);
            mes4 = int.Parse(txtMês_4.Text);
            mes5 = int.Parse(txtMês_5.Text);
            mes6 = int.Parse(txtMês_6.Text);

                conta = (mes1 + mes2 + mes3 + mes4 + mes5 + mes6) / 6;


            if (conta < 99.9)
            {
                MessageBox.Show("A média foi " + conta + " Consumo normal");
            }

            if (conta >= 100 && conta <= 299.9)
            {
                MessageBox.Show("A média foi " + conta + " Consumo alto");
            }

            if (conta >= 300)
            {
                MessageBox.Show("A média foi " + conta + " Consumo muito alto");
            }

        }

        private void atv_1_Click(object sender, EventArgs e)
        {
            Close();
            frmATV_1 frmATV_1 = new frmATV_1();
            frmATV_1.Show();
        }
    }
}
