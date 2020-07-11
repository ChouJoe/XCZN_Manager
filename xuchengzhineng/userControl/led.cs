using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace xuchengzhineng.userControl
{
    public partial class led : UserControl
    {
        public led()
        {
            InitializeComponent();
        }
        private Image[] _imagelist = null ;
        private bool _isWorking = false;
        private int _currentIndex = 0;
        public bool IsWorking
        {
            get
            {
                return this._isWorking;
            }
            set
            {
                this._isWorking = value;
            }
        }
        public void setImageList(Image[] imagelist)
        {
            this._imagelist = imagelist;

        }
        public void RegTimer(Timer timer)
        {
            timer.Tick += new EventHandler(timer_tick);
        }
        public Image initImage
        {
            get
            {
                return this.ledbox.Image;
            }
            set
            {
                ledbox.Image = value;
            }
        }
        private void timer_tick(object sender, EventArgs e)
        {
            if (this._isWorking)
            {
                this._currentIndex = (this._currentIndex == 0 ? 1 : 0);
                this.ledbox.Image = this._imagelist[this._currentIndex];
            }
            else
            {
                this._currentIndex = 0;
                this.ledbox.Image = this._imagelist[this._currentIndex];
            }
        }
    }
}
