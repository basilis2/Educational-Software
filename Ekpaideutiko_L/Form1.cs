using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ekpaideutiko_L
{
    public partial class Form1 : Form
    {
        public static String id;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_MouseHover(object sender, EventArgs e)
        {
            label6.ForeColor = Color.DeepSkyBlue;
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            label6.ForeColor = Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool x = true;
            if ((textBox1.Text.Equals("")) || (textBox2.Text.Equals("")))
            {
                MessageBox.Show("ΠΑΡΑΚΑΛΩ ΣΥΜΠΛΗΡΩΣΤΕ ΤΑ ΣΤΟΙΧΕΙΑ ΠΟΥ ΛΕΙΠΟΥΝ ");
            }
            else 
            {
                String constring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Vasilis\\source\\repos\\Ekpaideutiko_L\\Ekpaideutiko_L\\Database1.mdf;Integrated Security=True";
                SqlConnection conn = new SqlConnection(constring);
                conn.Open();
                try
                {
                    SqlCommand command = new SqlCommand("SELECT * FROM it where email='" + textBox1.Text.ToString() + "'and password='" + textBox2.Text.ToString() + "'", conn);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        x = false;
                        id = textBox1.Text.ToString();
                        Form2 f2 = new Form2();f2.Show();
                    }
                    if (x)//εαν δεν υπαρχει ο χρηστης
                    {
                        label7.Visible = true;
                        textBox1.ForeColor = Color.Red;
                        textBox2.ForeColor = Color.Red;

                    }

                }
                catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            }
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            label7.Visible = false; 
            textBox1.ForeColor = Color.Black;
            textBox2.ForeColor = Color.Black;
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            label7.Visible = false;
            textBox1.ForeColor = Color.Black;
            textBox2.ForeColor = Color.Black;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();f3.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tο παρον λογισμικό δημιουργηθηκε απο τον" + "\n" + "" +
                "Βασιλη Κατσικονούρη και εχει ως σκοπό να βοηθησει τους φοιτητές- "+"\n"+"" +
                "αποφοιτους πληροφορικης για τα  μεταπτυχιακα-επαγγελματικο προσανατολισμο!!!!");

        }
    }
}
