using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Componentes
{
  public partial class F_Timer : Form
  {
    int timerContador = 0;
    int posicaoX;
    int posicaoInicialX;
    int posicaoY;
    int posicaoInicialY;

    public F_Timer()
    {
      InitializeComponent();

    }

    private void btn_IniciarTimerRpincipal_Click(object sender, EventArgs e)
    {
      tmr_Principal.Start();
    }

    private void btn_PararTimerRpincipal_Click(object sender, EventArgs e)
    {
      tmr_Principal.Stop();
    }

    private void btn_ReiniciarTimerRpincipal_Click(object sender, EventArgs e)
    {
      tmr_Principal.Stop();
      timerContador = 0;
      tmr_Principal.Start();
    }

    private void tmr_Principal_Tick(object sender, EventArgs e)
    {
      timerContador++;
      lbl_TimerTimerRpincipal.Text = timerContador.ToString();
    }

    private void F_Timer_Load(object sender, EventArgs e)
    {
      img_Carro.Location = new Point(x: 0, y: (Height / 2) - img_Carro.Height);
      posicaoX = img_Carro.Location.X;
      posicaoY = img_Carro.Location.Y;
    }

    private void tmr_Carro_Tick(object sender, EventArgs e)
    {
      if ((posicaoX) < Width)
      {
        posicaoX += 2;
        posicaoY = (Height / 2) - img_Carro.Height;
        img_Carro.Location = new Point(posicaoX, posicaoY);
      }
      else
      {
        img_Carro.Location = new Point(x: 0 - img_Carro.Width, y: (Height / 2) - img_Carro.Height);
        posicaoX = img_Carro.Location.X;
        posicaoY = img_Carro.Location.Y;
      }
    }

    private void btn_IniciarCarro_Click(object sender, EventArgs e)
    {
      tmr_Carro.Start();
    }

    private void btnt_PararCarro_Click(object sender, EventArgs e)
    {
      tmr_Carro.Stop();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      img_Carro.Location = new Point(x: 0, y: (Height / 2) - img_Carro.Height);
    }
  }
}
