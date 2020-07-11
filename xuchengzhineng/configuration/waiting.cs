using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
namespace xuchengzhineng.configuration
{
    public partial class Waiting : Form
    {
        public Waiting()
        {
            InitializeComponent();
        }
        public event DrawControlHandler drawcontrolHandler;
        private void waiting_Shown(object sender, EventArgs e)
        {
            //BackgroundWorker worker = new BackgroundWorker();
            //worker.DoWork += (s, h) =>
            //{
            //    this.InvokeIfNeed(() =>
            //    {

            //        drawcontrolHandler();

            //        this.Close();
            //    });


            //};
            //worker.RunWorkerAsync();

            this.InvokeIfNeed(() =>
            {

                drawcontrolHandler();

                this.Close();
            });

        }
    }
}
