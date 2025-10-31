using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_test
{
    internal class TestButton : Button
    {
        
        //onの時の色.
        private Color  _onColor  = Color.Green;
        //offの時の色.
        private Color  _offColor = Color.Pink;
        //現在offかonかを判断.
        private bool _enable;

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

        public TestButton(Point position, Size size, string text)
        {
            Location = position;
            Size = size;
            Text = text;
            SetEnable(false);
            Click += ClickEvent;


        }

        private void ClickEvent(object sender, EventArgs e)
        {


            SetEnable(!_enable);
        }
    }


}

