using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {

        double cus_sat = 5;//удовлетворенность клиентов
        double sal_rev = 5;//Доход официанта
        double income;
        double cost;
        double good_rating;
        double com_volume;//жаловаться на громкость
        double pri_str;//Ценовая стратегия
        double cou_exp;//Опыт клиентов
        double techtechnology;
        double cus_req;//запрос клиента
        double emp_sat;//удовлетворенности сотрудников
        double t, t1, t2, t3, t4, t5 , t6;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            techtechnology = (double)numericUpDown1.Value;
            cus_req = (double)numericUpDown2.Value;
            emp_sat = (double)numericUpDown3.Value;
            t = 0;
            t1 = 15;
            t2 = 20;
            t3 = 8;
            t4 = 6;
            t5 = 4;
            t6 = 20;
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            timer1.Start();
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            pri_str = t2 - cus_req;
            cou_exp = t3 - techtechnology;
            income = cus_sat / t5;
            good_rating = cou_exp / t4;
            com_volume = sal_rev / t6;
            cost = pri_str / t1;
            cus_sat = cus_sat + good_rating - com_volume;
            sal_rev = sal_rev + income - cost;
            chart1.Series[0].Points.AddXY(t, sal_rev);
            chart1.Series[1].Points.AddXY(t, cus_sat);
            if (cus_sat > 100000 || sal_rev > 100000)
            {
                timer1.Stop();
            }

        }
    }
}
