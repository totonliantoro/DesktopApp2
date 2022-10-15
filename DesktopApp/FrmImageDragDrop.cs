//***********************************************************************************************
//Programmer: Toton Liantoro
//Date: 13 October 2022
//Software: Microsoft Visual Studio 2022 Community Edition
//Platform: Microsoft Windows 11 64-bit
//Purpose: To complete the assignment 2 Subject: Apply Advance Object-Oriented Language Skills
//***********************************************************************************************
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

namespace Assessment2_Toton
{
    public partial class FrmImageDragDrop : Form
    {
        public FrmImageDragDrop()
        {
            InitializeComponent();
            this.Width = 700;
            this.Height = 500;
        }

        private void pictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            var data = e.Data.GetData(DataFormats.FileDrop);
            if (data != null)
            {
                var fileNames = data as string[];
                if (fileNames.Length > 0)
                {
                    pictureBox1.Image = Image.FromFile(fileNames[0]);
                }
            }

        }

        private void FrmImageDragDrop_Load(object sender, EventArgs e)
        {
            pictureBox1.AllowDrop = true;  
            
        }

        private void pictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            FrmLink form = new FrmLink();
            form.ShowDialog();
        }
    }
}
