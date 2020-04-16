using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a ,n ,r ,an; 
            a = Convert.ToDouble(txtA1_1.Text);
            n = Convert.ToDouble(txtN_1.Text);
            r = Convert.ToDouble(txtR_1.Text);
            an = a + (n - 1) * r;
            txtAn_1.Text=Convert.ToString(an);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            double a, n, Sn, an;
            a = Convert.ToDouble(txtA1_2.Text);
            n = Convert.ToDouble(txtN_2.Text);
            an = Convert.ToDouble(txtAn_2.Text);
            Sn = ((a + an) / 2) * n;
            txtSn_2.Text = Convert.ToString(Sn);
        }

        private void butt3_Click(object sender, EventArgs e)
        {
            double a, n, Sn, r;
            a = Convert.ToDouble(txtA1_3.Text);
            n = Convert.ToDouble(txtN_3.Text);
            r = Convert.ToDouble(txtR_3.Text);
            Sn = ((2*a+(n-1)*r)/2)*n;
            txtSn_3.Text = Convert.ToString(Sn);
        }

        

        

        private void butt6_Click(object sender, EventArgs e)
        {
            double a, S, V,d;
            a = Convert.ToDouble(txtA_6.Text);
            
            S = 6*(a*a);
            V = a*a*a;
            d = a * Math.Sqrt(3);
            txtS_6.Text = Convert.ToString(S);
            txtV_6.Text = Convert.ToString(V);
            txtD_6.Text = Convert.ToString(d);
        }

        private void butt7_Click(object sender, EventArgs e)
        {
            double r, h, S, V;
            r = Convert.ToDouble(txtR_7.Text);
            h = Convert.ToDouble(txtH_7.Text);
            S = (2 * 3.14 * r)*(r + h);
            V = ((3.14) * (r*r)) * h;
            txtPc_7.Text = Convert.ToString(S);
            txtV_7.Text = Convert.ToString(V);

        }

       

        private void butt8_Click_1(object sender, EventArgs e)
        {
            double r, h, l, Pc, V;
            r = Convert.ToDouble(txtR_8.Text);
            h = Convert.ToDouble(txtH_8.Text);
            l = Math.Sqrt((h * h) + (r * r));
            Pc = (3.14 * (r * r)) * (3.14 * r * l);
            V = ((3.14 * (r * r)) * h) / 3;
            txtPc_8.Text = Convert.ToString(Pc);
            txtL_8.Text = Convert.ToString(l);
            txtV_8.Text = Convert.ToString(V);
        }

        private void buttczysc_Click(object sender, EventArgs e)
        {
            txtA_5.Clear();
            txtA_6.Clear();
            txtA1_1.Clear();
            txtA1_2.Clear();
            txtA1_3.Clear();
            txtAn_1.Clear();
            txtAn_2.Clear();
            txtAn_4.Clear();
            txtan1_4.Clear();
            txtan2_4.Clear();
            txtB_5.Clear();
            txtC_5.Clear();
            txtD_6.Clear();
            txtH_7.Clear();
            txtH_8.Clear();
            txtL_8.Clear();
            txtN_1.Clear();
            txtN_2.Clear();
            txtN_3.Clear();
            txtPc_7.Clear();
            txtPc_8.Clear();
            txtR_1.Clear();
            txtR_3.Clear();
            txtR_7.Clear();
            txtR_8.Clear();
            txtS_5.Clear();
            txtS_6.Clear();
            txtSn_2.Clear();
            txtSn_3.Clear();
            txtV_5.Clear();
            txtV_6.Clear();
            txtV_7.Clear();
            txtV_8.Clear();
            txtr1_9.Clear();
            txtr11_9.Clear();
            txtr12_9.Clear();
            txtr13_9.Clear();
            txtr2_9.Clear();
            txtr3_9.Clear();
            txtRz1_9.Clear();
            txtRz2_9.Clear();
        }

        private void butt4_Click_1(object sender, EventArgs e)
        {
            double a1, a2, an;
            a1 = Convert.ToDouble(txtan1_4.Text);
            a2 = Convert.ToDouble(txtan2_4.Text);
            an = (a1 + a2) / 2;
            txtAn_4.Text = Convert.ToString(an);
        }

        private void butt5_Click_1(object sender, EventArgs e)
        {
            double a, b, c, S, V;
            a = Convert.ToDouble(txtA_5.Text);
            b = Convert.ToDouble(txtB_5.Text);
            c = Convert.ToDouble(txtC_5.Text);
            S = (2 * (a * b)) + (2 * (a * c)) + (2 * (c * b));
            V = a * b * c;
            txtS_5.Text = Convert.ToString(S);
            txtV_5.Text = Convert.ToString(V);
        }

        private void butt1_9_Click(object sender, EventArgs e)
        {
            try
            {
                double r1, r2, r3, r;
                r1 = Convert.ToDouble(txtr1_9.Text);
                r2 = Convert.ToDouble(txtr2_9.Text);
                r3 = Convert.ToDouble(txtr3_9.Text);
                r = r1 + r2 + r3;
                txtRz1_9.Text = Convert.ToString(r);
            }
            catch (Exception ex)
            {
                string tekst = ex.Message;
                MessageBox.Show("Prosze Wypełnić poprawnie wszystkie pola   " + tekst, "ostrzeżenie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                MessageBox.Show("Prosze spróbowac ponownie ", "Informacja ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        

        private void butt2_9_Click(object sender, EventArgs e)
        {
            try
            {
                double r1, r2, r3, r;
                r1 = Convert.ToDouble(txtr11_9.Text);
                r2 = Convert.ToDouble(txtr12_9.Text);
                r3 = Convert.ToDouble(txtr13_9.Text);
                r = (1 / r1) + (1 / r2) + (1 / r3);
                txtRz2_9.Text = Convert.ToString(r);
            }
            catch (Exception ex)
            {
                string tekst = ex.Message;
                MessageBox.Show("Prosze Wypełnić poprawnie wszystkie pola   " + tekst, "ostrzeżenie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                MessageBox.Show("Prosze spróbowac ponownie ", "Informacja ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
