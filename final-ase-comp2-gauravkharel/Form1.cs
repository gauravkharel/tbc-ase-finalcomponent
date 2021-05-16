using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace final_ase_comp2_gauravkharel
{
    public partial class Canvas : Form
    {
        public Canvas()
        {
            InitializeComponent();
        }

        private void Canvas_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developed by Gaurav Kharel");
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text File (.txt)| *.txt";
            saveFileDialog.Title = "Save File...";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter fWriter = new StreamWriter(saveFileDialog.FileName);
                fWriter.Write(textBox1.Text);
                fWriter.Close();
            }
            textBox1.Text += "Command Save";
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog loadFileDialog = new OpenFileDialog();
            loadFileDialog.Filter = "Text File (.txt)|*.txt";
            loadFileDialog.Title = "Open File...";

            if (loadFileDialog.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader streamReader = new System.IO.StreamReader(loadFileDialog.FileName);
                textBox1.Text = streamReader.ReadToEnd();
                streamReader.Close();
            }
        }
    }
}
