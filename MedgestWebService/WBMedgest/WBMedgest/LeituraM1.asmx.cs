using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WBMedgest
{
    /// <summary>
    /// Summary description for LeituraM1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class LeituraM1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string ExecLeituraXml(string strCon, string strUrl, string strEmp)
        {
            LerXml executarLeitura = new LerXml(strCon, strEmp);
            executarLeitura.InserirDados(strUrl);
            return "Leitura concluída.";
        }

        [WebMethod]
        public string ExportarASO_Visio(string strCon, string strEmp, string strLocal)
        {
            LerXml executarLeitura = new LerXml(strCon, strEmp);
            executarLeitura.GerarXmlAso(strLocal);
            return "Xml Gerado.";
        }


    }
}
