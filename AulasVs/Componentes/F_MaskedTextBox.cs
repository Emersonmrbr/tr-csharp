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
  public partial class F_MaskedTextBox : Form
  {
    public F_MaskedTextBox()
    {
      InitializeComponent();
    }

    private void btn_mostrar_Click(object sender, EventArgs e)
    {
      mtb_cpf.TextMaskFormat = !ckb_somenteTexto.Checked ? MaskFormat.IncludeLiterals : MaskFormat.ExcludePromptAndLiterals;
      MessageBox.Show(mtb_cpf.Text);
    }

    private void ckb_mostrar_CheckedChanged(object sender, EventArgs e)
    {
        mtb_senha.PasswordChar = !ckb_mostrar.Checked ? '#' : '\0';
    }
  }
}
