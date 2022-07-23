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
        private int wnd1;
        private int wnd2;
        private string wnd3;
        private int wnd4;
        private int wnd5;
        private int tmp1;
        private string tmp2;
        private int dew1;
        private string dew2;
        private string aa11;
        private string aa12;
        private string aa13;
        private string aa14;
       

        public Meteorecord(int station, string date, int wnd1,int wnd2, string wnd3, int wnd4, int wnd5, int tmp1, string tmp2, int dew1, string dew2,
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
        public int Wnd1 { get { return wnd1; } }
        public int Wnd2 { get { return wnd2; } }
        public string Wnd3 { get { return wnd3; } }
        public int Wnd4 { get { return wnd4; } }
        public int Wnd5 { get { return wnd5; } }
        public int Dew1 { get { return dew1; } }
        public string Dew2 { get { return dew2; } }
        public string Aa11 { get { return aa11; } }
        public string Aa12 { get { return aa12; } }
        public string Aa13 { get { return aa13; } }
        public string Aa14 { get { return aa14; } }
        public int Tmp1 { get { return tmp1; } }
        public string Tmp2 { get { return tmp2; } }

        
    }   
    
}
