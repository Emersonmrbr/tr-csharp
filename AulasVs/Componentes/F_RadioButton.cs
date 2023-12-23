using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componentes
{
  public partial class F_RadioButton : Form
  {
    public F_RadioButton()
    {
      InitializeComponent();
    }

    private void btn_opcao1_Click(object sender, EventArgs e)
    {
      string txt = string.Empty;
      txt = groupBox1.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked).Text;
      ttb_selecionado.Text = txt;
    }

    private void btn_opcao2_Click(object sender, EventArgs e)
    {
      string txt = string.Empty;
      foreach (RadioButton i in groupBox1.Controls)
      {
        if (i.Checked)
        {
          txt = i.Text;
        }
        ttb_selecionado.Text = txt;
      }
    }
  }
}
