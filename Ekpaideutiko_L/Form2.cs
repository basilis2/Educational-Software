using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ekpaideutiko_L
{
    public partial class Form2 : Form
    {
        public static int l1, l2, l3, l4;
        public static String user,avatar;
        public static bool f2;
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            f2 = false;
            String constring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Vasilis\\source\\repos\\Ekpaideutiko_L\\Ekpaideutiko_L\\Database1.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            try
            {
                SqlCommand command = new SqlCommand("SELECT * FROM it where email='" + Form1.id +"'", conn);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    user = reader.GetString(2);
                    l1 = reader.GetInt32(4);
                    l2 = reader.GetInt32(5);
                    l3 = reader.GetInt32(6);
                    l4 = reader.GetInt32(7);
                    avatar = reader.GetString(3);
                    label5.Text = "ΓΕΙΑ ΣΟΥ"+" "+reader.GetString(2).ToString()+"!!!!";
                    if (reader.GetString(3).Equals("man"))
                        pictureBox1.Image = Properties.Resources.man;
                    else
                        pictureBox1.Image = Properties.Resources.woman;
                    break;
                }
                if (l2 == 0)
                {
                    button2.ForeColor = Color.Red;
                    button3.ForeColor = Color.Red;
                    button4.ForeColor = Color.Red;
                    pictureBox2.Image = Properties.Resources.eisag;
                  
                }
                else if (l3 == 0) 
                {
                    button3.ForeColor = Color.Red;
                    button4.ForeColor = Color.Red;
                    pictureBox2.Image = Properties.Resources.eisag2;
                }
                else
                    button4.ForeColor = Color.Red;

               

            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }

            if (l1 >= 6) { button2.ForeColor = Color.DeepSkyBlue; label6.Visible = true;label6.Text = "COMPLETE"; }
            if (l2 >= 6) { button3.ForeColor = Color.DeepSkyBlue; label7.Visible = true; label7.Text = "COMPLETE"; button2.ForeColor = Color.DeepSkyBlue; }
            if (l3 >= 6) { button4.ForeColor = Color.DeepSkyBlue; label8.Visible = true; label8.Text = "COMPLETE"; button3.ForeColor = Color.DeepSkyBlue; }
            if (l4 >= 6) { 
                label9.Visible = true; label9.Text = "COMPLETE"; button4.ForeColor = Color.DeepSkyBlue;
                pictureBox2.Image = Properties.Resources.complete;
                label5.Visible = false;
            }
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            label4.Visible = true;

        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
           label4.Visible = false;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            if ((l2 >= 1) && (l2 < 6))
            {
                label7.Visible = false;
                button2.BackColor = Color.White;
                button2.ForeColor = Color.DeepSkyBlue;
                pictureBox2.Image = Properties.Resources.eisag;
            }
            else if (l2>=6)
            {
                button2.BackColor = Color.White;
                button2.ForeColor = Color.DeepSkyBlue;
                pictureBox2.Image = Properties.Resources.complete;
            }
            else if(l2==0)
            {
                pictureBox2.Image = Properties.Resources.eisag;
                button2.BackColor = Color.White;
                button2.ForeColor = Color.Red;
            }
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.l3;
            if ((l3 >= 1) && (l3 < 6))
            {
                button3.BackColor = Color.DeepSkyBlue;
                button3.ForeColor = Color.White;
                label8.Visible = true;
                label8.Text = "Lest go!!!";
            }
            else if (l3 >= 6) 
            {
                button3.BackColor = Color.DeepSkyBlue;
                button3.ForeColor = Color.White;
            }
            else
            {
                label8.Visible = true;
                label8.Text = "LOCKED";
                button3.BackColor = Color.Red;
                button3.ForeColor = Color.White;
            }
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            if ((l3 >= 1) && (l3 < 6))
            {
                label8.Visible = false;
                button3.BackColor = Color.White;
                button3.ForeColor = Color.DeepSkyBlue;
                pictureBox2.Image = Properties.Resources.eisag;
            }
            else if (l3>=6)
            {
                button3.BackColor = Color.White;
                button3.ForeColor = Color.DeepSkyBlue;
                pictureBox2.Image = Properties.Resources.complete;
            }
            else if(l3==0)
            {
                pictureBox2.Image = Properties.Resources.eisag;
                button3.BackColor = Color.White;
                button3.ForeColor = Color.Red;
            }
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.l4;
            if ((l4 >= 1) && (l4 < 6))
            {
                button4.BackColor = Color.DeepSkyBlue;
                button4.ForeColor = Color.White;
                label9.Visible = true;
                label9.Text = "Lets Go!!!";
            }
            else if (l4 >=6)
            {
                button4.BackColor = Color.DeepSkyBlue;
                button4.ForeColor = Color.White;
            }
            else
            {
                button4.BackColor = Color.Red;
                button4.ForeColor = Color.White;
                label9.Visible = true;
                label9.Text = "LOCKED";
            }
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            if((l4 >= 1) && (l4 < 6))
            {
                label9.Visible = false;
                button4.BackColor = Color.White;
                button4.ForeColor = Color.DeepSkyBlue;
                pictureBox2.Image = Properties.Resources.eisag;
            }
            else if (l4>=6)
            {
                button4.BackColor = Color.White;
                button4.ForeColor = Color.DeepSkyBlue;
                pictureBox2.Image = Properties.Resources.complete;
            }
            else if(l4==0)
            {
                button4.BackColor = Color.White;
                button4.ForeColor = Color.Red;
                pictureBox2.Image = Properties.Resources.eisag;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (l2 >= 1) { Form6 f6 = new Form6(); f6.Show(); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (l3 >= 1) { Form7 f7 = new Form7(); f7.Show(); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (l4 >= 1) { Form8 f8 = new Form8(); f8.Show(); }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();f9.Show();
        }

        private void label3_Click(object sender, EventArgs e)//για το online help
        {
            f2 = true; Form11 f11 = new Form11();f11.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();f4.Show();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.DeepSkyBlue;
            button1.ForeColor = Color.White;
            pictureBox2.Image = Properties.Resources.l1;
            label6.Visible = true;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
            button1.ForeColor = Color.DeepSkyBlue;
            if (l1 < 6) { label6.Visible = false; pictureBox2.Image = Properties.Resources.eisag; }
            else
                pictureBox2.Image = Properties.Resources.complete;

        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.l2;
            if ((l2>=1)&&(l2 <6))
            {
                button2.BackColor = Color.DeepSkyBlue;
                button2.ForeColor = Color.White;
                label7.Visible = true;
                label7.Text = "Lets GO!!!";
            }
            else if (l2 >= 6)
            {
                button2.BackColor = Color.DeepSkyBlue;
                button2.ForeColor = Color.White;
            }
            else
            {
                label7.Visible = true;
                label7.Text = "LOCKED";
                button2.BackColor = Color.Red;
                button2.ForeColor = Color.White;
            }
          
        }
       
    }
}
