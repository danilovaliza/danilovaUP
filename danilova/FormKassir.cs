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
    public partial class FormKassir : Form
    {
        public FormKassir()
        {
            InitializeComponent();
        }

        private void FormKassir_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "danilovaaDataSet1.Bileti". При необходимости она может быть перемещена или удалена.
            this.biletiTableAdapter1.Fill(this.danilovaaDataSet1.Bileti);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "vozbratDataSet1.Vozvrati". При необходимости она может быть перемещена или удалена.
            this.vozvratiTableAdapter.Fill(this.vozbratDataSet1.Vozvrati);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "beiltiiiDataSet1.View_2". При необходимости она может быть перемещена или удалена.
            this.view_2TableAdapter.Fill(this.beiltiiiDataSet1.View_2);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "biletiDataSet1.Bileti". При необходимости она может быть перемещена или удалена.
            this.biletiTableAdapter.Fill(this.biletiDataSet1.Bileti);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = beiltiiiDataSet1.View_2;
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"Nazvanie LIKE '%{textBox1.Text}%'"; //динамический поиск
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView2.SelectedRows)
            {
                dataGridView2.Rows.Remove(row); //код для удаление записей с DataGridView
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            vozvratiTableAdapter.Update(vozbratDataSet1);
            {
                MessageBox.Show("Изменения сохранены!"); //код для обновление записей
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = vozbratDataSet1.Vozvrati;
            (dataGridView2.DataSource as DataTable).DefaultView.RowFilter = $"Kod_bileta LIKE '%{textBox3.Text}%'"; //динамический поиск
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string kod_bileta = comboBox1.SelectedIndex.ToString(); // код билета
            string data = dateTimePicker1.Value.ToString(); // дата возврата
            string kol = textBox2.Text.Trim(); // количество возвратов

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-MGA54G9\SQLEXPRESS; Initial Catalog = Danilovaa; Integrated Security=True");
            string inserquery = "INSERT INTO Vozvrati (Kod_bileta, Data_vozvrata, [Kol-vo_vozvrata]) VALUES ('" + kod_bileta + "','" + data + "','" + kol + "')";
            SqlCommand cmd2 = new SqlCommand(inserquery, con);
            con.Open();
            cmd2.ExecuteNonQuery();
            MessageBox.Show("Возврат успешно оформлен!");
            con.Close();
        }
    }
}
