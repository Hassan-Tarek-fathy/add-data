using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// hassan tarek fathy
 //nour ahmed fekry
namespace section4
{
    public partial class Form1 : Form
    {
        double sumage = 0.0;
        double numofgrad = 0.0;
        double min;
        double max;

        public Form1()
        {
            InitializeComponent();
        }

        private void min_max(double x)
        {
            if (numofgrad == 0.0)
            {
                min = max = x;
            }
            if (min > x)
            {
                min = x;
            }
            if (max < x)
            {
                max = x;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                if (!(txtid.Text == string.Empty))
                {
                    for (int i = 0; i < listView1.Items.Count; i++)
                    {
                        if (listView1.Items[i].SubItems[0].Text == txtid.Text)
                        {
                            MessageBox.Show("Don't enter the same id again", "Warning", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                            txtid.Clear();
                            txtid.Focus();
                            return;
                        }
                    }

                    int y;
                    bool id;
                    id = int.TryParse(txtid.Text, out y);
                    if (id == false)
                    {
                        MessageBox.Show("Enter numbers, not text", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtid.Clear();
                        txtid.Focus();
                        return;
                    }

                    if (txtname.Text.TrimEnd() == string.Empty)
                    {
                        MessageBox.Show("Enter the name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtname.Clear();
                        txtname.Focus();
                        return;
                    }

                    int t;
                    bool name;
                    name = int.TryParse(txtname.Text, out t);
                    if (name == true)
                    {
                        MessageBox.Show("Enter text, not numbers", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtname.Clear();
                        txtname.Focus();
                        return;
                    }

                    if (txtage.Text == string.Empty)
                    {
                        MessageBox.Show("Enter the age", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtage.Focus();
                        return;
                    }

                    double x;
                    bool age;
                    age = double.TryParse(txtage.Text, out x);
                    if (age == false)
                    {
                        MessageBox.Show("Enter numbers, not text", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtage.Clear();
                        txtage.Focus();
                        return;
                    }
                    

                    ListViewItem item;
                    item = listView1.Items.Add(y.ToString());
                    item.SubItems.Add(txtname.Text);
                    item.SubItems.Add(txtage.Text);
                    item.SubItems.Add(comboBox1.Text);

                    sumage += x;
                    min_max(x);
                    numofgrad++;

                    txtid.Clear();
                    txtname.Clear();
                    txtage.Clear();
                    txtid.Focus();

                    comboBox1.SelectedIndex = -1;
                    
                }
                else
                {
                    MessageBox.Show("Enter the id", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtid.Focus();
                }
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                if (!(txtid.Text == string.Empty))
                {
                    for (int i = 0; i < listView1.Items.Count; i++)
                    {
                        if (listView1.Items[i].SubItems[0].Text == txtid.Text)
                        {
                            MessageBox.Show("Don't enter the same id again", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtid.Clear();
                            txtid.Focus();
                            return;
                        }
                    }

                    int y;
                    bool id;
                    id = int.TryParse(txtid.Text, out y);
                    if (id == false)
                    {
                        MessageBox.Show("Enter numbers, not text", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtid.Clear();
                        txtid.Focus();
                        return;
                    }

                    if (txtname.Text.TrimEnd() == string.Empty)
                    {
                        MessageBox.Show("Enter the name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtname.Focus();
                        return;
                    }

                    int t;
                    bool name;
                    name = int.TryParse(txtname.Text, out t);
                    if (name == true)
                    {
                        MessageBox.Show("Enter text, not numbers", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtname.Clear();
                        txtname.Focus();
                        return;
                    }

                    if (txtage.Text == string.Empty)
                    {
                        MessageBox.Show("Enter the age", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtage.Focus();
                        return;
                    }

                    double x;
                    bool age;
                    age = double.TryParse(txtage.Text, out x);
                    if (age == false)
                    {
                        MessageBox.Show("Enter numbers, not text", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtage.Clear();
                        txtage.Focus();
                        return;
                    }

                    ListViewItem item;
                    item = listView1.Items.Add(y.ToString());
                    item.SubItems.Add(txtname.Text);
                    item.SubItems.Add(txtage.Text);
                    item.SubItems.Add(comboBox1.Text);

                    txtid.Clear();
                    txtname.Clear();
                    txtage.Clear();
                    txtid.Focus();

                    comboBox1.SelectedIndex = -1;

                }
                else
                {
                    MessageBox.Show("Enter the id", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtid.Focus();
                }
            }
            else
            {
                MessageBox.Show("Selected Status", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBox1.SelectedIndex = 0;
            }
        }

        private void lblave_Click(object sender, EventArgs e)
        {

        }

        private void lblmin_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = 0;
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].SubItems[0].Text == txtserid.Text)
                {
                    lblname.Text = listView1.Items[i].SubItems[1].Text;
                    lblgrad.Text = listView1.Items[i].SubItems[3].Text;
                    x++;
                    break;
                }
            }
            if (x == 0)
            {
                MessageBox.Show("Not found in records", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblgrad.Text = "";
                lblname.Text = "";
                txtserid.Clear();
                txtserid.Focus();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            lblnumofstu.Text = listView1.Items.Count.ToString();

            if (numofgrad==0.0)
            {
                MessageBox.Show("Not found Graduated", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblave.Text = "0";
                lblmin.Text = "0";
                lblmax.Text = "0";
                lblnumofgrad.Text = "0";
                return;
            }

            lblave.Text = (sumage / numofgrad).ToString();
            lblmin.Text = min.ToString();
            lblmax.Text = max.ToString();
            lblnumofgrad.Text = numofgrad.ToString();

        }
           
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void restToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sumage = 0.0;
            numofgrad = 0.0;
            listView1.Items.Clear();
            txtid.Clear();
            txtname.Clear();
            txtage.Clear();
            txtserid.Clear();
            lblnumofstu.Text = "";
            lblave.Text = "";
            lblmin.Text = "";
            lblmax.Text = "";
            lblnumofgrad.Text = "";
            lblgrad.Text = "";
            lblname.Text = "";
            comboBox1.SelectedIndex = -1;
            txtid.Focus();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void madeByToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Eslam Eid Sh3ban \n      ( Salmon )", "Made by", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lblname_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
