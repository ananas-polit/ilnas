using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        static string conStr = " Data Source = 10.10.0.120;Initial Catalog=abd_19; User ID = abd31_21; Password=123456qwerty.";
        DataContext context = new DataContext(conStr);
        public Form2()
        {
            InitializeComponent();
            Table<kl> kl = context.GetTable<kl>();
            dataGridView1.DataSource = kl.ToList();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            kl currentAccount = context.GetTable<kl>().FirstOrDefault(
x => x.id_klienta == Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            currentAccount.fname = textBox1.Text;
            currentAccount.name = textBox2.Text;
            currentAccount.otchestvo = textBox3.Text;
            currentAccount.adres = textBox4.Text;
            currentAccount.telefon = Convert.ToInt32(textBox5.Text);
            context.SubmitChanges();
            dataGridView1.DataSource = context.GetTable<kl>().ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var kl = context.GetTable<kl>().Where(x => x.fname.Contains(textBox6.Text));
            dataGridView1.DataSource = kl.ToList();
        }
    }
}
