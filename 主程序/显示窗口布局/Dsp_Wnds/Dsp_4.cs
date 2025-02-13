using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace dotNetLab
{
    namespace Framework
    {
        public partial class Dsp_4 : Dsp_Base
        {
            public Dsp_4()
            {
                InitializeComponent();
            }

            protected override void PrepareDspWnds(Control[] ctrl_ArrDspWnds)
            {

                this.AppendDspWnd(this.tableLayoutPanel1,
                     ctrl_ArrDspWnds[0], 0, 0);
                this.AppendDspWnd(this.tableLayoutPanel1,
                    ctrl_ArrDspWnds[1], 0, 1);
                this.AppendDspWnd(this.tableLayoutPanel1,
                    ctrl_ArrDspWnds[2], 1, 0);
                this.AppendDspWnd(this.tableLayoutPanel1,
                    ctrl_ArrDspWnds[3], 1, 1);
            }
            
        }

    }
}