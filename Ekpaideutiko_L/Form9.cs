using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ekpaideutiko_L
{
    public partial class Form9 : Form
    {
        int l1, l2, l3, l4;
        public static int revision;
        public static bool f9,paidagvghka,ugeia;
        int k1, k2, k3, k4;
        List<int> list = new List<int> { };
        public static int kef1, kef2, kef3, kef4;
        bool er, ep;
        int level;
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            button3.Enabled = false;
            revision = 0;
            f9 = false;
            er = false;
            ep = false;
            if (Form2.avatar.Equals("man"))
                pictureBox1.Image = Properties.Resources.man;
            else
                pictureBox1.Image = Properties.Resources.woman;
            textBox1.Text = Form2.user;
            textBox2.Text = Form1.id;

            String constring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Vasilis\\source\\repos\\Ekpaideutiko_L\\Ekpaideutiko_L\\Database1.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            try
            {
                SqlCommand command = new SqlCommand("SELECT * FROM it where email='" + Form1.id + "'", conn);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.GetInt32(7) >= 6) 
                    {
                        textBox3.Text = "4 ΤΕΛΕΙΟΦΟΙΤΟΣ";button1.Enabled = true;
                        groupBox3.Visible = true;
                    }
                    else if (reader.GetInt32(6) >= 6)
                        textBox3.Text = "3 ΠΡΟΧΩΡΗΜΕΝΟΣ";
                    else if (reader.GetInt32(5) >= 6)
                        textBox3.Text = "2 AΡΧΑΡΙΟΣ";
                    else if (reader.GetInt32(4) >= 1)
                        textBox3.Text = "1 ΝΕΟΣΥΛΛΕΚΤΟΣ";

                    l1 = reader.GetInt32(4);
                    l2 = reader.GetInt32(5);
                    l3 = reader.GetInt32(6);
                    l4 = reader.GetInt32(7);
                    k1 = l1; k2 = l2;k3 = l3;k4 = l4;
                    level = reader.GetInt32(8);
                    if (level >= 6) button2.Enabled = true;//se periptvsh pou exei perasei thn epanalypsi
                    if (reader.GetString(9).Equals("xxx")) textBox4.Text = "ΔΕΝ ΕΧΕΙ ΕΠΙΛΕΓΕΙ";
                    else textBox4.Text = reader.GetString(9);

                }
      
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }

        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)//Gia to epnalyptiko test
        {
            if (level<6) { button3.Enabled = true; ep = true; }
            button1.Enabled= false;
            revision = 0;
            groupBox3.Text = "EΠΑΝΑΛΥΠΤΙΚΟ ΤΕΣΤ ΟΛΩΝ ΤΩΝ ΚΕΦΑΛΑΙΩΝ";
            label8.Text = "1.Τι είδους δεδομένα αποθηκευουμε με τον τύπο String τις java;";
            comboBox1.Items.Add("Ακαιρέους"); comboBox1.Items.Add("αλφαριθμητικα"); comboBox1.Items.Add("κανενα");

            label9.Text = "2.Ποιες ικανότητες απαιτούνται για έναν A/I machin learning;";
            comboBox2.Items.Add("Δύκτια"); comboBox2.Items.Add("Λογιστικά"); comboBox2.Items.Add("Python");

            label10.Text = "3.Τι είναι τα Generators της Python;";
            comboBox3.Items.Add("συνάρτηση"); comboBox3.Items.Add("λειτουργία"); comboBox3.Items.Add("διαδικασία");

            label11.Text = "4.Ποιο απο τα παρακατω δεν είναι μεταβλητη στην C#;";
            comboBox4.Items.Add("string"); comboBox4.Items.Add("int"); comboBox4.Items.Add("presentation");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ep)
            {
                if (comboBox1.Text.Equals("αλφαριθμητικα")) revision += 2;
                if (comboBox2.Text.Equals("Python")) revision += 2;
                if (comboBox3.Text.Equals("συνάρτηση")) revision += 2;
                if (comboBox4.Text.Equals("presentation")) revision += 2;

                String constring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Vasilis\\source\\repos\\Ekpaideutiko_L\\Ekpaideutiko_L\\Database1.mdf;Integrated Security=True";
                SqlConnection conn = new SqlConnection(constring);
                conn.Open();
                try
                {
                    SqlCommand command = new SqlCommand("UPDATE it SET revis = @de Where email = '" + Form1.id + "' ", conn);
                    command.Parameters.AddWithValue("@de", revision);
                    SqlDataReader reader = command.ExecuteReader();
                    conn.Close();
                }
                catch (Exception ex) { MessageBox.Show(ex.ToString()); }

                if (revision >= 6)
                {
                    button3.Enabled = false; button1.Enabled = false; button2.Enabled = true; ep = false;
                }
                f9 = true;
                Form5 f5 = new Form5(); f5.Show();
                
            }
            else if (er) 
            {
                paidagvghka = false;
                ugeia = false;
                int count = 4;kef1 = 0;kef2 =0;kef3 =0;kef4 =0;
                //για την αγαπημενη κατευθινση
                if (comboBox1.Text.Equals("UX DESIGNER"))
                    k1 += 2;
                if (comboBox1.Text.Equals("DATA PROTECTION"))
                    k3 += 2;
                if (comboBox1.Text.Equals("A/I MACH.LEARNING"))
                    k2 += 2;
                if (comboBox1.Text.Equals("WEB DEVELOPER"))
                    k4 += 2;
                //Για την γλωσσα προγραμματισμου
                if (comboBox2.Text.Equals("java"))
                    k1 += 2;
                if (comboBox2.Text.Equals("Python")) { k2 += 2; k3 += 2; }
                if (comboBox2.Text.Equals("C#"))
                    k4 += 2;
                list.Add(k1); list.Add(k2); list.Add(k3); list.Add(k4);
                list.Sort();
                foreach (int x in list) 
                {
                    if ((x == k1)&&(kef1==0)) kef1 =count;
                    else if ((x == k2) && (kef2==0)) kef2 = count;
                    else if ((x == k3) && (kef3==0)) kef3 = count;
                    else if ((x == k4) && (kef4==0)) kef4 = count;
                    count--;
                }
                if (comboBox3.Text.Equals("ΝΑΙ")) ugeia = true;
                if (comboBox4.Text.Equals("ΜΟΥ ΑΡΕΣΕΙ")) paidagvghka = true;
                Form10 f10 = new Form10();f10.Show();
                er = false;
                button3.Enabled = false;
                list.Clear();
            }
           
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            er = true;
            groupBox3.Text = "Ερωτηματολόγια στο πλαίσιο ενός μικρού υποσυστήματος συστάσεων";
            comboBox1.Items.Clear();comboBox2.Items.Clear();comboBox3.Items.Clear();comboBox4.Items.Clear();
            comboBox1.Text = ""; comboBox2.Text = ""; comboBox3.Text = ""; comboBox4.Text = "";

            button3.Enabled = true;
            label8.Text = "1.Ποιος απο τους παρακατω επαγ.προσανατολισμους είναι ο αγαπημένος σου? ";
            comboBox1.Items.Add("UX DESIGNER"); comboBox1.Items.Add("DATA PROTECTION"); comboBox1.Items.Add("WEB DEVELOPER");
            comboBox1.Items.Add("A/I MACH.LEARNING"); comboBox1.Items.Add("ΚΑΝΕΝΑΣ");

            label9.Text = "2.Πάνω σε ποια γλωσσα προγραμματισμου σου αρεσει να εργαζεσαι;";
            comboBox2.Items.Add("java"); comboBox2.Items.Add("Python"); comboBox2.Items.Add("C#"); comboBox2.Items.Add("ΚΑΜΙΑ");

            label10.Text = "3.Σου αρέσει να ασχολήσε με θέματα που αφορούν την υγεία ;";
            comboBox3.Items.Add("ΝΑΙ"); comboBox3.Items.Add("ΟΧΙ");

            label11.Text = "4.Tη έχεις να πεις για τον κλαδο της εργασίς στην εκπαιδευσης;";
            comboBox4.Items.Add("ΜΟΥ ΑΡΕΣΕΙ"); comboBox4.Items.Add("ΔΕΝ Μ'ΑΡΕΣΕΙ");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            //
        }

        private void label6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ΑΝΑΛΥΤΙΚΗ ΒΑΘΜΟΛΟΓΙΑ"+"\n"+"" +
                "1 ΚΕΦΑΛΑΙΟ"+" : "+l1.ToString()+"/8"+"\n"+"" +
                "2 ΚΕΦΑΛΑΙΟ" + " : " + l2.ToString() + "/8" + "\n" + "" +
                "3 ΚΕΦΑΛΑΙΟ" + " : " + l3.ToString() + "/8" + "\n" + "" +
                "4 ΚΕΦΑΛΑΙΟ" + " : " + l4.ToString() + "/8"+"\n"+""+
                "ΕΠΑΝΑΛHΠΤΙΚΟ ΤΕΣΤ"+" : "+level.ToString()+"/8");
        }
    }
}
