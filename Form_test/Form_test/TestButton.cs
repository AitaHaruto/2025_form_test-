using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_test
{
    public class TestButton : Button
    {
        
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
        //Form1の参照.
        private Form1 _form1;
        public TestButton(Form1 form1,int x,int y,Point position, Size size, string text)
        {   
            //Form1の参照を保管.
            _form1 = form1;
            //座標を保管.
            _x = x;
            _y = y;
            
            Location = position;
            Size = size;
            Text = text;
            SetEnable(false);
            Click += ClickEvent;


        }

        private void ClickEvent(object sender, EventArgs e)
        {

            
            _form1.GetTextButton(_x, _y).SetEnable(!_enable);
            _form1.GetTextButton(_x+1, _y).SetEnable(!_enable);



        }
    }


}

