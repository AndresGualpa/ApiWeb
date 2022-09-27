using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        public string usr_cod { get; set; }
        public string usr_nom { get; set; }
        public string usr_est { get; set; }
        public string usr_treg { get; set; }
        public string usr_clv { get; set; }
        public string usr_tacc { get; set; }
        public string grp_cod { get; set; }
        public string usr_aud { get; set; }
        public DateTime usr_fec_ult { get; set; }
        public int usr_vig_clv { get; set; }
        public string usr_dom { get; set; }
    }
}
