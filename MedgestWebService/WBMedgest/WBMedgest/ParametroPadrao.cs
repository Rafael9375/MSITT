using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Xml;

namespace WBMedgest
{
    public class ParametroPadrao
    {
        public string url { get; set; }
        public string strConexao { get; set; }
        public SqlConnection con { get; set; }
        public SqlCommand command { get; set; }
        public string cm { get; set; }
        public string pm { get; set; }
        public string emp { get; set; }
    }
}