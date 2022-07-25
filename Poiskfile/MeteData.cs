using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Poiskfile
{
    public class MeteoData {

        public int Id { get; set; }
        public int station { get; set; }
        public string date { get; set; }
        public int wnd1 { get; set; }
        public int wnd2 { get; set; }
        public string wnd3 { get; set; }
        public int wnd4 { get; set; }
        public int wnd5 { get; set; }
        public int tmp1 { get; set; }
        public string tmp2 { get; set; }
        public int dew1 { get; set; }
        public string dew2 { get; set; }
        public string aa11 { get; set; }
        public string aa12 { get; set; }
        public string aa13 { get; set; }
        public string aa14 { get; set; }
    }

}
