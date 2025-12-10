using System;
using System.Globalization;
using System.Windows.Forms;

namespace comprehensive_Practice_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonShowHighest_Click(object sender, EventArgs e)
        {
            // 嘗試解析成績；若任何一個欄位非數字，提示使用者
            double v1, v2, v3;

            // 使用當前文化的格式解析並去除前後空白，遇到錯誤逐一回報並將焦點移至該欄位
            if (!double.TryParse(textBoxQuiz1.Text?.Trim(), NumberStyles.Float | NumberStyles.AllowThousands, CultureInfo.CurrentCulture, out v1))
            {
                MessageBox.Show("小考1 輸入錯誤，請輸入有效的數字成績。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxQuiz1.Focus();
                return;
            }

            if (!double.TryParse(textBoxQuiz2.Text?.Trim(), NumberStyles.Float | NumberStyles.AllowThousands, CultureInfo.CurrentCulture, out v2))
            {
                MessageBox.Show("小考2 輸入錯誤，請輸入有效的數字成績。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxQuiz2.Focus();
                return;
            }

            if (!double.TryParse(textBoxQuiz3.Text?.Trim(), NumberStyles.Float | NumberStyles.AllowThousands, CultureInfo.CurrentCulture, out v3))
            {
                MessageBox.Show("小考3 輸入錯誤，請輸入有效的數字成績。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxQuiz3.Focus();
                return;
            }

            // 計算最大值（避免額外 LINQ 依賴）
            double max = Math.Max(v1, Math.Max(v2, v3));

            // 美化數字顯示：若為整數則不顯示小數點
            string maxStr = (Math.Abs(max - Math.Round(max)) < 1e-9)
                ? ((long)Math.Round(max)).ToString()
                : max.ToString("0.##", CultureInfo.CurrentCulture);

            string fullName = $"{textBoxSurname.Text?.Trim()} {textBoxGivenName.Text?.Trim()}".Trim();
            string namePart = string.IsNullOrEmpty(fullName) ? "" : $"  姓名: {fullName}";
            labelResult.Text = $"最高分: {maxStr}{namePart}";
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
