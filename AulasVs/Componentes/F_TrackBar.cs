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
  public partial class F_TrackBar : Form
  {
    public F_TrackBar()
    {
      InitializeComponent();
    }

    private void Tkb_Valor_Scroll(object sender, EventArgs e)
    {
      Ttb_Valor.Text = Tkb_Valor.Value.ToString();
      Lbl_Valor.Text = Tkb_Valor.Value.ToString();
    }

    private void Btn_Definir_Click(object sender, EventArgs e)
    {
      if (Int32.Parse(Ttb_Valor.Text) > Tkb_Valor.Maximum)
      {
        MessageBox.Show("Valor muito grande");
        return;
      }
      if (Int32.Parse(Ttb_Valor.Text) < Tkb_Valor.Minimum)
      {
        MessageBox.Show("Valor muito pequeno");
        return;
      }
      Tkb_Valor.Value = Int32.Parse(Ttb_Valor.Text);
    }

    private void F_TrackBar_Load(object sender, EventArgs e)
    {
      Ttb_Valor.Text = Tkb_Valor.Value.ToString();
      Lbl_Valor.Text = Tkb_Valor.Value.ToString();
    }
  }
}
