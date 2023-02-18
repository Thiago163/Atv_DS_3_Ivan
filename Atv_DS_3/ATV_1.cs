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
    public partial class frmATV_1 : Form
    {
        public frmATV_1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string nome;
            int idade;

            nome = txtNome.Text;
            idade = int.Parse(txtIdade.Text);

            if (idade < 5)
            {
                MessageBox.Show(nome + " você infelizmente não se enquadra");
            }

            if (idade >= 5 && idade <= 7 )
            {
                MessageBox.Show(nome + " você está no Infantil A");
            }

            if (idade >= 8 && idade <= 10)
            {
                MessageBox.Show(nome + " você está no Infantil B");
            }

            if (idade >= 11 && idade <= 13)
            {
                MessageBox.Show(nome + " você está no Juvenil A");
            }

            if (idade >= 14 && idade <= 17)
            {
                MessageBox.Show(nome + " você está no Juvenil B");
            }

            if (idade >= 18)
            {
                MessageBox.Show(nome + " você está no Adulto");
            }
        }

        private void atv_2_Click(object sender, EventArgs e)
        {
            Close();
            frmATV_2 frmATV_2 = new frmATV_2();
            frmATV_2.Show();
        }
    }
}
