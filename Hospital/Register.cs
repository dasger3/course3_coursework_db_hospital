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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command;

            String email, password, name, surname, phone, adress="",
                    passport ="", dateOfBirth = "";

            int room = 0, idSpecialization =-1;

            email = txtEmail.Text;
            password = txtPassword.Text;
            name = txtName.Text;
            surname = txtSurname.Text;
            phone = txtPhone.Text;

            if (email == "Введіть пошту" || password == "Введіть пороль" ||
                name == "Введіть ім'я" || surname == "Введіть прізвище" || phone == "Введіть телефон")
            {
                MessageBox.Show("Не всі дані введені. Спробуйте знову.");
                return;
            }


            if (rb1.Checked) 
            {
                dateOfBirth = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                adress = txtAdress.Text;
                passport = txtPassport.Text;

                if (adress == "Введіть адресу" || passport == "Введіть номер паспорта")
                {
                    MessageBox.Show("Не всі дані введені. Спробуйте знову.");
                    return;
                }
            }
            else
            {
                try
                {
                    room = Int32.Parse(txtRoom.Text);
                    idSpecialization = cbSpecialization.SelectedIndex;
                }
                catch(FormatException)
                {
                    MessageBox.Show("Невірно введен номер кабінета. Спробуйте знову.");
                    return;
                }
                catch(ArgumentNullException)
                {
                    MessageBox.Show("Невірно введен номер кабінета. Спробуйте знову.");
                    return;
                }
                if (idSpecialization < 0)
                {
                    MessageBox.Show("Невірно введена спеціалізація. Спробуйте знову.");
                    return;
                }
            }

            db.openConnection();

            command = new MySqlCommand("INSERT INTO `users_table` (`email`, `password`) VALUES (@uL, @up)", db.getConnection());

            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = email;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = password;

            command.ExecuteNonQuery();

            command = new MySqlCommand("INSERT INTO `account_table` (`name`, `surname`, `telephone`) VALUES (@uN, @uS, @uT)", db.getConnection());

            command.Parameters.Add("@uN", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@uS", MySqlDbType.VarChar).Value = surname;
            command.Parameters.Add("@uT", MySqlDbType.VarChar).Value = phone;

            command.ExecuteNonQuery();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            if (rb1.Checked)
            {
                command = new MySqlCommand("INSERT INTO `cards_table` (`date_of_birth`, `location`, `passport_info`) VALUES (@uD, @uLc, @uPa)", db.getConnection());

                command.Parameters.Add("@uD", MySqlDbType.VarChar).Value = dateOfBirth;
                command.Parameters.Add("@uLc", MySqlDbType.VarChar).Value = adress;
                command.Parameters.Add("@uPa", MySqlDbType.VarChar).Value = passport;

                command.ExecuteNonQuery();
            }
            else
            {
                MySqlCommand command1 = new MySqlCommand("SELECT `id` FROM `account_table` WHERE `account_table`.`name` = @uId", db.getConnection());

                command1.Parameters.Add("@uId", MySqlDbType.VarChar).Value = name;

                int id = (int)(command1.ExecuteScalar());

                command = new MySqlCommand("INSERT INTO `doctors_table` (`room`, `specialization_id`, `account_id`) VALUES (@uR, @uS, @uId)", db.getConnection());

                command.Parameters.Add("@uR", MySqlDbType.VarChar).Value = room;
                command.Parameters.Add("@uS", MySqlDbType.VarChar).Value = idSpecialization;
                command.Parameters.Add("@uId", MySqlDbType.VarChar).Value = id;

                command.ExecuteNonQuery();
            }
                
            MessageBox.Show("Реєстрація пройшла успішно.");
            Login login = new Login();
            login.Show();
            this.Hide();
           
            db.closeConnection();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            panelP.Visible = true;
            panelD.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (txtName.Text == "Введіть ім'я")
                txtName.Text = "";
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (txtName.Text == "")
                txtName.Text = "Введіть ім'я";
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (txtSurname.Text == "Введіть прізвище")
                txtSurname.Text = "";
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (txtSurname.Text == "")
                txtSurname.Text = "Введіть прізвище";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void rb1_CheckedChanged(object sender, EventArgs e)
        {
            panelP.Visible = true;
            panelD.Visible = false;
        }

        private void rb2_CheckedChanged(object sender, EventArgs e)
        {
            panelD.Visible = true;
            panelP.Visible = false;
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Введіть пошту")
                txtEmail.Text = "";
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
                txtEmail.Text = "Введіть пошту";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Введіть пороль")
            {
                txtPassword.PasswordChar = '*';
                txtPassword.Text = "";
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.PasswordChar = '\0';
                txtPassword.Text = "Введіть пороль";
            }
        }

        private void txtPhone_Enter(object sender, EventArgs e)
        {
            if (txtPhone.Text == "Введіть телефон")
                txtPhone.Text = "";
        }

        private void txtPhone_Leave(object sender, EventArgs e)
        {
            if (txtPhone.Text == "")
                txtPhone.Text = "Введіть телефон";
        }

        private void txtRoom_Enter(object sender, EventArgs e)
        {
            if (txtRoom.Text == "Введіть номер кабінета")
                txtRoom.Text = "";
        }

        private void txtRoom_Leave(object sender, EventArgs e)
        {
            if (txtRoom.Text == "")
                txtRoom.Text = "Введіть номер кабінета";
        }

        private void textBox1_Enter_1(object sender, EventArgs e)
        {
            if (txtAdress.Text == "Введіть адресу")
                txtAdress.Text = "";
        }

        private void txtAdress_Leave(object sender, EventArgs e)
        {
            if (txtAdress.Text == "")
                txtAdress.Text = "Введіть адресу";
        }

        private void txtPassport_Enter(object sender, EventArgs e)
        {
            if (txtPassport.Text == "Введіть номер паспорта")
                txtPassport.Text = "";
        }

        private void txtPassport_Leave(object sender, EventArgs e)
        {
            if (txtPassport.Text == "")
                txtPassport.Text = "Введіть номер паспорта";
        }

        private void txtRoom_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
