using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversiones_De_Las_Unidades
{
    public partial class Form1 : Form
    {
        ConversionesdeUnidades objCnvrsr = new ConversionesdeUnidades();
        public Form1()

        {
        
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            lblAnswerMoney.Text = Math.Round(

                objCnvrsr.convertir(
                    double.Parse(txtMoney.Text), CboMoney.SelectedIndex, CboMoney2.SelectedIndex, 0
                )

                , 2).ToString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            lblAnswerMedida.Text = Math.Round(

               objCnvrsr.convertir(
                   double.Parse(txtMedida.Text), CboMedida.SelectedIndex, CboMedida1.SelectedIndex, 1
               )

               , 2).ToString();
        }
    }
}
