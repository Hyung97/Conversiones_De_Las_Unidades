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
                    double.Parse(txtMoney.Text), CboMoney2.SelectedIndex, CboMoney.SelectedIndex, 0
                )

                , 2).ToString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            lblAnswerMedida.Text = Math.Round(

               objCnvrsr.convertir(
                   double.Parse(txtMedida.Text), CboMedida1.SelectedIndex, CboMedida.SelectedIndex, 1
               )

               , 2).ToString();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            lblAnswerPeso.Text = Math.Round(

               objCnvrsr.convertir(
                   double.Parse(txtPeso.Text), CboPeso1.SelectedIndex, CboPeso.SelectedIndex, 2
               )

               , 4).ToString();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            lblAnswerTemperatura.Text = Math.Round(

                  objCnvrsr.convertir(
                      double.Parse(txtTemperatura.Text), CboTemperatura1.SelectedIndex, CboTemperatura.SelectedIndex, 4
                  )

                  , 10).ToString();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            lblAnswerCantidad.Text = Math.Round(

                 objCnvrsr.convertir(
                     double.Parse(txtCantidad.Text), CboCantidad1.SelectedIndex, CboCantidad.SelectedIndex, 4
                 )

                 , 10).ToString();
        }
    }
}
