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
  public partial class F_LinkLabel : Form
  {
    public F_LinkLabel()
    {
      InitializeComponent();
      ll_multiplosLinks.Links.Add(0, 6, "http://google.com");
      ll_multiplosLinks.Links.Add(9, 5, "https://www.youtube.com/channel/UCLIP4ogRfbOpPcM6M2ypycg");
      ll_multiplosLinks.Links.Add(17, 7, "https://www.youtube.com");
    }

    private void ll_canal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCLIP4ogRfbOpPcM6M2ypycg?nome=" + tb_nome.Text);
      LinkLabel ll = (LinkLabel)sender;
      ll.LinkVisited = true;
    }

    private void ll_programa_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      System.Diagnostics.Process.Start("calc.exe");
    }

    private void ll_multiplosLinks_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      System.Diagnostics.Process.Start(e.Link.LinkData.ToString() + "/search?q=" + tb_busca.Text);
      e.Link.Visited = true;
      Console.WriteLine(e.Link.LinkData);
    }
  }
}
