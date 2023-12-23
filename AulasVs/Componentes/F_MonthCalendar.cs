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
  public partial class F_MonthCalendar : Form
  {
    public F_MonthCalendar()
    {
      InitializeComponent();
    }

    private void btn_obter_Click(object sender, EventArgs e)
    {
      ttb_inicio.Text = mhc_calendario.SelectionStart.ToShortDateString();
      ttb_fim.Text = mhc_calendario.SelectionEnd.ToShortDateString();
      ttb_atual.Text = mhc_calendario.TodayDate.ToShortDateString();
    }

    private void mhc_calendario_DateChanged(object sender, DateRangeEventArgs e)
    {
      ttb_inicio.Text = mhc_calendario.SelectionStart.ToShortDateString();
      ttb_fim.Text = mhc_calendario.SelectionEnd.ToShortDateString();
      ttb_atual.Text = mhc_calendario.TodayDate.ToShortDateString();
    }
  }
}
