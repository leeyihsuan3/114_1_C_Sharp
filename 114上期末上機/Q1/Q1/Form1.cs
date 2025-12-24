using System;
using System.Drawing;
using System.Windows.Forms;

namespace Q1
{
    public enum Choice
    {
        None = -1,              
        Rock = 0,
        Paper = 1,
        Scissor = 2
    }

    public partial class Form1 : Form
    {
        private Random rnd = new Random();
        private Choice compChoice = Choice.None;
        private Choice playerChoice = Choice.None;
        private int playerWins = 0;
        private int compWins = 0;

        public Form1()
        {
            InitializeComponent();

            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 初始化畫面：清空圖片與結果
            playerPictureBox.Image = null;
            computerPictureBox.Image = null;
            resultLabel.Text = "請選擇：石頭、布或剪刀";
            UpdateScoreLabels();
        }

        // 產生電腦的隨機選擇
        private Choice getCompChoice()
        {
            int v = rnd.Next(0, 3); // 0,1,2
            compChoice = (Choice)v;
            return compChoice;
        }

        // 主程式：當玩家按按鈕時呼叫
        private void PlayRound(Choice player)
        {
            playerChoice = player;
            getCompChoice();

            showPlayerImage();
            showComputerImage();

            showWinner();
        }

        // 根據玩家選擇顯示圖片
        private void showPlayerImage()
        {
            // 指定圖片（例：玩家出石頭）
            if (playerPictureBox.Image != null) { playerPictureBox.Image.Dispose(); }
            playerPictureBox.Image = new Bitmap(Properties.Resources.Rock);
        }

        // 根據電腦選擇顯示圖片
        private void showComputerImage()
        {
            // 電腦出剪刀
            if (computerPictureBox.Image != null) { computerPictureBox.Image.Dispose(); }
            computerPictureBox.Image = new Bitmap(Properties.Resources.Scissor);
        }

        // 判斷勝負、更新分數、顯示結果
        private void showWinner()
        {
            if (playerChoice == compChoice)
            {
                resultLabel.Text = "平手，不計分";
                return;
            }

            bool playerWinsRound = false;
            // 石頭(Rock)贏 剪刀(Scissor)
            // 剪刀(Scissor)贏 布(Paper)
            // 布(Paper)贏 石頭(Rock)
            if (playerChoice == Choice.Rock && compChoice == Choice.Scissor) playerWinsRound = true;
            else if (playerChoice == Choice.Scissor && compChoice == Choice.Paper) playerWinsRound = true;
            else if (playerChoice == Choice.Paper && compChoice == Choice.Rock) playerWinsRound = true;
            else playerWinsRound = false;

            if (playerWinsRound)
            {
                playerWins++;
                resultLabel.Text = "你贏了！";
            }
            else
            {
                compWins++;
                resultLabel.Text = "電腦贏了！";
            }

            UpdateScoreLabels();
        }

        private void UpdateScoreLabels()
        {
            playerLabel.Text = $"玩家：{playerWins}";
            computerLabel.Text = $"電腦：{compWins}";
        }

        // 建立代表出拳的影像（動態繪製）
        private Image CreateChoiceImage(Choice c, bool isPlayer, int width, int height)
        {
            Bitmap bmp = new Bitmap(Math.Max(1, width), Math.Max(1, height));
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g.Clear(Color.White);

                // 繪製邊框與標題
                string title = isPlayer ? "玩家" : "電腦";
                using (Font f = new Font("Segoe UI", 10))
                using (Brush tb = Brushes.Black)
                {
                    g.DrawString(title, f, tb, 6, 6);
                }

                // 主要繪圖區
                Rectangle area = new Rectangle(10, 30, bmp.Width - 20, bmp.Height - 40);

                switch (c)
                {
                    case Choice.Rock:
                        // 石頭：灰色圓形
                        using (Brush b = new SolidBrush(Color.FromArgb(160, 160, 160)))
                        {
                            int pad = Math.Min(area.Width, area.Height) / 6;
                            Rectangle r = new Rectangle(area.X + pad, area.Y + pad, area.Width - pad * 2, area.Height - pad * 2);
                            g.FillEllipse(b, r);
                            using (Pen p = new Pen(Color.DimGray, 3)) g.DrawEllipse(p, r);
                        }
                        break;
                    case Choice.Paper:
                        // 布：白色矩形 + 紋理線
                        using (Brush b = new SolidBrush(Color.FromArgb(250, 250, 240)))
                        {
                            Rectangle r = new Rectangle(area.X + 10, area.Y + 10, area.Width - 20, area.Height - 20);
                            g.FillRectangle(b, r);
                            using (Pen p = new Pen(Color.SlateGray, 2)) g.DrawRectangle(p, r);
                            // 細線表示紙張紋理
                            using (Pen lp = new Pen(Color.LightGray, 1))
                            {
                                for (int y = r.Top + 6; y < r.Bottom; y += 8)
                                    g.DrawLine(lp, r.Left + 4, y, r.Right - 4, y);
                            }
                        }
                        break;
                    case Choice.Scissor:
                        // 剪刀：兩片交叉線 + 把手圓點
                        using (Pen p = new Pen(Color.SteelBlue, 6))
                        {
                            Point center = new Point(area.Left + area.Width / 2, area.Top + area.Height / 2);
                            p.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                            p.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                            g.DrawLine(p, center.X - 40, center.Y - 30, center.X + 40, center.Y + 30);
                            g.DrawLine(p, center.X - 40, center.Y + 30, center.X + 40, center.Y - 30);
                        }
                        using (Brush b = new SolidBrush(Color.SteelBlue))
                        {
                            g.FillEllipse(b, area.Right - 30, area.Bottom - 30, 16, 16);
                            g.FillEllipse(b, area.Left + 10, area.Bottom - 30, 16, 16);
                        }
                        break;
                    default:
                        // None: 顯示提示
                        using (Font f = new Font("Segoe UI", 10, FontStyle.Italic))
                        using (Brush tb = Brushes.Gray)
                        {
                            g.DrawString("尚未出拳", f, tb, area.X + 8, area.Y + area.Height / 2 - 8);
                        }
                        break;
                }
            }

            return bmp;
        }

        private Image GetResourceImageForChoice(Choice c, bool isPlayer)
        {
            string name = c switch
            {
                Choice.Rock => isPlayer ? "Rock_Player" : "Rock_Computer",
                Choice.Paper => isPlayer ? "Paper_Player" : "Paper_Computer",
                Choice.Scissor => isPlayer ? "Scissor_Player" : "Scissor_Computer",
                _ => null
            };

            if (string.IsNullOrEmpty(name)) return null;
            var obj = Properties.Resources.ResourceManager.GetObject(name);
            return obj as Image != null ? new Bitmap((Image)obj) : null;
        }

        // 事件處理：玩家選石頭
        private void stoneButton_Click(object sender, EventArgs e)
        {
            PlayRound(Choice.Rock);
        }

        // 玩家選布
        private void paperButton_Click(object sender, EventArgs e)
        {
            PlayRound(Choice.Paper);
        }

        // 玩家選剪刀
        private void scissorButton_Click(object sender, EventArgs e)
        {
            PlayRound(Choice.Scissor);
        }

        // 結束遊戲並顯示統計
        private void exitButton_Click(object sender, EventArgs e)
        {
            string msg = $"遊戲結束\n\n玩家勝場：{playerWins}\n電腦勝場：{compWins}\n\n按確定關閉程式。";
            MessageBox.Show(msg, "遊戲統計", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
