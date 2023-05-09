using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_WinForm
{
    public class MonHoc
    {
        public string MAMH { get; set; }
        public string TENMH { get; set; }
        public int STCLT { get; set; }
        public int STCTH { get; set; }

        public MonHoc(string mamh, string tenmh, int stclt, int stcth)
        {
            MAMH = mamh;
            TENMH = tenmh;
            STCLT = stclt;
            STCTH = stcth;
        }

    }
}
