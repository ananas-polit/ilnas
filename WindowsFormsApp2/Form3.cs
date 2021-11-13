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
    public partial class Form3 : Form
    {
        static string conStr = " Data Source = 10.10.0.120;Initial Catalog=abd_19; User ID = abd31_21; Password=123456qwerty.";
        DataContext context = new DataContext(conStr);
        public Form3()
        {
            InitializeComponent();
            Table<tov> tov = context.GetTable<tov>();
            dataGridView1.DataSource = tov.ToList();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tov currentAccount = context.GetTable<tov>().FirstOrDefault(
x => x.id_tovar == Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            context.GetTable<tov>().DeleteOnSubmit(currentAccount);
            dataGridView1.DataSource = context.GetTable<tov>().ToList();

        }
    }
}
