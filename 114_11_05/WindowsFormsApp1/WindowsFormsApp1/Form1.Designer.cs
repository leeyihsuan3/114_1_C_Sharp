namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.milkteaRadioButton1 = new System.Windows.Forms.RadioButton();
            this.coffeeRadioButton2 = new System.Windows.Forms.RadioButton();
            this.blackteaRadioButton3 = new System.Windows.Forms.RadioButton();
            this.juiceRadioButton4 = new System.Windows.Forms.RadioButton();
            this.jamsandwichRadioButton5 = new System.Windows.Forms.RadioButton();
            this.hamsandwichRadioButton6 = new System.Windows.Forms.RadioButton();
            this.tunaRadioButton7 = new System.Windows.Forms.RadioButton();
            this.SendButton = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.juiceRadioButton4);
            this.groupBox1.Controls.Add(this.blackteaRadioButton3);
            this.groupBox1.Controls.Add(this.coffeeRadioButton2);
            this.groupBox1.Controls.Add(this.milkteaRadioButton1);
            this.groupBox1.Location = new System.Drawing.Point(29, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 234);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "飲料";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tunaRadioButton7);
            this.groupBox2.Controls.Add(this.hamsandwichRadioButton6);
            this.groupBox2.Controls.Add(this.jamsandwichRadioButton5);
            this.groupBox2.Location = new System.Drawing.Point(354, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 234);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "三明治";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // milkteaRadioButton1
            // 
            this.milkteaRadioButton1.AutoSize = true;
            this.milkteaRadioButton1.Location = new System.Drawing.Point(43, 89);
            this.milkteaRadioButton1.Name = "milkteaRadioButton1";
            this.milkteaRadioButton1.Size = new System.Drawing.Size(69, 22);
            this.milkteaRadioButton1.TabIndex = 0;
            this.milkteaRadioButton1.TabStop = true;
            this.milkteaRadioButton1.Text = "奶茶";
            this.milkteaRadioButton1.UseVisualStyleBackColor = true;
            // 
            // coffeeRadioButton2
            // 
            this.coffeeRadioButton2.AutoSize = true;
            this.coffeeRadioButton2.Location = new System.Drawing.Point(43, 50);
            this.coffeeRadioButton2.Name = "coffeeRadioButton2";
            this.coffeeRadioButton2.Size = new System.Drawing.Size(69, 22);
            this.coffeeRadioButton2.TabIndex = 1;
            this.coffeeRadioButton2.TabStop = true;
            this.coffeeRadioButton2.Text = "咖啡";
            this.coffeeRadioButton2.UseVisualStyleBackColor = true;
            this.coffeeRadioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // blackteaRadioButton3
            // 
            this.blackteaRadioButton3.AutoSize = true;
            this.blackteaRadioButton3.Location = new System.Drawing.Point(43, 129);
            this.blackteaRadioButton3.Name = "blackteaRadioButton3";
            this.blackteaRadioButton3.Size = new System.Drawing.Size(69, 22);
            this.blackteaRadioButton3.TabIndex = 2;
            this.blackteaRadioButton3.TabStop = true;
            this.blackteaRadioButton3.Text = "紅茶";
            this.blackteaRadioButton3.UseVisualStyleBackColor = true;
            // 
            // juiceRadioButton4
            // 
            this.juiceRadioButton4.AutoSize = true;
            this.juiceRadioButton4.Location = new System.Drawing.Point(43, 168);
            this.juiceRadioButton4.Name = "juiceRadioButton4";
            this.juiceRadioButton4.Size = new System.Drawing.Size(69, 22);
            this.juiceRadioButton4.TabIndex = 3;
            this.juiceRadioButton4.TabStop = true;
            this.juiceRadioButton4.Text = "果汁";
            this.juiceRadioButton4.UseVisualStyleBackColor = true;
            // 
            // jamsandwichRadioButton5
            // 
            this.jamsandwichRadioButton5.AutoSize = true;
            this.jamsandwichRadioButton5.Location = new System.Drawing.Point(44, 50);
            this.jamsandwichRadioButton5.Name = "jamsandwichRadioButton5";
            this.jamsandwichRadioButton5.Size = new System.Drawing.Size(123, 22);
            this.jamsandwichRadioButton5.TabIndex = 4;
            this.jamsandwichRadioButton5.TabStop = true;
            this.jamsandwichRadioButton5.Text = "果醬三明治";
            this.jamsandwichRadioButton5.UseVisualStyleBackColor = true;
            this.jamsandwichRadioButton5.CheckedChanged += new System.EventHandler(this.jamsandwichRadioButton5_CheckedChanged);
            // 
            // hamsandwichRadioButton6
            // 
            this.hamsandwichRadioButton6.AutoSize = true;
            this.hamsandwichRadioButton6.Location = new System.Drawing.Point(44, 89);
            this.hamsandwichRadioButton6.Name = "hamsandwichRadioButton6";
            this.hamsandwichRadioButton6.Size = new System.Drawing.Size(123, 22);
            this.hamsandwichRadioButton6.TabIndex = 5;
            this.hamsandwichRadioButton6.TabStop = true;
            this.hamsandwichRadioButton6.Text = "火腿三明治";
            this.hamsandwichRadioButton6.UseVisualStyleBackColor = true;
            // 
            // tunaRadioButton7
            // 
            this.tunaRadioButton7.AutoSize = true;
            this.tunaRadioButton7.Location = new System.Drawing.Point(44, 129);
            this.tunaRadioButton7.Name = "tunaRadioButton7";
            this.tunaRadioButton7.Size = new System.Drawing.Size(123, 22);
            this.tunaRadioButton7.TabIndex = 6;
            this.tunaRadioButton7.TabStop = true;
            this.tunaRadioButton7.Text = "鮪魚三明治";
            this.tunaRadioButton7.UseVisualStyleBackColor = true;
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(65, 354);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(193, 42);
            this.SendButton.TabIndex = 1;
            this.SendButton.Text = "送出訂單";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(398, 354);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(163, 42);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "離開";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton blackteaRadioButton3;
        private System.Windows.Forms.RadioButton coffeeRadioButton2;
        private System.Windows.Forms.RadioButton milkteaRadioButton1;
        private System.Windows.Forms.RadioButton juiceRadioButton4;
        private System.Windows.Forms.RadioButton tunaRadioButton7;
        private System.Windows.Forms.RadioButton hamsandwichRadioButton6;
        private System.Windows.Forms.RadioButton jamsandwichRadioButton5;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Button Exit;
    }
}

