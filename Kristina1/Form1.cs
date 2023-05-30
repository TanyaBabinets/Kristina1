using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kristina1
{
    public partial class Form1 : Form
    {
        Controller controller;
        public Form1()
        {
            InitializeComponent();
            controller=new Controller();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controller.AddPerson(textBox1.Text, int.Parse(textBox2.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var a in controller.GetAllPerson())
            {
                listBox1.Items.Add(a);
            }
        }
        void Print()
        {
            listBox1.Items.Clear();
            foreach (var a in controller.GetAllPerson())
            {
                listBox1.Items.Add(a);
            }
        }

        private void показатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var a = listBox1.SelectedItem;
                controller.Delete((Model.Person)a);
                Print();
            }
            catch (Exception ex){ MessageBox.Show("No choice"); }
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); 
        }

        private void deleteChosenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)//      search
        {
            try
            {
                var list = controller.GetSearch(textBox3.Text);
                listBox1.Items.Clear();
               foreach (var a in list)
                {
                    
                        listBox1.Items.Add(a);
                   
                }
                                      
            }
            catch (Exception ex) { MessageBox.Show("Not found"); }
        }
    }
}
