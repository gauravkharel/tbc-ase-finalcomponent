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

        Creator factory = new Factory();
        Pen myPen = new Pen(Color.Red);
        int x = 0, y = 0, width, height;
        public Canvas()
        {
            InitializeComponent();
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

        private void runBtn_Click(object sender, EventArgs e)
        {
            Graphics g = panel1.CreateGraphics();

            string command = textBox1.Text.ToLower();
            string[] commandline = command.Split(new String[] { "\n" },
                StringSplitOptions.RemoveEmptyEntries);

            for (int k = 0; k < commandline.Length; k++)
            {

                string[] cmd = commandline[k].Split(' ');
                if (textBox2.Text.Equals("Run") == true)
                {


                    if (textBox1.Text.Equals("clear") == true)
                    {
                        textBox1.Text = "";
                        textBox2.Text = "";

                    }
                    else if (textBox1.Text.Equals("exit") == true)
                    {
                        this.Close();
                    }
                    else if (textBox1.Text.Equals("reset") == true)
                    {
                        x = 0;
                        y = 0;
                        width = 0;
                        height = 0;
                        textBox1.Text = "";
                        textBox2.Text = "";
                        panel1.Refresh();
                    }
                    else if (cmd[0].Equals("moveTo") == true)
                    {
                        panel1.Refresh();
                        string[] param = cmd[1].Split(',');
                        if (param.Length != 2)
                        { MessageBox.Show("Please input the value as --> moveTo 100,200 "); }
                        else
                        {
                            Int32.TryParse(param[0], out x);
                            Int32.TryParse(param[1], out y);
                            moveTo(x, y);
                        }

                    }

                    else if (cmd[0].Equals("width") == true)
                    {
                        int w;
                        if (cmd[1].Equals("=") == true)
                        {
                            Int32.TryParse(cmd[2], out width);
                        }
                        else if (cmd[1].Equals("+") == true)
                        {
                            Int32.TryParse(cmd[2], out w);
                            width = width + w;
                        }
                        else if (cmd[1].Equals("-") == true)
                        {
                            for (int rc = 0; rc < repeatval; rc++)
                            {
                                Int32.TryParse(cmd[2], out w);
                                width = width - w;
                            }
                        }

                        else
                        {
                            MessageBox.Show("Syntax Error");
                        }
                    }
                    else if (cmd[0].Equals("height") == true)
                    {
                        int h;
                        if (cmd[1].Equals("=") == true)
                        {
                            Int32.TryParse(cmd[2], out height);
                        }
                        else if (cmd[1].Equals("+") == true)
                        {
                            Int32.TryParse(cmd[2], out h);
                            height = height + h;
                        }
                        else if (cmd[1].Equals("-") == true)
                        {
                            for (int rc = 0; rc < repeatval; rc++)
                            {
                                Int32.TryParse(cmd[2], out h);
                                height = height - h;

                            }
                        }
                        else
                        {
                            MessageBox.Show("Syntax Error");
                        }
                    }
                    else if (cmd[0].Equals("drawto") == true)
                    {
                        string[] param = cmd[1].Split(',');
                        int x = 0, y = 0;
                        if (param.Length != 2)
                        {
                            MessageBox.Show("Incorrect Parameter");
                        }
                        else
                        {
                            Int32.TryParse(param[0], out x);
                            Int32.TryParse(param[1], out y);
                            drawTo(x, y);
                        }
                    }
                    else if (cmd[0].Equals("drawline") == true)
                    {
                        string[] param = cmd[1].Split(',');
                        int toX = 0, toY = 0;
                        if (param.Length != 2)
                        {
                            MessageBox.Show("Incorrect parameter please use both width and height");
                        }
                        else
                        {
                            Int32.TryParse(param[0], out toX);
                            Int32.TryParse(param[1], out toY);
                            Shape line = factory.getShape("line");
                            line.set(x, y, toX, toY);
                            line.draw(g);
                        }

                    }
                }
            }
        }


        public void moveTo(int toX, int toY)
        { x = toX; y = toY; }

        public void drawTo(int toX, int toY)
        { x = toX; y = toY; }

    }
}
    

