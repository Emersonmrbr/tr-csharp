﻿using System;
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
    StringReader leitura = null;
    public F_Principal()
    {
      InitializeComponent();
    }
    private void Novo()
    {

      if (rht_editor.Text != string.Empty)
      {
        DialogResult msg = MessageBox.Show("Deseja salvar o arquivo", "Salvar", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        if (msg == DialogResult.OK)
        {
          Salvar();
          rht_editor.Clear();
          rht_editor.Focus();
        }
        else
        {
          rht_editor.Clear();
          rht_editor.Focus();
        }
      }
      else
      {
        rht_editor.Clear();
        rht_editor.Focus();
      }
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
      catch (Exception e)
      {
        MessageBox.Show("Não foi possivel salvar: " + e.Message, "Falha ao salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void Abrir()
    {
      this.ofd_abrir.Title = "Abrir arquivo";
      ofd_abrir.InitialDirectory = @"C:\\Users\\emers\\Documents\\VirtualMachines\";
      ofd_abrir.Filter = "(*.map)|*.map";
      if (this.ofd_abrir.ShowDialog() == DialogResult.OK)
      {
        try
        {
          FileStream arquivo = new FileStream(ofd_abrir.FileName, FileMode.Open, FileAccess.Read);
          StreamReader leitor = new StreamReader(arquivo);
          leitor.BaseStream.Seek(0, SeekOrigin.Begin);
          this.rht_editor.Clear();
          string linha = leitor.ReadLine();
          while (linha != null)
          {
            this.rht_editor.Text += linha + "\n";
            linha = leitor.ReadLine();
          }
          leitor.Close();
        }
        catch (Exception e)
        {
          MessageBox.Show("Não foi possivel abrir: " + e.Message, "Falha ao abrir", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }
    }

    private void Fechar()
    {

      if (rht_editor.Text != string.Empty)
      {
        DialogResult msg = MessageBox.Show("Deseja salvar o arquivo", "Salvar", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        if (msg == DialogResult.OK)
        {
          Salvar();
          Close();
        }
        else
        {
          Close();
        }
      }
      else
      {
        Close();
      }
    }

    private void Copiar()
    {
      if (rht_editor.SelectionLength > 0)
      {
        rht_editor.Copy();
      }
    }

    private void Colar()
    {
      rht_editor.Paste();
    }
    private void Recortar()
    {
      if (rht_editor.SelectionLength > 0)
      {
        rht_editor.Cut();
      }
    }

    private void AplicarEstilo(RichTextBox caixaTexto, FontStyle estilo)
    {
      Font fonteAtual = caixaTexto.SelectionFont;
      FontStyle novoEstilo = fonteAtual.Style ^ estilo;
      Font novaFonte = new Font(fonteAtual, novoEstilo);
      caixaTexto.SelectionFont = novaFonte;
    }

    private void Negrito()
    {
      AplicarEstilo(rht_editor, FontStyle.Bold);
      tsb_negrito.Checked = rht_editor.SelectionFont.Bold;

    }

    private void Italico()
    {
      AplicarEstilo(rht_editor, FontStyle.Italic);
      tsb_italico.Checked = rht_editor.SelectionFont.Italic;
    }

    private void Sublinhado()
    {
      AplicarEstilo(rht_editor, FontStyle.Underline);
      tsb_sublinhado.Checked = rht_editor.SelectionFont.Underline;
    }

    private void AlinharEsquerda()
    {
      rht_editor.SelectionAlignment = HorizontalAlignment.Left;
    }
    private void AlinharCentro()
    {
      rht_editor.SelectionAlignment = HorizontalAlignment.Center;
    }
    private void AlinharDireita()
    {
      rht_editor.SelectionAlignment = HorizontalAlignment.Right;
    }

    private void Imprimir()
    {
      ptd_imprimir.Document = ptd_imprimirDocumento;
      leitura = new StringReader(this.rht_editor.Text);
      if (ptd_imprimir.ShowDialog() == DialogResult.OK)
      {
        this.ptd_imprimirDocumento.Print();
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

    private void tsb_abrir_Click(object sender, EventArgs e)
    {
      Abrir();
    }

    private void abiriToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Abrir();
    }

    private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Copiar();
    }

    private void tsb_copiar_Click(object sender, EventArgs e)
    {
      Copiar();
    }

    private void colarToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Colar();
    }

    private void tsb_colar_Click(object sender, EventArgs e)
    {
      Colar();
    }

    private void recortarToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Recortar();
    }

    private void tsb_recortar_Click(object sender, EventArgs e)
    {
      Recortar();
    }

    private void sairToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Fechar();
    }

    private void negritoToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Negrito();
    }

    private void itálicoToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Italico();
    }

    private void sublinhadoToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Sublinhado();
    }

    private void tsb_negrito_Click(object sender, EventArgs e)
    {
      Negrito();
    }

    private void tsb_italico_Click(object sender, EventArgs e)
    {
      Italico();
    }

    private void tsb_sublinhado_Click(object sender, EventArgs e)
    {
      Sublinhado();
    }

    private void rht_editor_SelectionChanged(object sender, EventArgs e)
    {
      tsb_negrito.Checked = rht_editor.SelectionFont.Bold;
      tsb_italico.Checked = rht_editor.SelectionFont.Italic;
      tsb_sublinhado.Checked = rht_editor.SelectionFont.Underline;
    }

    private void tsb_esquerda_Click(object sender, EventArgs e)
    {
      AlinharEsquerda();
    }

    private void esquerdaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      AlinharEsquerda();
    }

    private void tsb_centro_Click(object sender, EventArgs e)
    {
      AlinharCentro();
    }

    private void centralizadoToolStripMenuItem_Click(object sender, EventArgs e)
    {
      AlinharCentro();
    }

    private void tsb_direita_Click(object sender, EventArgs e)
    {
      AlinharDireita();
    }

    private void direitaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      AlinharDireita();
    }

    private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Imprimir();
    }

    private void tsb_imprimir_Click(object sender, EventArgs e)
    {
      Imprimir();
    }

    private void ptd_imprimirDocumento_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
    {
      const float margemFixa = 50;
      float linhasPagina = 0;
      float posicionamentoY = 0;
      int cotador = 0;
      float margemEsquerda = Math.Max(e.MarginBounds.Left - margemFixa, 5);
      float margemSuperior = Math.Max(e.MarginBounds.Top - margemFixa, 5);
      string linha = null;
      Font fonte = this.rht_editor.Font;
      SolidBrush pincel = new SolidBrush(Color.Black);

    }
  }
}
