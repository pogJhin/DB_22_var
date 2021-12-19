using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Var_22_BD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        Class1 Gear = new Class1();
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Gear.x[Gear.i] = comboBox1.Text; ;
            comboBox2.Items.Clear();
            switch(Gear.x[Gear.i])
            {
                case "0,7":
                case "0,5":
                case "0,3":
                    comboBox2.Items.Add("14");
                    comboBox2.Items.Add("16");
                    comboBox2.Items.Add("17");
                    comboBox2.Items.Add("18");
                    comboBox2.Items.Add("19");
                    comboBox2.Items.Add("20");
                    comboBox2.Items.Add("21");
                    comboBox2.Items.Add("22");
                    comboBox2.Items.Add("24");
                    comboBox2.Items.Add("25");
                    comboBox2.Items.Add("28");
                    comboBox2.Items.Add("30");
                    comboBox2.Items.Add("32");
                    comboBox2.Items.Add("37");
                    comboBox2.Items.Add("40");
                    comboBox2.Items.Add("45");
                    comboBox2.Items.Add("50");
                    comboBox2.Items.Add("60");
                    comboBox2.Items.Add("80");
                    comboBox2.Items.Add("100");
                    break;
                case "0,1":
                    comboBox2.Items.Add("17");
                    comboBox2.Items.Add("18");
                    comboBox2.Items.Add("19");
                    comboBox2.Items.Add("20");
                    comboBox2.Items.Add("21");
                    comboBox2.Items.Add("22");
                    comboBox2.Items.Add("24");
                    comboBox2.Items.Add("25");
                    comboBox2.Items.Add("28");
                    comboBox2.Items.Add("30");
                    comboBox2.Items.Add("32");
                    comboBox2.Items.Add("37");
                    comboBox2.Items.Add("40");
                    comboBox2.Items.Add("45");
                    comboBox2.Items.Add("50");
                    comboBox2.Items.Add("60");
                    comboBox2.Items.Add("80");
                    comboBox2.Items.Add("100");
                    break;
                case "-0,1":
                    comboBox2.Items.Add("19");
                    comboBox2.Items.Add("20");
                    comboBox2.Items.Add("21");
                    comboBox2.Items.Add("22");
                    comboBox2.Items.Add("24");
                    comboBox2.Items.Add("25");
                    comboBox2.Items.Add("28");
                    comboBox2.Items.Add("30");
                    comboBox2.Items.Add("32");
                    comboBox2.Items.Add("37");
                    comboBox2.Items.Add("40");
                    comboBox2.Items.Add("45");
                    comboBox2.Items.Add("50");
                    comboBox2.Items.Add("60");
                    comboBox2.Items.Add("80");
                    comboBox2.Items.Add("100");
                    comboBox2.Items.Add("150");
                    break;
                case "-0,3":
                    comboBox2.Items.Add("25");
                    comboBox2.Items.Add("28");
                    comboBox2.Items.Add("30");
                    comboBox2.Items.Add("32");
                    comboBox2.Items.Add("37");
                    comboBox2.Items.Add("40");
                    comboBox2.Items.Add("45");
                    comboBox2.Items.Add("50");
                    comboBox2.Items.Add("60");
                    comboBox2.Items.Add("80");
                    comboBox2.Items.Add("100");
                    comboBox2.Items.Add("150");
                    break;
                case "-0,5":
                    comboBox2.Items.Add("32");
                    comboBox2.Items.Add("37");
                    comboBox2.Items.Add("40");
                    comboBox2.Items.Add("45");
                    comboBox2.Items.Add("50");
                    comboBox2.Items.Add("60");
                    comboBox2.Items.Add("80");
                    comboBox2.Items.Add("100");
                    comboBox2.Items.Add("150");
                    break;
                case "0":
                    comboBox2.Items.Add("17");
                    comboBox2.Items.Add("18");
                    comboBox2.Items.Add("19");
                    comboBox2.Items.Add("20");
                    comboBox2.Items.Add("21");
                    comboBox2.Items.Add("22");
                    comboBox2.Items.Add("24");
                    comboBox2.Items.Add("25");
                    comboBox2.Items.Add("28");
                    comboBox2.Items.Add("30");
                    comboBox2.Items.Add("32");
                    comboBox2.Items.Add("37");
                    comboBox2.Items.Add("40");
                    comboBox2.Items.Add("45");
                    comboBox2.Items.Add("50");
                    comboBox2.Items.Add("60");
                    comboBox2.Items.Add("80");
                    comboBox2.Items.Add("100");
                    comboBox2.Items.Add("150");
                    comboBox2.Items.Add("Рейка");
                    break;

            }
        }

        private double xt1Value(double u, double Bm)
        {
            if (u < 4)
            {
                if (Bm <= 15)
                    return 0.04;
                else if (Bm <= 29)
                    return 0.08;
                else if (Bm <= 40)
                    return 0.12;
                else
                    return 0.16;
            }
            else
            {
                if (Bm <= 15)
                    return 0.06;
                else if (Bm <= 29)
                    return 0.10;
                else if (Bm <= 40)
                    return 0.14;
                else
                    return 0.18;
            }


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Zv = comboBox2.Text;
            switch (Gear.x[Gear.i]){
                case "0,7":
                    switch (Zv)
                    {
                        case "14":
                            textBox1.Text = "3,12";
                            break;
                        case "16":
                            textBox1.Text = "3,15";
                            break;
                        case "17":
                            textBox1.Text = "3,16";
                            break;
                        case "18":
                            textBox1.Text = "3,17";
                            break;
                        case "19":
                            textBox1.Text = "3,18";
                            break;
                        case "20":
                            textBox1.Text = "3,19";
                            break;
                        case "21":
                            textBox1.Text = "3,20";
                            break;
                        case "22":
                            textBox1.Text = "3,21";
                            break;
                        case "24":
                            textBox1.Text = "3,23";
                            break;
                        case "25":
                            textBox1.Text = "3,24";
                            break;
                        case "28":
                            textBox1.Text = "3,27";
                            break;
                        case "30":
                            textBox1.Text = "3,28";
                            break;
                        case "32":
                            textBox1.Text = "3,29";
                            break;
                        case "37":
                            textBox1.Text = "3,32";
                            break;
                        case "40":
                            textBox1.Text = "3,33";
                            break;
                        case "45":
                            textBox1.Text = "3,36";
                            break;
                        case "50":
                            textBox1.Text = "3,38";
                            break;
                        case "60":
                            textBox1.Text = "3,41";
                            break;
                        case "80":
                            textBox1.Text = "3,45";
                            break;
                        case "100":
                            textBox1.Text = "3,49";
                            break;
                    }
                    break;
                case "0,5":
                    switch (Zv)
                    {
                        case "14":
                        case "37":
                        case "40":
                            textBox1.Text = "3,42";
                            break;
                        case "16":
                        case "17":
                        case "28":
                        case "30":
                            textBox1.Text = "3,40";
                            break;
                        case "18":
                        case "19":
                        case "20":
                        case "21":
                        case "22":
                        case "24":
                        case "25":
                            textBox1.Text = "3,39";
                            break;
                        case "32":
                            textBox1.Text = "3,41";
                            break;
                        case "45":
                            textBox1.Text = "3,43";
                            break;
                        case "50":
                            textBox1.Text = "3,44";
                            break;
                        case "60":
                            textBox1.Text = "3,47";
                            break;
                        case "80":
                            textBox1.Text = "3,50";
                            break;
                        case "100":
                            textBox1.Text = "3,52";
                            break;

                    }
                    break;
                case "0,3":
                    switch (Zv)
                    {
                        case "14":
                            textBox1.Text = "3,78";
                            break;
                        case "16":
                            textBox1.Text = "3,72";
                            break;
                        case "17":
                            textBox1.Text = "3,67";
                            break;
                        case "18":
                            textBox1.Text = "3,64";
                            break;
                        case "19":
                            textBox1.Text = "3,62";
                            break;
                        case "20":
                            textBox1.Text = "3,61";
                            break;
                        case "21":
                            textBox1.Text = "3,60";
                            break;
                        case "22":
                            textBox1.Text = "3,59";
                            break;
                        case "24":
                            textBox1.Text = "3,58";
                            break;
                        case "25":
                            textBox1.Text = "3,57";
                            break;
                        case "28":
                            textBox1.Text = "3,56";
                            break;
                        case "30":
                        case "32":
                        case "80":
                            textBox1.Text = "3,54";
                            break;
                        case "37":
                        case "40":
                        case "60":
                            textBox1.Text = "3,53";
                            break;
                        case "45":
                        case "50":
                            textBox1.Text = "3,52";
                            break;
                        case "100":
                            textBox1.Text = "3,55";
                            break;
                    }
                    break;
                case "0,1":
                    switch (Zv)
                    {
                        case "17":
                            textBox1.Text = "4,03";
                            break;
                        case "18":
                            textBox1.Text = "3,97";
                            break;
                        case "19":
                            textBox1.Text = "3,92";
                            break;
                        case "20":
                            textBox1.Text = "3,89";
                            break;
                        case "21":
                            textBox1.Text = "3,85";
                            break;
                        case "22":
                            textBox1.Text = "3,82";
                            break;
                        case "24":
                            textBox1.Text = "3,79";
                            break;
                        case "25":
                            textBox1.Text = "3,77";
                            break;
                        case "28":
                            textBox1.Text = "3,72";
                            break;
                        case "30":
                            textBox1.Text = "3,70";
                            break;
                        case "32":
                            textBox1.Text = "3,69";
                            break;
                        case "37":
                            textBox1.Text = "3,64";
                            break;
                        case "40":
                            textBox1.Text = "3,63";
                            break;
                        case "45":
                            textBox1.Text = "3,62";
                            break;
                        case "50":
                            textBox1.Text = "3,60";
                            break;
                        case "60":
                            textBox1.Text = "3,59";
                            break;
                        case "80":
                        case "100":
                            textBox1.Text = "3,58";
                            break;
                    }
                    break;
                case "0":
                    switch (Zv)
                    {
                        case "17":
                            textBox1.Text = "4,26";
                            break;
                        case "18":
                            textBox1.Text = "4,20";
                            break;
                        case "19":
                            textBox1.Text = "4,11";
                            break;
                        case "20":
                            textBox1.Text = "4,08";
                            break;
                        case "21":
                            textBox1.Text = "4,01";
                            break;
                        case "22":
                            textBox1.Text = "4,00";
                            break;
                        case "24":
                            textBox1.Text = "3,92";
                            break;
                        case "25":
                            textBox1.Text = "3,90";
                            break;
                        case "28":
                            textBox1.Text = "3,82";
                            break;
                        case "30":
                            textBox1.Text = "3,80";
                            break;
                        case "32":
                            textBox1.Text = "3,78";
                            break;
                        case "37":
                            textBox1.Text = "3,71";
                            break;
                        case "40":
                            textBox1.Text = "3,70";
                            break;
                        case "45":
                            textBox1.Text = "3,68";
                            break;
                        case "50":
                            textBox1.Text = "3,65";
                            break;
                        case "60":
                            textBox1.Text = "3,62";
                            break;
                        case "80":
                            textBox1.Text = "3,61";
                            break;
                        case "100":
                        case "150":
                            textBox1.Text = "3,60";
                            break;
                        case "Рейка":
                            textBox1.Text = "3,63";
                            break;
                    }
                    break;
                case "-0,1":
                    switch (Zv)
                    {
                        case "19":
                            textBox1.Text = "4,32";
                            break;
                        case "20":
                            textBox1.Text = "4,28";
                            break;
                        case "21":
                            textBox1.Text = "4,22";
                            break;
                        case "22":
                            textBox1.Text = "4,20";
                            break;
                        case "24":
                            textBox1.Text = "4,10";
                            break;
                        case "25":
                            textBox1.Text = "4,05";
                            break;
                        case "28":
                            textBox1.Text = "3,95";
                            break;
                        case "30":
                            textBox1.Text = "3,90";
                            break;
                        case "32":
                            textBox1.Text = "3,87";
                            break;
                        case "37":
                            textBox1.Text = "3,80";
                            break;
                        case "40":
                            textBox1.Text = "3,77";
                            break;
                        case "45":
                            textBox1.Text = "3,72";
                            break;
                        case "50":
                            textBox1.Text = "3,70";
                            break;
                        case "60":
                            textBox1.Text = "3,67";
                            break;
                        case "80":
                            textBox1.Text = "3,62";
                            break;
                        case "100":
                            textBox1.Text = "3,61";
                            break;
                        case "150":
                            textBox1.Text = "3,63";
                            break;
                    }
                    break;
                case "-0,3":
                    switch (Zv)
                    {
                        case "25":
                            textBox1.Text = "4,28";
                            break;
                        case "28":
                            textBox1.Text = "3,22";
                            break;
                        case "30":
                            textBox1.Text = "4,14";
                            break;
                        case "32":
                            textBox1.Text = "4,08";
                            break;
                        case "37":
                            textBox1.Text = "3,96";
                            break;
                        case "40":
                            textBox1.Text = "3,92";
                            break;
                        case "45":
                            textBox1.Text = "3,86";
                            break;
                        case "50":
                            textBox1.Text = "3,81";
                            break;
                        case "60":
                            textBox1.Text = "3,74";
                            break;
                        case "80":
                            textBox1.Text = "3,68";
                            break;
                        case "100":
                            textBox1.Text = "3,65";
                            break;
                        case "150":
                            textBox1.Text = "3,63";
                            break;
                    }
                    break;
                case "-0,5":
                    switch (Zv)
                    {
                        case "32":
                            textBox1.Text = "4,45";
                            break;
                        case "37":
                            textBox1.Text = "4,20";
                            break;
                        case "40":
                            textBox1.Text = "4,13";
                            break;
                        case "45":
                            textBox1.Text = "4,02";
                            break;
                        case "50":
                            textBox1.Text = "3,96";
                            break;
                        case "60":
                            textBox1.Text = "3,84";
                            break;
                        case "80":
                            textBox1.Text = "3,73";
                            break;
                        case "100":
                            textBox1.Text = "3,68";
                            break;
                        case "150":
                            textBox1.Text = "3,63";
                            break;
                    }
                    break;
            }
           
            Gear.Zv[Gear.i] = Convert.ToDouble(Zv);
            Gear.Yf[Gear.i] = Convert.ToDouble(textBox1.Text);
        }

        private void Find_Yf()
        {
            Gear.Yf[Gear.i] = Convert.ToDouble(textBox1.Text);
            Gear.xt1[Gear.i] = Convert.ToDouble(textBox4.Text);
            Gear.YF[Gear.i] = Gear.Yf[Gear.i] * Math.Pow(((2.2 + Gear.xt1[Gear.i]) / 2.2), 2);
            textBox5.Text = Convert.ToString(Gear.YF[Gear.i]);
            Gear.NodeTipe[Gear.i] = comboBox3.Text;
            if (Gear.NodeTipe[Gear.i] == "прямые")
                Gear.Yb[Gear.i] = 1;
            else
                Gear.Yb[Gear.i] = 1 - Gear.Bm[Gear.i] / 140;
            textBox6.Text = $"{Gear.Yb[Gear.i]}";
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            label8.Visible = false;
            label11.Visible = false;
            if (textBox3.Text != "")
                try
                {
                    double x = Convert.ToDouble(textBox3.Text);
                    label11.Visible = false;
                    if (!((x < 2.5) || (x > 6.3)))
                    {
                        label8.Visible = false;
                        Gear.u[Gear.i] = x;
                    }
                    else
                        label8.Visible = true;
                    if (!label9.Visible && !label8.Visible && textBox2.Text != "")
                    {
                        textBox4.Text = Convert.ToString(xt1Value(Gear.u[Gear.i], Gear.Bm[Gear.i]));
                        Find_Yf();
                    }
                    else
                        textBox4.Text = "";
                }
                catch
                {
                    label11.Visible = true;
                }

            else textBox4.Text = "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label9.Visible = false;
            label10.Visible = false;
            if (textBox2.Text != "")
                try
                {
                    double x = Convert.ToDouble(textBox2.Text);
                    label10.Visible = false;
                    if (!((x < 0) || (x > 45)))
                    {
                        Gear.Bm[Gear.i] = x;
                        label9.Visible = false;
                    }
                    else
                        label9.Visible = true;
                    if (!label9.Visible && !label8.Visible && textBox3.Text != "")
                    {
                        textBox4.Text = Convert.ToString(xt1Value(Gear.u[Gear.i], Gear.Bm[Gear.i]));
                        Find_Yf();
                    }
                    else
                        textBox4.Text = "";
                }
                catch
                {
                    label10.Visible = true;
                }
            else textBox4.Text = "";
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            label20.Visible = false;
            label21.Visible = false;
            if (textBox7.Text != "")
                try
                {
                    double x = Convert.ToDouble(textBox7.Text);
                    label20.Visible = false;
                    if (!(x < 0))
                    {
                        Gear.Bm[Gear.i] = x;
                        label21.Visible = false;
                    }
                    else
                        label21.Visible = true;
                }
                catch
                {
                    label20.Visible = true;
                }
            else textBox7.Text = "";
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!label20.Visible && !label21.Visible && textBox7.Text != "")
            {
                Gear.v[Gear.i] = Convert.ToDouble(comboBox4.Text);
                Gear.N[Gear.i] = Convert.ToDouble(textBox7.Text);
                Gear.Ft[Gear.i] = 1000 * Gear.N[Gear.i] / Gear.v[Gear.i];
                textBox8.Text = $"{Gear.Ft[Gear.i]}";
                Gear.T1[Gear.i] = 9550 * Gear.N[Gear.i] / 50000;
                textBox17.Text = $"{Gear.T1[Gear.i]}";
                Gear.dw[Gear.i] = 2000 * Gear.T1[Gear.i] / Gear.Ft[Gear.i];
                textBox18.Text = $"{Gear.dw[Gear.i]}";
                Gear.Mtm[Gear.i] = Gear.dw[Gear.i]/Gear.Zv[Gear.i];
                textBox19.Text = $"{Gear.Mtm[Gear.i]}";
                Gear.Mnm[Gear.i] = Gear.Mtm[Gear.i] * Math.Cos(Gear.Bm[Gear.i] * 3.14 / 180);
                textBox20.Text = $"{Gear.Mnm[Gear.i]}";
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox6.Items.Clear();
            comboBox6.Text = "";
            if (comboBox3.Text == "прямые")
            {
                comboBox6.Items.Add("1,15");
                comboBox6.Items.Add("1,30"); 
                comboBox6.Items.Add("1,48");
                comboBox6.Items.Add("1,67");
                comboBox6.Items.Add("1,90");
            }
            else
            {
                comboBox6.Items.Add("1,07");
                comboBox6.Items.Add("1,15");
                comboBox6.Items.Add("1,24");
                comboBox6.Items.Add("1,34");
                comboBox6.Items.Add("1,43");
            }
            textBox13.Text = "";
            if (comboBox3.Text == "прямые")
                textBox13.Text = "0,016";
            else
                textBox13.Text = "0,006";
            Gear.sigmaf[Gear.i] = Convert.ToDouble(textBox13.Text);
            comboBox5.Items.Clear();
            comboBox5.Text = "";
            if (comboBox3.Text == "прямые")
                if (Gear.u[Gear.i] > 3) 
                { 
                    comboBox5.Items.Add("18");
                    comboBox5.Items.Add("19"); 
                    comboBox5.Items.Add("20");
                }
                else
                {
                    comboBox5.Items.Add("20");
                    comboBox5.Items.Add("21"); 
                    comboBox5.Items.Add("22");
                    comboBox5.Items.Add("23");
                    comboBox5.Items.Add("24");
                    comboBox5.Items.Add("25");
                }
            else
            {
                if (Gear.u[Gear.i] > 4)
                    comboBox5.Items.Add("14");
                else
                    comboBox5.Items.Add("16");
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            Gear.z1[Gear.i] = Convert.ToDouble(comboBox5.Text);
            Gear.ea[Gear.i] = (1.88 - 3.2 / Gear.z1[Gear.i]) * Math.Cos(Gear.Bm[Gear.i]*3.14 / 180);
            textBox11.Text = $"{Gear.ea[Gear.i]}";
            Gear.Kfa[Gear.i] = 1 / Gear.ea[Gear.i];
            textBox9.Text = $"{Gear.Kfa[Gear.i]}";
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            Gear.Kfb[Gear.i] = Convert.ToDouble(comboBox6.Text);
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox8.Text == "До 3.5")
                textBox12.Text = "28";
            else if(comboBox8.Text == "Св.3.5 до 10")
                textBox12.Text = "31";
            else
                textBox12.Text = "37";
            Gear.m[Gear.i] = comboBox8.Text;
            Gear.g0[Gear.i] = Convert.ToDouble(textBox12.Text);
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            Gear.b[Gear.i] = Convert.ToDouble(comboBox7.Text);
            Gear.wft[Gear.i] = Gear.Ft[Gear.i] * Gear.Kfa[Gear.i]* Gear.Kfb[Gear.i]/ Gear.b[Gear.i];
            textBox10.Text = $"{Gear.wft[Gear.i]}";
            switch (Gear.b[Gear.i])
            {
                case 20:
                    Gear.Re[Gear.i] = 67.41;
                    break;
                case 22:
                    Gear.Re[Gear.i] = 77.44;
                    break;
                case 25:
                    Gear.Re[Gear.i] = 85.18;
                    break;
                case 28:
                    Gear.Re[Gear.i] = 93.54;
                    break;
                case 30:
                    Gear.Re[Gear.i] = 103.49;
                    break;
            }
            textBox14.Text = $"{Gear.Re[Gear.i]}";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double Wfvmax;
            Gear.wfv[Gear.i] = Gear.sigmaf[Gear.i] * Gear.g0[Gear.i] * Gear.v[Gear.i] * Math.Sqrt((Gear.Re[Gear.i] - Gear.b[Gear.i] / 2) / Gear.u[Gear.i]);
            if (Gear.m[Gear.i] == "До 3.5")
                Wfvmax = 85;
            else if (Gear.m[Gear.i] == "Св.3.5 до 10")
                Wfvmax = 105;
            else
                Wfvmax = 150;
            if (Gear.wfv[Gear.i] > Wfvmax)
                Gear.wfv[Gear.i] = Wfvmax;
            textBox15.Text = $"{Gear.wfv[Gear.i]}";
            Gear.Kfv[Gear.i] = 1 + Gear.wfv[Gear.i] / Gear.wft[Gear.i];
            textBox16.Text = $"{Gear.Kfv[Gear.i]}";
            Gear.KF[Gear.i] = Gear.Kfa[Gear.i] * Gear.Kfb[Gear.i] * Gear.Kfv[Gear.i];
            textBox22.Text = $"{Gear.KF[Gear.i]}";
            Gear.sigmaf[Gear.i] = (Gear.YF[Gear.i] * Gear.Yb[Gear.i] * Gear.Ft[Gear.i] * Gear.KF[Gear.i])/(0.85* Gear.b[Gear.i]* Gear.Mnm[Gear.i]);
            textBox21.Text = $"{Gear.sigmaf[Gear.i]}";
            Gear.sigmafp[Gear.i] = Gear.sigma_fp[Gear.i] * Gear.Kfl[Gear.i] * 1000000;
            textBox23.Text = $"{Gear.sigmafp[Gear.i]}";
            if(Gear.sigmaf[Gear.i]<= Gear.sigmafp[Gear.i])
            {
                label47.Visible = true;
                label48.Visible = false;
            }
            else
            {
                label48.Visible = true;
                label47.Visible = false;
            }

        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            Gear.sigma_fp[Gear.i] = Convert.ToDouble(comboBox10.Text);
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            Gear.Kfl[Gear.i] = Convert.ToDouble(comboBox9.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Gear.i += 1;
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
            comboBox5.Text = "";
            comboBox6.Text = "";
            comboBox7.Text = "";
            comboBox8.Text = "";
            comboBox9.Text = "";
            comboBox10.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            textBox15.Text = "";
            textBox16.Text = "";
            textBox17.Text = "";
            textBox18.Text = "";
            textBox19.Text = "";
            textBox20.Text = "";
            textBox21.Text = "";
            textBox22.Text = "";
            textBox23.Text = "";
        }
    }
}
