using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using UtilitairesSlam;

namespace PileWinformLibrary
{
    public partial class FrmConversion : Form
    {
        public FrmConversion()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            Int32 nbAConvertir = 0, Reste, quotien;
            Int16 NewBase = 0;
            string result;
            textBox3.Clear();

            try
            {
                nbAConvertir = Int32.Parse(textBox1.Text);
                NewBase = Int16.Parse(textBox2.Text);
                Pile Wonder;
                Wonder = new Pile(25);

                do
                {
                    quotien = nbAConvertir % NewBase;
                    Reste = nbAConvertir / NewBase;
                    nbAConvertir = Reste;
                    Pile.Empiler(Wonder, Convert.ToString(quotien));
                } while (Reste > 0);


                result = Pile.FormatResult(Pile.Depile(Wonder));
                textBox3.Text = result;


            }
            catch (OverflowException oex) {
                MessageBox.Show("Nombre trop grand");
            }
            catch (FormatException fex)
            {
                MessageBox.Show("Seuls les entiers sont autorisés");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
    
}
