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
  public partial class F_Checkbox : Form
  {
    List<CheckBox> trasnportes = new List<CheckBox>();
    
    
    public F_Checkbox()
    {
      InitializeComponent();
      trasnportes.Add(cb_aviao);
      trasnportes.Add(cb_carro);
      trasnportes.Add(cb_navio);
      trasnportes.Add(cb_onibus);

    }


    private void btn_transportesMarcados_Click(object sender, EventArgs e)
    {
      string txt = null;
      foreach (CheckBox t in trasnportes)
      {
        if (t.Checked) { txt += t.Text + ", "; }
      }

      MessageBox.Show(txt);
    }
  }
}
