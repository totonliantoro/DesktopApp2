using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment2_Toton
{
    public partial class FrmDragDrop : Form
    {
        public FrmDragDrop()
        {
            InitializeComponent();
            this.Width = 700;
            this.Height = 500;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //Enable drag and drop for this form
            this.AllowDrop = true;

            //Add event handler for drag & drop functionality
            this.DragEnter += new DragEventHandler(Frm_DragEnter);
            this.DragDrop += new DragEventHandler(Frm_DragDrop);
        }

        

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Font font = new Font("Arial", 12);
            Brush myBrush = new SolidBrush(Color.DarkGreen);
            g.DrawString("Drag and drop your file here", font, myBrush, 155, 130);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            FrmMain frmMain = new FrmMain();
            frmMain.ShowDialog();
        }

        private void Frm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }
        private void Frm_DragDrop(object sender, DragEventArgs e)
        {
            string[] FileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach (string File in FileList)
                this.lblFile.Text = File;
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            FrmLink frmLink = new FrmLink();
            frmLink.ShowDialog();
        }
    }
}
