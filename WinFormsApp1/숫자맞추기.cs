using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WinFormsApp1
{
    public partial class 숫자맞추기 : Form
    {
        private int findNumber = 0;
        private int chance = 0;
        public 숫자맞추기()
        {
            InitializeComponent();
            HINT.TextChanged += Form3_TextChanged;
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            findNumber = rand.Next(1, 21);
            // 1 ~ 20 까지의 숫자를 지정함.

            chance = 10;
            display.Text = "맞출 숫자를 입력하세요.";
        }

        private void ButtonInput_Click(object sender, EventArgs e)
        {
            int inputNumber = Int32.Parse(textBox.Text);

            if (inputNumber == findNumber)
            {
                display.Text = "승리했습니다!!";
                HINT.Text = "HINT";
            }
            else
            {
                chance--;
                display.Text = "기회는 " + chance + "번 남았습니다.";
                if (inputNumber > findNumber)
                {
                    HINT.Text = "입력한 값이 정답보다 큽니다";
                }
                else
                {
                    HINT.Text = "입력한 값이 정답보다 작습니다.";
                }
            }

            if (chance <= 0)
            {
                display.Text = "실패했습니다!!";
                HINT.Text = "HINT";
            }
        }

        private void AdjustLabelPadding(Label label)
        {
            //// label의 전체 너비와 텍스트 너비 계산
            //int totalWIdth = label.Width;
            //int textWidth = TextRenderer.MeasureText(label.Text, label.Font).Width;

            //// 좌우 Padding 계산 (label 너비에서 텍스트 너비를 뺀 나머지를 양쪽에 나눔 )
            //int padding = (totalWIdth - textWidth) / 2;

            //// Padding 적용
            //label.Padding = new Padding(padding, 0, padding, 0);

            // 텍스트 너비 계산
            int textWidth = TextRenderer.MeasureText(label.Text, label.Font).Width;

            // Label 너비를 텍스트 너비로 설정
            label.Width = textWidth;

            // 폼 중앙에 Label 위치 설정
            label.Left = (this.ClientSize.Width - label.Width) / 2;
        }

        private void Form3_TextChanged(object? sender, EventArgs e)
        {
            AdjustLabelPadding(HINT);
        }
    }
}
