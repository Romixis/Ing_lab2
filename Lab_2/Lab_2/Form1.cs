using System;
using System.Windows.Forms;

namespace Lab_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label9.Text = "";
            label3.Text = "";

            label28.Text = "";
            label31.Text = "";

            label47.Text = "";
            label45.Text = "";

            label54.Text = "";
            label52.Text = "";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || comboBox2.SelectedIndex <= -1)
            {
                MessageBox.Show("Заполните все поля верно.", "Ошибка!");
            }
            else
            {
                if (comboBox2.SelectedIndex == 0)
                {
                    double a = 2.4;
                    double b = 1.05;
                    double c = 2.5;
                    double d = 0.38;

                    double PM = a * Math.Pow(Convert.ToDouble(textBox1.Text), b);
                    double TM = c * Math.Pow(PM, d);

                    label9.Text = Convert.ToString(PM);
                    label3.Text = Convert.ToString(TM);
                }
                if (comboBox2.SelectedIndex == 1)
                {
                    double a = 3;
                    double b = 1.12;
                    double c = 2.5;
                    double d = 0.35;

                    double PM = a * Math.Pow(Convert.ToDouble(textBox1.Text), b);
                    double TM = c * Math.Pow(PM, d);

                    label9.Text = Convert.ToString(PM);
                    label3.Text = Convert.ToString(TM);
                }
                if (comboBox2.SelectedIndex == 2)
                {
                    double a = 3.6;
                    double b = 1.20;
                    double c = 2.5;
                    double d = 0.32;

                    double PM = a * Math.Pow(Convert.ToDouble(textBox1.Text), b);
                    double TM = c * Math.Pow(PM, d);

                    label9.Text = Convert.ToString(PM);
                    label3.Text = Convert.ToString(TM);
                }
            }
        }

        // Первый экран генерация и очистка
        #region
        private void button5_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int v = rnd.Next(1, 101);
            textBox1.Text = Convert.ToString(v);

            comboBox2.SelectedIndex = rnd.Next(comboBox2.Items.Count);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            comboBox2.SelectedIndex = -1;
            textBox1.Text = "";
            label9.Text = "";
            label3.Text = "";
        }
        #endregion

        // Второй экран генерация и очистка
        #region
        private void button8_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int v = rnd.Next(1, 101);
            textBox2.Text = Convert.ToString(v);

            comboBox1.SelectedIndex = rnd.Next(comboBox1.Items.Count);

            comboBox3.SelectedIndex = rnd.Next(comboBox3.Items.Count);
            comboBox4.SelectedIndex = rnd.Next(comboBox4.Items.Count);
            comboBox5.SelectedIndex = rnd.Next(comboBox5.Items.Count);
            comboBox6.SelectedIndex = rnd.Next(comboBox6.Items.Count);
            comboBox7.SelectedIndex = rnd.Next(comboBox7.Items.Count);
            comboBox8.SelectedIndex = rnd.Next(comboBox8.Items.Count);
            comboBox9.SelectedIndex = rnd.Next(comboBox9.Items.Count);
            comboBox10.SelectedIndex = rnd.Next(comboBox10.Items.Count);
            comboBox11.SelectedIndex = rnd.Next(comboBox11.Items.Count);
            comboBox12.SelectedIndex = rnd.Next(comboBox12.Items.Count);
            comboBox13.SelectedIndex = rnd.Next(comboBox13.Items.Count);
            comboBox14.SelectedIndex = rnd.Next(comboBox14.Items.Count);
            comboBox15.SelectedIndex = rnd.Next(comboBox15.Items.Count);
            comboBox16.SelectedIndex = rnd.Next(comboBox16.Items.Count);
            comboBox17.SelectedIndex = rnd.Next(comboBox17.Items.Count);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            textBox2.Text = "";

            comboBox3.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;
            comboBox5.SelectedIndex = -1;
            comboBox6.SelectedIndex = -1;
            comboBox7.SelectedIndex = -1;
            comboBox8.SelectedIndex = -1;
            comboBox9.SelectedIndex = -1;
            comboBox10.SelectedIndex = -1;
            comboBox11.SelectedIndex = -1;
            comboBox12.SelectedIndex = -1;
            comboBox13.SelectedIndex = -1;
            comboBox14.SelectedIndex = -1;
            comboBox15.SelectedIndex = -1;
            comboBox16.SelectedIndex = -1;
            comboBox17.SelectedIndex = -1;

            label28.Text = "";
            label31.Text = "";
        }
        #endregion

        // Третий экран генерация и очистка
        #region
        private void button10_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int v = rnd.Next(1, 101);
            textBox3.Text = Convert.ToString(v);

            comboBox22.SelectedIndex = rnd.Next(comboBox22.Items.Count);
            comboBox21.SelectedIndex = rnd.Next(comboBox21.Items.Count);
            comboBox20.SelectedIndex = rnd.Next(comboBox20.Items.Count);
            comboBox19.SelectedIndex = rnd.Next(comboBox19.Items.Count);
            comboBox18.SelectedIndex = rnd.Next(comboBox18.Items.Count);

            comboBox29.SelectedIndex = rnd.Next(comboBox29.Items.Count);
            comboBox28.SelectedIndex = rnd.Next(comboBox28.Items.Count);
            comboBox27.SelectedIndex = rnd.Next(comboBox27.Items.Count);
            comboBox26.SelectedIndex = rnd.Next(comboBox26.Items.Count);
            comboBox25.SelectedIndex = rnd.Next(comboBox25.Items.Count);
            comboBox24.SelectedIndex = rnd.Next(comboBox24.Items.Count);
            comboBox23.SelectedIndex = rnd.Next(comboBox23.Items.Count);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            comboBox22.SelectedIndex = -1;
            comboBox21.SelectedIndex = -1;
            comboBox20.SelectedIndex = -1;
            comboBox19.SelectedIndex = -1;
            comboBox18.SelectedIndex = -1;

            comboBox29.SelectedIndex = -1;
            comboBox28.SelectedIndex = -1;
            comboBox27.SelectedIndex = -1;
            comboBox26.SelectedIndex = -1;
            comboBox25.SelectedIndex = -1;
            comboBox24.SelectedIndex = -1;
            comboBox23.SelectedIndex = -1;

            label47.Text = "";
            label45.Text = "";
        }
        #endregion

        // Четвёртый экран генерация и очистка
        #region
        private void button12_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int v = rnd.Next(1, 101);
            textBox4.Text = Convert.ToString(v);

            comboBox41.SelectedIndex = rnd.Next(comboBox41.Items.Count);
            comboBox40.SelectedIndex = rnd.Next(comboBox40.Items.Count);
            comboBox39.SelectedIndex = rnd.Next(comboBox39.Items.Count);
            comboBox38.SelectedIndex = rnd.Next(comboBox38.Items.Count);
            comboBox37.SelectedIndex = rnd.Next(comboBox37.Items.Count);

            comboBox36.SelectedIndex = rnd.Next(comboBox36.Items.Count);
            comboBox35.SelectedIndex = rnd.Next(comboBox35.Items.Count);
            comboBox34.SelectedIndex = rnd.Next(comboBox34.Items.Count);
            comboBox33.SelectedIndex = rnd.Next(comboBox33.Items.Count);
            comboBox32.SelectedIndex = rnd.Next(comboBox32.Items.Count);
            comboBox31.SelectedIndex = rnd.Next(comboBox31.Items.Count);

            comboBox30.SelectedIndex = rnd.Next(comboBox30.Items.Count);
            comboBox46.SelectedIndex = rnd.Next(comboBox46.Items.Count);
            comboBox45.SelectedIndex = rnd.Next(comboBox45.Items.Count);
            comboBox44.SelectedIndex = rnd.Next(comboBox44.Items.Count);
            comboBox43.SelectedIndex = rnd.Next(comboBox43.Items.Count);

            comboBox42.SelectedIndex = rnd.Next(comboBox42.Items.Count);
            comboBox50.SelectedIndex = rnd.Next(comboBox50.Items.Count);
            comboBox49.SelectedIndex = rnd.Next(comboBox49.Items.Count);
            comboBox48.SelectedIndex = rnd.Next(comboBox48.Items.Count);
            comboBox47.SelectedIndex = rnd.Next(comboBox47.Items.Count);
            comboBox51.SelectedIndex = rnd.Next(comboBox51.Items.Count);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";

            comboBox41.SelectedIndex = -1;
            comboBox40.SelectedIndex = -1;
            comboBox39.SelectedIndex = -1;
            comboBox38.SelectedIndex = -1;
            comboBox37.SelectedIndex = -1;

            comboBox36.SelectedIndex = -1;
            comboBox35.SelectedIndex = -1;
            comboBox34.SelectedIndex = -1;
            comboBox33.SelectedIndex = -1;
            comboBox32.SelectedIndex = -1;
            comboBox31.SelectedIndex = -1;

            comboBox30.SelectedIndex = -1;
            comboBox46.SelectedIndex = -1;
            comboBox45.SelectedIndex = -1;
            comboBox44.SelectedIndex = -1;
            comboBox43.SelectedIndex = -1;

            comboBox42.SelectedIndex = -1;
            comboBox50.SelectedIndex = -1;
            comboBox49.SelectedIndex = -1;
            comboBox48.SelectedIndex = -1;
            comboBox47.SelectedIndex = -1;
            comboBox51.SelectedIndex = -1;

            label47.Text = "";
            label45.Text = "";
        }
        #endregion

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || comboBox3.SelectedIndex <= -1 || comboBox1.SelectedIndex <= -1 || 
                comboBox4.SelectedIndex <= -1 || comboBox5.SelectedIndex <= -1 || comboBox6.SelectedIndex <= -1 || 
                comboBox7.SelectedIndex <= -1 || comboBox8.SelectedIndex <= -1 || comboBox9.SelectedIndex <= -1 || 
                comboBox10.SelectedIndex <= -1 || comboBox11.SelectedIndex <= -1 || comboBox12.SelectedIndex <= -1 || 
                comboBox13.SelectedIndex <= -1 || comboBox14.SelectedIndex <= -1 || comboBox15.SelectedIndex <= -1 || 
                comboBox16.SelectedIndex <= -1 || comboBox17.SelectedIndex <= -1)
            {
                MessageBox.Show("Заполните все поля верно.", "Ошибка!"); 
            }
            else
            {
                double indicator1 = 0;
                double indicator2 = 0;
                double indicator3 = 0;
                double indicator4 = 0;
                double indicator5 = 0;
                double indicator6 = 0;
                double indicator7 = 0;
                double indicator8 = 0;
                double indicator9 = 0;
                double indicator10 = 0;
                double indicator11 = 0;
                double indicator12 = 0;
                double indicator13 = 0;
                double indicator14 = 0;
                double indicator15 = 0;

                // Указываем значения под каждое
                #region
                if (comboBox3.SelectedIndex == 0)
                {
                    indicator1 = 0.75;
                }
                if (comboBox3.SelectedIndex == 1)
                {
                    indicator1 = 0.88;
                }
                if (comboBox3.SelectedIndex == 2)
                {
                    indicator1 = 1;
                }
                if (comboBox3.SelectedIndex == 3)
                {
                    indicator1 = 1.15;
                }
                if (comboBox3.SelectedIndex == 4)
                {
                    indicator1 = 1.4;
                }
                if (comboBox3.SelectedIndex == 5)
                {
                    indicator1 = 1;
                }
                if (comboBox4.SelectedIndex == 0)
                {
                    indicator2 = 1;
                }
                if (comboBox4.SelectedIndex == 1)
                {
                    indicator2 = 0.94;
                }
                if (comboBox4.SelectedIndex == 2)
                {
                    indicator2 = 1;
                }
                if (comboBox4.SelectedIndex == 3)
                {
                    indicator2 = 1.08;
                }
                if (comboBox4.SelectedIndex == 4)
                {
                    indicator2 = 1.16;
                }
                if (comboBox4.SelectedIndex == 5)
                {
                    indicator2 = 1;
                }

                if (comboBox5.SelectedIndex == 0)
                {
                    indicator3 = 0.7;
                }
                if (comboBox5.SelectedIndex == 1)
                {
                    indicator3 = 0.85;
                }
                if (comboBox5.SelectedIndex == 2)
                {
                    indicator3 = 1;
                }
                if (comboBox5.SelectedIndex == 3)
                {
                    indicator3 = 1.15;
                }
                if (comboBox5.SelectedIndex == 4)
                {
                    indicator3 = 1.3;
                }
                if (comboBox5.SelectedIndex == 5)
                {
                    indicator3 = 1.65;
                }

                if (comboBox6.SelectedIndex == 0)
                {
                    indicator4 = 1;
                }
                if (comboBox6.SelectedIndex == 1)
                {
                    indicator4 = 1;
                }
                if (comboBox6.SelectedIndex == 2)
                {
                    indicator4 = 1;
                }
                if (comboBox6.SelectedIndex == 3)
                {
                    indicator4 = 1.11;
                }
                if (comboBox6.SelectedIndex == 4)
                {
                    indicator4 = 1.3;
                }
                if (comboBox6.SelectedIndex == 5)
                {
                    indicator4 = 1.66;
                }

                if (comboBox7.SelectedIndex == 0)
                {
                    indicator5 = 1;
                }
                if (comboBox7.SelectedIndex == 1)
                {
                    indicator5 = 1;
                }
                if (comboBox7.SelectedIndex == 2)
                {
                    indicator5 = 1;
                }
                if (comboBox7.SelectedIndex == 3)
                {
                    indicator5 = 1.06;
                }
                if (comboBox7.SelectedIndex == 4)
                {
                    indicator5 = 1.21;
                }
                if (comboBox7.SelectedIndex == 5)
                {
                    indicator5 = 1.56;
                }

                if (comboBox8.SelectedIndex == 0)
                {
                    indicator6 = 1;
                }
                if (comboBox8.SelectedIndex == 1)
                {
                    indicator6 = 0.87;
                }
                if (comboBox8.SelectedIndex == 2)
                {
                    indicator6 = 1;
                }
                if (comboBox8.SelectedIndex == 3)
                {
                    indicator6 = 1.15;
                }
                if (comboBox8.SelectedIndex == 4)
                {
                    indicator6 = 1.3;
                }
                if (comboBox8.SelectedIndex == 5)
                {
                    indicator6 = 1;
                }

                if (comboBox9.SelectedIndex == 0)
                {
                    indicator7 = 1;
                }
                if (comboBox9.SelectedIndex == 1)
                {
                    indicator7 = 0.87;
                }
                if (comboBox9.SelectedIndex == 2)
                {
                    indicator7 = 1;
                }
                if (comboBox9.SelectedIndex == 3)
                {
                    indicator7 = 1.07;
                }
                if (comboBox9.SelectedIndex == 4)
                {
                    indicator7 = 1.15;
                }
                if (comboBox9.SelectedIndex == 5)
                {
                    indicator7 = 1;
                }

                if (comboBox10.SelectedIndex == 0)
                {
                    indicator8 = 1.46;
                }
                if (comboBox10.SelectedIndex == 1)
                {
                    indicator8 = 1.19;
                }
                if (comboBox10.SelectedIndex == 2)
                {
                    indicator8 = 1;
                }
                if (comboBox10.SelectedIndex == 3)
                {
                    indicator8 = 0.86;
                }
                if (comboBox10.SelectedIndex == 4)
                {
                    indicator8 = 0.71;
                }
                if (comboBox10.SelectedIndex == 5)
                {
                    indicator8 = 1;
                }

                if (comboBox11.SelectedIndex == 0)
                {
                    indicator9 = 1.29;
                }
                if (comboBox11.SelectedIndex == 1)
                {
                    indicator9 = 1.13;
                }
                if (comboBox11.SelectedIndex == 2)
                {
                    indicator9 = 1;
                }
                if (comboBox11.SelectedIndex == 3)
                {
                    indicator9 = 0.91;
                }
                if (comboBox11.SelectedIndex == 4)
                {
                    indicator9 = 0.82;
                }
                if (comboBox11.SelectedIndex == 5)
                {
                    indicator9 = 1;
                }

                if (comboBox12.SelectedIndex == 0)
                {
                    indicator10 = 1.42;
                }
                if (comboBox12.SelectedIndex == 1)
                {
                    indicator10 = 1.17;
                }
                if (comboBox12.SelectedIndex == 2)
                {
                    indicator10 = 1;
                }
                if (comboBox12.SelectedIndex == 3)
                {
                    indicator10 = 0.86;
                }
                if (comboBox12.SelectedIndex == 4)
                {
                    indicator10 = 0.7;
                }
                if (comboBox12.SelectedIndex == 5)
                {
                    indicator10 = 1;
                }

                if (comboBox13.SelectedIndex == 0)
                {
                    indicator11 = 1.21;
                }
                if (comboBox13.SelectedIndex == 1)
                {
                    indicator11 = 1.10;
                }
                if (comboBox13.SelectedIndex == 2)
                {
                    indicator11 = 1;
                }
                if (comboBox13.SelectedIndex == 3)
                {
                    indicator11 = 0.9;
                }
                if (comboBox13.SelectedIndex == 4)
                {
                    indicator11 = 1;
                }
                if (comboBox13.SelectedIndex == 5)
                {
                    indicator11 = 1;
                }

                if (comboBox14.SelectedIndex == 0)
                {
                    indicator12 = 1.14;
                }
                if (comboBox14.SelectedIndex == 1)
                {
                    indicator12 = 1.07;
                }
                if (comboBox14.SelectedIndex == 2)
                {
                    indicator12 = 1;
                }
                if (comboBox14.SelectedIndex == 3)
                {
                    indicator12 = 0.95;
                }
                if (comboBox14.SelectedIndex == 4)
                {
                    indicator12 = 1;
                }
                if (comboBox14.SelectedIndex == 5)
                {
                    indicator12 = 1;
                }

                if (comboBox15.SelectedIndex == 0)
                {
                    indicator13 = 1.24;
                }
                if (comboBox15.SelectedIndex == 1)
                {
                    indicator13 = 1.1;
                }
                if (comboBox15.SelectedIndex == 2)
                {
                    indicator13 = 1;
                }
                if (comboBox15.SelectedIndex == 3)
                {
                    indicator13 = 0.91;
                }
                if (comboBox15.SelectedIndex == 4)
                {
                    indicator13 = 0.82;
                }
                if (comboBox15.SelectedIndex == 5)
                {
                    indicator13 = 1;
                }

                if (comboBox16.SelectedIndex == 0)
                {
                    indicator14 = 1.24;
                }
                if (comboBox16.SelectedIndex == 1)
                {
                    indicator14 = 1.1;
                }
                if (comboBox16.SelectedIndex == 2)
                {
                    indicator14 = 1;
                }
                if (comboBox16.SelectedIndex == 3)
                {
                    indicator14 = 0.91;
                }
                if (comboBox16.SelectedIndex == 4)
                {
                    indicator14 = 0.83;
                }
                if (comboBox16.SelectedIndex == 5)
                {
                    indicator14 = 1;
                }

                if (comboBox17.SelectedIndex == 0)
                {
                    indicator15 = 1.23;
                }
                if (comboBox17.SelectedIndex == 1)
                {
                    indicator15 = 1.08;
                }
                if (comboBox17.SelectedIndex == 2)
                {
                    indicator15 = 1;
                }
                if (comboBox17.SelectedIndex == 3)
                {
                    indicator15 = 1.04;
                }
                if (comboBox17.SelectedIndex == 4)
                {
                    indicator15 = 1.1;
                }
                if (comboBox17.SelectedIndex == 5)
                {
                    indicator15 = 1;
                }
                #endregion

                // Расчёты
                if (comboBox1.SelectedIndex == 0)
                {
                    double a = 3.2;
                    double b = 1.05;
                    double c = 2.5;
                    double d = 0.38;

                    double EAF = indicator1 * indicator2 * indicator3 * indicator4 * indicator5 * 
					indicator6 * indicator7 * indicator8 * indicator9 * indicator10 * indicator11 * 
					indicator12 * indicator13 * indicator14 * indicator15;
					
                    double PM = EAF * a * Math.Pow(Convert.ToDouble(textBox2.Text), b);
                    //double TM = c * Math.Pow(PM, d);
                    label28.Text = Convert.ToString(PM);
                    //label31.Text = Convert.ToString(TM);
                }

                if (comboBox1.SelectedIndex == 1)
                {
                    double a = 3;
                    double b = 1.12;
                    double c = 2.5;
                    double d = 0.35;

                    double EAF = indicator1 * indicator2 * indicator3 * indicator4 * indicator5 * 
					indicator6 * indicator7 * indicator8 * indicator9 * indicator10 * indicator11 * 
					indicator12 * indicator13 * indicator14 * indicator15;
					
                    double PM = EAF * a * Math.Pow(Convert.ToDouble(textBox2.Text), b);
                    //double TM = c * Math.Pow(PM, d);
                    label28.Text = Convert.ToString(PM);
                    //label31.Text = Convert.ToString(TM);
                }

                if (comboBox1.SelectedIndex == 2)
                {
                    double a = 2.8;
                    double b = 1.2;
                    double c = 2.5;
                    double d = 0.32;

                    double EAF = indicator1 * indicator2 * indicator3 * indicator4 * indicator5 * 
					indicator6 * indicator7 * indicator8 * indicator9 * indicator10 * indicator11 * 
					indicator12 * indicator13 * indicator14 * indicator15;
					
                    double PM = EAF * a * Math.Pow(Convert.ToDouble(textBox2.Text), b);
                    //double TM = c * Math.Pow(PM, d);
                    label28.Text = Convert.ToString(PM);
                    //label31.Text = Convert.ToString(TM);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "" || comboBox18.SelectedIndex <= -1 || comboBox19.SelectedIndex <= -1 || 
                comboBox20.SelectedIndex <= -1 || comboBox21.SelectedIndex <= -1 || comboBox22.SelectedIndex <= -1 || 
                comboBox23.SelectedIndex <= -1 || comboBox24.SelectedIndex <= -1 || comboBox25.SelectedIndex <= -1 || 
                comboBox26.SelectedIndex <= -1 || comboBox27.SelectedIndex <= -1 || comboBox28.SelectedIndex <= -1 || 
                comboBox29.SelectedIndex <= -1)
            {
                MessageBox.Show("Заполните все поля верно.", "Ошибка!");
            }

            else
            {
                double A = 2.94;
                double B = 0.91;

                double index1 = 0;
                double index2 = 0;
                double index3 = 0;
                double index4 = 0;
                double index5 = 0;

                double indexes1 = 0;
                double indexes2 = 0;
                double indexes3 = 0;
                double indexes4 = 0;
                double indexes5 = 0;
                double indexes6 = 0;
                double indexes7 = 0;

                // Указываем значения под каждое
                #region
                if (comboBox22.SelectedIndex == 0)
                {
                    index1 = 6.20;
                }
                if (comboBox22.SelectedIndex == 1)
                {
                    index1 = 4.96;
                }
                if (comboBox22.SelectedIndex == 2)
                {
                    index1 = 3.72;
                }
                if (comboBox22.SelectedIndex == 3)
                {
                    index1 = 2.48;
                }
                if (comboBox22.SelectedIndex == 4)
                {
                    index1 = 1.24;
                }
                if (comboBox22.SelectedIndex == 5)
                {
                    index1 = 0;
                }
				
                if (comboBox21.SelectedIndex == 0)
                {
                    index2 = 5.07;
                }
                if (comboBox21.SelectedIndex == 1)
                {
                    index2 = 4.05;
                }
                if (comboBox21.SelectedIndex == 2)
                {
                    index2 = 3.04;
                }
                if (comboBox21.SelectedIndex == 3)
                {
                    index2 = 2.03;
                }
                if (comboBox21.SelectedIndex == 4)
                {
                    index2 = 1.01;
                }
                if (comboBox21.SelectedIndex == 5)
                {
                    index2 = 0;
                }

                if (comboBox20.SelectedIndex == 0)
                {
                    index3 = 7.07;
                }
                if (comboBox20.SelectedIndex == 1)
                {
                    index3 = 5.65;
                }
                if (comboBox20.SelectedIndex == 2)
                {
                    index3 = 4.24;
                }
                if (comboBox20.SelectedIndex == 3)
                {
                    index3 = 2.83;
                }
                if (comboBox20.SelectedIndex == 4)
                {
                    index3 = 1.41;
                }
                if (comboBox20.SelectedIndex == 5)
                {
                    index3 = 0;
                }

                if (comboBox19.SelectedIndex == 0)
                {
                    index4 = 5.48;
                }
                if (comboBox19.SelectedIndex == 1)
                {
                    index4 = 4.38;
                }
                if (comboBox19.SelectedIndex == 2)
                {
                    index4 = 3.29;
                }
                if (comboBox19.SelectedIndex == 3)
                {
                    index4 = 2.19;
                }
                if (comboBox19.SelectedIndex == 4)
                {
                    index4 = 1.1;
                }
                if (comboBox19.SelectedIndex == 5)
                {
                    index4 = 0;
                }

                if (comboBox18.SelectedIndex == 0)
                {
                    index5 = 7.8;
                }
                if (comboBox18.SelectedIndex == 1)
                {
                    index5 = 6.24;
                }
                if (comboBox18.SelectedIndex == 2)
                {
                    index5 = 4.68;
                }
                if (comboBox18.SelectedIndex == 3)
                {
                    index5 = 3.12;
                }
                if (comboBox18.SelectedIndex == 4)
                {
                    index5 = 1.56;
                }
                if (comboBox18.SelectedIndex == 5)
                {
                    index5 = 0;
                }

                if (comboBox29.SelectedIndex == 0)
                {
                    indexes1 = 2.12;
                }
                if (comboBox29.SelectedIndex == 1)
                {
                    indexes1 = 1.62;
                }
                if (comboBox29.SelectedIndex == 2)
                {
                    indexes1 = 1.26;
                }
                if (comboBox29.SelectedIndex == 3)
                {
                    indexes1 = 1;
                }
                if (comboBox29.SelectedIndex == 4)
                {
                    indexes1 = 0.83;
                }
                if (comboBox29.SelectedIndex == 5)
                {
                    indexes1 = 0.63;
                }
                if (comboBox29.SelectedIndex == 5)
                {
                    indexes1 = 0.5;
                }

                if (comboBox28.SelectedIndex == 0)
                {
                    indexes2 = 1.59;
                }
                if (comboBox28.SelectedIndex == 1)
                {
                    indexes2 = 1.33;
                }
                if (comboBox28.SelectedIndex == 2)
                {
                    indexes2 = 1.22;
                }
                if (comboBox28.SelectedIndex == 3)
                {
                    indexes2 = 1;
                }
                if (comboBox28.SelectedIndex == 4)
                {
                    indexes2 = 0.87;
                }
                if (comboBox28.SelectedIndex == 5)
                {
                    indexes2 = 0.74;
                }
                if (comboBox28.SelectedIndex == 5)
                {
                    indexes2 = 0.62;
                }

                if (comboBox27.SelectedIndex == 0)
                {
                    indexes3 = 0.49;
                }
                if (comboBox27.SelectedIndex == 1)
                {
                    indexes3 = 0.6;
                }
                if (comboBox27.SelectedIndex == 2)
                {
                    indexes3 = 0.83;
                }
                if (comboBox27.SelectedIndex == 3)
                {
                    indexes3 = 1;
                }
                if (comboBox27.SelectedIndex == 4)
                {
                    indexes3 = 1.33;
                }
                if (comboBox27.SelectedIndex == 5)
                {
                    indexes3 = 1.91;
                }
                if (comboBox27.SelectedIndex == 5)
                {
                    indexes3 = 2.72;
                }

                if (comboBox26.SelectedIndex == 0)
                {
                    indexes4 = 1;
                }
                if (comboBox26.SelectedIndex == 1)
                {
                    indexes4 = 1;
                }
                if (comboBox26.SelectedIndex == 2)
                {
                    indexes4 = 0.95;
                }
                if (comboBox26.SelectedIndex == 3)
                {
                    indexes4 = 1;
                }
                if (comboBox26.SelectedIndex == 4)
                {
                    indexes4 = 1.07;
                }
                if (comboBox26.SelectedIndex == 5)
                {
                    indexes4 = 1.15;
                }
                if (comboBox26.SelectedIndex == 5)
                {
                    indexes4 = 1.24;
                }

                if (comboBox25.SelectedIndex == 0)
                {
                    indexes5 = 1;
                }
                if (comboBox25.SelectedIndex == 1)
                {
                    indexes5 = 1;
                }
                if (comboBox25.SelectedIndex == 2)
                {
                    indexes5 = 0.87;
                }
                if (comboBox25.SelectedIndex == 3)
                {
                    indexes5 = 1;
                }
                if (comboBox25.SelectedIndex == 4)
                {
                    indexes5 = 1.29;
                }
                if (comboBox25.SelectedIndex == 5)
                {
                    indexes5 = 1.81;
                }
                if (comboBox25.SelectedIndex == 5)
                {
                    indexes5 = 2.61;
                }

                if (comboBox24.SelectedIndex == 0)
                {
                    indexes6 = 1.43;
                }
                if (comboBox24.SelectedIndex == 1)
                {
                    indexes6 = 1.3;
                }
                if (comboBox24.SelectedIndex == 2)
                {
                    indexes6 = 1.1;
                }
                if (comboBox24.SelectedIndex == 3)
                {
                    indexes6 = 1;
                }
                if (comboBox24.SelectedIndex == 4)
                {
                    indexes6 = 0.87;
                }
                if (comboBox24.SelectedIndex == 5)
                {
                    indexes6 = 0.73;
                }
                if (comboBox24.SelectedIndex == 5)
                {
                    indexes6 = 0.62;
                }

                if (comboBox23.SelectedIndex == 0)
                {
                    indexes7 = 1;
                }
                if (comboBox23.SelectedIndex == 1)
                {
                    indexes7 = 1.43;
                }
                if (comboBox23.SelectedIndex == 2)
                {
                    indexes7 = 1.14;
                }
                if (comboBox23.SelectedIndex == 3)
                {
                    indexes7 = 1;
                }
                if (comboBox23.SelectedIndex == 4)
                {
                    indexes7 = 1;
                }
                if (comboBox23.SelectedIndex == 5)
                {
                    indexes7 = 1;
                }
                if (comboBox23.SelectedIndex == 5)
                {
                    indexes7 = 1;
                }
                #endregion

                double SF = index1 + index2 + index3 + index4 + index5;
                double EAF = indexes1 * indexes2 * indexes3 * indexes4 * indexes5 * indexes6 * indexes7;

                double EPS = B + 0.01 * SF;
                double PM = EAF * A * Math.Pow(Convert.ToDouble(textBox3.Text), EPS);

                double C = 3.67;
                double D = 0.28;
                double EAF2 = indexes1 * indexes2 * indexes3 * indexes4 * indexes5 * indexes6;
                double PM2 = EAF2 * A * Math.Pow(Convert.ToDouble(textBox3.Text), EPS);
                double TM = indexes7 * C * Math.Pow(PM2, D+0.2*(EPS - B));
				
                label47.Text = Convert.ToString(PM);
                label45.Text = Convert.ToString(TM);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "" || comboBox30.SelectedIndex <= -1 || comboBox31.SelectedIndex <= -1 || 
                comboBox32.SelectedIndex <= -1 || comboBox33.SelectedIndex <= -1 || comboBox34.SelectedIndex <= -1 || 
                comboBox35.SelectedIndex <= -1 || comboBox36.SelectedIndex <= -1 || comboBox37.SelectedIndex <= -1 || 
                comboBox38.SelectedIndex <= -1 || comboBox39.SelectedIndex <= -1 || comboBox40.SelectedIndex <= -1 || 
                comboBox41.SelectedIndex <= -1 || comboBox42.SelectedIndex <= -1 || comboBox43.SelectedIndex <= -1 || 
                comboBox44.SelectedIndex <= -1 || comboBox45.SelectedIndex <= -1 || comboBox46.SelectedIndex <= -1 || 
                comboBox47.SelectedIndex <= -1 || comboBox48.SelectedIndex <= -1 || comboBox49.SelectedIndex <= -1 || 
                comboBox50.SelectedIndex <= -1 || comboBox51.SelectedIndex <= -1)
            {
                MessageBox.Show("Заполните все поля верно.", "Ошибка!");         
            }
            else
            {
                double A = 2.45;
                double B = 0.91;

                double index1 = 0;
                double index2 = 0;
                double index3 = 0;
                double index4 = 0;
                double index5 = 0;

                double indexes1 = 0;
                double indexes2 = 0;
                double indexes3 = 0;
                double indexes4 = 0;
                double indexes5 = 0;
                double indexes6 = 0;
                double indexes7 = 0;
                double indexes8 = 0;
                double indexes9 = 0;
                double indexes10 = 0;
                double indexes11 = 0;
                double indexes12 = 0;
                double indexes13 = 0;
                double indexes14 = 0;
                double indexes15 = 0;
                double indexes16 = 0;
                double indexes17 = 0;

                // Указываем значения под каждое
                #region
                // 1 показатель
                if (comboBox41.SelectedIndex == 0)
                {
                    index1 = 6.20;
                }
                if (comboBox41.SelectedIndex == 1)
                {
                    index1 = 4.96;
                }
                if (comboBox41.SelectedIndex == 2)
                {
                    index1 = 3.72;
                }
                if (comboBox41.SelectedIndex == 3)
                {
                    index1 = 2.48;
                }
                if (comboBox41.SelectedIndex == 4)
                {
                    index1 = 1.24;
                }
                if (comboBox41.SelectedIndex == 5)
                {
                    index1 = 0;
                }
                // 2 показатель
                if (comboBox40.SelectedIndex == 0)
                {
                    index2 = 5.07;
                }
                if (comboBox40.SelectedIndex == 1)
                {
                    index2 = 4.05;
                }
                if (comboBox40.SelectedIndex == 2)
                {
                    index2 = 3.04;
                }
                if (comboBox40.SelectedIndex == 3)
                {
                    index2 = 2.03;
                }
                if (comboBox40.SelectedIndex == 4)
                {
                    index2 = 1.01;
                }
                if (comboBox40.SelectedIndex == 5)
                {
                    index2 = 0;
                }
                // 3 показатель
                if (comboBox39.SelectedIndex == 0)
                {
                    index3 = 7.07;
                }
                if (comboBox39.SelectedIndex == 1)
                {
                    index3 = 5.65;
                }
                if (comboBox39.SelectedIndex == 2)
                {
                    index3 = 4.24;
                }
                if (comboBox39.SelectedIndex == 3)
                {
                    index3 = 2.83;
                }
                if (comboBox39.SelectedIndex == 4)
                {
                    index3 = 1.41;
                }
                if (comboBox39.SelectedIndex == 5)
                {
                    index3 = 0;
                }

                if (comboBox38.SelectedIndex == 0)
                {
                    index4 = 5.48;
                }
                if (comboBox38.SelectedIndex == 1)
                {
                    index4 = 4.38;
                }
                if (comboBox38.SelectedIndex == 2)
                {
                    index4 = 3.29;
                }
                if (comboBox38.SelectedIndex == 3)
                {
                    index4 = 2.19;
                }
                if (comboBox38.SelectedIndex == 4)
                {
                    index4 = 1.1;
                }
                if (comboBox38.SelectedIndex == 5)
                {
                    index4 = 0;
                }

                if (comboBox37.SelectedIndex == 0)
                {
                    index5 = 7.8;
                }
                if (comboBox37.SelectedIndex == 1)
                {
                    index5 = 6.24;
                }
                if (comboBox37.SelectedIndex == 2)
                {
                    index5 = 4.68;
                }
                if (comboBox37.SelectedIndex == 3)
                {
                    index5 = 3.12;
                }
                if (comboBox37.SelectedIndex == 4)
                {
                    index5 = 1.56;
                }
                if (comboBox37.SelectedIndex == 5)
                {
                    index5 = 0;
                }

                if (comboBox36.SelectedIndex == 0)
                {
                    indexes1 = 1.42;
                }
                if (comboBox36.SelectedIndex == 1)
                {
                    indexes1 = 1.29;
                }
                if (comboBox36.SelectedIndex == 2)
                {
                    indexes1 = 1;
                }
                if (comboBox36.SelectedIndex == 3)
                {
                    indexes1 = 0.85;
                }
                if (comboBox36.SelectedIndex == 4)
                {
                    indexes1 = 0.71;
                }
                if (comboBox36.SelectedIndex == 5)
                {
                    indexes1 = 1;
                }

                if (comboBox35.SelectedIndex == 0)
                {
                    indexes2 = 1.22;
                }
                if (comboBox35.SelectedIndex == 1)
                {
                    indexes2 = 1.1;
                }
                if (comboBox35.SelectedIndex == 2)
                {
                    indexes2 = 1;
                }
                if (comboBox35.SelectedIndex == 3)
                {
                    indexes2 = 0.88;
                }
                if (comboBox35.SelectedIndex == 4)
                {
                    indexes2 = 0.81;
                }
                if (comboBox35.SelectedIndex == 5)
                {
                    indexes2 = 1;
                }

                if (comboBox34.SelectedIndex == 0)
                {
                    indexes3 = 1.34;
                }
                if (comboBox34.SelectedIndex == 1)
                {
                    indexes3 = 1.15;
                }
                if (comboBox34.SelectedIndex == 2)
                {
                    indexes3 = 1;
                }
                if (comboBox34.SelectedIndex == 3)
                {
                    indexes3 = 0.88;
                }
                if (comboBox34.SelectedIndex == 4)
                {
                    indexes3 = 0.76;
                }
                if (comboBox34.SelectedIndex == 5)
                {
                    indexes3 = 1;
                }

                if (comboBox33.SelectedIndex == 0)
                {
                    indexes4 = 1.29;
                }
                if (comboBox33.SelectedIndex == 1)
                {
                    indexes4 = 1.12;
                }
                if (comboBox33.SelectedIndex == 2)
                {
                    indexes4 = 1;
                }
                if (comboBox33.SelectedIndex == 3)
                {
                    indexes4 = 0.9;
                }
                if (comboBox33.SelectedIndex == 4)
                {
                    indexes4 = 0.81;
                }
                if (comboBox33.SelectedIndex == 5)
                {
                    indexes4 = 1;
                }

                if (comboBox32.SelectedIndex == 0)
                {
                    indexes5 = 1.19;
                }
                if (comboBox32.SelectedIndex == 1)
                {
                    indexes5 = 1.09;
                }
                if (comboBox32.SelectedIndex == 2)
                {
                    indexes5 = 1;
                }
                if (comboBox32.SelectedIndex == 3)
                {
                    indexes5 = 0.91;
                }
                if (comboBox32.SelectedIndex == 4)
                {
                    indexes5 = 0.85;
                }
                if (comboBox32.SelectedIndex == 5)
                {
                    indexes5 = 1;
                }

                if (comboBox31.SelectedIndex == 0)
                {
                    indexes6 = 1.2;
                }
                if (comboBox31.SelectedIndex == 1)
                {
                    indexes6 = 1.09;
                }
                if (comboBox31.SelectedIndex == 2)
                {
                    indexes6 = 1;
                }
                if (comboBox31.SelectedIndex == 3)
                {
                    indexes6 = 0.91;
                }
                if (comboBox31.SelectedIndex == 4)
                {
                    indexes6 = 0.84;
                }
                if (comboBox31.SelectedIndex == 5)
                {
                    indexes6 = 1;
                }

                if (comboBox30.SelectedIndex == 0)
                {
                    indexes7 = 0.84;
                }
                if (comboBox30.SelectedIndex == 1)
                {
                    indexes7 = 0.92;
                }
                if (comboBox30.SelectedIndex == 2)
                {
                    indexes7 = 1;
                }
                if (comboBox30.SelectedIndex == 3)
                {
                    indexes7 = 1.1;
                }
                if (comboBox30.SelectedIndex == 4)
                {
                    indexes7 = 1.26;
                }
                if (comboBox30.SelectedIndex == 5)
                {
                    indexes7 = 1;
                }

                if (comboBox46.SelectedIndex == 0)
                {
                    indexes8 = 1;
                }
                if (comboBox46.SelectedIndex == 1)
                {
                    indexes8 = 0.23;
                }
                if (comboBox46.SelectedIndex == 2)
                {
                    indexes8 = 1;
                }
                if (comboBox46.SelectedIndex == 3)
                {
                    indexes8 = 1.14;
                }
                if (comboBox46.SelectedIndex == 4)
                {
                    indexes8 = 1.28;
                }
                if (comboBox46.SelectedIndex == 5)
                {
                    indexes8 = 1;
                }

                if (comboBox45.SelectedIndex == 0)
                {
                    indexes9 = 0.73;
                }
                if (comboBox45.SelectedIndex == 1)
                {
                    indexes9 = 0.87;
                }
                if (comboBox45.SelectedIndex == 2)
                {
                    indexes9 = 1;
                }
                if (comboBox45.SelectedIndex == 3)
                {
                    indexes9 = 1.17;
                }
                if (comboBox45.SelectedIndex == 4)
                {
                    indexes9 = 1.34;
                }
                if (comboBox45.SelectedIndex == 5)
                {
                    indexes9 = 1.74;
                }

                if (comboBox44.SelectedIndex == 0)
                {
                    indexes10 = 1;
                }
                if (comboBox44.SelectedIndex == 1)
                {
                    indexes10 = 0.95;
                }
                if (comboBox44.SelectedIndex == 2)
                {
                    indexes10 = 1;
                }
                if (comboBox44.SelectedIndex == 3)
                {
                    indexes10 = 1.07;
                }
                if (comboBox44.SelectedIndex == 4)
                {
                    indexes10 = 1.15;
                }
                if (comboBox44.SelectedIndex == 5)
                {
                    indexes10 = 1.24;
                }

                if (comboBox43.SelectedIndex == 0)
                {
                    indexes11 = 0.81;
                }
                if (comboBox43.SelectedIndex == 1)
                {
                    indexes11 = 0.91;
                }
                if (comboBox43.SelectedIndex == 2)
                {
                    indexes11 = 1;
                }
                if (comboBox43.SelectedIndex == 3)
                {
                    indexes11 = 1.11;
                }
                if (comboBox43.SelectedIndex == 4)
                {
                    indexes11 = 1.23;
                }
                if (comboBox43.SelectedIndex == 5)
                {
                    indexes11 = 1;
                }

                if (comboBox42.SelectedIndex == 0)
                {
                    indexes12 = 1;
                }
                if (comboBox42.SelectedIndex == 1)
                {
                    indexes12 = 1;
                }
                if (comboBox42.SelectedIndex == 2)
                {
                    indexes12 = 1;
                }
                if (comboBox42.SelectedIndex == 3)
                {
                    indexes12 = 1.11;
                }
                if (comboBox42.SelectedIndex == 4)
                {
                    indexes12 = 1.29;
                }
                if (comboBox42.SelectedIndex == 5)
                {
                    indexes12 = 1.63;
                }

                if (comboBox50.SelectedIndex == 0)
                {
                    indexes13 = 1;
                }
                if (comboBox50.SelectedIndex == 1)
                {
                    indexes13 = 1;
                }
                if (comboBox50.SelectedIndex == 2)
                {
                    indexes13 = 1;
                }
                if (comboBox50.SelectedIndex == 3)
                {
                    indexes13 = 1.05;
                }
                if (comboBox50.SelectedIndex == 4)
                {
                    indexes13 = 1.17;
                }
                if (comboBox50.SelectedIndex == 5)
                {
                    indexes13 = 1.46;
                }

                if (comboBox49.SelectedIndex == 0)
                {
                    indexes14 = 1;
                }
                if (comboBox49.SelectedIndex == 1)
                {
                    indexes14 = 0.87;
                }
                if (comboBox49.SelectedIndex == 2)
                {
                    indexes14 = 1;
                }
                if (comboBox49.SelectedIndex == 3)
                {
                    indexes14 = 1.15;
                }
                if (comboBox49.SelectedIndex == 4)
                {
                    indexes14 = 1.3;
                }
                if (comboBox49.SelectedIndex == 5)
                {
                    indexes14 = 1;
                }

                if (comboBox48.SelectedIndex == 0)
                {
                    indexes15 = 1.17;
                }
                if (comboBox48.SelectedIndex == 1)
                {
                    indexes15 = 1.09;
                }
                if (comboBox48.SelectedIndex == 2)
                {
                    indexes15 = 1;
                }
                if (comboBox48.SelectedIndex == 3)
                {
                    indexes15 = 0.9;
                }
                if (comboBox48.SelectedIndex == 4)
                {
                    indexes15 = 0.78;
                }
                if (comboBox48.SelectedIndex == 5)
                {
                    indexes15 = 1;
                }

                if (comboBox47.SelectedIndex == 0)
                {
                    indexes16 = 1.22;
                }
                if (comboBox47.SelectedIndex == 1)
                {
                    indexes16 = 1.09;
                }
                if (comboBox47.SelectedIndex == 2)
                {
                    indexes16 = 1;
                }
                if (comboBox47.SelectedIndex == 3)
                {
                    indexes16 = 0.93;
                }
                if (comboBox47.SelectedIndex == 4)
                {
                    indexes16 = 0.86;
                }
                if (comboBox47.SelectedIndex == 5)
                {
                    indexes16 = 0.8;
                }

                if (comboBox51.SelectedIndex == 0)
                {
                    indexes17 = 1.43;
                }
                if (comboBox51.SelectedIndex == 1)
                {
                    indexes17 = 1.14;
                }
                if (comboBox51.SelectedIndex == 2)
                {
                    indexes17 = 1;
                }
                if (comboBox51.SelectedIndex == 3)
                {
                    indexes17 = 1;
                }
                if (comboBox51.SelectedIndex == 4)
                {
                    indexes17 = 1;
                }
                if (comboBox51.SelectedIndex == 5)
                {
                    indexes17 = 1;
                }
                #endregion

                double SF = index1 + index2 + index3 + index4 + index5;
                double EAF = indexes1 * indexes2 * indexes3 * indexes4 * indexes5 * 
                    indexes6 * indexes7 * indexes8 * indexes9 * indexes10 * indexes11 * 
                    indexes12 * indexes13 * indexes14 * indexes15 * indexes16 * indexes17;

                double EPS = B + 0.01 * SF;
                double PM = EAF * A * Math.Pow(Convert.ToDouble(textBox4.Text), EPS);

                double C = 3.67;
                double D = 0.28;
                double EAF2 = indexes1 * indexes2 * indexes3 * indexes4 * indexes5 * 
                    indexes6 * indexes7 * indexes8 * indexes9 * indexes10 * indexes11 * 
                    indexes12 * indexes13 * indexes14 * indexes15 * indexes16;
                double PM2 = EAF2 * A * Math.Pow(Convert.ToDouble(textBox4.Text), EPS);
                double TM = indexes17 * C * Math.Pow(PM, D + 0.2 * (EPS - B));
                label54.Text = Convert.ToString(PM);
                label52.Text = Convert.ToString(TM);
            }
        }
    }
}
