namespace WinFormsApp1
{
  partial class Form1
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      btn1 = new Button();
      btn2 = new Button();
      btn3 = new Button();
      btn6 = new Button();
      btn5 = new Button();
      btn4 = new Button();
      btn9 = new Button();
      btn8 = new Button();
      btn7 = new Button();
      txtPantalla = new TextBox();
      btnSuma = new Button();
      btnIgual = new Button();
      btn0 = new Button();
      btnPunto = new Button();
      btnResta = new Button();
      SuspendLayout();
      // 
      // btn1
      // 
      btn1.Font = new Font("Segoe UI", 15F);
      btn1.Location = new Point(318, 242);
      btn1.Name = "btn1";
      btn1.Size = new Size(50, 50);
      btn1.TabIndex = 0;
      btn1.Text = "1";
      btn1.UseVisualStyleBackColor = true;
      btn1.Click += btn_Click;
      // 
      // btn2
      // 
      btn2.Font = new Font("Segoe UI", 15F);
      btn2.Location = new Point(374, 242);
      btn2.Name = "btn2";
      btn2.Size = new Size(50, 50);
      btn2.TabIndex = 1;
      btn2.Text = "2";
      btn2.UseVisualStyleBackColor = true;
      btn2.Click += btn_Click;
      // 
      // btn3
      // 
      btn3.Font = new Font("Segoe UI", 15F);
      btn3.Location = new Point(430, 242);
      btn3.Name = "btn3";
      btn3.Size = new Size(50, 50);
      btn3.TabIndex = 2;
      btn3.Text = "3";
      btn3.UseVisualStyleBackColor = true;
      btn3.Click += btn_Click;
      // 
      // btn6
      // 
      btn6.Font = new Font("Segoe UI", 15F);
      btn6.Location = new Point(430, 186);
      btn6.Name = "btn6";
      btn6.Size = new Size(50, 50);
      btn6.TabIndex = 5;
      btn6.Text = "6";
      btn6.UseVisualStyleBackColor = true;
      btn6.Click += btn_Click;
      // 
      // btn5
      // 
      btn5.Font = new Font("Segoe UI", 15F);
      btn5.Location = new Point(374, 186);
      btn5.Name = "btn5";
      btn5.Size = new Size(50, 50);
      btn5.TabIndex = 4;
      btn5.Text = "5";
      btn5.UseVisualStyleBackColor = true;
      btn5.Click += btn_Click;
      // 
      // btn4
      // 
      btn4.Font = new Font("Segoe UI", 15F);
      btn4.Location = new Point(318, 186);
      btn4.Name = "btn4";
      btn4.Size = new Size(50, 50);
      btn4.TabIndex = 3;
      btn4.Text = "4";
      btn4.UseVisualStyleBackColor = true;
      btn4.Click += btn_Click;
      // 
      // btn9
      // 
      btn9.Font = new Font("Segoe UI", 15F);
      btn9.Location = new Point(430, 130);
      btn9.Name = "btn9";
      btn9.Size = new Size(50, 50);
      btn9.TabIndex = 8;
      btn9.Text = "9";
      btn9.UseVisualStyleBackColor = true;
      btn9.Click += btn_Click;
      // 
      // btn8
      // 
      btn8.Font = new Font("Segoe UI", 15F);
      btn8.Location = new Point(374, 130);
      btn8.Name = "btn8";
      btn8.Size = new Size(50, 50);
      btn8.TabIndex = 7;
      btn8.Text = "8";
      btn8.UseVisualStyleBackColor = true;
      btn8.Click += btn_Click;
      // 
      // btn7
      // 
      btn7.Font = new Font("Segoe UI", 15F);
      btn7.Location = new Point(318, 130);
      btn7.Name = "btn7";
      btn7.Size = new Size(50, 50);
      btn7.TabIndex = 6;
      btn7.Text = "7";
      btn7.UseVisualStyleBackColor = true;
      btn7.Click += btn_Click;
      // 
      // txtPantalla
      // 
      txtPantalla.Font = new Font("Segoe UI", 20F);
      txtPantalla.Location = new Point(318, 81);
      txtPantalla.Name = "txtPantalla";
      txtPantalla.Size = new Size(218, 43);
      txtPantalla.TabIndex = 9;
      txtPantalla.TextAlign = HorizontalAlignment.Right;
      // 
      // btnSuma
      // 
      btnSuma.Font = new Font("Segoe UI", 15F);
      btnSuma.Location = new Point(486, 130);
      btnSuma.Name = "btnSuma";
      btnSuma.Size = new Size(50, 50);
      btnSuma.TabIndex = 10;
      btnSuma.Text = "+";
      btnSuma.UseVisualStyleBackColor = true;
      btnSuma.Click += btnOperador_Click;
      // 
      // btnIgual
      // 
      btnIgual.Font = new Font("Segoe UI", 15F);
      btnIgual.Location = new Point(486, 242);
      btnIgual.Name = "btnIgual";
      btnIgual.Size = new Size(50, 106);
      btnIgual.TabIndex = 11;
      btnIgual.Text = "=";
      btnIgual.UseVisualStyleBackColor = true;
      btnIgual.Click += btnIgual_Click;
      // 
      // btn0
      // 
      btn0.Font = new Font("Segoe UI", 15F);
      btn0.Location = new Point(318, 298);
      btn0.Name = "btn0";
      btn0.Size = new Size(106, 50);
      btn0.TabIndex = 12;
      btn0.Text = "0";
      btn0.UseVisualStyleBackColor = true;
      btn0.Click += btn_Click;
      // 
      // btnPunto
      // 
      btnPunto.Font = new Font("Segoe UI", 15F);
      btnPunto.Location = new Point(430, 298);
      btnPunto.Name = "btnPunto";
      btnPunto.Size = new Size(50, 50);
      btnPunto.TabIndex = 13;
      btnPunto.Text = ".";
      btnPunto.UseVisualStyleBackColor = true;
      btnPunto.Click += btn_Click;
      // 
      // btnResta
      // 
      btnResta.Font = new Font("Segoe UI", 15F);
      btnResta.Location = new Point(486, 186);
      btnResta.Name = "btnResta";
      btnResta.Size = new Size(50, 50);
      btnResta.TabIndex = 14;
      btnResta.Text = "-";
      btnResta.UseVisualStyleBackColor = true;
      btnResta.Click += btnOperador_Click;
      // 
      // Form1
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(800, 450);
      Controls.Add(btnResta);
      Controls.Add(btnPunto);
      Controls.Add(btn0);
      Controls.Add(btnIgual);
      Controls.Add(btnSuma);
      Controls.Add(txtPantalla);
      Controls.Add(btn9);
      Controls.Add(btn8);
      Controls.Add(btn7);
      Controls.Add(btn6);
      Controls.Add(btn5);
      Controls.Add(btn4);
      Controls.Add(btn3);
      Controls.Add(btn2);
      Controls.Add(btn1);
      Name = "Form1";
      Text = "Form1";
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Button btn1;
    private Button btn2;
    private Button btn3;
    private Button btn6;
    private Button btn5;
    private Button btn4;
    private Button btn9;
    private Button btn8;
    private Button btn7;
    private TextBox txtPantalla;
    private Button btnSuma;
    private Button btnIgual;
    private Button btn0;
    private Button btnPunto;
    private Button btnResta;
  }
}
