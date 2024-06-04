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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        int count;
        public static int value8;
        public static bool f8,f08;
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

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("                              ΠΡΟΣΟΧΗ!!!!!!");
            listBox1.Items.Add("          THN ΩΡΑ ΤΟΥ ΤΕΣΤ ΔΕΝ ΜΠΟΡΕΙΣ ΝΑ ΔΕΙΣ ");
            listBox1.Items.Add("     THN ΘΕΩΡΙΑ ΤΩΝ ΚΕΦΑΛΑΙΩΝ ΤΟΥ ΑΝΤΙΣΤΟΙΧΟΥ LEVEL!");
            groupBox2.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            intro();
            count = 0;
            f8 = false;
            f08 = false;
        }
        public void intro() 
        {
            groupBox2.Visible = false;
            listBox1.Items.Clear();
            listBox1.Items.Add("WEB PROGRAMMING--ΕΙΣΑΓΩΓΗ");
            listBox1.Items.Add("\n");
            listBox1.Items.Add("1.ΜΕ ΤΗ ΑΣΧΟΛΕΙΤΑΙ ΕΝΑΣ Web Programmer");
            listBox1.Items.Add("   Ο προγραμματισμός Ιστού είναι η  ");
            listBox1.Items.Add("   διαδικασία δημιουργίας ιστοσελίδων.");
            listBox1.Items.Add("   Κατά τη διάρκεια αυτής της διαδικασίας,");
            listBox1.Items.Add("   ο προγραμματιστής είναι υπεύθυνος για ");
            listBox1.Items.Add("   τη διαμόρφωση του ιστότοπου σύμφωνα με ");
            listBox1.Items.Add("   τις απαιτήσεις και τις ανάγκες της εταιρείας");
            listBox1.Items.Add("\n");
            listBox1.Items.Add("2.Ποιες ικανότητες-Γνωσεις απαιτούνται?");
            listBox1.Items.Add("  ~Τεχνολογια Λογισμικού(c#)");
            listBox1.Items.Add("  ~Internet and WEb programming (Servlets)");
            listBox1.Items.Add("\n");
            listBox1.Items.Add("3.KΑΤΗΓΟΡΙΕΣ WEB PROGRAMMING");
            listBox1.Items.Add("  ~Front-end web development ");
            listBox1.Items.Add("     1. JavaScript");
            listBox1.Items.Add("     2. HTML");
            listBox1.Items.Add("     3. React");
            listBox1.Items.Add("  ~Back-end web development");
            listBox1.Items.Add("     1. Python");
            listBox1.Items.Add("     2. Java");
            listBox1.Items.Add("     3. SQL");
            listBox1.Items.Add("     4. C#");
            listBox1.Items.Add("  ~Full-stack web development ");
            listBox1.Items.Add("     1. Java");
            listBox1.Items.Add("     2. HTML");
            listBox1.Items.Add("  ~Content developer ");
            listBox1.Items.Add("     1. HTML");
            listBox1.Items.Add("     2. JavaScript");
            listBox1.Items.Add("     3. PHP");
            listBox1.Items.Add("  ~Webmaster");
            listBox1.Items.Add("     1. Object-Oriented Programming");
            listBox1.Items.Add("     2. Programming with MySQL");
            listBox1.Items.Add("     3. Web services with node.js, XML..");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            count++;
            listBox1.Items.Clear();
            listBox1.Items.Add("TΕXΝΟΛΟΓΙΑ ΛΟΓΙΣΜΙΚΟΥ--ΘΕΩΡΙΑ");
            listBox1.Items.Add("\n");
            listBox1.Items.Add("1.ΜΕ ΤΗ ΑΣΧΟΛΕΙΤΑΙ TO ΜΑΘΗΜΑ ΑΥΤΟ?");
            listBox1.Items.Add("   To μαθημα αυτο περιλαμβάνει πληρορ=φορίες ");
            listBox1.Items.Add("   σχετικά με την γλώσσα προγραμματισμού ");
            listBox1.Items.Add("   c# η οποία αποτελεί μεγάλο μέρος για την ");
            listBox1.Items.Add("   καριέρα ενός Web Programmer ,αλλα θα δούμε.");
            listBox1.Items.Add("   και μια εισαγωγή στην Γλώσσα μοντελοποίησης UML!");
            listBox1.Items.Add("\n");
            listBox1.Items.Add("2.ΒΑΣΙΚΕΣ ΕΝΤΟΛΕΣ C#:");
            listBox1.Items.Add("\n");
            listBox1.Items.Add("  ~Console.WriteLine(.....);H οποια εντολή εμφανίζει το ");
            listBox1.Items.Add("    αποτελεσμα που υπαρχει αναμεσα στις παρενθεσεις ");
            listBox1.Items.Add("\n");
            listBox1.Items.Add("  ~static void MyMethod(), Εντολή που δημιουργεί μεθοδο");
            listBox1.Items.Add("    η οποία δεδν επιστρέφει κατι σαν αποτελεσμα");
            listBox1.Items.Add("\n");
            listBox1.Items.Add("  ~C# Variables");
            listBox1.Items.Add("     1.string :Για αλφαριθμητικα");
            listBox1.Items.Add("     2.int :Ακεραιους αριθμούς ");
            listBox1.Items.Add("     3.bool : Για true ή false ");
            listBox1.Items.Add("     4.float :Για αριθμούς με κόμα");
            listBox1.Items.Add("\n");
            listBox1.Items.Add("  ~UML- Modeling Types");
            listBox1.Items.Add("     1.Classes diagrams");
            listBox1.Items.Add("     2.Objects diagrams ");
            listBox1.Items.Add("     3.Deployment diagrams");
            listBox1.Items.Add("     4.Package diagrams ");
            listBox1.Items.Add("     5.Composite structure diagram");
            listBox1.Items.Add("     6.Component diagram");
            listBox1.Items.Add("\n");
            listBox1.Items.Add("                               ΤΕΛΟΣ !! ");
            if ((count >= 3) && Form2.l4 < 6)
            {
                button4.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            intro();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            label6.Visible = true;
            label6.Text = "Tεχνολογιες Λογισμικου C#";
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            label6.Visible = false;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            label6.Visible = true;
            label6.Text = "Internet And Web Programming";
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            label6.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            count++;
            listBox1.Items.Clear();
            listBox1.Items.Add("Internet-Web Programming--ΘΕΩΡΙΑ");
            listBox1.Items.Add("\n");
            listBox1.Items.Add("1.ΜΕ ΤΗ ΑΣΧΟΛΕΙΤΑΙ TO ΜΑΘΗΜΑ ΑΥΤΟ?");
            listBox1.Items.Add("   Το μάθημα ασχολείται με τη θεωρητική μελέτη  ");
            listBox1.Items.Add("   και την πρακτική εξάσκηση σε θέματα ");
            listBox1.Items.Add("   προγραμματισμού στο διαδίκτυο και στον  ");
            listBox1.Items.Add("   παγκόσμιο ιστό, όπως προγραμματισμό sockets");
            listBox1.Items.Add("   την υλοποίηση εφαρμογών πελάτη-εξυπηρετητή ");
            listBox1.Items.Add("   και τις αρχιτεκτονικές 3-tier.");
            listBox1.Items.Add("\n");
            listBox1.Items.Add("2.ΒΑΣΙΚΕΣ αρχες 3-tier:");
            listBox1.Items.Add("    Επίπεδο 1 (presentation):Το επίπεδο 1 ασχολείται");
            listBox1.Items.Add("    με την παρουσίαση");
            listBox1.Items.Add("\n");
            listBox1.Items.Add("    Επίπεδο 2 (business logic): Το μεσαίο επίπεδο");
            listBox1.Items.Add("    υλοποιεί τις λειτουργίες της εφαρμογής.Συντονίζει");
            listBox1.Items.Add("    τις διεργασίες,λαμβάνει αποφάσεις και εκτελεί υπολογισμούς ");
            listBox1.Items.Add("\n");
            listBox1.Items.Add("    Επίπεδο 3 (data):Το επίπεδο 3 διαχειρίζεται ");
            listBox1.Items.Add("    τα δεδομένα της εφαρμογής.Η πληροφορία αποθηκεύεται");
            listBox1.Items.Add("    και ανακτάται μέσω μιας Βάσης Δεδομένων.");
            listBox1.Items.Add("\n");
            listBox1.Items.Add("                               ΤΕΛΟΣ !! ");
            if ((count >= 3) && Form2.l4 < 6)
            {
                button4.Visible = true;
            }
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

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            checkBox5.Checked = false;
            checkBox4.Checked = false;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            checkBox6.Checked = false;
            checkBox4.Checked = false;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            checkBox6.Checked = false;
            checkBox5.Checked = false;
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            checkBox7.Checked = false;
            checkBox8.Checked = false;
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            checkBox9.Checked = false;
            checkBox7.Checked = false;
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            checkBox9.Checked = false;
            checkBox8.Checked = false;
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            checkBox11.Checked = false;
            checkBox10.Checked = false;
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            checkBox12.Checked = false;
            checkBox10.Checked = false;
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            checkBox12.Checked = false;
            checkBox11.Checked = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            value8 = 0;
            if (checkBox3.Checked) value8 += 2;
            if (checkBox5.Checked) value8 += 2;
            if (checkBox9.Checked) value8 += 2;
            if (checkBox11.Checked) value8 += 2;
            f8 = true;
            Form5 f5 = new Form5(); f5.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9(); f9.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            f08 = true; Form11 f11 = new Form11(); f11.Show();
        }
    }
}
