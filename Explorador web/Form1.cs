using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Explorador_web
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BotonIr_Click(object sender, EventArgs e)
        {
            String uri = comboBox1.Text;
            if (!uri.Contains("http://"))
                uri = "http://" + comboBox1.Text;
            webBrowser1.Navigate(new Uri(uri));
            if (!uri.Contains("."))
                uri = " http://www.google.com/search?q=" + comboBox1.Text;
            webBrowser1.Navigate(new Uri(uri));
        }

        private void navegadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }
        private void goForwardToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void goBackToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            webBrowser1.GoHome();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}