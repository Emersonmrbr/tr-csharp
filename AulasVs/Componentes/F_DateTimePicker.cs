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
  public partial class F_DateTimePicker : Form
  {
    public F_DateTimePicker()
    {
      InitializeComponent();
    }

    private void btn_obterData_Click(object sender, EventArgs e)
    {
      tb_dataAtual.Text = dtp_dataSelecionada.Text;
      tb_dia.Text = dtp_dataSelecionada.Value.Day.ToString();
      tb_mes.Text = dtp_dataSelecionada.Value.Month.ToString();
      tb_ano.Text = dtp_dataSelecionada.Value.Year.ToString();
    }

    private void btn_setarData_Click(object sender, EventArgs e)
    {
      if (tb_dia.Text != "" && tb_mes.Text != "" && tb_ano.Text != "")
      {
        dtp_dataSelecionada.Value = new DateTime(
          year: int.Parse(tb_ano.Text),
          month: int.Parse(tb_mes.Text),
          day: int.Parse(tb_dia.Text));
      }
    }

    private void btn_hoje_Click(object sender, EventArgs e)
    {
      dtp_dataSelecionada.Value = DateTime.Today;
    }
  }
}
