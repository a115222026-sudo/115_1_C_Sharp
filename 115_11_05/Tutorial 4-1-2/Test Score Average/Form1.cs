using System;
using System.Windows.Forms;

namespace Test_Score_Average
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            const double PASSING_SCORE = 60.0;
            double test1;
            double test2;
            double test3;
            double average;

            try
            {
                // 取得三次測驗成績。
                test1 = double.Parse(test1TextBox.Text);
                test2 = double.Parse(test2TextBox.Text);
                test3 = double.Parse(test3TextBox.Text);

                // 計算三次測驗成績的平均值。
                average = (test1 + test2 + test3) / 3.0;

                // 顯示平均成績。
                averageLabel.Text = average.ToString("n1");

                // 判斷是否及格。
                if (average >= PASSING_SCORE)
                {
                    MessageBox.Show("恭喜你及格！");
                }
                else
                {
                    MessageBox.Show("很可惜你沒有及格。");
                }
            }
            catch (FormatException)             
            {
                MessageBox.Show("請在三個成績欄位中輸入有效的數值。");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清除三個成績輸入欄位及平均成績。
            test1TextBox.Text = "";
            test2TextBox.Text = "";
            test3TextBox.Text = "";
            averageLabel.Text = "";

            // 將焦點移回第一個成績輸入欄位。
            test1TextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單。
            Close();
        }
    }
}
