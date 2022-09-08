using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menustrip
{
    public partial class Form1 : Form
    {
        int counter = 1;
        ToolStrip toolStrip;
        public Form1()
        {
            InitializeComponent();
            toolStrip = new ToolStrip();
            this.Controls.Add(toolStrip);
            ToolStripMenuItem tsmi = new ToolStripMenuItem(counter.ToString());
            tsmi.MouseHover += new EventHandler(MouseHover);
            toolStrip.Items.Add(tsmi);
            counter++;
        }
        public void MouseHover(object sender, EventArgs e)
        {
            toolStrip.Items[counter - 2].MouseHover -= new EventHandler(MouseHover);
            ToolStripMenuItem tsmi = new ToolStripMenuItem(counter.ToString());
            toolStrip.Items.Add(tsmi);
            tsmi.MouseHover += new EventHandler(MouseHover);
            counter++;
        }
    }
}
