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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }
        String epilogh;

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            if (Form9.kef1.Equals(1)) { label4.Text = "UX DESIGNER";epilogh= "UX DESIGNER"; label7.Text = "Ψηφιακός Πολιτισμός, Έξυπνες Πόλεις,PAPEI"; }
            else if (Form9.kef2.Equals(1)) { label4.Text = "A/I MACHINE LEARNING"; epilogh = "A/I MACHINE LEARNING"; label7.Text = "Ανάπτυξη Λογισμικού και Τεχνητής Νοημοσύνης,PAPEI"; }
            else if (Form9.kef3.Equals(1)) { label4.Text = "DATA PROTECTION"; epilogh = "DATA PROTECTION"; label7.Text = "Κυβερνοασφάλεια και Επιστήμη Δεδομένων,PAPEI"; }
            else if (Form9.kef4.Equals(1)) { label4.Text = "WEB DEVELOPER"; epilogh = "WEB DEVELOPER"; label7.Text = "Ανάπτυξη Λογισμικού και Τεχνητής Νοημοσύνης,PAPEI"; }

            if (Form9.kef1.Equals(2)) {label8.Text = "Ψηφιακός Πολιτισμός, Έξυπνες Πόλεις,PAPEI"; }
            else if (Form9.kef2.Equals(2)) { label8.Text = "Ανάπτυξη Λογισμικού και Τεχνητής Νοημοσύνης,PAPEI"; }
            else if (Form9.kef3.Equals(2)) { label8.Text = "Κυβερνοασφάλεια και Επιστήμη Δεδομένων,PAPEI"; }
            else if (Form9.kef4.Equals(2)) { label8.Text = "Ανάπτυξη Λογισμικού και Τεχνητής Νοημοσύνης,PAPEI"; }

            if (Form9.kef1.Equals(3)) { label9.Text = "Ψηφιακός Πολιτισμός, Έξυπνες Πόλεις,PAPEI"; }
            else if (Form9.kef2.Equals(3)) { label9.Text = "Ανάπτυξη Λογισμικού και Τεχνητής Νοημοσύνης,PAPEI"; }
            else if (Form9.kef3.Equals(3)) { label9.Text = "Κυβερνοασφάλεια και Επιστήμη Δεδομένων,PAPEI"; }
            else if (Form9.kef4.Equals(3)) { label9.Text = "Ανάπτυξη Λογισμικού και Τεχνητής Νοημοσύνης,PAPEI"; }

            if (Form9.ugeia) { label10.Visible = true;label10.Text = "Οργάνωση και Διοίκηση Υπηρεσιών Υγείας,PAPEI"; }
            if ((Form9.paidagvghka)&&(Form9.ugeia==false)) { label10.Visible = true; label10.Text = "Τεχνολογίες της Πληροφορικής και των Επικοινωνιών στην Εκπαίδευση,PAPEI"; }
            else if(Form9.paidagvghka) { label11.Visible = true; label11.Text = "Τεχνολογίες της Πληροφορικής και των Επικοινωνιών στην Εκπαίδευση,PAPEI"; }


            String constring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Vasilis\\source\\repos\\Ekpaideutiko_L\\Ekpaideutiko_L\\Database1.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            try
            {
                SqlCommand command = new SqlCommand("UPDATE it SET resualt = @de Where email = '" + Form1.id + "' ", conn);
                command.Parameters.AddWithValue("@de", epilogh);
                SqlDataReader reader = command.ExecuteReader();
                conn.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
