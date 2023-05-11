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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.PasswordChar = '*';
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "loginDataSet.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.loginDataSet.Users);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection DanilovaConnectionString = new SqlConnection(@"Data Source=DESKTOP-MGA54G9\SQLEXPRESS; Initial Catalog = Danilovaa; Integrated Security=True");
            string query = "Select * FROM Users WHERE login='" + comboBox1.Text + "'and password='" + textBox1.Text + "'";
            DanilovaConnectionString.Open(); // соединение с базой данных sql

            SqlCommand cmd = new SqlCommand(query, DanilovaConnectionString);
            SqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    object Login = rdr.GetValue(0); //логин
                    object Password = rdr.GetValue(1); //пароль

                    string login = Login.ToString();
                    string password = Password.ToString();
                    if (login == "Kassir")
                    {
                        FormKassir frm2 = new FormKassir();
                        frm2.Show();
                        this.Hide(); // открыть форму админа
                    }
                    else if (login == "Zritel")
                    {
                        FormZritel frm3 = new FormZritel();
                        frm3.Show();
                        this.Hide(); // открыть форму пользователя
                    }
                }
            }
            else
            {
                MessageBox.Show("Не правильный пароль", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
        }
    }
}
