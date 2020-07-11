using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace xuchengzhineng
{
    internal static class controlExtensions
    {
        internal static void InvokeIfNeed(this Control ctl, Action doit)
        {
            if (ctl.InvokeRequired)
            {
                ctl.BeginInvoke(doit);
            }
            else
            {
                doit();
            }
        }
    }
}
