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
        //constをつけると初期化時にのみ値の変更が可能になる.
        const int BUTTON_SIZE_X = 100;
        const int BUTTON_SIZE_Y = 100;

        const int BOARD_SIZE_X = 3;
        const int BOARD_SIZE_Y = 3;

        public TestButton[,] _buttonArray;

       

        public Form1()
        {

            InitializeComponent();
           
                //buttonArray　の初期化.
                _buttonArray = new TestButton[BOARD_SIZE_Y, BOARD_SIZE_X];
            for (int i = 0; i < BOARD_SIZE_X; i++)

            {

                for (int j = 0; j < BOARD_SIZE_Y; j++)
                {

                    TestButton testButton1 = new TestButton(this,i,j,
                        new Point(BUTTON_SIZE_X * j, BUTTON_SIZE_Y * i),
                        new Size(BUTTON_SIZE_X, BUTTON_SIZE_Y), "");
                    _buttonArray[j, i] = testButton1;


                    Controls.Add(testButton1);
                }
                //GetTextButton(0, 0).SetEnable(true);
            }
            //_buttonArray[2, 2].SetEnable(true);
        }
        public TestButton GetTextButton(int x, int y)
        {
            if (x < 0 || x >= BOARD_SIZE_X) return null;
            if (y < 0 || y >= BOARD_SIZE_X) return null;


            return _buttonArray[y, x];
        }
        private void ClickEvent(object sender, EventArgs e) 
        {
            
        }

    }
}
