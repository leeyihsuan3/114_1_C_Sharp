    namespace comprehensive_Practice_1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelGivenName;
        private System.Windows.Forms.Label labelQuiz1;
        private System.Windows.Forms.Label labelQuiz2;
        private System.Windows.Forms.Label labelQuiz3;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxGivenName;
        private System.Windows.Forms.TextBox textBoxQuiz1;
        private System.Windows.Forms.TextBox textBoxQuiz2;
        private System.Windows.Forms.TextBox textBoxQuiz3;
        private System.Windows.Forms.Button buttonShowHighest;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelResult;

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
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelGivenName = new System.Windows.Forms.Label();
            this.labelQuiz1 = new System.Windows.Forms.Label();
            this.labelQuiz2 = new System.Windows.Forms.Label();
            this.labelQuiz3 = new System.Windows.Forms.Label();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxGivenName = new System.Windows.Forms.TextBox();
            this.textBoxQuiz1 = new System.Windows.Forms.TextBox();
            this.textBoxQuiz2 = new System.Windows.Forms.TextBox();
            this.textBoxQuiz3 = new System.Windows.Forms.TextBox();
            this.buttonShowHighest = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Font = new System.Drawing.Font("微軟正黑體", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelSurname.Location = new System.Drawing.Point(422, 34);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(68, 55);
            this.labelSurname.TabIndex = 0;
            this.labelSurname.Text = "姓";
            // 
            // labelGivenName
            // 
            this.labelGivenName.AutoSize = true;
            this.labelGivenName.Font = new System.Drawing.Font("微軟正黑體", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelGivenName.Location = new System.Drawing.Point(20, 42);
            this.labelGivenName.Name = "labelGivenName";
            this.labelGivenName.Size = new System.Drawing.Size(68, 55);
            this.labelGivenName.TabIndex = 2;
            this.labelGivenName.Text = "名";
            // 
            // labelQuiz1
            // 
            this.labelQuiz1.AutoSize = true;
            this.labelQuiz1.Font = new System.Drawing.Font("微軟正黑體", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelQuiz1.Location = new System.Drawing.Point(20, 140);
            this.labelQuiz1.Name = "labelQuiz1";
            this.labelQuiz1.Size = new System.Drawing.Size(138, 55);
            this.labelQuiz1.TabIndex = 4;
            this.labelQuiz1.Text = "小考1";
            // 
            // labelQuiz2
            // 
            this.labelQuiz2.AutoSize = true;
            this.labelQuiz2.Font = new System.Drawing.Font("微軟正黑體", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelQuiz2.Location = new System.Drawing.Point(20, 200);
            this.labelQuiz2.Name = "labelQuiz2";
            this.labelQuiz2.Size = new System.Drawing.Size(138, 55);
            this.labelQuiz2.TabIndex = 6;
            this.labelQuiz2.Text = "小考2";
            // 
            // labelQuiz3
            // 
            this.labelQuiz3.AutoSize = true;
            this.labelQuiz3.Font = new System.Drawing.Font("微軟正黑體", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelQuiz3.Location = new System.Drawing.Point(20, 260);
            this.labelQuiz3.Name = "labelQuiz3";
            this.labelQuiz3.Size = new System.Drawing.Size(138, 55);
            this.labelQuiz3.TabIndex = 8;
            this.labelQuiz3.Text = "小考3";
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Font = new System.Drawing.Font("微軟正黑體", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxSurname.Location = new System.Drawing.Point(110, 31);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(260, 66);
            this.textBoxSurname.TabIndex = 1;
            // 
            // textBoxGivenName
            // 
            this.textBoxGivenName.Font = new System.Drawing.Font("微軟正黑體", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxGivenName.Location = new System.Drawing.Point(518, 31);
            this.textBoxGivenName.Name = "textBoxGivenName";
            this.textBoxGivenName.Size = new System.Drawing.Size(260, 66);
            this.textBoxGivenName.TabIndex = 3;
            // 
            // textBoxQuiz1
            // 
            this.textBoxQuiz1.Font = new System.Drawing.Font("微軟正黑體", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxQuiz1.Location = new System.Drawing.Point(110, 136);
            this.textBoxQuiz1.Name = "textBoxQuiz1";
            this.textBoxQuiz1.Size = new System.Drawing.Size(260, 66);
            this.textBoxQuiz1.TabIndex = 5;
            // 
            // textBoxQuiz2
            // 
            this.textBoxQuiz2.Font = new System.Drawing.Font("微軟正黑體", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxQuiz2.Location = new System.Drawing.Point(110, 196);
            this.textBoxQuiz2.Name = "textBoxQuiz2";
            this.textBoxQuiz2.Size = new System.Drawing.Size(260, 66);
            this.textBoxQuiz2.TabIndex = 7;
            // 
            // textBoxQuiz3
            // 
            this.textBoxQuiz3.Font = new System.Drawing.Font("微軟正黑體", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxQuiz3.Location = new System.Drawing.Point(110, 256);
            this.textBoxQuiz3.Name = "textBoxQuiz3";
            this.textBoxQuiz3.Size = new System.Drawing.Size(260, 66);
            this.textBoxQuiz3.TabIndex = 9;
            // 
            // buttonShowHighest
            // 
            this.buttonShowHighest.Font = new System.Drawing.Font("微軟正黑體", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonShowHighest.Location = new System.Drawing.Point(84, 351);
            this.buttonShowHighest.Name = "buttonShowHighest";
            this.buttonShowHighest.Size = new System.Drawing.Size(320, 60);
            this.buttonShowHighest.TabIndex = 10;
            this.buttonShowHighest.Text = "顯示最高分";
            this.buttonShowHighest.UseVisualStyleBackColor = true;
            this.buttonShowHighest.Click += new System.EventHandler(this.buttonShowHighest_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("微軟正黑體", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonExit.Location = new System.Drawing.Point(432, 351);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(320, 60);
            this.buttonExit.TabIndex = 11;
            this.buttonExit.Text = "離開";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelResult
            // 
            this.labelResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelResult.Font = new System.Drawing.Font("微軟正黑體", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelResult.Location = new System.Drawing.Point(432, 162);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(320, 100);
            this.labelResult.TabIndex = 12;
            this.labelResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.labelGivenName);
            this.Controls.Add(this.textBoxGivenName);
            this.Controls.Add(this.labelQuiz1);
            this.Controls.Add(this.textBoxQuiz1);
            this.Controls.Add(this.labelQuiz2);
            this.Controls.Add(this.textBoxQuiz2);
            this.Controls.Add(this.labelQuiz3);
            this.Controls.Add(this.textBoxQuiz3);
            this.Controls.Add(this.buttonShowHighest);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.labelResult);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}

