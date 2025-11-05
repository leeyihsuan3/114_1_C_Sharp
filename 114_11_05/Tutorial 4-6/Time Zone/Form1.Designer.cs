namespace Time_Zone
{
    partial class Form1
    {
        /// <summary>
        /// 必需的設計器變數 (Designer variable)。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源（繁體中文註解）
        /// 若 disposing 為 true，表示要釋放受控資源 (managed resources)。
        /// 此處維持原有 Dispose 行為，不做其他邏輯變更。
        /// </summary>
        /// <param name="disposing">若為 true，表示應釋放受控資源。</param>
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
        /// 此方法由設計工具產生，用於初始化表單上的所有元件（InitializeComponent）。
        /// 變更內容（依使用者要求）：
        ///  1. 將所有可見元件的 Text 屬性改為繁體中文。
        ///  2. 將表單整體字型設定為 18pt（會套用至未個別指定字型的子元件）。
        ///  3. 在元件區塊加入繁體中文詳細註解（說明用途與注意事項）。
        /// 注意：未變更元件的位置、大小、名稱或事件綁定等行為。
        /// </summary>
        private void InitializeComponent()
        {
            this.promptLabel = new System.Windows.Forms.Label();
            this.cityListBox = new System.Windows.Forms.ListBox();
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.timeZoneLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // 全域字型設定
            // 將表單的預設字型設定為 18pt，會影響未單獨設定 Font 的子元件。
            // 若需要為個別元件設定不同字型，可在該元件區塊額外指定 Font 屬性（此處遵循要求僅調整大小）。
            // 
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // promptLabel
            // 
            // 指示使用者在清單中選擇城市的說明文字（提示用）
            this.promptLabel.AutoSize = true;
            this.promptLabel.Location = new System.Drawing.Point(5, 9);
            this.promptLabel.Name = "promptLabel";
            this.promptLabel.Size = new System.Drawing.Size(221, 13);
            this.promptLabel.TabIndex = 0;
            // 將提示文字改為繁體中文
            this.promptLabel.Text = "請選擇一個城市，我會告訴您該城市的時區。";
            // 
            // cityListBox
            // 
            // 城市清單：列出可供選擇的城市（已改為繁體中文名稱）
            this.cityListBox.FormattingEnabled = true;
            this.cityListBox.Items.AddRange(new object[] {
            "丹佛",
            "檀香山",
            "明尼阿波利斯",
            "紐約",
            "舊金山"});
            this.cityListBox.Location = new System.Drawing.Point(55, 31);
            this.cityListBox.Name = "cityListBox";
            this.cityListBox.Size = new System.Drawing.Size(120, 69);
            this.cityListBox.TabIndex = 1;
            // 
            // outputDescriptionLabel
            // 
            // 結果左側描述：標示下方欄位為「時區」
            this.outputDescriptionLabel.AutoSize = true;
            this.outputDescriptionLabel.Location = new System.Drawing.Point(32, 113);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(61, 13);
            this.outputDescriptionLabel.TabIndex = 2;
            // 將描述文字改為繁體中文
            this.outputDescriptionLabel.Text = "時區：";
            // 
            // timeZoneLabel
            // 
            // 顯示所選城市的時區（結果欄）
            // 保留邊框與置中對齊設定，預設為空白，透過事件填入文字。
            this.timeZoneLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeZoneLabel.Location = new System.Drawing.Point(99, 108);
            this.timeZoneLabel.Name = "timeZoneLabel";
            this.timeZoneLabel.Size = new System.Drawing.Size(100, 23);
            this.timeZoneLabel.TabIndex = 3;
            this.timeZoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // okButton
            // 
            // 確認按鈕：按下後觸發 okButton_Click 事件以顯示所選城市的時區
            this.okButton.Location = new System.Drawing.Point(37, 150);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 4;
            // 將按鈕文字改為繁體中文
            this.okButton.Text = "確定";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // exitButton
            // 
            // 關閉按鈕：關閉視窗（觸發 exitButton_Click）
            this.exitButton.Location = new System.Drawing.Point(118, 150);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 5;
            // 將按鈕文字改為繁體中文
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            // 表單屬性：保持原有大小與控制項集合，僅修改標題文字為繁體中文
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 189);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.timeZoneLabel);
            this.Controls.Add(this.outputDescriptionLabel);
            this.Controls.Add(this.cityListBox);
            this.Controls.Add(this.promptLabel);
            this.Name = "Form1";
            // 表單標題改為繁體中文
            this.Text = "時區";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label promptLabel;
        private System.Windows.Forms.ListBox cityListBox;
        private System.Windows.Forms.Label outputDescriptionLabel;
        private System.Windows.Forms.Label timeZoneLabel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button exitButton;
    }
}

