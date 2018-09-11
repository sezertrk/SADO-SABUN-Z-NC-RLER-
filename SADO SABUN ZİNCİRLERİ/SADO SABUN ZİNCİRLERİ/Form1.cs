using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SADO_SABUN_ZİNCİRLERİ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "ANTİ BAKTERİYEL":
                {
                    comboBox2.Items.Clear();
                    comboBox2.Items.Add("LAVANTA ÖZLÜ");
                    comboBox2.Items.Add("BUĞDAY ÖZLÜ");
                    break;
                }
                case "MEYVE ÖZLÜ":
                {
                    comboBox2.Items.Clear ();
                    comboBox2.Items .Add ("NAR");
                    comboBox2.Items .Add ("PORTAKAL");
                    comboBox2.Items .Add ("LİMON");
                    comboBox2.Items .Add ("KAVUN");
                    comboBox2.Items .Add ("KARPUZ");
                    break;
                }
                case "ÇİÇEK ÖZLÜ":
                {
                    comboBox2.Items.Clear();
                    comboBox2.Items.Add("DEFNE");
                    comboBox2.Items.Add("YASEMİN");
                    comboBox2.Items.Add("LAVANTA");
                    comboBox2.Items.Add("PAPATYA");
                    comboBox2.Items.Add("GÜL");
                    break;
                }
            }
        }
    }
}
