using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanSoNangCao
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            tu1.Focus();
        }

        void PhepTinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            PhepTinh.Text = e.KeyChar.ToString();
            int Tu1 = int.Parse(tu1.Text);
            int Mau1 = int.Parse(mau1.Text);
            int Tu2 = int.Parse(tu2.Text);
            int Mau2 = int.Parse(mau2.Text);
            if(0 == Mau1 || 0 == Mau2)
            {
                MessageBox.Show("Phân số nhập không hợp lệ, vui lòng nhập lại");
                ResetTextBoxes();
                e.KeyChar = '\0';
                tu1.Focus();
                return;
            }    
            var phanSo1 = new PhanSo(Tu1, Mau1);
            var phanSo2 = new PhanSo(Tu2, Mau2);
            PhanSo ketqua = null;

            if (e.KeyChar == '+')
            {
                ketqua = phanSo1 + phanSo2;
            } else if (e.KeyChar ==  '-')
            {
                ketqua = phanSo1 - phanSo2;
            } else if (e.KeyChar == '*')
            {
                ketqua = phanSo1 * phanSo2;
            } else if (e.KeyChar == '/')
            {
                if(Tu2 == 0)
                {
                    MessageBox.Show("Phép tính không hợp lệ, vui lòng nhập lại");
                    ResetTextBoxes();
                    e.KeyChar = '\0';
                    tu1.Focus();
                    return;
                } else  
                ketqua = phanSo1 / phanSo2;
            } 
            if(ketqua.Mau < 0)
            {
                ketqua.Tu *= -1;
                ketqua.Mau *= -1;
            } 
            
            tukq.Text = ketqua.Tu.ToString();
            maukq.Text = ketqua.Mau.ToString();
            if(maukq.Text == "1")
            {
                MessageBox.Show("Kết quả của phép tính: " + tukq.Text);
            } else
            {
                MessageBox.Show("Kết quả của phép tính: " + tukq.Text + "/" + maukq.Text);
            }
            ResetTextBoxes();
            e.KeyChar = '\0';
            tu1.Focus();
        }

        private void ResetTextBoxes()
        {
            tu1.Text = "";
            mau1.Text = "";
            tu2.Text = "";
            mau2.Text = "";
            tukq.Text = "";
            maukq.Text = "";
        }

        private void tu1_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                mau1.Focus();
            }
        }

        private void mau1_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tu2.Focus();
            }
        }

        private void tu2_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                mau2.Focus();
            }
        }

        private void mau2_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PhepTinh.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class PhanSo
    {
        public int Tu { get; set; }
        public int Mau { get; set; }
        public PhanSo(int tu, int mau)
        {
            Tu = tu; Mau = mau;
        }

        private static int uscln(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);

            while (a != b)
            {
                if (a > b) a = a - b;
                else b = b - a;
                if (a == 0) return b;
                if (b == 0) return a;
            }
            return a;
        }

        private static void rutgon(ref int tuSo, ref int mauSo)
        {
            int ucln = uscln(tuSo, mauSo);
            tuSo /= ucln;
            mauSo /= ucln;
        }

        public static PhanSo operator +(PhanSo a, PhanSo b)
        {
            int tukq = a.Tu * b.Mau + a.Mau * b.Tu;
            int maukq = a.Mau * b.Mau;
            rutgon(ref tukq, ref maukq);
            return new PhanSo(tukq, maukq);
        }

        public static PhanSo operator -(PhanSo a, PhanSo b)
        {
            int tukq = a.Tu * b.Mau - a.Mau * b.Tu;
            int maukq = a.Mau * b.Mau;
            rutgon(ref tukq, ref maukq);
            return new PhanSo(tukq, maukq);
        }

        public static PhanSo operator *(PhanSo a, PhanSo b)
        {
            int tukq = a.Tu * b.Tu;
            int maukq = a.Mau * b.Mau;
            rutgon(ref tukq, ref maukq);
            return new PhanSo(tukq, maukq);
        }

        public static PhanSo operator /(PhanSo a, PhanSo b)
        {
            int tukq = a.Tu * b.Mau;
            int maukq = a.Mau * b.Tu;
            rutgon(ref tukq, ref maukq);
            return new PhanSo(tukq, maukq);
        }
    }
}
