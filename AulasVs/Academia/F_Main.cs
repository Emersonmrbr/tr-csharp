﻿using System;
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
  public partial class F_Main : Form
  {
    public F_Main()
    {
      InitializeComponent();
      F_Login f_Login = new F_Login(this);
      f_Login.ShowDialog();
    }
  }
}
