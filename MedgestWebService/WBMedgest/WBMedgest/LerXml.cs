using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Xml;

namespace WBMedgest
{
    public class LerXml : ParametroPadrao 
    {
        public XmlDocument xml { get; set; }


        public LerXml(string _strCon, string _strEmp)
        {
            this.strConexao = _strCon;
            this.con = new SqlConnection(this.strConexao);
            this.emp = _strEmp;
            
        }

        public void InserirDados(string _strUrl)
        {
            this.xml = new XmlDocument();
            this.url = _strUrl;
            this.xml.Load(_strUrl);
            var tipoEvento = this.xml.DocumentElement.Name;
            ExecutarInsert(tipoEvento);
        }

        public void GerarXmlAso(string local)
        {
            Aso aso = new Aso(this.con);
            aso.emp = this.emp;
            aso.url = this.url;
            aso.con = this.con;
            aso.GerarXmlTodos(local);
        }

        public void ExecutarInsert(string tipoEvento)
        {
            SqlCommand command = new SqlCommand();
            switch (tipoEvento)
            {
                case "funcionarios":
                    Funciona funcionarios = new Funciona();
                    funcionarios.emp = this.emp;
                    funcionarios.url = this.url;
                    funcionarios.con = this.con;
                    funcionarios.ExecutarComando();
                    break;
                case "ASOS":
                    Aso resultado = new Aso(this.con);
                    resultado.url = this.url;
                    resultado.emp = this.emp;
                    resultado.ExecutarComando();
                    break;
                case "CARGOS":
                    Cargo cargo = new Cargo();
                    cargo.url = this.url;
                    cargo.con = this.con;
                    cargo.emp = this.emp;
                    cargo.ExecutarComando();
                    break;
                case "SETORES":
                    Setor setor = new Setor();
                    setor.url = this.url;
                    setor.con = this.con;
                    setor.emp = this.emp;
                    setor.ExecutarComando();

                    break;
                default:
                    break;
            }
        }
    }
    
}