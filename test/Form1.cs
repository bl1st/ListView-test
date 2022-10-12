using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            Random rand = new Random();
            ImageList img = new ImageList();
       
            
            img.ImageSize = new Size(90, 90);
            for (int i =0; i < 5; i++)
            {              
                img.Images.Add(new Bitmap(Properties.Resources._1));
            }

            lv.SmallImageList = img;

            for (int i = 0; i < 5; i++)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.ImageIndex = i;
                lvi.Text = "Some text " + rand.Next(100)+ "\nCost : 5000 \nManufacturer: SPBKIT";             
                lv.Items.Add(lvi);
            }
        }

        private void lv_SizeChanged(object sender, EventArgs e)
        {
            lv.Columns[0].Width = lv.Width - 4 - SystemInformation.VerticalScrollBarWidth;
        }


    }
}
