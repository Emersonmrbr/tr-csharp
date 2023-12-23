using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace EditorTexto
{
  public partial class F_Principal : Form
  {
    StreamReader leitura = null;
    public F_Principal()
    {
      InitializeComponent();
    }
    private void Novo()
    {
      rht_editor.Clear();
      rht_editor.Focus();
    }

    private void Salvar()
    {
      try
      {
        if (this.sfd_salvar.ShowDialog() == DialogResult.OK)
        {
          FileStream arquivo = new FileStream(sfd_salvar.FileName, FileMode.OpenOrCreate, FileAccess.Write);
          StreamWriter escritor = new StreamWriter(arquivo);
          escritor.Flush();
          escritor.BaseStream.Seek(0, SeekOrigin.Begin);
          escritor.Write(this.rht_editor.Text);
          escritor.Flush();
          escritor.Close();
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show("Não foi possivel salvar: "+ ex.Message,"Falha ao salvar", MessageBoxButtons.OK,MessageBoxIcon.Error);
      }
    }

    private void tsb_novo_Click(object sender, EventArgs e)
    {
      Novo();
    }

    private void novoToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Novo();
    }

    private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Salvar();
    }

    private void tsb_salvar_Click(object sender, EventArgs e)
    {
      Salvar();
    }
  }
}
