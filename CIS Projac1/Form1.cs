using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS_Projac1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();   //ออกจากโปรแกรม
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double A;   //สร้าง A ไว้เก็บค่า เพื่อนำไปคำนวน
            bool b = double.TryParse(num.Text, out A); //
            if (b == false)
            {
                MessageBox.Show("กรุณาใส่เฉพาะตัวเลข");  //โชว์ข้อความ ใส่เฉพาะตัวเลข
            }
            else
            {
                if (RB1.Checked)
                {
                    double i = A;   //

                    Show.ColumnCount = 3;
                    Show.Columns[0].Name = "เมตร";
                    Show.Columns[1].Name = "เซนติเมตร";
                    Show.Columns[2].Name = "มิลลิเมตร";

                    string[] row = new string[] { (i * 1000).ToString(), (i * 100000).ToString(), (i * 1000000).ToString() };
                    Show.Rows.Add(row);
                }
                else if (RB2.Checked)
                {
                    double i = A;

                    Show.ColumnCount = 3;
                    Show.Columns[0].Name = "กิโลเมตร";
                    Show.Columns[1].Name = "เซนติเมตร";
                    Show.Columns[2].Name = "มิลลิเมตร";

                    string[] row = new string[] { (i / 1000).ToString(), (i * 100).ToString(), (i * 1000).ToString() };
                    Show.Rows.Add(row);
                }
                else if (RB3.Checked)
                {
                    double i = A;

                    Show.ColumnCount = 3;
                    Show.Columns[0].Name = "กิโลเมตร";
                    Show.Columns[1].Name = "เมตร";
                    Show.Columns[2].Name = "มิลลิเมตร";

                    string[] row = new string[] { (i / 100000).ToString(), (i / 100).ToString(), (i * 10).ToString() };
                    Show.Rows.Add(row);
                }
                else if (RB4.Checked)
                {
                    double i = A;

                    Show.ColumnCount = 3;
                    Show.Columns[0].Name = "กิโลเมตร";
                    Show.Columns[1].Name = "เมตร";
                    Show.Columns[2].Name = "เซนติเมตร";


                    string[] row = new string[] { (i / 100000).ToString(), (i / 10000).ToString(), (i / 10).ToString() };
                    Show.Rows.Add(row);
                }
            }
           
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
                Show.Rows.Clear();
        }

        private void RB4_CheckedChanged(object sender, EventArgs e)
        {

        }

        
    }
}

