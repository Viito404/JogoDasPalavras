using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho02.JogoDasPalavras
{
     public partial class Menu : Form
     {
          public Menu()
          {
               InitializeComponent();
          }

          private void button20_Click(object sender, EventArgs e)
          {
               this.Hide();
               Form1 jogoDasPalavras = new Form1();
               jogoDasPalavras.Show();
          }

          private void button1_Click(object sender, EventArgs e)
          {
               this.Close();
          }
     }
}
