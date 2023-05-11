using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace danilova
{
    public partial class FormZritel : Form
    {
        public FormZritel()
        {
            InitializeComponent();
        }

        private void FormZritel_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "showsDataSet1.Spektakli". При необходимости она может быть перемещена или удалена.
            this.spektakliTableAdapter1.Fill(this.showsDataSet1.Spektakli);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "spektakelDataSet.Spektakli". При необходимости она может быть перемещена или удалена.
            this.spektakliTableAdapter.Fill(this.spektakelDataSet.Spektakli);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = showsDataSet1.Spektakli;
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"Nazvanie LIKE '%{textBox1.Text}%'"; //динамический поиск
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                string nazvanie = comboBox1.SelectedIndex.ToString(); // название спектакля
                string ryad = textBox2.Text.Trim(); // ряд
                string mesto = textBox3.Text.Trim(); // место

                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-MGA54G9\SQLEXPRESS; Initial Catalog = Danilovaa; Integrated Security=True");
                string inserquery = "INSERT INTO Bileti (Kod_spektalya, Mesto, Ryad) VALUES ('" + nazvanie + "','" + mesto + "','" + ryad + "')";
                SqlCommand cmd2 = new SqlCommand(inserquery, con);
                con.Open();
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Заказ успешно оформлен! Спасибо за заказ!");
                con.Close();
            }

        }
    }
}
