using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_test
{
    public partial class Form1 : Form
    { 
       
        public Form1()
        {
            int cnt = 0;
            InitializeComponent();
            for (int i = 1; i <= 4; i++)
                
            {
                
                for (int j = 1; j <= 6; j++)
                {
                    cnt = cnt + 1;
                    TestButton testButton1 = new TestButton();


                    //位置設定.
                    testButton1.Location = new Point(50 * j, 50*i);

                    //大きさ設定.
                    testButton1.Size = new Size(50, 50);
                    //イベントを設定.
                    testButton1.MouseHover += button1_Click;
                    //テキストを設定.
                    testButton1.Text = $"{cnt}";
                    testButton1.Tag = cnt;

                    testButton1.BackColor = new Color();

                    Controls.Add(testButton1);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int num = (int)btn.Tag;
            MessageBox.Show($"これは{num}個目のボタンです");
        }
    }
}
