using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Friend_File
{
    public partial class Form1 : Form
    {
        private const string FileName = "FriendFile.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void writeNameButton_Click(object sender, EventArgs e)
        {
            var name = nameTextBox.Text?.Trim();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("請輸入姓名。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, FileName);

            try
            {
                // using 確保 StreamWriter 自動關閉與釋放
                using (var outputFile = new StreamWriter(path, append: true, encoding: Encoding.UTF8))
                {
                    outputFile.WriteLine(name);
                }

                nameTextBox.Clear();
                MessageBox.Show("已儲存。", "完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"寫入檔案失敗：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 可選：若擔心 UI 卡頓，可改用非同步寫入（需在 Designer 把按鈕事件改接此方法）
        private async void writeNameButton_Click_Async(object sender, EventArgs e)
        {
            var name = nameTextBox.Text?.Trim();
            if (string.IsNullOrEmpty(name)) return;

            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, FileName);

            try
            {
                await Task.Run(() => File.AppendAllText(path, name + Environment.NewLine, Encoding.UTF8));
                nameTextBox.Clear();
                MessageBox.Show("已儲存（非同步）。", "完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"寫入檔案失敗：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
