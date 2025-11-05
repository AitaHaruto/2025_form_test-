using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_test
{
    public class TestButton : Button
    {
       //論理型をランダムに返すものを作成.
        private static Random rand = new Random();
        public bool BoolRandom;
       
        //onの時の色.
        private Color  _onColor  = Color.Green;
        //offの時の色.
        private Color  _offColor = Color.Pink;
        //現在offかonかを判断.
        private bool _enable;
        //座標の取得.
        //縦.
        private int _y;
        //横.
        private int _x;

       

        public void SetEnable(bool on)
        {
            _enable = on;
            if (on)
            {
                BackColor = _onColor;
            }
            else 
            {
                BackColor = _offColor;
            }
        }

        public void Toggle()
        {
            SetEnable(!_enable);
        }
        //Form1の参照.
        private Form1 _form1;
        public TestButton(Form1 form1,int x,int y,Point location, Size size, string text)
        {   
            //Form1の参照を保管.
            _form1 = form1;
            //座標を保管.
            _x = x;
            _y = y;
            BoolRandom = rand.Next(0, 2) == 0;
            Location = location;
            Size = size;
            Text = text;
            SetEnable(BoolRandom);
            Click += ClickEvent;
             


        }

        private void ClickEvent(object sender, EventArgs e)
        {


           // _form1.GetTextButton(_x , _y)?.Toggle();
           // _form1.GetTextButton(_x+1, _y)?.Toggle();
           // _form1.GetTextButton(_x-1, _y)?.Toggle();
           // _form1.GetTextButton(_x, _y+1)?.Toggle();
           // _form1.GetTextButton(_x, _y-1)?.Toggle();

            for (int i = 0; i < _toggleData.Length; i++)
            {
                var data = _toggleData[i];
                var button = _form1.GetTextButton(_x + data[0], _y + data[1]);
                if (button != null) 
                {
                    button.Toggle();
                }
            }
          
        }
        private int[][] _toggleData =
        {       new int []  {0,0},
                new int []  {1,0},
                new int []  {-1,0},
                new int []  {0,1},
                new int []  {0,-1},

                            

        };
    }


}

