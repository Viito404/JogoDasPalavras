namespace Trabalho02.JogoDasPalavras
{
     public partial class Form1 : Form
     {
          private JogoDasPalavras novoJogo;
          private int contagemTentativas = 0;
          private int contagemPosicoes = 4;
          private int contagemAcertos = 0;
          public Form1()
          {
               InitializeComponent();
               novoJogo = new JogoDasPalavras();
               ButtonsConfiguration();
          }

          private void ButtonsConfiguration()
          {
               foreach (Button button in gbButtons.Controls)
               {
                    button.Click += VerifyLetter;
               }
          }

          private void ReiniciarJogo()
          {
               novoJogo = new JogoDasPalavras();

               foreach (Label l in tlpFirstTry.Controls)
               {
                    l.Text = "";
                    l.BackColor = SystemColors.ControlLightLight;
               }
               foreach (Label l in tlpSecondTry.Controls)
               {
                    l.Text = "";
                    l.BackColor = SystemColors.ControlLightLight;
               }
               foreach (Label l in tlpThirdTry.Controls)
               {
                    l.Text = "";
                    l.BackColor = SystemColors.ControlLightLight;
               }
               foreach (Label l in tlpFourthTry.Controls)
               {
                    l.Text = "";
                    l.BackColor = SystemColors.ControlLightLight;
               }
               foreach (Label l in tlpFifthTry.Controls)
               {
                    l.Text = "";
                    l.BackColor = SystemColors.ControlLightLight;
               }
               contagemTentativas = 0;
               contagemPosicoes = 4;
               contagemAcertos = 0;
          }
          private void VerifyLetter(Object? sender, EventArgs e)
          {
               Button button = (Button)sender;

               Label label = VerifyLetterPosition();

               label.Text = button.Text;

               if (contagemPosicoes > 0)
               {
                    contagemPosicoes--;
               }
          }

          private Label VerifyLetterPosition()
          {
               Label label = new Label();

               switch (contagemTentativas)
               {
                    case 0: return label = (Label)tlpFirstTry.Controls[contagemPosicoes];

                    case 1: return label = (Label)tlpSecondTry.Controls[contagemPosicoes];

                    case 2: return label = (Label)tlpThirdTry.Controls[contagemPosicoes];

                    case 3: return label = (Label)tlpFourthTry.Controls[contagemPosicoes];

                    case 4: return label = (Label)tlpFifthTry.Controls[contagemPosicoes];
               }
               return label;
          }

          private void Form1_Load(object sender, EventArgs e)
          {

          }

          private void btnClear_Click(object sender, EventArgs e)
          {
               Label label = VerifyLetterPosition();

               if (label.Text == "" && contagemPosicoes < 4)
               {
                    contagemPosicoes++;
                    label = VerifyLetterPosition();
                    label.ResetText();
               }
               else
                    label.ResetText();
          }

          private void btnEntry_Click(object sender, EventArgs e)
          {
               Label label = VerifyLetterPosition();
               contagemAcertos = 0;
               if (contagemPosicoes == 0 && label.Text != "")
               {
                    VerifyWord();

                    if (contagemAcertos == 5)
                    {
                         MessageBox.Show($"Voce acertou a palavra '{novoJogo.PalavraAleatoria.ToString()}', parabéns!");
                         ReiniciarJogo();
                         return;
                    }

                    else if (contagemTentativas == 4)
                    {
                         MessageBox.Show($"Voce perdeu!, a palavra era '{novoJogo.PalavraAleatoria.ToString()}'");
                         ReiniciarJogo();
                         return;
                    }

                    contagemTentativas++;
                    contagemPosicoes = 4;
               }
          }

          private void VerifyWord()
          {
               switch (contagemTentativas)
               {
                    case 0:
                         foreach (Label l in tlpFirstTry.Controls)
                         {
                              if (novoJogo.CaracteresPalavra.Contains(l.Text[0]))
                              {
                                   if (l.Text[0] == novoJogo.CaracteresPalavra.ElementAt(l.TabIndex))
                                   {
                                        l.BackColor = Color.Green;
                                        contagemAcertos++;
                                   }

                                   else
                                        l.BackColor = Color.Gold;
                              }
                              else
                                   l.BackColor = Color.Red;
                         }
                         break;
                    case 1:
                         foreach (Label l in tlpSecondTry.Controls)
                         {
                              if (novoJogo.CaracteresPalavra.Contains(l.Text[0]))
                              {
                                   if (l.Text[0] == novoJogo.CaracteresPalavra.ElementAt(l.TabIndex))
                                   {
                                        l.BackColor = Color.Green;
                                        contagemAcertos++;
                                   }

                                   else
                                        l.BackColor = Color.Gold;
                              }
                              else
                                   l.BackColor = Color.Red;
                         }
                         break;
                    case 2:
                         foreach (Label l in tlpThirdTry.Controls)
                         {
                              if (novoJogo.CaracteresPalavra.Contains(l.Text[0]))
                              {
                                   if (l.Text[0] == novoJogo.CaracteresPalavra.ElementAt(l.TabIndex))
                                   {
                                        l.BackColor = Color.Green;
                                        contagemAcertos++;
                                   }

                                   else
                                        l.BackColor = Color.Gold;
                              }
                              else
                                   l.BackColor = Color.Red;
                         }
                         break;
                    case 3:
                         foreach (Label l in tlpFourthTry.Controls)
                         {
                              if (novoJogo.CaracteresPalavra.Contains(l.Text[0]))
                              {
                                   if (l.Text[0] == novoJogo.CaracteresPalavra.ElementAt(l.TabIndex))
                                   {
                                        l.BackColor = Color.Green;
                                        contagemAcertos++;
                                   }

                                   else
                                        l.BackColor = Color.Gold;
                              }
                              else
                                   l.BackColor = Color.Red;
                         }
                         break;
                    case 4:
                         foreach (Label l in tlpFifthTry.Controls)
                         {
                              if (novoJogo.CaracteresPalavra.Contains(l.Text[0]))
                              {
                                   if (l.Text[0] == novoJogo.CaracteresPalavra.ElementAt(l.TabIndex))
                                   {
                                        l.BackColor = Color.Green;
                                        contagemAcertos++;
                                   }

                                   else
                                        l.BackColor = Color.Gold;
                              }
                              else
                                   l.BackColor = Color.Red;
                         }
                         break;
               }
          }
     }
}