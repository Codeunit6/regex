using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace regex
{
    public partial class Form1 : Form
    {
        Regex expresion;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            coleccion.Items.Clear();
            MatchCollection regex;
            expresion = new Regex("([+][5][2]|)((\\s?[0-9]{3}(-?|\\s?)){2}[0-9]{4}|(\\s?[0-9]{2}(-?|\\s?)){4}[0-9]{2})");
            regex = expresion.Matches(txtparrafo.Text);
            foreach (var item in regex)
            {
                coleccion.Items.Add(item);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
