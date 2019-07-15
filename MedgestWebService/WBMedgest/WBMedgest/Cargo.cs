using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;

namespace WBMedgest
{
    public class Cargo : ParametroPadrao
    {
        public void ExecutarComando()
        {
            InfraDados<Cargo> infra = new InfraDados<Cargo>(this.con);
            XmlTextReader reader = new XmlTextReader(this.url);
            reader.Read();
            infra.ConfiguraCmdTxt();
            infra.emp = this.emp;
            this.cm = infra.cm;
            this.pm = infra.pm;
            this.command = infra.command;
            var tagAtual = "";
            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element:
                        tagAtual = reader.Name.ToString();
                        break;
                    case XmlNodeType.Text:
                        switch (tagAtual)
                        {
                            case "NOME":
                                this.cm += "NOME";
                                this.pm += "@NOME";
                                command.Parameters.AddWithValue("@NOME", reader.Value.ToString());
                                break;
                            case "DS_DETALHADA":
                                this.cm += ", DS_DETALHADA";
                                this.pm += ", @DS_DETALHADA";
                                command.Parameters.AddWithValue("@DS_DETALHADA", reader.Value.ToString());
                                break;
                            case "FUNCAO":
                                this.cm += ", FUNCAO";
                                this.pm += ", @FUNCAO";
                                command.Parameters.AddWithValue("@FUNCAO", reader.Value.ToString());
                                break;
                            default:
                                break;
                        }
                        break;
                    case XmlNodeType.EndElement:
                        tagAtual = reader.Name.ToString();
                        switch (tagAtual)
                        {
                            case "CARGO":
                                infra.command = this.command;
                                infra.cm = this.cm;
                                infra.pm = this.pm;
                                infra.ExecInsert();
                                infra.ConfiguraCmdTxt();
                                this.cm = infra.cm;
                                this.pm = infra.pm;
                                this.command = infra.command;
                                break;
                            default:
                                break;
                        }
                        break;
                    default:
                        break;
                }
            }
        }
    }
}