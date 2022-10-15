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
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment2_Toton
{
    public partial class FrmLink : Form
    {
        public FrmLink()
        {
            InitializeComponent();
            this.Width = 700;
            this.Height = 500;
        }

        private void FrmLink_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            FrmDragDrop frmDragDrop = new FrmDragDrop();
            frmDragDrop.ShowDialog();
        }


        private void btnForward_Click(object sender, EventArgs e)
        {
            LinkedList<char> myData = new LinkedList<char>();
            char[] strArr = txtBoxSuburb.Text.ToCharArray();   
            foreach (char i in strArr)
            {
                myData.AddLast(i);
            }

            for (LinkedListNode<char> node = myData.First; node != null; node = node.Next)
            {
                char i = node.Value;
                lstBoxResult.Items.Add(i.ToString());   
                lstBoxResult.BackColor = Color.LightGreen;
                
            }
          

        }

        private void btnBackward_Click(object sender, EventArgs e)
        {
            LinkedList<char> myData = new LinkedList<char>();
            char[] strArr = txtBoxSuburb.Text.ToCharArray();
            foreach (char i in strArr)
            {
                myData.AddFirst(i);
            }

            for (LinkedListNode<char> node = myData.First; node != null; node = node.Next)
            {
                char i = node.Value;
                lstBoxResult.Items.Add(i.ToString());
                lstBoxResult.BackColor = Color.Cyan;

            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstBoxResult.Items.Clear();
        }

        private void nxtBtn_Click(object sender, EventArgs e)
        {
            FrmImageDragDrop form = new FrmImageDragDrop();
            form.ShowDialog();
        }
    }
}
