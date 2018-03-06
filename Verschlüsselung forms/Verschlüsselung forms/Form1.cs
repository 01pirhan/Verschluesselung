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

        private void btnverschluesseln_Click(object sender, EventArgs e)
        {
            string beispieltext;

            beispieltext =tfeingabe.Text;

            Char[] chararray = beispieltext.ToCharArray();

            int verschlusselungweite = Convert.ToInt32(tfschrittweite.Text);
            
            for (int i = 0; i < beispieltext.Length; i++)
            {
                Char buchstabe = chararray[i];

                int verschlusselung = Convert.ToInt32(buchstabe);

                verschlusselung = verschlusselung + verschlusselungweite;

                chararray[i] = Convert.ToChar(verschlusselung);

                string ausgabe = "";

                for (int j = 0; j < chararray.Length; j++)
                {
                    ausgabe = ausgabe + Convert.ToString(chararray[j]);
                }

                tfausgabe.Text = ausgabe;
            }
        }
    }
}
