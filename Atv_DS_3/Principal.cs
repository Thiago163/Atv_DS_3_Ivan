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
    public partial class frm_Principal : Form
    {
        public frm_Principal()
        {
            InitializeComponent();
        }

        private void btn_atv_1_Click(object sender, EventArgs e)
        {
            frmATV_1 frmATV_1 = new frmATV_1();
            frmATV_1.Show();
        }

        private void btn_atv_2_Click(object sender, EventArgs e)
        {
            frmATV_2 frmATV_2 = new frmATV_2();
            frmATV_2.Show();
        }
    }
}
