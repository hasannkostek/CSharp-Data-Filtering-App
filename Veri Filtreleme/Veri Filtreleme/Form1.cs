using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veri_Filtreleme
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> itemList;

        private void Form1_Load(object sender, EventArgs e)
        {
            itemList = listBox1.Items.Cast<string>().ToList(); // Verileri içinde tutuyor
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); //kullanıcı textboxtaki veriyi her değiştirdiğinde textbox temizlenir
            listBox1.Items.AddRange(itemList.Where(i => i.ToLower().Contains(textBox1.Text.ToLower())).ToArray()); // texboxtda yazılan harflere uygun verileri sıralar ("tolower" küçük harf büyük harf ayırt etmemek için)
        }
    }
}
