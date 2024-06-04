using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ekpaideutiko_L
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            if (Form4.f4)
            {
                if (Form4.degre >= 6)
                {
                    pictureBox1.Image = Properties.Resources.win;
                    label1.ForeColor = Color.Green;
                    button2.Visible = true;
                    label1.Text = "ΜΠΡΑΒΟΟ!!!!!" + " " + Form2.user + "\n" + "ΠΕΡΑΣΕΣ ΤΟ ΠΡΟΤΟ" + "\n" + "ΕΠΙΠΕΔΟ ΜΕ" + " " + Form4.degre + "/8" + "\n" +
                        "TΩΡΑ ΜΠΟΡΕΙΣ ΝΑ" + "\n" + " ΣΥΝΕΧΙΣΕΙΣ ΚΑΙ" + "\n" + " ΣΤΑ ΕΠΟΜΕΝΑ ΕΠΙΠΕΔΑ!!";
                    String constring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Vasilis\\source\\repos\\Ekpaideutiko_L\\Ekpaideutiko_L\\Database1.mdf;Integrated Security=True";
                    SqlConnection conn = new SqlConnection(constring);
                    conn.Open();
                    try
                    {
                        SqlCommand command = new SqlCommand("UPDATE it SET le1 = @de,le2 = @cit Where email = '" + Form1.id + "' ", conn);
                        command.Parameters.AddWithValue("@de", Form4.degre);
                        command.Parameters.AddWithValue("@cit", 1);
                        SqlDataReader reader = command.ExecuteReader();
                        conn.Close();
                    }
                    catch (Exception ex) { MessageBox.Show(ex.ToString()); }

                }
                else
                {
                    pictureBox1.Image = Properties.Resources.lose;
                    label1.ForeColor = Color.Red;
                    label1.Text = "ΜΑΛΛΟΝ ΔΕΝ ΔΙΑΒΑΣΕΣ" + "\n" + " ΚΑΛΑ" + " " + Form2.user + "\n" + "ΚΟΠΗΚΕΣ ΣΤΟ ΠΡΩΤΟ" + "\n" + " ΕΠΙΠΕΔΟ ΜΕ" + " " + Form4.degre + "/8" + "\n" +
                        "ΜΠΟΡΕΙΣ ΝΑ " + "\n" + "ΞΑΝΑ-ΠΡΟΣΠΑΘΗΣΕΙΣ!!";
                }
                Form4.f4 = false;
            }
            else if (Form6.f6)
            {
                if (Form6.value >= 6)
                {
                    pictureBox1.Image = Properties.Resources.win;
                    label1.ForeColor = Color.Green;
                    button2.Visible = true;
                    label1.Text = "ΜΠΡΑΒΟΟ!!!!!" + " " + Form2.user + "\n" + "ΠΕΡΑΣΕΣ ΤΟ ΔΕΥΤΕΡΟ" + "\n" + "ΕΠΙΠΕΔΟ ΜΕ" + " " + Form6.value + "/8" + "\n" +
                        "TΩΡΑ ΜΠΟΡΕΙΣ ΝΑ" + "\n" + " ΣΥΝΕΧΙΣΕΙΣ ΚΑΙ" + "\n" + " ΣΤΑ ΕΠΟΜΕΝΑ ΕΠΙΠΕΔΑ!!";
                    String constring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Vasilis\\source\\repos\\Ekpaideutiko_L\\Ekpaideutiko_L\\Database1.mdf;Integrated Security=True";
                    SqlConnection conn = new SqlConnection(constring);
                    conn.Open();
                    try
                    {
                        SqlCommand command = new SqlCommand("UPDATE it SET le2 = @de,le3 = @cit Where email = '" + Form1.id + "' ", conn);
                        command.Parameters.AddWithValue("@de", Form6.value);
                        command.Parameters.AddWithValue("@cit", 1);
                        SqlDataReader reader = command.ExecuteReader();
                        conn.Close();
                    }
                    catch (Exception ex) { MessageBox.Show(ex.ToString()); }

                }
                else
                {
                    pictureBox1.Image = Properties.Resources.lose;
                    label1.ForeColor = Color.Red;
                    label1.Text = "ΜΑΛΛΟΝ ΔΕΝ ΔΙΑΒΑΣΕΣ" + "\n" + " ΚΑΛΑ" + " " + Form2.user + "\n" + "ΚΟΠΗΚΕΣ ΣΤΟ ΔΕΥΤΕΡΟ" + "\n" + " ΕΠΙΠΕΔΟ ΜΕ" + " " + Form6.value + "/8" + "\n" +
                        "ΜΠΟΡΕΙΣ ΝΑ " + "\n" + "ΞΑΝΑ-ΠΡΟΣΠΑΘΗΣΕΙΣ!!";
                }
                Form6.f6 = false;
            }
            else if (Form7.f7)
            {
                if (Form7.value7 >= 6)
                {
                    pictureBox1.Image = Properties.Resources.win;
                    label1.ForeColor = Color.Green;
                    button2.Visible = true;
                    label1.Text = "ΜΠΡΑΒΟΟ!!!!!" + " " + Form2.user + "\n" + "ΠΕΡΑΣΕΣ ΤΟ ΤΡΙΤΟ" + "\n" + "ΕΠΙΠΕΔΟ ΜΕ" + " " + Form7.value7 + "/8" + "\n" +
                        "TΩΡΑ ΜΠΟΡΕΙΣ ΝΑ" + "\n" + " ΣΥΝΕΧΙΣΕΙΣ ΚΑΙ" + "\n" + " ΣΤΑ ΕΠΟΜΕΝΑ ΕΠΙΠΕΔΑ!!";
                    String constring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Vasilis\\source\\repos\\Ekpaideutiko_L\\Ekpaideutiko_L\\Database1.mdf;Integrated Security=True";
                    SqlConnection conn = new SqlConnection(constring);
                    conn.Open();
                    try
                    {
                        SqlCommand command = new SqlCommand("UPDATE it SET le3 = @de,l4 = @cit Where email = '" + Form1.id + "' ", conn);
                        command.Parameters.AddWithValue("@de", Form7.value7);
                        command.Parameters.AddWithValue("@cit", 1);
                        SqlDataReader reader = command.ExecuteReader();
                        conn.Close();
                    }
                    catch (Exception ex) { MessageBox.Show(ex.ToString()); }

                }
                else
                {
                    pictureBox1.Image = Properties.Resources.lose;
                    label1.ForeColor = Color.Red;
                    label1.Text = "ΜΑΛΛΟΝ ΔΕΝ ΔΙΑΒΑΣΕΣ" + "\n" + " ΚΑΛΑ" + " " + Form2.user + "\n" + "ΚΟΠΗΚΕΣ ΣΤΟ ΤΡΙΤΟ" + "\n" + " ΕΠΙΠΕΔΟ ΜΕ" + " " + Form7.value7 + "/8" + "\n" +
                        "ΜΠΟΡΕΙΣ ΝΑ " + "\n" + "ΞΑΝΑ-ΠΡΟΣΠΑΘΗΣΕΙΣ!!";
                }
                Form7.f7 = false;
            }
            else if (Form8.f8)
            {
                if (Form8.value8 >= 6)
                {
                    pictureBox1.Image = Properties.Resources.win;
                    label1.ForeColor = Color.Green;
                    button2.Visible = true;
                    label1.Text = "ΜΠΡΑΒΟΟ!!!!!" + " " + Form2.user + "\n" + "ΠΕΡΑΣΕΣ ΤΟ ΤΕΤΑΡΤΟ" + "\n" + "ΕΠΙΠΕΔΟ ΜΕ" + " " + Form8.value8 + "/8" + "\n" +
                        "TΩΡΑ ΜΠΟΡΕΙΣ ΝΑ" + "\n" + " ΚΑΝΕΙΣ ΤΟ" + "\n" + "ΕΠΑΝΑΛΗΠΤΙΚΟ ΤΕΣΤ";
                    String constring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Vasilis\\source\\repos\\Ekpaideutiko_L\\Ekpaideutiko_L\\Database1.mdf;Integrated Security=True";
                    SqlConnection conn = new SqlConnection(constring);
                    conn.Open();
                    try
                    {
                        SqlCommand command = new SqlCommand("UPDATE it SET l4 = @de Where email = '" + Form1.id + "' ", conn);
                        command.Parameters.AddWithValue("@de", Form8.value8);
                        SqlDataReader reader = command.ExecuteReader();
                        conn.Close();
                    }
                    catch (Exception ex) { MessageBox.Show(ex.ToString()); }

                }
                else
                {
                    pictureBox1.Image = Properties.Resources.lose;
                    label1.ForeColor = Color.Red;
                    label1.Text = "ΜΑΛΛΟΝ ΔΕΝ ΔΙΑΒΑΣΕΣ" + "\n" + " ΚΑΛΑ" + " " + Form2.user + "\n" + "ΚΟΠΗΚΕΣ ΣΤΟ ΤΕΤΑΡΤΟ" + "\n" + " ΕΠΙΠΕΔΟ ΜΕ" + " " + Form8.value8 + "/8" + "\n" +
                        "ΜΠΟΡΕΙΣ ΝΑ " + "\n" + "ΞΑΝΑ-ΠΡΟΣΠΑΘΗΣΕΙΣ!!";
                }
                Form8.f8 = false;
            }
            else if (Form9.f9) 
            {
                if (Form9.revision >= 6) 
                {
              
                    pictureBox1.Image = Properties.Resources.win;
                    label1.ForeColor = Color.Green;
                    label1.Text = "ΜΠΡΑΒΟΟ!!!!!" + " " + Form2.user + "\n" + "ΠΕΡΑΣΕΣ ΤΟ ΤΕΣΤ" + "\n" + "ΕΠΑΝΑΛΥΨΗΣ ΜΕ" + " " + Form9.revision + "/8" + "\n" +
                        "TΩΡΑ ΜΠΟΡΕΙΣ ΝΑ" + "\n" + " ΚΑΝΕΙΣ ΤΟ" + "\n" + "ΕΡΩΤΗΜΑΤΟΛΟΓΙΟ !!";
                }
                else 
                {
                    pictureBox1.Image = Properties.Resources.lose;
                    label1.ForeColor = Color.Red;
                    label1.Text = "ΜΑΛΛΟΝ ΔΕΝ ΔΙΑΒΑΣΕΣ" + "\n" + " ΚΑΛΑ" + " " + Form2.user + "\n" + "ΚΟΠΗΚΕΣ " + "\n" + " ΜΕ" + " " + Form9.revision + "/8" + "\n" +
                        "ΜΠΟΡΕΙΣ ΝΑ " + "\n" + "ΞΑΝΑ-ΠΡΟΣΠΑΘΗΣΕΙΣ!!";
                }
                Form9.revision = 0;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();f2.Show();
        }

    }
}
