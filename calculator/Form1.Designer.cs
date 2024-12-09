namespace calculator
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
            screen = new TextBox();
            btn1 = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn0 = new Button();
            btn9 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn6 = new Button();
            btnclear = new Button();
            btndivide = new Button();
            btnminus = new Button();
            btnmultiply = new Button();
            btnplus = new Button();
            btnequals = new Button();
            SuspendLayout();
            // 
            // screen
            // 
            screen.BorderStyle = BorderStyle.FixedSingle;
            screen.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            screen.Location = new Point(18, 17);
            screen.Margin = new Padding(4);
            screen.Multiline = true;
            screen.Name = "screen";
            screen.Size = new Size(736, 92);
            screen.TabIndex = 0;
            screen.TextAlign = HorizontalAlignment.Right;
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btn1.Location = new Point(18, 118);
            btn1.Margin = new Padding(4);
            btn1.Name = "btn1";
            btn1.Size = new Size(140, 66);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btn3.Location = new Point(316, 118);
            btn3.Margin = new Padding(4);
            btn3.Name = "btn3";
            btn3.Size = new Size(140, 66);
            btn3.TabIndex = 2;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btn2.Location = new Point(167, 118);
            btn2.Margin = new Padding(4);
            btn2.Name = "btn2";
            btn2.Size = new Size(140, 66);
            btn2.TabIndex = 3;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btn4.Location = new Point(465, 118);
            btn4.Margin = new Padding(4);
            btn4.Name = "btn4";
            btn4.RightToLeft = RightToLeft.No;
            btn4.Size = new Size(140, 66);
            btn4.TabIndex = 4;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btn5.Location = new Point(614, 118);
            btn5.Margin = new Padding(4);
            btn5.Name = "btn5";
            btn5.Size = new Size(140, 66);
            btn5.TabIndex = 5;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn0
            // 
            btn0.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btn0.Location = new Point(615, 201);
            btn0.Margin = new Padding(4);
            btn0.Name = "btn0";
            btn0.Size = new Size(140, 66);
            btn0.TabIndex = 10;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btn9.Location = new Point(466, 201);
            btn9.Margin = new Padding(4);
            btn9.Name = "btn9";
            btn9.Size = new Size(140, 66);
            btn9.TabIndex = 9;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn7
            // 
            btn7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btn7.Location = new Point(168, 201);
            btn7.Margin = new Padding(4);
            btn7.Name = "btn7";
            btn7.Size = new Size(140, 66);
            btn7.TabIndex = 8;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btn8.Location = new Point(317, 201);
            btn8.Margin = new Padding(4);
            btn8.Name = "btn8";
            btn8.Size = new Size(140, 66);
            btn8.TabIndex = 7;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btn6.Location = new Point(19, 201);
            btn6.Margin = new Padding(4);
            btn6.Name = "btn6";
            btn6.Size = new Size(140, 66);
            btn6.TabIndex = 6;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btnclear
            // 
            btnclear.Location = new Point(19, 377);
            btnclear.Margin = new Padding(4);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(736, 66);
            btnclear.TabIndex = 15;
            btnclear.Text = "CLEAR";
            btnclear.UseVisualStyleBackColor = true;
            btnclear.Click += btnclear_Click;
            // 
            // btndivide
            // 
            btndivide.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btndivide.Location = new Point(465, 287);
            btndivide.Margin = new Padding(4);
            btndivide.Name = "btndivide";
            btndivide.RightToLeft = RightToLeft.No;
            btndivide.Size = new Size(140, 66);
            btndivide.TabIndex = 14;
            btndivide.Text = "/";
            btndivide.UseVisualStyleBackColor = true;
            btndivide.Click += btndivide_Click;
            // 
            // btnminus
            // 
            btnminus.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnminus.Location = new Point(167, 287);
            btnminus.Margin = new Padding(4);
            btnminus.Name = "btnminus";
            btnminus.Size = new Size(140, 66);
            btnminus.TabIndex = 13;
            btnminus.Text = "-";
            btnminus.UseVisualStyleBackColor = true;
            btnminus.Click += btnminus_Click;
            // 
            // btnmultiply
            // 
            btnmultiply.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnmultiply.Location = new Point(316, 287);
            btnmultiply.Margin = new Padding(4);
            btnmultiply.Name = "btnmultiply";
            btnmultiply.Size = new Size(140, 66);
            btnmultiply.TabIndex = 12;
            btnmultiply.Text = "*";
            btnmultiply.UseVisualStyleBackColor = true;
            btnmultiply.Click += btnmultiply_Click;
            // 
            // btnplus
            // 
            btnplus.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnplus.Location = new Point(18, 287);
            btnplus.Margin = new Padding(4);
            btnplus.Name = "btnplus";
            btnplus.Size = new Size(140, 66);
            btnplus.TabIndex = 11;
            btnplus.Text = "+";
            btnplus.UseVisualStyleBackColor = true;
            btnplus.Click += btnplus_Click;
            // 
            // btnequals
            // 
            btnequals.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnequals.Location = new Point(615, 287);
            btnequals.Margin = new Padding(4);
            btnequals.Name = "btnequals";
            btnequals.RightToLeft = RightToLeft.No;
            btnequals.Size = new Size(140, 66);
            btnequals.TabIndex = 16;
            btnequals.Text = "=";
            btnequals.UseVisualStyleBackColor = true;
            btnequals.Click += btnequals_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 459);
            Controls.Add(btnequals);
            Controls.Add(btnclear);
            Controls.Add(btndivide);
            Controls.Add(btnminus);
            Controls.Add(btnmultiply);
            Controls.Add(btnplus);
            Controls.Add(btn0);
            Controls.Add(btn9);
            Controls.Add(btn7);
            Controls.Add(btn8);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn2);
            Controls.Add(btn3);
            Controls.Add(btn1);
            Controls.Add(screen);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "CALCULATOR";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox screen;
        private Button btn1;
        private Button btn3;
        private Button btn2;
        private Button btn4;
        private Button btn5;
        private Button btn0;
        private Button btn9;
        private Button btn7;
        private Button btn8;
        private Button btn6;
        private Button btnclear;
        private Button btndivide;
        private Button btnminus;
        private Button btnmultiply;
        private Button btnplus;
        private Button btnequals;
    }
}
