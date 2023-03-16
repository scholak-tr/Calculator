using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            groupBox1.Visible = true;
            groupBox2.Visible = true;

            switch (comboBox1.SelectedIndex + 1)
            {

                case 1:
                    {
                        /*  double k1, k2;
                           k1 = Convert.ToDouble(textBox2.Text);
                           k2 = Convert.ToDouble(textBox3.Text); */
                        label3.Text = ("ax+b=0");
                        groupBox1.Visible = true;
                        label4.Visible = true;
                        label5.Visible = true;
                        coef_a.Visible = true;
                        coef_b.Visible = true;
                        label13.Visible = true;
                        _value0.Visible = true;
                        label3.Visible = true; break;

                    }
                case 2:
                    {
                        label3.Text = ("ax^2+bx+c=0");
                        label4.Visible = true;
                        label5.Visible = true;
                        label6.Visible = true;
                        coef_a.Visible = true;
                        coef_b.Visible = true;
                        coef_c.Visible = true;
                        _value1.Visible = true;
                        _value2.Visible = true;
                        label3.Visible = true;
                        label10.Visible = true;
                        label11.Visible = true;
                        break;
                    }
                case 3:
                    {
                        label3.Text = ("ax^3+bx^2+cx+d=0");
                        groupBox1.Visible = true;
                        label4.Visible = true;
                        label5.Visible = true;
                        label6.Visible = true;
                        label7.Visible = true;
                        coef_a.Visible = true;
                        coef_b.Visible = true;
                        coef_c.Visible = true;
                        coef_d.Visible = true;
                        // textBox5.Visible = true;
                        label2.Visible = true; break;
                    }

                case 4:
                    {
                        label3.Text = ("ax^4+bx^3+cx^2+dx+e=0");
                        groupBox1.Visible = true;
                        label4.Visible = true;
                        label5.Visible = true;
                        label6.Visible = true;
                        label7.Visible = true;
                        label8.Visible = true;
                        coef_b.Visible = true;
                        coef_c.Visible = true;
                        coef_d.Visible = true;
                        coef_e.Visible = true;
                        coef_f.Visible = true;
                        label2.Visible = true; break;
                    }

                case 5:
                    {
                        label2.Text = ("ax^5+bx^4+cx^3+dx^2+ex+f=0");
                        groupBox1.Visible = true;
                        label4.Visible = true;
                        label5.Visible = true;
                        label6.Visible = true;
                        label7.Visible = true;
                        label8.Visible = true;
                        label9.Visible = true;
                        coef_b.Visible = true;
                        coef_c.Visible = true;
                        coef_d.Visible = true;
                        coef_e.Visible = true;
                        coef_f.Visible = true;
                        //      textBox7.Visible = true;
                        label2.Visible = true; break;
                    }
              //     value = Convert.ToInt32(comboBox1.SelectedItem);

            }
        }
 
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                switch (Convert.ToInt32(comboBox1.SelectedItem))
                {
                    case 1:
                        {
                            int a, b;
                            if((int.TryParse(coef_a.Text, out a) && (int.TryParse(coef_b.Text, out b))))
                            {
                                var x = -b / a;
                                _value0.Text = x.ToString();
                            }
                            chart1.Series["Func"].Points.Clear();
                            int y;
                            for(int x=-10; x<=10;  x++)
                            {
                               y = Convert.ToInt32(coef_a.Text) * x + Convert.ToInt32(coef_b.Text);
                               chart1.Series["Func"].Points.AddXY(x, y);
                            }
                        }
                        break;
                    case 2:
                        {
                double a, b, c;
                if ((double.TryParse(coef_a.Text, out a) && (double.TryParse(coef_b.Text, out b) && (double.TryParse(coef_c.Text, out c)))))
                {
                    double discriminant = b * b - 4 * a * c;
                    //
                    // textBox1.Text = discriminant.ToString();
                    if (discriminant < 0)
                    {
                                    label10.Visible = false; label11.Visible = false; _value1.Visible = false; _value2.Visible = false; label12.Visible = true;
                                    label12.Text = "Дискриминант меньше нуля. \nКорней нет.";
                    }
                    else if (discriminant == 0)
                    {
                        double x = -b / (2 * a);
                        _value0.Text = x.ToString();         
                        // textBox11.Text = x.ToString();
                        label10.Visible = true;
                        label11.Visible = true;
                        _value1.Visible = true;
                        _value2.Visible = true;
                    }
                    else
                    {
                        double x1 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                        _value1.Text = x1.ToString();
                        double x2 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                        _value2.Text = x2.ToString();
                    }

                                chart1.Series["Func"].Points.Clear();
                                int y;
                                for (int x=-10; x<=10; x++)
                                {
                                    y = Convert.ToInt32(coef_a.Text) * x * x + Convert.ToInt32(coef_b.Text) * x + Convert.ToInt32(coef_c.Text);
                                    chart1.Series["Func"].Points.AddXY(x, y);
                                }
                }
            }
                        break;
                    case 3:
                        {
                            double a, b, c, d;
                            if ((double.TryParse(coef_a.Text, out a) && (double.TryParse(coef_b.Text, out b) && (double.TryParse(coef_c.Text, out c) && (double.TryParse(coef_d.Text, out d)))))) ;
       

                        }
                        break;
                    case 4:
                        {


                        }
                        break;
                }

            }           
            catch (FormatException)
            {
                MessageBox.Show("Ошибка формата", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LimitFuction lim = new LimitFuction();
            lim.ShowDialog();
        }
    }
}
