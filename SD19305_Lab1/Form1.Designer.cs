namespace SD19305_Lab1
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
            label1 = new Label();
            label2 = new Label();
            txt_soA = new TextBox();
            txt_soB = new TextBox();
            txt_result = new TextBox();
            btn_plus = new Button();
            btn_reset = new Button();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            label3 = new Label();
            label4 = new Label();
            txt_hoadon = new TextBox();
            label5 = new Label();
            checkBox3 = new CheckBox();
            btn_checkout = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(41, 55);
            label1.Name = "label1";
            label1.Size = new Size(90, 37);
            label1.TabIndex = 0;
            label1.Text = "label1";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(41, 126);
            label2.Name = "label2";
            label2.Size = new Size(90, 37);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // txt_soA
            // 
            txt_soA.Location = new Point(158, 69);
            txt_soA.Name = "txt_soA";
            txt_soA.Size = new Size(425, 23);
            txt_soA.TabIndex = 2;
            // 
            // txt_soB
            // 
            txt_soB.Location = new Point(158, 140);
            txt_soB.Name = "txt_soB";
            txt_soB.Size = new Size(425, 23);
            txt_soB.TabIndex = 3;
            // 
            // txt_result
            // 
            txt_result.Location = new Point(158, 229);
            txt_result.Name = "txt_result";
            txt_result.Size = new Size(425, 23);
            txt_result.TabIndex = 4;
            // 
            // btn_plus
            // 
            btn_plus.Location = new Point(158, 188);
            btn_plus.Name = "btn_plus";
            btn_plus.Size = new Size(75, 23);
            btn_plus.TabIndex = 5;
            btn_plus.Text = "+";
            btn_plus.UseVisualStyleBackColor = true;
            btn_plus.Click += btn_plus_Click;
            // 
            // btn_reset
            // 
            btn_reset.Location = new Point(269, 188);
            btn_reset.Name = "btn_reset";
            btn_reset.Size = new Size(75, 23);
            btn_reset.TabIndex = 6;
            btn_reset.Text = "reset";
            btn_reset.UseVisualStyleBackColor = true;
            btn_reset.Click += btn_reset_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Location = new Point(48, 281);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(160, 41);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox2.Location = new Point(41, 328);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(160, 41);
            checkBox2.TabIndex = 8;
            checkBox2.Text = "checkBox2";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(324, 282);
            label3.Name = "label3";
            label3.Size = new Size(78, 37);
            label3.TabIndex = 9;
            label3.Text = "250K";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(324, 332);
            label4.Name = "label4";
            label4.Size = new Size(78, 37);
            label4.TabIndex = 10;
            label4.Text = "100K";
            // 
            // txt_hoadon
            // 
            txt_hoadon.Location = new Point(41, 403);
            txt_hoadon.Name = "txt_hoadon";
            txt_hoadon.Size = new Size(425, 23);
            txt_hoadon.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(709, 283);
            label5.Name = "label5";
            label5.Size = new Size(78, 37);
            label5.TabIndex = 13;
            label5.Text = "450K";
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox3.Location = new Point(433, 282);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(160, 41);
            checkBox3.TabIndex = 12;
            checkBox3.Text = "checkBox3";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // btn_checkout
            // 
            btn_checkout.Location = new Point(433, 343);
            btn_checkout.Name = "btn_checkout";
            btn_checkout.Size = new Size(75, 23);
            btn_checkout.TabIndex = 14;
            btn_checkout.Text = "thanh toán";
            btn_checkout.UseVisualStyleBackColor = true;
            btn_checkout.Click += btn_checkout_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_checkout);
            Controls.Add(label5);
            Controls.Add(checkBox3);
            Controls.Add(txt_hoadon);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(btn_reset);
            Controls.Add(btn_plus);
            Controls.Add(txt_result);
            Controls.Add(txt_soB);
            Controls.Add(txt_soA);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_soA;
        private TextBox txt_soB;
        private TextBox txt_result;
        private Button btn_plus;
        private Button btn_reset;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Label label3;
        private Label label4;
        private TextBox txt_hoadon;
        private Label label5;
        private CheckBox checkBox3;
        private Button btn_checkout;
    }
}