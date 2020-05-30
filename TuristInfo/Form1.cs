using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TuristInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rdnBtn1.Enabled = rdnBtn2.Enabled=  false;
        }

        private void rdnBtnTarihi_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "Nasıl bir tarihi yer olmasını istersiniz?";
            rdnBtn1.Text = "Mağaralar";
            rdnBtn2.Text = "Tapınaklar";
            rdnBtn1.Enabled = rdnBtn2.Enabled = true;
            rdnBtn1.Checked = rdnBtn2.Checked = false;
        }

        private void rdBtnDogal_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "Nasıl bir doğal yer olmasını istersiniz?";
            rdnBtn1.Text = "Göller";
            rdnBtn2.Text = "Şelaleler";
            rdnBtn1.Enabled = rdnBtn2.Enabled = true;
            rdnBtn1.Checked = rdnBtn2.Checked = false;
        }

        private void rdBtnOrman_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "Nasıl bir orman olmasını istersiniz?";
            rdnBtn1.Text = "Doğal";
            rdnBtn2.Text = "Tarihi";
            rdnBtn1.Enabled = rdnBtn2.Enabled = true;
            rdnBtn1.Checked = rdnBtn2.Checked = false;
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            if(rdnBtn1.Checked == false && rdnBtn2.Checked == false)
            {
                MessageBox.Show("Lütfen detayları işaretleyin");
            }
            else
            {
                Form2 form = new Form2();
                if (rdnBtn1.Checked == true)
                    form.text = rdnBtn1.Text;
                else if (rdnBtn2.Checked == true)
                    form.text = rdnBtn2.Text;
                else
                    MessageBox.Show("yanlış birşey var");
                form.Show();
            }
        }
    }
}
