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
    public partial class Form4 : Form
    {
        static string conStr = " Data Source = 10.10.0.120;Initial Catalog=abd_19; User ID = abd31_21; Password=123456qwerty.";
        DataContext context = new DataContext(conStr);
        public Form4()
        {
            InitializeComponent();
            Table<prod> prod = context.GetTable<prod>();
            dataGridView1.DataSource = prod.ToList();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "abd_19DataSet1.prod". При необходимости она может быть перемещена или удалена.
            this.prodTableAdapter.Fill(this.abd_19DataSet1.prod);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var prod = context.GetTable<prod>().Where(x => x.kolvo.Contains(Convert.ToString(comboBox1.SelectedValue)));
            dataGridView1.DataSource = prod.ToList();
        }
    }
}
