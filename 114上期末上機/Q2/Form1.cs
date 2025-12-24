using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Q2
{
    // 與 Designer 產生的部分合併的 partial 類別
    public partial class Form1 : Form
    {
        // 常數：服務價格、稅率、工時費率
        private const decimal PRICE_CHANGE_OIL = 780m;
        private const decimal PRICE_LUBRICATION = 540m;
        private const decimal PRICE_RADIATOR_CLEANING = 900m;
        private const decimal PRICE_TRANSMISSION_CLEANING = 2400m;
        private const decimal PRICE_INSPECTION = 450m;
        private const decimal PRICE_MUFFLER_REPLACE = 3000m;
        private const decimal PRICE_TIRE_ROTATION = 600m;

        private const decimal TAX_RATE = 0.06m;     // 6% 稅金
        private const decimal LABOR_RATE = 600m;    // 600 / 小時

        public Form1()
        {
            InitializeComponent();

            // 把按鈕事件在程式碼中關聯（如果設計器未綁定）
            btnCalculate.Click += BtnCalculate_Click;
            btnClear.Click += BtnClear_Click;
            btnExit.Click += BtnExit_Click;

            // 在 Form 關閉前詢問是否儲存明細
            this.FormClosing += Form1_FormClosing;
        }

        // 計算按鈕：主要流程
        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            // 讀取並驗證輸入（零件費用與工時）
            if (!TryGetInputs(out decimal partsCost, out decimal laborHours))
            {
                // 若驗證失敗，函式內已顯示錯誤訊息
                return;
            }

            // 計算服務項目總額（不含零件與稅）
            decimal servicesTotal = CalculateServicesTotal();

            // 計算工資（工時 * 單價）
            decimal laborCost = CalculateLaborCost(laborHours);

            // 服務與工資總額（顯示）
            decimal serviceAndLaborTotal = servicesTotal + laborCost;

            // 稅金（只算零件的稅）
            decimal tax = CalculateTax(partsCost);

            // 總費用
            decimal grandTotal = serviceAndLaborTotal + partsCost + tax;

            // 將結果顯示於輸出欄位（格式化到小數點 2 位）
            txtServiceLaborTotal.Text = serviceAndLaborTotal.ToString("0.00");
            txtPartsCostOut.Text = partsCost.ToString("0.00");
            txtTax.Text = tax.ToString("0.00");
            txtTotalCost.Text = grandTotal.ToString("0.00");
        }

        // 取得並驗證輸入（使用 TryParse 與 decimal）
        private bool TryGetInputs(out decimal partsCost, out decimal laborHours)
        {
            partsCost = 0m;
            laborHours = 0m;

            // 先檢查空字串情況
            if (string.IsNullOrWhiteSpace(txtPartsCost.Text))
            {
                MessageBox.Show("請輸入零件費用。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPartsCost.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtLaborHours.Text))
            {
                MessageBox.Show("請輸入工時（小時）。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLaborHours.Focus();
                return false;
            }

            // 嘗試解析零件費用
            if (!decimal.TryParse(txtPartsCost.Text.Trim(), out partsCost) || partsCost < 0m)
            {
                MessageBox.Show("零件費用格式錯誤或為負值，請輸入正確的數字。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPartsCost.Focus();
                return false;
            }

            // 嘗試解析工時
            if (!decimal.TryParse(txtLaborHours.Text.Trim(), out laborHours) || laborHours < 0m)
            {
                MessageBox.Show("工時格式錯誤或為負值，請輸入正確的數字。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLaborHours.Focus();
                return false;
            }

            return true;
        }

        // 計算所有被勾選的服務項目總額（價格為常數）
        private decimal CalculateServicesTotal()
        {
            decimal total = 0m;

            if (chkChangeOil.Checked)
                total += PRICE_CHANGE_OIL;
            if (chkLubrication.Checked)
                total += PRICE_LUBRICATION;
            if (chkRadiatorCleaning.Checked)
                total += PRICE_RADIATOR_CLEANING;
            if (chkTransmissionCleaning.Checked)
                total += PRICE_TRANSMISSION_CLEANING;
            if (chkInspection.Checked)
                total += PRICE_INSPECTION;
            if (chkMufflerReplace.Checked)
                total += PRICE_MUFFLER_REPLACE;
            if (chkTireRotation.Checked)
                total += PRICE_TIRE_ROTATION;

            return total;
        }

        // 計算工資
        private decimal CalculateLaborCost(decimal hours)
        {
            return hours * LABOR_RATE;
        }

        // 計算稅金（零件費用的 6%）
        private decimal CalculateTax(decimal partsCost)
        {
            return Decimal.Round(partsCost * TAX_RATE, 2);
        }

        // 清除按鈕：重設所有輸入與輸出（恢復預設）
        private void BtnClear_Click(object sender, EventArgs e)
        {
            // 取消勾選所有服務項目
            chkChangeOil.Checked = false;
            chkLubrication.Checked = false;
            chkRadiatorCleaning.Checked = false;
            chkTransmissionCleaning.Checked = false;
            chkInspection.Checked = false;
            chkMufflerReplace.Checked = false;
            chkTireRotation.Checked = false;

            // 清空輸入欄位
            txtPartsCost.Text = string.Empty;
            txtLaborHours.Text = string.Empty;

            // 清空輸出欄位
            txtServiceLaborTotal.Text = string.Empty;
            txtPartsCostOut.Text = string.Empty;
            txtTax.Text = string.Empty;
            txtTotalCost.Text = string.Empty;

            // 將焦點回到第一個輸入欄位
            txtPartsCost.Focus();
        }

        // 離開按鈕：觸發關閉（FormClosing 事件會處理儲存詢問）
        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 在表單關閉前詢問是否儲存明細為 UTF-8 文字檔
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 問使用者是否要儲存
            var result = MessageBox.Show("是否要儲存本次明細為 UTF-8 文字檔？\n選「取消」可停止關閉。", "儲存明細", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Cancel)
            {
                // 取消關閉
                e.Cancel = true;
                return;
            }
            else if (result == DialogResult.No)
            {
                // 不儲存，直接離開
                return;
            }
            else
            {
                // 使用者選 YES -> 開啟儲存檔案對話方塊
                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "文字檔 (*.txt)|*.txt|所有檔案 (*.*)|*.*";
                    sfd.DefaultExt = "txt";
                    sfd.AddExtension = true;
                    sfd.FileName = "維修明細.txt";

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            // 建構明細內容
                            string content = BuildDetailText();
                            // 寫入 UTF-8
                            File.WriteAllText(sfd.FileName, content, Encoding.UTF8);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("儲存檔案失敗：\n" + ex.Message, "儲存失敗", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            // 選擇是否要取消關閉（這裡我們不取消，讓使用者決定）
                        }
                    }
                    else
                    {
                        // 使用者在 SaveFileDialog 按取消：取消關閉
                        e.Cancel = true;
                        return;
                    }
                }
            }
        }

        // 建構要寫入檔案的明細文字（UTF-8）
        private string BuildDetailText()
        {
            // 讀取顯示欄位（若為空則顯示 0.00）
            string serviceLabor = string.IsNullOrWhiteSpace(txtServiceLaborTotal.Text) ? "0.00" : txtServiceLaborTotal.Text;
            string parts = string.IsNullOrWhiteSpace(txtPartsCostOut.Text) ? "0.00" : txtPartsCostOut.Text;
            string tax = string.IsNullOrWhiteSpace(txtTax.Text) ? "0.00" : txtTax.Text;
            string total = string.IsNullOrWhiteSpace(txtTotalCost.Text) ? "0.00" : txtTotalCost.Text;

            // 列出被勾選的服務項目
            var sb = new StringBuilder();
            sb.AppendLine("汽車維修明細");
            sb.AppendLine("----------------------------");
            sb.AppendLine("服務項目：");
            if (chkChangeOil.Checked) sb.AppendLine($"- 更換機油：{PRICE_CHANGE_OIL:0.00}");
            if (chkLubrication.Checked) sb.AppendLine($"- 潤滑保養：{PRICE_LUBRICATION:0.00}");
            if (chkRadiatorCleaning.Checked) sb.AppendLine($"- 水箱清洗：{PRICE_RADIATOR_CLEANING:0.00}");
            if (chkTransmissionCleaning.Checked) sb.AppendLine($"- 變速箱清洗：{PRICE_TRANSMISSION_CLEANING:0.00}");
            if (chkInspection.Checked) sb.AppendLine($"- 檢驗：{PRICE_INSPECTION:0.00}");
            if (chkMufflerReplace.Checked) sb.AppendLine($"- 更換消音器：{PRICE_MUFFLER_REPLACE:0.00}");
            if (chkTireRotation.Checked) sb.AppendLine($"- 輪胎換位：{PRICE_TIRE_ROTATION:0.00}");
            sb.AppendLine("----------------------------");
            sb.AppendLine($"工時（小時）： {txtLaborHours.Text}");
            sb.AppendLine($"服務與工資總額： {serviceLabor}");
            sb.AppendLine($"零件費用： {parts}");
            sb.AppendLine($"稅金： {tax}");
            sb.AppendLine($"總費用： {total}");
            sb.AppendLine($"列印時間： {DateTime.Now:G}");
            return sb.ToString();
        }
    }
}               