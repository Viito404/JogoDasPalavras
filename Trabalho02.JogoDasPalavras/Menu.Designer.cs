namespace Trabalho02.JogoDasPalavras
{
     partial class Menu
     {
          /// <summary>
          /// Required designer variable.
          /// </summary>
          private System.ComponentModel.IContainer components = null;

          /// <summary>
          /// Clean up any resources being used.
          /// </summary>
          /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
          protected override void Dispose(bool disposing)
          {
               if (disposing && (components != null))
               {
                    components.Dispose();
               }
               base.Dispose(disposing);
          }

          #region Windows Form Designer generated code

          /// <summary>
          /// Required method for Designer support - do not modify
          /// the contents of this method with the code editor.
          /// </summary>
          private void InitializeComponent()
          {
               button20 = new Button();
               pictureBox1 = new PictureBox();
               button1 = new Button();
               ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
               SuspendLayout();
               // 
               // button20
               // 
               button20.Anchor = AnchorStyles.None;
               button20.BackColor = Color.LightGray;
               button20.FlatAppearance.BorderColor = Color.Black;
               button20.FlatAppearance.BorderSize = 0;
               button20.FlatStyle = FlatStyle.Flat;
               button20.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
               button20.Location = new Point(217, 308);
               button20.Name = "button20";
               button20.Size = new Size(129, 42);
               button20.TabIndex = 29;
               button20.Text = "JOGAR";
               button20.UseVisualStyleBackColor = false;
               button20.Click += button20_Click;
               // 
               // pictureBox1
               // 
               pictureBox1.Image = Properties.Resources.TERMUS;
               pictureBox1.Location = new Point(200, 111);
               pictureBox1.Name = "pictureBox1";
               pictureBox1.Size = new Size(162, 161);
               pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
               pictureBox1.TabIndex = 30;
               pictureBox1.TabStop = false;
               // 
               // button1
               // 
               button1.Anchor = AnchorStyles.None;
               button1.BackColor = Color.LightGray;
               button1.FlatAppearance.BorderColor = Color.Black;
               button1.FlatAppearance.BorderSize = 0;
               button1.FlatStyle = FlatStyle.Flat;
               button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
               button1.Location = new Point(217, 365);
               button1.Name = "button1";
               button1.Size = new Size(129, 42);
               button1.TabIndex = 31;
               button1.Text = "SAIR";
               button1.UseVisualStyleBackColor = false;
               button1.Click += button1_Click;
               // 
               // Menu
               // 
               AutoScaleDimensions = new SizeF(7F, 15F);
               AutoScaleMode = AutoScaleMode.Font;
               ClientSize = new Size(567, 507);
               Controls.Add(button1);
               Controls.Add(pictureBox1);
               Controls.Add(button20);
               MinimumSize = new Size(583, 546);
               Name = "Menu";
               StartPosition = FormStartPosition.CenterScreen;
               Text = "Menu";
               ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
               ResumeLayout(false);
          }

          #endregion

          private Button button20;
          private PictureBox pictureBox1;
          private Button button1;
     }
}