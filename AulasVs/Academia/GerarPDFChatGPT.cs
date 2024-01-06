using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academia
{
  internal class GerarPDFChatGPT
  {
    //private void btn_Imprimir_Click(object sender, EventArgs e)
    //{
    //  string nomeArquivo = Globais.caminho + @"\turmas.pdf";
    //  FileStream arquivoPDF = new FileStream(nomeArquivo, FileMode.Create);
    //  Document doc = new Document(PageSize.A4);
    //  PdfWriter escritorPDF = PdfWriter.GetInstance(doc, arquivoPDF);

    //  iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(Globais.caminho + @"\Logo.png");
    //  logo.ScaleToFit(140f, 120f);
    //  logo.Alignment = Element.ALIGN_LEFT;
    //  //logo.SetAbsolutePosition(100f, 600f);

    //  string dados = string.Empty;

    //  Paragraph paragrafo1 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 20, (int)System.Drawing.FontStyle.Bold));
    //  paragrafo1.Alignment = Element.ALIGN_CENTER;
    //  paragrafo1.Add("Relatório de turmas\n\n");

    //  Paragraph paragrafo2 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Bold));
    //  paragrafo2.Alignment = Element.ALIGN_CENTER;
    //  paragrafo2.Add("Núcleo MAP - Curso de C#");

    //  PdfPTable tabela = new PdfPTable(3);
    //  tabela.DefaultCell.FixedHeight = 20;

    //  tabela.AddCell("ID");
    //  tabela.AddCell("Turma");
    //  tabela.AddCell("Horário");

    //  string selectQuery = @"
    //            SELECT
    //                tbt.N_IDTURMA as 'ID',
    //                tbt.T_DSCTURMA as 'Nome',
    //                tbh.T_DSCHORARIO as 'Horário'
    //            FROM
    //                tb_turmas as tbt
    //            INNER JOIN
    //                tb_horarios as tbh on tbh.N_IDHORARIO = tbt.N_IDHORARIO
    //            ORDER BY
    //                T_DSCTURMA
    //        ";
    //  DataTable dt = Banco.DQL(selectQuery);

    //  for (int i = 0; i < dt.Rows.Count; i++)
    //  {
    //    tabela.AddCell(dt.Rows[i]["ID"].ToString());
    //    tabela.AddCell(dt.Rows[i]["Nome"].ToString());
    //    tabela.AddCell(dt.Rows[i]["Horário"].ToString());
    //  }

    //  doc.Open();
    //  doc.Add(logo);
    //  doc.Add(paragrafo1);
    //  doc.Add(tabela);
    //  doc.Add(paragrafo2);
    //  doc.Close();

    //  DialogResult resposta = MessageBox.Show("Desja abrir o relatório?", "Relatório", MessageBoxButtons.YesNo);
    //  if (resposta == DialogResult.Yes)
    //  {
    //    System.Diagnostics.Process.Start(Globais.caminho + @"\turmas.pdf");
    //  }
    //}
  }
}
