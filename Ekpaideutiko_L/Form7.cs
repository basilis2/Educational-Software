using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Ekpaideutiko_L
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        int count;
        public static int value7;
        public static bool f7,f07;

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            label4.Visible = true; ;
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
            intro();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            intro();
            count = 0;
            f7 = false;
            f07 = false;
        }
        public void intro() 
        {
            groupBox2.Visible = false;
            listBox1.Items.Clear();
            listBox1.Items.Add("DATA PROTECTION--ΕΙΣΑΓΩΓΗ");
            listBox1.Items.Add("\n");
            listBox1.Items.Add("1.ΜΕ ΤΗ ΑΣΧΟΛΕΙΤΑΙ ΕΝΑΣ DATA PROTECTION");
            listBox1.Items.Add("   Η πρόκληση της προστασίας δεδομένων προσωπικού  ");
            listBox1.Items.Add("   χαρακτήρα είναι η χρήση");
            listBox1.Items.Add("   δεδομένων προστατεύοντας ταυτόχρονα τις ");
            listBox1.Items.Add("   προτιμήσεις απορρήτου ενός ατόμου");
            listBox1.Items.Add("   και τις προσωπικές του πληροφορίες . ");
            listBox1.Items.Add("   Τα πεδία της ασφάλειας υπολογιστών,");
            listBox1.Items.Add("   της ασφάλειας των δεδομένων και της ");
            listBox1.Items.Add("   ασφάλειας των πληροφοριών σχεδιάζουν");
            listBox1.Items.Add("   και χρησιμοποιούν λογισμικό, υλικό και ");
            listBox1.Items.Add("   ανθρώπινο δυναμικό για την αντιμετώπιση ");
            listBox1.Items.Add("   αυτού του ζητήματος ");
            listBox1.Items.Add("\n");
            listBox1.Items.Add("2.Ποιες ικανότητες απαιτούνται?");
            listBox1.Items.Add("  ~κρυπτογραφια");
            listBox1.Items.Add("  ~Python II");
            listBox1.Items.Add("\n");
            listBox1.Items.Add("3.KΑΤΗΓΟΡΙΕΣ DATA PROTECTION");
            listBox1.Items.Add("  ~data privacy ");
            listBox1.Items.Add("  ~data security");
            listBox1.Items.Add("  ~traditional data protection ");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            count++;
            listBox1.Items.Clear();
            listBox1.Items.Add("ΚΡΥΠΤΟΓΡΑΦΙΑ--ΘΕΩΡΙΑ");
            listBox1.Items.Add("\n");
            listBox1.Items.Add("1.ΜΕ ΤΗ ΑΣΧΟΛΕΙΤΑΙ TO ΜΑΘΗΜΑ ΑΥΤΟ?");
            listBox1.Items.Add("   Κρυπτογράφηση: µέθοδος µετασχηµατισµού  ");
            listBox1.Items.Add("   απλού-µη κρυπτογραφηµένου κειµένου ");
            listBox1.Items.Add("   (plaintext)σε κρυπτογραφηµένο κείµενο(cipher text) ");
            listBox1.Items.Add("   Ο µετασχηµατισµός ορίζεται µέσω ενός κλειδιού.");
            listBox1.Items.Add("\n");
            listBox1.Items.Add("2.ΣΤΟΧΟΙ ΚΡΥΠΤΟΓΡΑΦΙΑΣ:");
            listBox1.Items.Add("   Α.Εµπιστευτικότητα");
            listBox1.Items.Add("     Πρέπει να είναι ανέφικτος Ο υπολογισµός");
            listBox1.Items.Add("     του m(µήνυµα) από ένα c(κρυπτογραφηµένο μνμ)");
            listBox1.Items.Add("     για Paragraphs");
            listBox1.Items.Add("   Β.Ακεραιότητα");
            listBox1.Items.Add("   C.Αυθεντικότητα");
            listBox1.Items.Add("     Πρέπει να είναι υπολογιστικά ανέφικτο να");
            listBox1.Items.Add("     προσδιοριστεί το Ek από το c, ακόµη και ");
            listBox1.Items.Add("     είναι γνωστό το m,όπου :");
            listBox1.Items.Add("\n");
            listBox1.Items.Add("      1.m=µήνυµα");
            listBox1.Items.Add("\n");
            listBox1.Items.Add("      2.c=κρυπτογραφηµένο µήνυµα");
            listBox1.Items.Add("\n");
            listBox1.Items.Add("      3.Ek=Αλγόριθµος Κρυπτογράφησης");
            listBox1.Items.Add("\n");
            listBox1.Items.Add("                               ΤΕΛΟΣ !! ");
            if ((count >= 3) && Form2.l3 < 6)
            {
                button4.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            count++;
            listBox1.Items.Clear();
            listBox1.Items.Add("PYTHON II--ΘΕΩΡΙΑ");
            listBox1.Items.Add("\n");
            listBox1.Items.Add("1.ΜΕ ΤΗ ΑΣΧΟΛΕΙΤΑΙ TO ΜΑΘΗΜΑ ΑΥΤΟ?");
            listBox1.Items.Add("   Ο προγραμματισμός Python χρησιμοποιεί  ");
            listBox1.Items.Add("   μια απλή αντικειμενοστραφή προσέγγιση ");
            listBox1.Items.Add("   προγραμματισμού και πολύ αποτελεσματικές ");
            listBox1.Items.Add("   δομές δεδομένων υψηλού επιπέδου.Ο");
            listBox1.Items.Add("   προγραμματισμός Python χρησιμοποιεί");
            listBox1.Items.Add("   επίσης απλή και συνοπτική σύνταξη.");
            listBox1.Items.Add("\n");
            listBox1.Items.Add("2.ΠΡΟΧΩΡΗΜΕΝΕΣ ΕΝΤΟΛΕΣ Python:");
            listBox1.Items.Add("   a.Lambda Function,Eίναι μικρές ανώνυμες");
            listBox1.Items.Add("     λειτουργίες καθώς δεν έχουν όνομα και ");
            listBox1.Items.Add("     περιέχονται σε μία γραμμή κώδικα. Η λέξη-κλειδί ");
            listBox1.Items.Add("     'Def' χρησιμοποιείται για τον καθορισμό λειτουργιών ");
            listBox1.Items.Add("   b.Generators ,είναι ένας ειδικός τύπος ");
            listBox1.Items.Add("     συνάρτησης που αντί να επιστρέφει μία τιμή,");
            listBox1.Items.Add("     επιστρέφει ένα αντικείμενο");
            listBox1.Items.Add("   c.Threading,είναι η μικρότερη μονάδα ");
            listBox1.Items.Add("     ή διαδικασία που μπορεί να προγραμματιστεί");
            listBox1.Items.Add("     από ένα λειτουργικό σύστημα. Python περιέχει την ");
            listBox1.Items.Add("     Thread τάξη που βοηθά στον πολυαναγωγικό  ");
            listBox1.Items.Add("     προγραμματισμό ");
            listBox1.Items.Add("\n");
            listBox1.Items.Add("                               ΤΕΛΟΣ !! ");
            if ((count >= 3) && Form2.l3 < 6)
            {
                button4.Visible = true;
            }
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            label6.Text = "ΚΡΥΠΤΟΓΡΑΦΙΑ";
            label6.Visible = true;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            label6.Visible = false;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            label6.Visible = true;
            label6.Text = "PYTHON II";

        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            label6.Visible = false;
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
            checkBox4.Checked = false;
            checkBox6.Checked = false;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            checkBox5.Checked = false;
            checkBox6.Checked = false;
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            checkBox8.Checked = false;
            checkBox7.Checked = false;
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            checkBox7.Checked = false;
            checkBox9.Checked = false;
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            checkBox8.Checked = false;
            checkBox9.Checked = false;
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
            value7 = 0;
            if (checkBox2.Checked) value7 += 2;
            if (checkBox6.Checked) value7 += 2;
            if (checkBox7.Checked) value7 += 2;
            if (checkBox10.Checked) value7 += 2;
            f7 = true;
            Form5 f5 = new Form5(); f5.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9(); f9.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            f07 = true; Form11 f11 = new Form11(); f11.Show();
        }
    }
}
