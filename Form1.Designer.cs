namespace JogoDaVelha
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
            groupBox1 = new GroupBox();
            lblJogadorO = new Label();
            lblJogadorX = new Label();
            btnIniciar = new Button();
            btnO = new Button();
            btnX = new Button();
            groupBox2 = new GroupBox();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btn4 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblJogadorO);
            groupBox1.Controls.Add(lblJogadorX);
            groupBox1.Controls.Add(btnIniciar);
            groupBox1.Controls.Add(btnO);
            groupBox1.Controls.Add(btnX);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(314, 426);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // lblJogadorO
            // 
            lblJogadorO.AutoSize = true;
            lblJogadorO.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJogadorO.Location = new Point(166, 157);
            lblJogadorO.Name = "lblJogadorO";
            lblJogadorO.Size = new Size(104, 25);
            lblJogadorO.TabIndex = 4;
            lblJogadorO.Text = "Jogador O";
            // 
            // lblJogadorX
            // 
            lblJogadorX.AutoSize = true;
            lblJogadorX.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJogadorX.Location = new Point(29, 157);
            lblJogadorX.Name = "lblJogadorX";
            lblJogadorX.Size = new Size(103, 25);
            lblJogadorX.TabIndex = 3;
            lblJogadorX.Text = "Jogador X";
            // 
            // btnIniciar
            // 
            btnIniciar.Enabled = false;
            btnIniciar.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIniciar.Location = new Point(29, 201);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(243, 40);
            btnIniciar.TabIndex = 2;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // btnO
            // 
            btnO.Font = new Font("Comic Sans MS", 35F);
            btnO.Location = new Point(166, 49);
            btnO.Name = "btnO";
            btnO.Size = new Size(106, 99);
            btnO.TabIndex = 1;
            btnO.Text = "O";
            btnO.UseVisualStyleBackColor = true;
            btnO.Click += btnO_Click;
            // 
            // btnX
            // 
            btnX.Font = new Font("Comic Sans MS", 35F);
            btnX.Location = new Point(29, 49);
            btnX.Name = "btnX";
            btnX.Size = new Size(106, 99);
            btnX.TabIndex = 0;
            btnX.Text = "X";
            btnX.UseVisualStyleBackColor = true;
            btnX.Click += btnX_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn9);
            groupBox2.Controls.Add(btn8);
            groupBox2.Controls.Add(btn7);
            groupBox2.Controls.Add(btn4);
            groupBox2.Controls.Add(btn6);
            groupBox2.Controls.Add(btn5);
            groupBox2.Controls.Add(btn3);
            groupBox2.Controls.Add(btn2);
            groupBox2.Controls.Add(btn1);
            groupBox2.Location = new Point(398, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(390, 426);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // btn9
            // 
            btn9.Font = new Font("Comic Sans MS", 34.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn9.Location = new Point(268, 273);
            btn9.Name = "btn9";
            btn9.Size = new Size(106, 99);
            btn9.TabIndex = 16;
            btn9.Text = "O";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Comic Sans MS", 34.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn8.Location = new Point(146, 273);
            btn8.Name = "btn8";
            btn8.Size = new Size(106, 99);
            btn8.TabIndex = 15;
            btn8.Text = "X";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn7
            // 
            btn7.Font = new Font("Comic Sans MS", 34.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn7.Location = new Point(24, 273);
            btn7.Name = "btn7";
            btn7.Size = new Size(106, 99);
            btn7.TabIndex = 14;
            btn7.Text = "O";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Comic Sans MS", 34.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn4.Location = new Point(24, 157);
            btn4.Name = "btn4";
            btn4.Size = new Size(106, 99);
            btn4.TabIndex = 1;
            btn4.Text = "X";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Comic Sans MS", 34.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn6.Location = new Point(268, 157);
            btn6.Name = "btn6";
            btn6.Size = new Size(106, 99);
            btn6.TabIndex = 13;
            btn6.Text = "X";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Comic Sans MS", 34.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn5.Location = new Point(146, 157);
            btn5.Name = "btn5";
            btn5.Size = new Size(106, 99);
            btn5.TabIndex = 12;
            btn5.Text = "O";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Comic Sans MS", 34.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn3.Location = new Point(268, 42);
            btn3.Name = "btn3";
            btn3.Size = new Size(106, 99);
            btn3.TabIndex = 11;
            btn3.Text = "O";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Comic Sans MS", 34.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn2.Location = new Point(146, 43);
            btn2.Name = "btn2";
            btn2.Size = new Size(106, 99);
            btn2.TabIndex = 10;
            btn2.Text = "X";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn1
            // 
            btn1.Font = new Font("Comic Sans MS", 34.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn1.Location = new Point(24, 42);
            btn1.Name = "btn1";
            btn1.Size = new Size(106, 99);
            btn1.TabIndex = 9;
            btn1.Text = "O";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnIniciar;
        private GroupBox groupBox2;
        private Button btn4;
        private Button btnO;
        private Button btnX;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btn6;
        private Button btn5;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Label lblJogadorO;
        private Label lblJogadorX;
    }
}
