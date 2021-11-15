using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Verduleria
{
    public partial class Form1 : Form
    {
        double verdura,monto,tomate, banana,cebolla, morron ,papa, lechuga;
        String detalle;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "TOMATE";
            label2.Text = "";
            label3.Text = "";
            label6.Text = "";
            label7.Text = "";
            label9.Text = "";
            label8.Text = "";
            label4.Text = "PRECIO X KG";
            label5.Text = "CANTIDAD DE KG";
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            button8.Enabled = true;
            button8.Text = "AGREGAR";
            verdura = 1;
            
          




        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "BANANA";
            label2.Text = "";
            label3.Text = "";
            label6.Text = "";
            label7.Text = ""
            label9.Text = "";
            label8.Text = "";
            label4.Text = "PRECIO X KG";
            label5.Text = "CANTIDAD DE KG";
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            button8.Enabled = true;            
            button8.Text = "AGREGAR";
            verura = 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text = CEBOLLA";
            label1.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text  "";
            label9.Text = "";
            label8.Text = "";
            label7.Text = "PRECIO X KG";
            label6.Text = "CANTIDAD DE KG";
            textBox4.Enabled = true;
            textBox3.Enabled = true;
            textBox1.Enabled = false;
            textBox2.Enabled = false
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            button8.Enabled = true;
            button8.Text = "AGREGAR";
            verdura = 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label2.Text = "MORRON";
            label1.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label9.Text = "";
            label8.Text = "";
            label7.Text = "PRECIO X KG"
            label6.Text = "CANTIDAD DE KG";
            textBox4.Enabled = true;
            textBox3.Enabled = true;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            button8.Enabled = true;
            button8.Text = "AGREGAR";
            verdura = 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label3.Text = "PAPAS";
            label2.Text = "";
            label1.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label9.Text = "PRECIO X KG";
            label8.Text = "CANTIDAD DE KG";
            textBox6.Enabled = true;
            textBox5.Enabled = true;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            button8.Enabled = true;
            button8.Text = "AGREGAR";
            verdura = 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label3.Text = "LECHUGA";
            label2.Text = "";
            label1.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label9.Text = "PRECIO X KG";
            label8.Text = "CANTIDAD DE KG";
            textBox6.Enabled = true;
            textBox5.Enabled = true;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBo3.Enabled = false;
            textBox4.Enabled = false;
            button8.Enabled = true;
            button8.Text = "AGREGAR";
            verdura = 6;

        }

        private void button7_Click(object sender, EventArgs e)
        {            
            if (monto > 100)
            {
                MessageBox.Show("TU COMPRA SUPERO LOS 100 $ "+"\n"+ "TIENES UN DESCUENTO DE EL 10%");
                double porcentaje,final;
                porcentaje = (monto * 10) / 100
                final = monto - porcentaje;            
                label11.Text = detalle + "\n" + "A PAGAR $ " + monto.ToString()+ "\n"+"MENOS EL 10% "+ "\n" + "FINAL A PAGAR $ " + final.ToString();
            }
            else
            {
                label11.Text = detalle + "\n" + "A PAGAR $ " + monto.ToString();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            switch (verdura)
            {
                case 1:
                    monto = monto + Convert.ToDouble(textBox1.Text)* Convert.ToDouble(textBox2.Text);
                    tomate= Convert.ToDouble(textBox1.Tet) * Convert.ToDouble(textBox2.Text);
                    button1.Enabled = false;                  
                    detalle += (textBox2.Text +" KG. DE TOMATE A " + (textBox1.Text) + "  $...TOTAL DE TOMATE " + tomate.ToString() + "\n");
                    MessageBox.Show(detalle + "\n" + "SU MONTO TOTAL ES DE " + monto + " $");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Txt = "";
                    textBox6.Text = "";
                    label1.Text = "";
                    label2.Text = "";
                    label3.Text = "";
                    label4.Text = "";
                    label5.Text = "";
                    label6.Text = "";
                    label7.Text = ""
                    label9.Text = "";
                    label8.Text = "";



                    break;
                case 2:
                    monto = monto  Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox2.Text);
                    button2.Enabled = false;
                    banana= Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox2.Text);                    
                    detalle += (textBox2.Text  " KG. DE BANANA A " + (textBox1.Text) + "  $...TOTAL DE BANANA " + banana.ToSting() + "\n");
                    MessageBox.Show(detalle + "\n" + "SU MONTO TOTAL ES DE " + monto + " $");
                    textBox1.Text = "";
                    textox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    label1.Text = "";
                    label2.Text = "";
                    label3.Text = "";
                    label4.Text = "";
                    label5.Text = "";
                    label6.Text = "";
                    label7.Text = "";
                    label9.Text = "";
                    label8.Text = "";
                    break;
                case 3:
                    monto = monto + Convert.ToDouble(textBox3.Text) * Convert.ToDouble(textBox4.Text);
                    cebolla = Convert.ToDouble textBox3.Text) * Convert.ToDouble(textBox4.Text);
                    button3.Enabled = false;                    
                    detalle += (textBox3.Text + " KG. DE CEBOLLA A " + (textBox4.Text) + "  $....TOTAL DE CEBOLLA " + cebolla.ToString() + "\n");
                    MessageBox.Show(detalle + "\n" + "SU MONTO TOTAL ES DE " + monto +" $");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    labe1.Text = "";
                    label2.Text = "";
                    label3.Text = "";
                    label4.Text = "";
                    label5.Text = "";
                    label6.Text = "";
                    label7.Text = "";
                    label9.Text = "";
                    label8.Text = "";
                    break;
                case 4:
                    monto = monto + Convert.ToDouble(textBox3.Text) * Convert.ToDouble(textBox4.Text);
                    morron = Convert.ToDouble(textBox3.Text) * Convert.ToDouble(textBox4.Text);
                    button4.Enabled = fals;                 
                    detalle += (textBox3.Text + " KG. DE MORRON A " + (textBox4.Text) + "  $...TOTAL DE MORRON " + morron.ToString()+"\n");
                    MessageBox.Show(detalle + "\n" + "SU MONTO TOTAL ES DE " + monto + " $");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    label1.Text = "";
                    label2.Text = "";
                    label3.Text = "";
                    label4.Text = "";
                    label5.Text = "";
                    label6.Text = "";
                    label7.Text = "";
                    label9.Text = "";
                    label8.Text = "";
                    break;
                case 5:
                    monto = monto + Convert.ToDouble(textBox5.Text) * Convert.ToDouble(textBox6.Text);
                    papa=  Convert.ToDouble(textBox5.Text) * Convert.ToDouble(textBox6.Text);
                    button5.Enabled = false;                   
                    detalle += (textBox5.Text + " KG. DE PAPA A " + (textBox6.Text) + "  $...TOTAL DE PAPA " + papa.ToString() + "\n");
                    MessageBox.Show(detalle + "\n" + "SU MONTO TOTAL ES DE" + monto + " $");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Tex = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    label1.Text = "";
                    label2.Text = "";
                    label3.Text = "";
                    label4.Text = "";
                    label5.Text = "";
                    label6.Text = "";
                    label7.Text = "";
                    label9.Text = "";
                    label8.Text = "";
                    break;
                case 6:
                    monto = monto + Convert.ToDouble(textBox5.Text) * Covert.ToDouble(textBox6.Text);
                    lechuga= Convert.ToDouble(textBox5.Text) * Convert.ToDouble(textBox6.Text);
                    button6.Enabed = false;                
                    detalle += (textBox5.Text + " KG. DE LECHUGA A " + (textBox6.Text) + "  $...TOTAL DE LECHUGA " + lechuga.ToString() + "\n");
                    MessageBox.Show(detalle + "\n" + "SU MONTO TOTAL ES DE"+ monto + " $");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    label1.Text = "";
                    label2.Text = "";
                    lael3.Text = "";
                    label4.Text = "";
                    label5.Text = "";
                    label6.Text = "";
                    label7.Text = "";
                    label9.Text = "";
                    label8.Text = "";
                    break;


            }
            
        }
    }
}
