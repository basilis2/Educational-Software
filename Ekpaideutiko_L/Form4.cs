using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ekpaideutiko_L
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        int count = 0;
        public static int degre;
        public static bool f4,f04;
        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            label4.Visible = true;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            label4.Visible = false;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            label6.Visible = true;label6.Text = "ΤΕΧΝΟΛΟΓΙΕΣ ΔΙΑΔΥΚΤΙΟΥ";
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            label6.Visible = false;

        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            label6.Visible = true; label6.Text = "ΑΝΤΙΚΕΙΜΕΝΟΣΤΡΕΦΗΣ ΠΡΟΓΡΑΜΜΑΤΙΣΜΟΣ";
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            label6.Visible = false;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            count = 1;
            degre = 0;
            f04 = false;
            f4 = false;
            if (Form2.avatar.Equals("man"))
                pictureBox1.Image = Properties.Resources.man;
            else
                pictureBox1.Image = Properties.Resources.woman;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("UX DESIGNER--ΕΙΣΑΓΩΓΗ");
            listBox1.Items.Add("\n");
            listBox1.Items.Add("1.ΜΕ ΤΗ ΑΣΧΟΛΕΙΤΑΙ ΕΝΑΣ UX DESIGNER");
            listBox1.Items.Add("   O UX Designer εστιάζει στην αλληλεπίδραση μεταξύ");
            listBox1.Items.Add("   ανθρώπων και καθημερινών προϊόντων και υπηρεσιών");
            listBox1.Items.Add("   όπως ιστότοπους,εφαρμογές ακομα και μηχανές καφέ.");
            listBox1.Items.Add("\n");
            listBox1.Items.Add("2.Ποιες ικανότητες απαιτούνται?");
            listBox1.Items.Add("  ~ΤΕΧΝΟΛΟΓΙΕΣ ΔΙΑΔΥΚΤΙΟΥ");
            listBox1.Items.Add("  ~ΑΝΤΙΚΕΙΜΕΝΟΣΤΡΕΦΗΣ ΠΡΟΓΡΑΜΜΑΤΙΣΜΟΣ");
            listBox1.Items.Add("\n");
            listBox1.Items.Add("3.KΑΤΗΓΟΡΙΕΣ UX DESIGNER");
            listBox1.Items.Add("  ~interaction design");
            listBox1.Items.Add("  ~visual design");
            listBox1.Items.Add("  ~information architecture");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            count++;
            listBox1.Items.Clear();
            listBox1.Items.Add("ΤΕΧΝΟΛΟΓΙΕΣ ΔΙΑΔΥΚΤΙΟΥ--ΘΕΩΡΙΑ");
            listBox1.Items.Add("\n");
            listBox1.Items.Add("1.ΜΕ ΤΗ ΑΣΧΟΛΕΙΤΑΙ TO ΜΑΘΗΜΑ ΑΥΤΟ?");
            listBox1.Items.Add("   Σε αυτό το μάθημα θα μάθουμε τα");
            listBox1.Items.Add("   βασικά για την γλώσσα προγραμματισμού HTML");
            listBox1.Items.Add("   η οποία είναι πολύ χρησιμη εαν θεσ να γίνεις ενας.");
            listBox1.Items.Add("   πολύ καλός UX DESIGNER.");
            listBox1.Items.Add("\n");
            listBox1.Items.Add("2.ΒΑΣΙΚΕΣ ΕΝΤΟΛΕΣ HTML:");
            listBox1.Items.Add("  ~<h1>ή<h2>ή...ή<h6> Το οποίο είναι για Headings");
            listBox1.Items.Add("    όπου καθως μεγαλώνει ο αριθμος μικρένει η γραμματοσειρα");
            listBox1.Items.Add("  ~<p> **** </p> Tο οποιο ειναι");
            listBox1.Items.Add("    για Paragraphs");
            listBox1.Items.Add("  ~<a href=https:www.unipi.com>Ονομα</a> To οποίο είναι");
            listBox1.Items.Add("    για Links");
            listBox1.Items.Add("  ~<p style=color:blue;>The sky is really blue today.</p>");
            listBox1.Items.Add("    Για να δωσουμε χρώμα");
            listBox1.Items.Add("\n");
            listBox1.Items.Add("                               ΤΕΛΟΣ !! ");
            if( (count >= 3)&& Form2.l1<6)
            {
                button4.Visible = true;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            count++;
            listBox1.Items.Clear();
            listBox1.Items.Add("ΑΝΤΙΚΕΙΜΕΝΟΣΤΡΕΦΗΣ ΠΡΟΓΡΑΜΜΑΤΙΣΜΟΣ--ΘΕΩΡΙΑ");
            listBox1.Items.Add("\n");
            listBox1.Items.Add("1.ΜΕ ΤΗ ΑΣΧΟΛΕΙΤΑΙ TO ΜΑΘΗΜΑ ΑΥΤΟ?");
            listBox1.Items.Add("   Σε αυτό το μάθημα θα μάθουμε τα");
            listBox1.Items.Add("   βασικά για την γλώσσα προγραμματισμού java");
            listBox1.Items.Add("   η οποία είναι πολύ χρησιμη εαν θεσ να γίνεις ενας.");
            listBox1.Items.Add("   πολύ καλός UX DESIGNER.");
            listBox1.Items.Add("\n");
            listBox1.Items.Add("2.ΒΑΣΙΚΗ ΓΝΩΣΗ ΓΙΑ JAVA:");
            listBox1.Items.Add("  ~Java Modifiers : Access Modifiers:");
            listBox1.Items.Add("      1.default");
            listBox1.Items.Add("      2.public");
            listBox1.Items.Add("      3.protected");
            listBox1.Items.Add("      4.private");
            listBox1.Items.Add("  ~Java Modifiers :Non-access Modifiers");
            listBox1.Items.Add("      1.final");
            listBox1.Items.Add("      2.abstract");
            listBox1.Items.Add("  ~Java Variables");
            listBox1.Items.Add("      1.Local Variables");
            listBox1.Items.Add("      2.Class Variables (Static Variables)");
            listBox1.Items.Add("      3.Instance Variables (Non-static Variables");
            listBox1.Items.Add("  ~Basic Datatypes");
            listBox1.Items.Add("      1.int:Για ακαιρεους αριθμους");
            listBox1.Items.Add("      2.float :Για αριθμούς με κόμα");
            listBox1.Items.Add("      3.String:Για αλφαριθμητικα");
            listBox1.Items.Add("\n");
            listBox1.Items.Add("                               ΤΕΛΟΣ !! ");

            if ((count >= 3) && Form2.l1<6 )
            {
                button4.Visible = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            listBox1.Items.Clear();
            listBox1.Items.Add("                              ΠΡΟΣΟΧΗ!!!!!!");
            listBox1.Items.Add("          THN ΩΡΑ ΤΟΥ ΤΕΣΤ ΔΕΝ ΜΠΟΡΕΙΣ ΝΑ ΔΕΙΣ ");
            listBox1.Items.Add("     THN ΘΕΩΡΙΑ ΤΩΝ ΚΕΦΑΛΑΙΩΝ ΤΟΥ ΑΝΤΙΣΤΟΙΧΟΥ LEVEL!");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Checked = false;
            checkBox3.Checked = false;

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox3.Checked = false;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Checked = false;
            checkBox1.Checked = false;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            checkBox5.Checked = false;
            checkBox6.Checked = false;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            checkBox4.Checked = false;
            checkBox6.Checked = false;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            checkBox5.Checked = false;
            checkBox4.Checked = false;
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            checkBox8.Checked = false;
            checkBox9.Checked = false;
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            checkBox7.Checked = false;
            checkBox9.Checked = false;
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            checkBox8.Checked = false;
            checkBox7.Checked = false;
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            checkBox11.Checked = false;
            checkBox12.Checked = false;
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            checkBox10.Checked = false;
            checkBox12.Checked = false;
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            checkBox11.Checked = false;
            checkBox10.Checked = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            degre = 0;
            if (checkBox10.Checked) degre += 2;
            if(checkBox8.Checked) degre += 2;
            if (checkBox6.Checked) degre += 2;
            if (checkBox2.Checked) degre += 2;
            f4 = true;
            Form5 f5 = new Form5(); f5.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9(); f9.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            f04 = true; Form11 f11 = new Form11();f11.Show();
        }
    }
}
