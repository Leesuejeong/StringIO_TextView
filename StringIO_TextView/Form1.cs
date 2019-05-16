using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StringIO_TextView
{
    public partial class Form1 : Form
    {
        private string OrgStr;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.OrgStr = this.lb1Result.Text;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (TextCheck()==true)
            {
                this.lb1Result.Text = this.OrgStr + this.txtEdit.Text;
            }
            
        }

        private bool TextCheck()
        {
            if (this.txtEdit.Text != "")
            {
                return true;
            }
            else
            {
                MessageBox.Show("텍스트를 입력하세요\n아시겠어요?", "알림이지롱~", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtEdit.Focus();
                return false;
            }
        }

        private void txtEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                if (TextCheck())
                {
                    this.lb1Result.Text = this.OrgStr + this.txtEdit.Text;
                    e.Handled = true; //이벤트 버블링
                }
            }
        }
    }
}
