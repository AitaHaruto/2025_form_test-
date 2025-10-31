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

        public Form1()
        {
            
            InitializeComponent();
            for (int i = 1; i <= BOARD_SIZE_X; i++)
                
            {
                
                for (int j = 1; j <= BOARD_SIZE_Y; j++)
                {
                    
                    TestButton testButton1 = new TestButton(new Point(BUTTON_SIZE_X*j,BUTTON_SIZE_Y*i),
                        new Size(BUTTON_SIZE_X, BUTTON_SIZE_Y  ),"");


                    Controls.Add(testButton1);
                }
            }

        }


    }
}
