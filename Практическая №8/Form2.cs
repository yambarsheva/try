using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практическая__8
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double Xmin = double.Parse(textBox1.Text);
            double Xmax = double.Parse(textBox2.Text);
            double step = double.Parse(textBox3.Text);
            if (Xmin >= Xmax) MessageBox.Show("Введены некорректные данные");
            int count = (int)Math.Ceiling((Xmax - Xmin) / step);
            double[] x = new double[count];
            double[] y1 = new double[count];
            for (int i = 1; i <count; i++)
            {
                x[i] = Xmin + step * i;
                if (x[i]<-1) y1[i] =x[i]+1;
            else y1[i] = 1 - x[i];
            }
            chart1.Series[0].Points.DataBindXY(x, y1);

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            double Xmin = double.Parse(textBox1.Text);
            double Xmax = double.Parse(textBox2.Text);
            double step = double.Parse(textBox3.Text);
            if (Xmin >= Xmax) MessageBox.Show("Введены некорректные данные");
            int count = (int)Math.Ceiling((Xmax - Xmin) / step); 
            double[] x = new double[count];
            double[] y1 = new double[count];
            for (int i = 0; i < count; i++)
            {
                x[i] = Xmin + step * i;
                if (x[i] <= -4) y1[i] = Math.Pow(Math.E, (x[i] + 5));
                else if (x[i] > 3) y1[i] = Math.Sqrt(x[i] + 2);
                else y1[i] = Math.Pow(x[i], 3) + 10;
            }
            chart1.Series[0].Points.DataBindXY(x, y1);
           
        }
    }
}
