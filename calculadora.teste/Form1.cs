using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora.teste
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }
        int v1;
        int[] vx = new int[4];
        private void btnsoma_Click(object sender, EventArgs e)
        {
            if (vx[0] == 1)
            {
                v1 += Convert.ToInt32(txt1.Text);
                txt1.Clear();
            }
            else if (vx[1] == 1)
            {
                v1 -= Convert.ToInt32(txt1.Text);
                txt1.Clear();
            }
            else if (vx[2] == 1)
            {
                v1 *= Convert.ToInt32(txt1.Text);
                txt1.Clear();
            }
            else if (vx[3] == 1)
            {
                try
                {
                    v1 /= Convert.ToInt32(txt1.Text);
                    txt1.Clear();
                }
                catch
                {
                    txtr.Text = "valores incorretos";
                    txt1.Clear();
                }
            }
            else
            {
                v1 = Convert.ToInt32(txt1.Text);
                txt1.Clear();
            }
            vx[0] = 1;
            vx[1] = 0;
            vx[2] = 0;
            vx[3] = 0;
            txtr.Text = v1.ToString();
        }

        private void btnsub_Click(object sender, EventArgs e)
        {
            if (vx[0] == 1)
            {
                v1 += Convert.ToInt32(txt1.Text);
                txt1.Clear();
            }
            else if (vx[1] == 1)
            {
                v1 -= Convert.ToInt32(txt1.Text);
                txt1.Clear();
            }
            else if (vx[2] == 1)
            {
                v1 *= Convert.ToInt32(txt1.Text);
                txt1.Clear();
            }
            else if (vx[3] == 1)
            {
                try
                {
                    v1 /= Convert.ToInt32(txt1.Text);
                    txt1.Clear();
                }
                catch
                {
                    txtr.Text = "valores incorretos";
                    txt1.Clear();
                }
            }
            else
            {
                v1 = Convert.ToInt32(txt1.Text);
                txt1.Clear();
            }
            vx[0] = 0;
            vx[1] = 1;
            vx[2] = 0;
            vx[3] = 0;
            txtr.Text = v1.ToString();
        }

        private void btnmulti_Click(object sender, EventArgs e)
        {
            if (vx[0] == 1)
            {
                v1 += Convert.ToInt32(txt1.Text);
                txt1.Clear();
            }
            else if (vx[1] == 1)
            {
                v1 -= Convert.ToInt32(txt1.Text);
                txt1.Clear();
            }
            else if (vx[2] == 1)
            {
                v1 *= Convert.ToInt32(txt1.Text);
                txt1.Clear();
            }
            else if (vx[3] == 1)
            {
                try
                {
                    v1 /= Convert.ToInt32(txt1.Text);
                    txt1.Clear();
                }
                catch
                {
                    txtr.Text = "valores incorretos";
                    txt1.Clear();
                }
            }
            else
            {
                v1 = Convert.ToInt32(txt1.Text);
                txt1.Clear();
            }
            vx[0] = 0;
            vx[1] = 0;
            vx[2] = 1;
            vx[3] = 0;
            txtr.Text = v1.ToString();
        }

        private void btndivi_Click(object sender, EventArgs e)
        {
            if (vx[0] == 1)
            {
                v1 += Convert.ToInt32(txt1.Text);
                txt1.Clear();
            }
            else if (vx[1] == 1)
            {
                v1 -= Convert.ToInt32(txt1.Text);
                txt1.Clear();
            }
            else if (vx[2] == 1)
            {
                v1 *= Convert.ToInt32(txt1.Text);
                txt1.Clear();
            }
            else if (vx[3] == 1)
            {
                try
                {
                    v1 /= Convert.ToInt32(txt1.Text);
                    txt1.Clear();
                }
                catch
                {
                    txtr.Text = "valores incorretos";
                    txt1.Clear();
                }
            }
            else
            {
                v1 = Convert.ToInt32(txt1.Text);
                txt1.Clear();
            }
            vx[0] = 0;
            vx[1] = 0;
            vx[2] = 0;
            vx[3] = 1;
            txtr.Text = v1.ToString();
        }

        private void btnzero_Click(object sender, EventArgs e)
        {
            txt1.Text = "";
            v1 = 0;
            txtr.Text = "";
        }

        private void btnr_Click(object sender, EventArgs e)
        {
            if (vx[0] == 1)
            {
                v1 += Convert.ToInt32(txt1.Text);
                txt1.Clear();
            }
            else if (vx[1] == 1)
            {
                v1 -= Convert.ToInt32(txt1.Text);
                txt1.Clear();
            }
            else if (vx[2] == 1)
            {
                v1 *= Convert.ToInt32(txt1.Text);
                txt1.Clear();
            }
            else if (vx[3] == 1)
            {
                try
                {
                    v1 /= Convert.ToInt32(txt1.Text);
                    txt1.Clear();
                }
                catch
                {
                    txtr.Text = "valores incorretos";
                    txt1.Clear();
                }
            }
            else
            {
                v1 = Convert.ToInt32(txt1.Text);
                txt1.Clear();
            }
            vx[0] = 0;
            vx[1] = 0;
            vx[2] = 0;
            vx[3] = 0;
            txtr.Text = v1.ToString();
        }

        private void btnNumero_Click(object sender, EventArgs e)
        {
            var btn = ((Button)sender);
            if (isvalid())
                txt1.Text = txt1.Text + btn.Text;
        }

        private bool isvalid()
        {
            return !(txt1.TextLength > 8);
        }

        private void O(object sender, EventArgs e)
        {

        }
    }
}
