using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;

namespace WBMedgest
{
    public class Setor : ParametroPadrao
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
                            case "DESCRICAO":
                                this.cm += ", DESCRICAO";
                                this.pm += ", @DESCRICAO";
                                command.Parameters.AddWithValue("@DESCRICAO", reader.Value.ToString());
                                break;
                            default:
                                break;
                        }
                        break;
                    case XmlNodeType.EndElement:
                        tagAtual = reader.Name.ToString();
                        switch (tagAtual)
                        {
                            case "SETOR":
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