using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poiskfile
{
    internal class Meteorecord
    {
        private int station;
        private string date;
        private string wnd1;
        private string wnd2;
        private string wnd3;
        private string wnd4;
        private string wnd5;
        private string tmp1;
        private string tmp2;
        private string dew1;
        private string dew2;
        private string aa11;
        private string aa12;
        private string aa13;
        private string aa14;
       

        public Meteorecord(int station, string date, string wnd1, string wnd2, string wnd3, string wnd4, string wnd5, string tmp1, string tmp2, string dew1, string dew2,
            string aa11, string aa12, string aa13, string aa14)
        {
            this.station = station;
            this.date = date;
            this.wnd1 = wnd1;
            this.wnd2 = wnd2;
            this.wnd3 = wnd3;
            this.wnd4 = wnd4;
            this.wnd5 = wnd5;
            this.tmp1 = tmp1;
            this.tmp2 = tmp2;
            this.dew1 = dew1;
            this.dew2 = dew2;
            this.aa11 = aa11;
            this.aa12 = aa12;
            this.aa13 = aa13;
            this.aa14 = aa14;
            
        }
        public int Station { get { return station; } }
        public string Dates { get { return date; } }
        public string Wnd1 { get { return wnd1; } }
        public string Wnd2 { get { return wnd2; } }
        public string Wnd3 { get { return wnd3; } }
        public string Wnd4 { get { return wnd4; } }
        public string Wnd5 { get { return wnd5; } }
        public string Dew1 { get { return dew1; } }
        public string Dew2 { get { return dew2; } }
        public string Aa11 { get { return aa11; } }
        public string Aa12 { get { return aa12; } }
        public string Aa13 { get { return aa13; } }
        public string Aa14 { get { return aa14; } }
        public string Tmp1 { get { return tmp1; } }
        public string Tmp2 { get { return tmp2; } }

        
    }   
    
}
