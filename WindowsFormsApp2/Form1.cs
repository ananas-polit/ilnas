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
    public partial class Form1 : Form
    {
        static string conStr = " Data Source = 10.10.0.120;Initial Catalog=abd_19; User ID = abd31_21; Password=123456qwerty.";
        DataContext context = new DataContext(conStr);
        public Form1()
        {
            InitializeComponent();
            Table<pr> pr = context.GetTable<pr>();
            dataGridView1.DataSource = pr.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "abd_19DataSet1.prodazha". При необходимости она может быть перемещена или удалена.
            this.prodazhaTableAdapter.Fill(this.abd_19DataSet1.prodazha);

            //this.transactionTableAdapter.Fill(this.abd_19DataSet.Transaction);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_14_abdDataSet.Transaction". При необходимости она может быть перемещена или удалена.

        }

        private void abd19DataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            pr NewUser = new pr {id_client = Convert.ToInt32(textBox1.Text), data_prod = Convert.ToDateTime(dateTimePicker1.Value)};
            context.GetTable<pr>().InsertOnSubmit(NewUser);
            context.SubmitChanges();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }
    }
    
}
