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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        int count;
        public static int value;
        public static bool f6,f06;
        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            if (Form2.avatar.Equals("man"))
                pictureBox1.Image = Properties.Resources.man;
            else
                pictureBox1.Image = Properties.Resources.woman;
            count = 0;
            f6 = false;
            f06 = false;//gia online help
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
            label6.Visible = true;
            label6.Text = "Τεχνητη Νοιμοσυνη Και Εμπειρα Συστηματα";
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            label6.Visible = false;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            label6.Visible = true;
            label6.Text = "Eπεξεργασια Φυσικης Γλωσσας";
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            label6.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            listBox1.Items.Clear();
            listBox1.Items.Add("AI/Machine learning--ΕΙΣΑΓΩΓΗ");
            listBox1.Items.Add("\n");
            listBox1.Items.Add("1.ΜΕ ΤΗ ΑΣΧΟΛΕΙΤΑΙ ΕΝΑΣ AI/Machine learning");
            listBox1.Items.Add("   Η μηχανική μάθηση διερευνά τη μελέτη και την κατασκευή");
            listBox1.Items.Add("   αλγορίθμων που μπορούν να μαθαίνουν από τα δεδομένα");
            listBox1.Items.Add("   και να κάνουν προβλέψεις σχετικά με αυτά.");
            listBox1.Items.Add("\n");
            listBox1.Items.Add("2.Ποιες ικανότητες απαιτούνται?");
            listBox1.Items.Add("  ~ΤΕΧΝΗΤΗ ΝΟΗΜΟΣΥΝΗ");
            listBox1.Items.Add("  ~ΕΠΕΞΕΡΓΑΣΙΑ ΦΥΣΙΚΗΣ ΓΛΩΣΣΑΣ");
            listBox1.Items.Add("\n");
            listBox1.Items.Add("3.KΑΤΗΓΟΡΙΕΣ AI/Machine learning");
            listBox1.Items.Add("  ~supervised");
            listBox1.Items.Add("  ~semi-supervised");
            listBox1.Items.Add("  ~unsupervised");
            listBox1.Items.Add("  ~reinforcement");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            count++;
            listBox1.Items.Clear();
            listBox1.Items.Add("TΕΧΝΗΤΗ ΝΟΗΜΟΣΥΝΗ--ΘΕΩΡΙΑ");
            listBox1.Items.Add("\n");
            listBox1.Items.Add("1.ΜΕ ΤΗ ΑΣΧΟΛΕΙΤΑΙ TO ΜΑΘΗΜΑ ΑΥΤΟ?");
            listBox1.Items.Add("   Ο όρος τεχνητή νοημοσύνη αναφέρεται ");
            listBox1.Items.Add("   στον κλάδο της πληροφορικής ο οποίος ασχολείται");
            listBox1.Items.Add("   με τη σχεδίαση και την υλοποίηση υπολογιστικών ");
            listBox1.Items.Add("   συστημάτων που μιμούνται στοιχεία της ανθρώπινης συμπεριφοράς.");
            listBox1.Items.Add("   Σε αυτό το μαθημα θα μαθουμε τα βασικα για την Python.");
            listBox1.Items.Add("\n");
            listBox1.Items.Add("2.ΒΑΣΙΚΕΣ ΕΝΤΟΛΕΣ Python:");
            listBox1.Items.Add("  ~print(), H οποια εντολή εμφανίζει το αποτελεσμα");
            listBox1.Items.Add("    που υπαρχει αναμεσα στις παρενθεσεις");
            listBox1.Items.Add("  ~x = 5 ή y = John, Δηλωσει μεταβλητων στην Python");
            listBox1.Items.Add("    για Paragraphs");
            listBox1.Items.Add("  ~thislist = [...,...,..] To οποίο είναι μια λίστα");
            listBox1.Items.Add("    για την Pyhton");
            listBox1.Items.Add("  ~def my_function() Tο οποίο δημιουργει  ");
            listBox1.Items.Add("    Function ");
            listBox1.Items.Add("\n");
            listBox1.Items.Add("                               ΤΕΛΟΣ !! ");
            if ((count >= 3) && Form2.l2<6)
            {
                button4.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            count++;
            listBox1.Items.Clear();
            listBox1.Items.Add("Eπεξεργασια Φυσικης Γλωσσας--ΘΕΩΡΙΑ");
            listBox1.Items.Add("\n");
            listBox1.Items.Add("1.ΜΕ ΤΗ ΑΣΧΟΛΕΙΤΑΙ TO ΜΑΘΗΜΑ ΑΥΤΟ?");
            listBox1.Items.Add("   Η επεξεργασία φυσικής γλώσσας (ΕΦΓ)");
            listBox1.Items.Add("   είναι ένας διεπιστημονικός κλάδος της");
            listBox1.Items.Add("   επιστήμης της πληροφορικής, της τεχνητής  ");
            listBox1.Items.Add("   νοημοσύνης και της υπολογιστικής γλωσσολογίας ");
            listBox1.Items.Add("   και ασχολείται με τις αλληλεπιδράσεις μεταξύ ");
            listBox1.Items.Add("   των υπολογιστών και των ανθρώπινων (φυσικών) γλωσσών. ");
            listBox1.Items.Add("   Σε αυτό το μαθημα θα μαθουμε για τα FSTN!. ");
            listBox1.Items.Add("\n");
            listBox1.Items.Add("2.ΒΑΣΙΚΕΣ ΓΝΩΣΕΙΣ FSTN:");
            listBox1.Items.Add("  ~Properties and Operations");
            listBox1.Items.Add("    1.By definition");
            listBox1.Items.Add("      A. Union");
            listBox1.Items.Add("      B. Iteration");
            listBox1.Items.Add("      C. Concatenation");
            listBox1.Items.Add("    2.By deduction");
            listBox1.Items.Add("      A. Intersection");
            listBox1.Items.Add("      B. Complementation");
            listBox1.Items.Add("      C. Substitution");
            listBox1.Items.Add("      D. Reversal");
            listBox1.Items.Add("  ~Approximate methods");
            listBox1.Items.Add("    1.Has right set of letters (any order).");
            listBox1.Items.Add("    2.Has right sounds (Soundex).");
            listBox1.Items.Add("    3.Random (suprimposed) coding (Unix Spell)");
            listBox1.Items.Add("  ~Exact Methods");
            listBox1.Items.Add("    1.Hashing.");
            listBox1.Items.Add("    2.Search (linear, binary ...).");
            listBox1.Items.Add("    3.Digital search (“Tries”)");
            listBox1.Items.Add("\n");
            listBox1.Items.Add("                               ΤΕΛΟΣ !! ");
            if ((count >= 3) && Form2.l2 < 6)
            {
                button4.Visible = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            listBox1.Items.Clear();
            listBox1.Items.Add("                              ΠΡΟΣΟΧΗ!!!!!!");
            listBox1.Items.Add("          THN ΩΡΑ ΤΟΥ ΤΕΣΤ ΔΕΝ ΜΠΟΡΕΙΣ ΝΑ ΔΕΙΣ ");
            listBox1.Items.Add("     THN ΘΕΩΡΙΑ ΤΩΝ ΚΕΦΑΛΑΙΩΝ ΤΟΥ ΑΝΤΙΣΤΟΙΧΟΥ LEVEL!");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
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
            value = 0;
            if (checkBox1.Checked) value += 2;
            if (checkBox6.Checked) value += 2;
            if (checkBox9.Checked) value += 2;
            if (checkBox10.Checked) value += 2;
            f6 = true;
            Form5 f5 = new Form5(); f5.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9(); f9.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            f06 = true;Form11 f11 = new Form11();f11.Show();
        }
    }
}
