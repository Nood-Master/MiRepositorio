using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEscritorio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public bool esVocal(char c)
        {
            return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
        }
        public int contarVocales(string texto)
        {
            if (string.IsNullOrEmpty(texto))
                return 0;
            int count = 0;
            texto = texto.Trim();
            texto = texto.ToLower();
            for (int i = 0; i < texto.Length; i++)
            {
                char c = texto[i];
                if (esVocal(c))
                    count++;

            }

            return count;
        }
        public int contarPalabras(string texto)
        {
            if (string.IsNullOrEmpty(texto))
                return 0;
            int count = 0;
            texto = texto.Trim();
            string[] palabras = texto.Split(' ');
            count = palabras.Length;
            return count;
        }
        public int invertirletras(string texto)
        {
            if (string.IsNullOrEmpty(texto))
                return 0;
            int count = 0;
            texto = texto.Trim();
            char[] letras = texto.ToCharArray();
            Array.Reverse(letras);
            string textoInvertido = new string(letras);
            MessageBox.Show($"El texto invertido es: {textoInvertido}");
            return count;
        }
        public string InvertirPalabras(string texto)
        {
            if (string.IsNullOrEmpty(texto))
                return string.Empty;
            string[] palabras = texto.Split(' ');
            string[] resultado = new string[palabras.Length];
            for (int i = 0; i < palabras.Length; i++)
            {
                char[] caracteres = palabras[i].ToCharArray();
                Array.Reverse(caracteres);
                resultado[i] = new string(caracteres);
            }
            string textoFinal = string.Join(" ", resultado);
            MessageBox.Show($"El texto transformado es: {textoFinal}");

            return textoFinal;
        }





        private void opcion1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            string valor1 = txt1.Text;

            string valor2 = txt2.Text;

            try
            {
                decimal d1 = Decimal.Parse(valor1);
                decimal d2 = Decimal.Parse(valor2);

                decimal promedio =(d1+d2)/2;
                MessageBox.Show($"El promedio es {promedio}");
            }
            catch (Exception ex) {

                MessageBox.Show(ex.Message);
            }
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            String texto = richTxt.Text;
            if (radioButton1.Checked)
            {

                int n = contarVocales(texto);
                MessageBox.Show($"Existen {n} en el texto");
            }
            else if (radioButton2.Checked)
            {
                int n = contarPalabras(texto);
                MessageBox.Show($"Existen {n} palabras en el texto");
            }
            else if (radioButton3.Checked)
            {
                int n = invertirletras(texto);
            }
            else if (radioButton4.Checked)
            {
                _ = InvertirPalabras(texto);
            }
        }
        private void mkBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
