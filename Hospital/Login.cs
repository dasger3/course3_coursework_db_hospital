using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String loginUser = textBox1.Text;
            String passwordUser = textBox2.Text;
            
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users_table` WHERE `users_table`.`email` = @uL AND `users_table`.`password` = @uP", db.getConnection());

            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passwordUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                Main main = new Main();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Невірна пошта або пороль. Спробуйте ще.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Введіть пошту")
                textBox1.Text = "";
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Введіть пороль")
            {
                textBox2.PasswordChar= '*';
                textBox2.Text = "";
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                
                textBox1.Text = "Введіть пошту";
            }
        }


        private void textBox2_Leave_1(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.PasswordChar ='\0';
                textBox2.Text = "Введіть пороль";
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
