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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public static bool f3=false;
        bool exist = false;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text.Equals("woman"))
                pictureBox1.Image = Properties.Resources.woman;
            else
                pictureBox1.Image = Properties.Resources.man;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            exist = false;
            if ((textBox1.Text.Equals("")) || (textBox2.Text.Equals("")) || (textBox3.Text.Equals("")))
                MessageBox.Show("ΠΑΡΑΚΑΛΩ ΣΥΜΠΛΗΡΩΣΤΕ ΤΑ ΣΤΟΙΧΕΙΑ ΠΟΥ ΛΕΙΠΟΥΝ ");
            else 
            {
                String constring2 = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Vasilis\\source\\repos\\Ekpaideutiko_L\\Ekpaideutiko_L\\Database1.mdf;Integrated Security=True";
                SqlConnection conn2 = new SqlConnection(constring2);
                conn2.Open();
                try
                {
                    SqlCommand command = new SqlCommand("SELECT * FROM it where email='" + textBox1.Text.ToString() +  "'", conn2);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        exist = true;
                    }
                    if (exist)//εαν  υπαρχει ο χρηστης
                    {
                        MessageBox.Show("Το παρόν e-mail χρησιμοποιείται!!!");
                    }
                    else //εαν δεν υπάρχει
                    {
                        String constring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Vasilis\\source\\repos\\Ekpaideutiko_L\\Ekpaideutiko_L\\Database1.mdf;Integrated Security=True";
                        SqlConnection conn = new SqlConnection(constring);
                        SqlCommand sc;

                        String sql = "Insert into it(email,password,username,avatar,le1,le2,le3,l4,revis,resualt) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + comboBox1.Text + "','" + 1 + "','" + 0 + "','" + 0 + "','" + 0 + "','" + 0 + "','xxx')";
                        try
                        {
                            conn.Open();
                            sc = new SqlCommand(sql, conn);
                            sc.ExecuteNonQuery();
                            sc.Dispose();
                            conn.Close();
                            MessageBox.Show("Η ΕΓΓΡΑΦΗ ΟΛΟΚΛΗΡΩΘΗΚΕ ΜΕ ΕΠΙΤΥΧΙΑ!");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("ΟΥΠΣ,ΜΑΛΛΟΝ ΕΓΙΝΕ ΚΑΠΟΙΟ ΛΑΘΟΣ,ΔΟΚΙΜΑΣΕ ΞΑΝΑ!");
                            Console.WriteLine(ex.ToString());
                        }
                        this.Close();
                    }

                }
                catch (Exception ex) { MessageBox.Show(ex.ToString()); }
                             
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            f3 = true; Form11 f11 = new Form11();f11.Show();
        }
    }
}
