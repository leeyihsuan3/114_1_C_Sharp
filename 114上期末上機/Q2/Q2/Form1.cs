using System;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Q2
{
    // 主表單：負責 UI 事件綁定與所有計算邏輯
    // 注意：此檔配合已修改的 Form1.Designer.cs（控制項名稱保持不變）
    public partial class Form1 : Form
    {
        // -------------------------
        // 常數：各項服務價格、稅率、工時費率
        // -------------------------
        private const decimal PRICE_CHANGE_OIL = 780m;
        private const decimal PRICE_LUBRICATION = 540m;
        private const decimal PRICE_RADIATOR_CLEANING = 900m;
        private const decimal PRICE_TRANSMISSION_CLEANING = 2400m;
        private const decimal PRICE_INSPECTION = 450m;
        private const decimal PRICE_MUFFLER_REPLACE = 3000m;
        private const decimal PRICE_TIRE_ROTATION = 600m;

        private const decimal LABOR_RATE_PER_HOUR = 600m; // 工時費率 NT$600/小時
        private const decimal PARTS_TAX_RATE = 0.06m;     // 零件稅率 6%

        // 本地化貨幣格式（使用繁體中文台灣）
        private readonly CultureInfo taiwanCulture = CultureInfo.GetCultureInfo("zh-TW");

        public Form1()
        {
            InitializeComponent();

            // 綁定按鈕事件（設計器未指定按鈕事件時在此綁定）
            this.button1.Click += calculateButton_Click; // 計算
            this.button3.Click += clearButton_Click;     // 清除
            this.button2.Click += exitButton_Click;      // 離開

            // 表單關閉時詢問是否儲存（會呼叫儲存方法）
            this.FormClosing += Form1_FormClosing;

            // 設定預設顯示格式（空白顯示）
            ClearFees();
        }

        // -------------------------
        // 計算方法：依照建議的方法結構拆分
        // -------------------------

        // 計算機油與潤滑服務費用（更換機油、潤滑保養）
        private decimal OilLubeCharges()
        {
            decimal total = 0m;
            if (checkBox3.Checked) total += PRICE_CHANGE_OIL;     // 更換機油
            if (checkBox2.Checked) total += PRICE_LUBRICATION;    // 潤滑保養
            return total;
        }

        // 計算清洗服務費用（水箱清洗、變速箱清洗）
        private decimal FlushCharges()
        {
            decimal total = 0m;
            if (checkBox1.Checked) total += PRICE_RADIATOR_CLEANING;    // 水箱清洗
            if (checkBox4.Checked) total += PRICE_TRANSMISSION_CLEANING; // 變速箱清洗
            return total;
        }

        // 計算其他維修服務（檢驗、更換消音器、輪胎換位）
        private decimal MiscCharges()
        {
            decimal total = 0m;
            if (checkBox5.Checked) total += PRICE_INSPECTION;       // 檢驗
            if (checkBox6.Checked) total += PRICE_MUFFLER_REPLACE;  // 更換消音器
            if (checkBox7.Checked) total += PRICE_TIRE_ROTATION;    // 輪胎換位
            return total;
        }

        // 計算零件與工時費用（工時費 = 小時 * 每小時費率）
        // 參數 labourHours 已由呼叫端解析與驗證
        private decimal OtherCharges(decimal labourHours)
        {
            return labourHours * LABOR_RATE_PER_HOUR;
        }

        // 計算稅金（僅對零件收 6%）
        private decimal TaxCharges(decimal partsCost)
        {
            // 保留兩位小數（四捨五入）
            return Decimal.Round(partsCost * PARTS_TAX_RATE, 2, MidpointRounding.AwayFromZero);
        }

        // 計算總費用並回傳所有明細（服務與工資總額、稅金、總費用）
        private (decimal serviceAndLaborTotal, decimal partsCost, decimal tax, decimal grandTotal) TotalCharges(decimal partsInput, decimal labourHours)
        {
            // 服務總額 = 各服務項目之和
            decimal servicesTotal = OilLubeCharges() + FlushCharges() + MiscCharges();

            // 工資（其他費用）
            decimal laborCost = OtherCharges(labourHours);

            // 服務與工資總額
            decimal serviceAndLaborTotal = servicesTotal + laborCost;

            // 零件費用（由使用者輸入）
            decimal partsCost = partsInput;

            // 稅金（零件）
            decimal tax = TaxCharges(partsCost);

            // 總費用
            decimal grandTotal = serviceAndLaborTotal + partsCost + tax;

            return (serviceAndLaborTotal, partsCost, tax, grandTotal);
        }

        // -------------------------
        // 事件處理：按鈕與表單關閉
        // -------------------------

        // 計算按鈕事件：解析輸入、計算、更新顯示
        private void calculateButton_Click(object sender, EventArgs e)
        {
            // 解析並驗證使用者輸入（零件費用與工時）
            if (!TryParseInputs(out decimal partsCost, out decimal labourHours))
            {
                // 驗證失敗時已顯示訊息
                return;
            }

            // 計算所有費用
            var (serviceAndLaborTotal, parts, tax, grandTotal) = TotalCharges(partsCost, labourHours);

            // 更新 UI（使用台灣貨幣格式顯示）
            label3.Text = serviceAndLaborTotal.ToString("C2", taiwanCulture);
            label4.Text = parts.ToString("C2", taiwanCulture);
            label6.Text = tax.ToString("C2", taiwanCulture);
            label5.Text = grandTotal.ToString("C2", taiwanCulture);
        }

        // 清除按鈕事件：重設所有欄位與選項
        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearOilLube();
            ClearFlushes();
            ClearMisc();
            ClearOther();
            ClearFees();
        }

        // 離開按鈕：關閉表單（FormClosing 事件會詢問是否儲存）
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 表單關閉事件：在離開前詢問是否儲存明細（Yes/No/Cancel）
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 如果所有欄位都沒有內容，直接關閉（不詢問）
            bool anyInput = checkBox1.Checked || checkBox2.Checked || checkBox3.Checked ||
                            checkBox4.Checked || checkBox5.Checked || checkBox6.Checked || checkBox7.Checked ||
                            !string.IsNullOrWhiteSpace(textBox1.Text) || !string.IsNullOrWhiteSpace(textBox2.Text) ||
                            !string.IsNullOrWhiteSpace(label3.Text) || !string.IsNullOrWhiteSpace(label4.Text) ||
                            !string.IsNullOrWhiteSpace(label5.Text) || !string.IsNullOrWhiteSpace(label6.Text);

            if (!anyInput) return;

            var result = MessageBox.Show("是否要儲存本次維修明細為 UTF-8 文字檔？\n選擇「取消」可中止關閉。", "儲存明細", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Cancel)
            {
                // 取消關閉
                e.Cancel = true;
                return;
            }
            else if (result == DialogResult.Yes)
            {
                // 儲存明細
                bool saved = SaveServiceDetailsToFile();
                // 若使用者放棄儲存（例如在儲存對話框按取消），則取消關閉
                if (!saved)
                {
                    e.Cancel = true;
                    return;
                }
            }
            // DialogResult.No -> 不儲存，直接關閉
        }

        // -------------------------
        // 輔助方法：解析與清除
        // -------------------------

        // 安全解析使用者輸入（零件費用、工時）
        // 回傳 bool 表示解析是否成功；失敗時顯示錯誤訊息
        private bool TryParseInputs(out decimal partsCost, out decimal labourHours)
        {
            partsCost = 0m;
            labourHours = 0m;

            // 先處理零件費用（允許空白視為 0）
            string partsText = textBox1.Text?.Trim();
            if (string.IsNullOrEmpty(partsText))
            {
                partsCost = 0m;
            }
            else
            {
                if (!decimal.TryParse(partsText, NumberStyles.Number, taiwanCulture, out partsCost) || partsCost < 0m)
                {
                    MessageBox.Show("請輸入正確的零件費用（不可為負數）。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Focus();
                    return false;
                }
            }

            // 處理工時（空白視為 0）
            string labourText = textBox2.Text?.Trim();
            if (string.IsNullOrEmpty(labourText))
            {
                labourHours = 0m;
            }
            else
            {
                if (!decimal.TryParse(labourText, NumberStyles.Number, taiwanCulture, out labourHours) || labourHours < 0m)
                {
                    MessageBox.Show("請輸入正確的工時（小時），不可為負數。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox2.Focus();
                    return false;
                }
            }

            return true;
        }

        // 清除：機油與潤滑選項
        private void ClearOilLube()
        {
            checkBox3.Checked = false; // 更換機油
            checkBox2.Checked = false; // 潤滑保養
        }

        // 清除：清洗服務選項
        private void ClearFlushes()
        {
            checkBox1.Checked = false; // 水箱清洗
            checkBox4.Checked = false; // 變速箱清洗
        }

        // 清除：其他服務選項
        private void ClearMisc()
        {
            checkBox5.Checked = false; // 檢驗
            checkBox6.Checked = false; // 更換消音器
            checkBox7.Checked = false; // 輪胎換位
        }

        // 清除：零件與工時輸入
        private void ClearOther()
        {
            textBox1.Text = string.Empty; // 零件費用
            textBox2.Text = string.Empty; // 工時
        }

        // 清除：費用顯示
        private void ClearFees()
        {
            label3.Text = string.Empty; // 服務與工資總額
            label4.Text = string.Empty; // 零件費用
            label6.Text = string.Empty; // 稅金
            label5.Text = string.Empty; // 總費用
        }

        // -------------------------
        // 檔案處理：儲存維修明細至文字檔（UTF-8）
        // 回傳 bool：true 表示已成功儲存或使用者完成儲存；false 表示使用者取消或儲存失敗
        // -------------------------
        private bool SaveServiceDetailsToFile()
        {
            // 先嘗試解析當前輸入（若格式錯誤則提示）
            if (!TryParseInputs(out decimal partsCost, out decimal labourHours))
            {
                return false;
            }

            var (serviceAndLaborTotal, parts, tax, grandTotal) = TotalCharges(partsCost, labourHours);

            // 建構報表文字（繁體中文、條列清晰）
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("汽車維修明細");
            sb.AppendLine("========================================");
            sb.AppendLine($"列印時間： {DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")}");
            sb.AppendLine();
            sb.AppendLine("服務項目：");

            // 列出所有被勾選之服務項目與金額
            if (checkBox3.Checked) sb.AppendLine($" - 更換機油： {PRICE_CHANGE_OIL.ToString("C2", taiwanCulture)}");
            if (checkBox2.Checked) sb.AppendLine($" - 潤滑保養： {PRICE_LUBRICATION.ToString("C2", taiwanCulture)}");
            if (checkBox1.Checked) sb.AppendLine($" - 水箱清洗： {PRICE_RADIATOR_CLEANING.ToString("C2", taiwanCulture)}");
            if (checkBox4.Checked) sb.AppendLine($" - 變速箱清洗： {PRICE_TRANSMISSION_CLEANING.ToString("C2", taiwanCulture)}");
            if (checkBox5.Checked) sb.AppendLine($" - 檢驗： {PRICE_INSPECTION.ToString("C2", taiwanCulture)}");
            if (checkBox6.Checked) sb.AppendLine($" - 更換消音器： {PRICE_MUFFLER_REPLACE.ToString("C2", taiwanCulture)}");
            if (checkBox7.Checked) sb.AppendLine($" - 輪胎換位： {PRICE_TIRE_ROTATION.ToString("C2", taiwanCulture)}");

            sb.AppendLine();
            sb.AppendLine("費用明細：");
            sb.AppendLine($" - 服務與工資總額： {serviceAndLaborTotal.ToString("C2", taiwanCulture)}");
            sb.AppendLine($" - 零件費用： {parts.ToString("C2", taiwanCulture)}");
            sb.AppendLine($" - 零件稅（6%）： {tax.ToString("C2", taiwanCulture)}");
            sb.AppendLine($" - 總費用： {grandTotal.ToString("C2", taiwanCulture)}");
            sb.AppendLine("========================================");

            // 使用 SaveFileDialog 取得使用者欲儲存之路徑
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "文字檔 (*.txt)|*.txt|所有檔案 (*.*)|*.*";
                sfd.DefaultExt = "txt";
                sfd.FileName = $"維修明細_{DateTime.Now.ToString("yyyyMMdd_HHmmss")}.txt";

                if (sfd.ShowDialog() != DialogResult.OK)
                {
                    // 使用者取消儲存
                    return false;
                }

                // 使用 UTF-8 寫入（確保中文正常）
                try
                {
                    using (StreamWriter writer = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
                    {
                        writer.Write(sb.ToString());
                    }
                    MessageBox.Show("已成功儲存維修明細。", "儲存成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("儲存失敗：" + ex.Message, "儲存失敗", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        // -------------------------
        // Designer 檔案綁定的 Checkbox 事件（Designer 可能有綁定，實作為空或簡單行為以避免編譯錯誤）
        // 此處將在勾選變更時自動重新計算以即時更新費用顯示（若使用者希望即時預覽）
        // -------------------------
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // 嘗試重新計算，但不強迫解析錯誤（僅在能解析時更新）
            if (TryParseInputs(out decimal parts, out decimal hours))
            {
                var (serviceAndLaborTotal, p, tax, grand) = TotalCharges(parts, hours);
                label3.Text = serviceAndLaborTotal.ToString("C2", taiwanCulture);
                label4.Text = p.ToString("C2", taiwanCulture);
                label6.Text = tax.ToString("C2", taiwanCulture);
                label5.Text = grand.ToString("C2", taiwanCulture);
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            // 同上：若能解析輸入則更新顯示
            if (TryParseInputs(out decimal parts, out decimal hours))
            {
                var (serviceAndLaborTotal, p, tax, grand) = TotalCharges(parts, hours);
                label3.Text = serviceAndLaborTotal.ToString("C2", taiwanCulture);
                label4.Text = p.ToString("C2", taiwanCulture);
                label6.Text = tax.ToString("C2", taiwanCulture);
                label5.Text = grand.ToString("C2", taiwanCulture);
            }
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }
    }
}
