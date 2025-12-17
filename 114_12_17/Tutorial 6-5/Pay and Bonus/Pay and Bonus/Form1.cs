using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pay_and_Bonus
{
    public partial class Form1 : Form
    {
        // Constant field for the contribution rate
        private const decimal CONTRIB_RATE = 0.05m;

        public Form1()
        {
            InitializeComponent();
        }

        // The InputIsValid method converts the user input and stores
        // it in the arguments (passed by reference). If the conversion
        // is successful, the method returns true. Otherwise it returns
        // false.
        

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // 使用者按下「計算提撥」按鈕後的處理程序：
            // 通常流程：
            // 1. 驗證 grossPayTextBox 與 bonusTextBox 的輸入是否為可解析的數字（請以 decimal 解析以保留貨幣精度）。
            // 2. 若輸入有效，計算 (總薪資 + 獎金) * CONTRIB_RATE。
            // 3. 將結果格式化（例如 ToString("C") 或 ToString("N2")）並顯示在 contributionLabel。
            // 4. 若輸入無效，顯示錯誤訊息（例如 MessageBox.Show）並將焦點移回輸入欄位。
            //
            // 注意：為了不更動既有程式邏輯，此方法尚未新增實際計算程式碼。
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
