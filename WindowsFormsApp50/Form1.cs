using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp50
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            /*Napište program, který bude po stisku tlačítek s popiskem a,e,i,o,u,y mazat příslušná
písmena z textu zadaného do TextBoxu. Po stisku tlačítka Ulož, program uloží větu do
Listu, poté se zpřístupní tlačítka a,e,i,o,u,y. Vytvořte jednu obsluhu pro všechna
tlačítka se samohláskami, které budou z Listu mazat příslušná písmenka a poté List
zobrazovat do TextBoxu. Příslušné tlačítko se po akci znepřístupní. Naprogramuj
metodu Vypis, která bude vracet string – písmena z Listu přepíše do string.*/
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        List<char> list = new List<char>();
        private void button1_Click(object sender, EventArgs e)
        {
            String str = vypis(list).Replace(((Button)sender).Text, String.Empty);
            textBox1.Text = str;
            list.Clear();
            foreach(char c in str)
            {
                list.Add(c);
            }

            ((Button)sender).Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = false;
            foreach (char c in textBox1.Text)
            {
                list.Add(c);
            }
        }

        private String vypis(List<char> list)
        {
            String str = "";
            list.ForEach(s => { str += s; });
            return str;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            list.Clear();
            button1.Enabled = !true;
            button2.Enabled = !true;
            button3.Enabled = !true;
            button4.Enabled = !true;
            button5.Enabled = !true;
            button6.Enabled = !true;
            button7.Enabled = !false;
            textBox1.Text = "";
        }
    }
}
