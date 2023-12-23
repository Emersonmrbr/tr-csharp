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
  public partial class F_PictureBox : Form
  {
    public F_PictureBox()
    {
      InitializeComponent();
    }

    private void F_PictureBox_Load(object sender, EventArgs e)
    {
      lbl_empresa.Text = Properties.Resources.Empresa;
      lbl_url.Text = Properties.Resources.URL;
      peb_logo2.Image = Properties.Resources.logo;
    }

    private void btn_logo1_Click(object sender, EventArgs e)
    {
      peb_logo1.Image = Properties.Resources.logoCompelto;
    }

    private void btn_logo2_Click(object sender, EventArgs e)
    {
      peb_logo1.Image = Properties.Resources.scketch;
    }

    private void btn_logo3_Click(object sender, EventArgs e)
    {
      peb_logo1.Image = Properties.Resources.logo;
    }
  }
}
