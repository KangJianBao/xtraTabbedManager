using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DXApplication1
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Create a BarManager that will display a bar of commands at the top of the main form.
        
        }

        int ctr = 0;
        

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form2 f = new Form2();
            f.Text = "Child Form " + (++ctr).ToString();
            f.MdiParent = this;
            f.Show();
        }
    }
}
