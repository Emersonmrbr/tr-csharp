using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia
{
  internal class GerarPDF
  {
    static void PDF()
    {
      string nomeArquivo = Globais.caminho + @"\turmas.pdf";
      FileStream arquivoPDF = new FileStream(nomeArquivo, FileMode.Create);
      Document doc = new Document(PageSize.A4);
      PdfWriter escritorPDF = PdfWriter.GetInstance(doc, arquivoPDF);

      iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(Globais.caminho + @"\Logo.png");
      logo.ScaleToFit(140f, 120f);
      logo.Alignment = Element.ALIGN_LEFT;
      //logo.SetAbsolutePosition(100f, 600f);

      string dados = string.Empty;

      Paragraph paragrafo1 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 20, (int)System.Drawing.FontStyle.Bold));
      paragrafo1.Alignment = Element.ALIGN_CENTER;
      paragrafo1.Add("Núcleo MAP\n");
      paragrafo1.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Italic);
      paragrafo1.Add("Curso de C#\n");
      string texto = "http://www.nucleomap.com.br\n";
      paragrafo1.Add(texto);

      Paragraph paragrafo2 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Bold));
      paragrafo2.Alignment = Element.ALIGN_LEFT;
      texto = "Texto do segundo paragrafo\n\n";
      paragrafo2.Add(texto);

      Paragraph paragrafo3 = new Paragraph();
      paragrafo3.Add("\n");

      PdfPTable tabela = new PdfPTable(3);
      tabela.DefaultCell.FixedHeight = 20;

      PdfPCell celula1 = new PdfPCell();
      celula1.Colspan = 3;
      celula1.AddElement(logo);
      tabela.AddCell(celula1);

      PdfPCell celula2 = new PdfPCell(new Phrase("Tabela de preços"));
      celula2.Colspan = 3;
      celula2.Rotation = 90;
      tabela.AddCell(celula2);


      tabela.AddCell("Código");
      tabela.AddCell("Produto");
      tabela.AddCell("Preço");

      tabela.AddCell("01");
      tabela.AddCell("Mouse");
      tabela.AddCell("25,00");

      tabela.AddCell("02");
      tabela.AddCell("Teclado");
      tabela.AddCell("65,00");

      PdfPCell celula3 = new PdfPCell(new Phrase("tabela de preços"));
      celula3.Colspan = 3;
      celula3.Rotation = 0;
      celula3.FixedHeight = 40;
      celula3.HorizontalAlignment = Element.ALIGN_CENTER;
      celula3.VerticalAlignment = Element.ALIGN_MIDDLE;
      tabela.AddCell(celula3);

      doc.Open();
      doc.Add(logo);
      doc.Add(paragrafo1);
      doc.Add(paragrafo2);
      doc.Add(paragrafo3);
      doc.Add(tabela);
      doc.Close();
    }
  }
}
