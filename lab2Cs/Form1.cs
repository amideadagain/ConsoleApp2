using System;
using System.Windows.Forms;

namespace Lab2_CS
{
    
    public partial class Form1 : Form
    {
        public double tmp = 0;
        Equilateral triangle = new Equilateral();
        Prisma prisma = new Prisma();
        public Form1()
        {
            
            InitializeComponent();
 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            triangle.Line = Convert.ToDouble(textBox5.Text);
            prisma.Height = Convert.ToDouble(textBox6.Text);

            triangle.CalculateArea();
            triangle.CalculatePerimeter();

            if (prisma.Height !=0)
            {
               prisma.CalculateArea(triangle.Line, triangle.Area, prisma.Height);
               prisma.CalcVolume();
               richTextBox1.Text = prisma.ToString(triangle.Line, prisma.Height, triangle.Perimeter, triangle.Area, prisma.Area1, prisma.Volume);
               dataGridView1.Rows.Add("Prisma", triangle.Line,prisma.Height, triangle.Area, triangle.Perimeter, prisma.Area1, prisma.Volume);
            }
            else
            {
              richTextBox1.Text = triangle.ToString();
              dataGridView1.Rows.Add("Triangle", triangle.Line, prisma.Height, triangle.Area, triangle.Perimeter,0,0);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int numb = 0;
            tmp = Convert.ToDouble(dataGridView1.Rows[1].Cells[6].Value);
            for (int i = 0; i < (dataGridView1.RowCount-1); i++)
            {
                if (tmp < Convert.ToDouble(dataGridView1.Rows[i].Cells[6].Value))
                {
                    tmp = Convert.ToDouble(dataGridView1.Rows[i].Cells[6].Value);
                    numb = i;
                }
            }
            numb = numb + 1;
            richTextBox1.Text = "Prisma with biggest are in row" + numb;
            tmp = 0;
            int n = 0;
            for (int i = 0; i < dataGridView1.RowCount-1; i++)
            {
                if (Convert.ToString(dataGridView1.Rows[i].Cells[0].Value) == "Triangle")
                {
                    tmp = tmp + Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value);
                    n++;
                }
            }
            tmp = tmp / dataGridView1.RowCount;
            richTextBox1.Text += "\nTriangles wich area less then average area of triangles in line: ";
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                if (Convert.ToString(dataGridView1.Rows[i].Cells[0].Value) == "Triangle")
                {
                    if (Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value) < tmp)
                    {
                        numb = i + 1;
                        richTextBox1.Text += numb + " ";
                    }
                }
            }
        }
    }
}
