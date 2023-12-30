using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academia
{
  public partial class F_Login : Form
  {
    F_Main f_Main;
    public F_Login(F_Main form)
    {
      InitializeComponent();
      f_Main = form;
    }
  }
}
