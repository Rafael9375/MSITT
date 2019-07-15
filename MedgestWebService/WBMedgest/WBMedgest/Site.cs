using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;

namespace WBMedgest
{
    public class Site : ParametroPadrao
    {
        internal void ExecutarComando()
        {
            InfraDados<Funciona> infra = new InfraDados<Funciona>(this.con);
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
                        if (tagAtual != "sites" &&
                            tagAtual != "site" &&
                            this.cm.Substring(this.cm.Length - 1, 1) != "(")
                        {
                            this.cm += ", ";
                            this.pm += ", ";
                        }
                        break;
                    case XmlNodeType.Text:
                        switch (tagAtual)
                        {
                            case "NOME":
                                this.cm += "NOME";
                                this.pm += "@NOME";
                                command.Parameters.AddWithValue("@NOME", reader.Value.ToString());
                                break;
                            case "GRISC":
                                this.cm += "GRISC";
                                this.pm += "@GRISC";
                                command.Parameters.AddWithValue("@GRISC", reader.Value.ToString());
                                break;
                            case "CID":
                                this.cm += "CID";
                                this.pm += "@CID";
                                command.Parameters.AddWithValue("@CID", reader.Value.ToString());
                                break;
                            case "UF":
                                this.cm += "UF";
                                this.pm += "@UF";
                                command.Parameters.AddWithValue("@UF", reader.Value.ToString());
                                break;
                            case "CEP":
                                this.cm += "CEP";
                                this.pm += "@CEP";
                                command.Parameters.AddWithValue("@CEP", reader.Value.ToString());
                                break;
                            case "CNPJ":
                                this.cm += "CNPJ";
                                this.pm += "@CNPJ";
                                command.Parameters.AddWithValue("@CNPJ", reader.Value.ToString());
                                break;
                            case "INSCR":
                                this.cm += "INSCR";
                                this.pm += "@INSCR";
                                command.Parameters.AddWithValue("@INSCR", reader.Value.ToString());
                                break;
                            case "TEL":
                                this.cm += "TEL";
                                this.pm += "@TEL";
                                command.Parameters.AddWithValue("@TEL", reader.Value.ToString());
                                break;
                            case "CONTATO":
                                this.cm += "CONTATO";
                                this.pm += "@CONTATO";
                                command.Parameters.AddWithValue("@CONTATO", reader.Value.ToString());
                                break;
                            case "TEL2":
                                this.cm += "TEL2";
                                this.pm += "@TEL2";
                                command.Parameters.AddWithValue("@TEL2", reader.Value.ToString());
                                break;
                            case "TEL3":
                                this.cm += "TEL3";
                                this.pm += "@TEL3";
                                command.Parameters.AddWithValue("@TEL3", reader.Value.ToString());
                                break;
                            case "TEL4":
                                this.cm += "TEL4";
                                this.pm += "@TEL4";
                                command.Parameters.AddWithValue("@TEL4", reader.Value.ToString());
                                break;
                            case "CONTATO2":
                                this.cm += "CONTATO2";
                                this.pm += "@CONTATO2";
                                command.Parameters.AddWithValue("@CONTATO2", reader.Value.ToString());
                                break;
                            case "CONTATO3":
                                this.cm += "CONTATO3";
                                this.pm += "@CONTATO3";
                                command.Parameters.AddWithValue("@CONTATO3", reader.Value.ToString());
                                break;
                            case "CONTATO4":
                                this.cm += "CONTATO4";
                                this.pm += "@CONTATO4";
                                command.Parameters.AddWithValue("@CONTATO4", reader.Value.ToString());
                                break;
                            case "MAIL":
                                this.cm += "MAIL";
                                this.pm += "@MAIL";
                                command.Parameters.AddWithValue("@MAIL", reader.Value.ToString());
                                break;
                            case "MAIL2":
                                this.cm += "MAIL2";
                                this.pm += "@MAIL2";
                                command.Parameters.AddWithValue("@MAIL2", reader.Value.ToString());
                                break;
                            case "MAIL3":
                                this.cm += "MAIL3";
                                this.pm += "@MAIL3";
                                command.Parameters.AddWithValue("@MAIL3", reader.Value.ToString());
                                break;
                            case "MAIL4":
                                this.cm += "MAIL4";
                                this.pm += "@MAIL4";
                                command.Parameters.AddWithValue("@MAIL4", reader.Value.ToString());
                                break;
                            case "ENDE":
                                this.cm += "ENDE";
                                this.pm += "@ENDE";
                                command.Parameters.AddWithValue("@ENDE", reader.Value.ToString());
                                break;
                            case "BAIRRO":
                                this.cm += "BAIRRO";
                                this.pm += "@BAIRRO";
                                command.Parameters.AddWithValue("@BAIRRO", reader.Value.ToString());
                                break;
                            case "DT_CONTRATO":
                                this.cm += "DT_CONTRATO";
                                this.pm += "@DT_CONTRATO";
                                command.Parameters.AddWithValue("@DT_CONTRATO", reader.Value.ToString());
                                break;
                            case "CNAE_COD":
                                this.cm += "CNAE_COD";
                                this.pm += "@CNAE_COD";
                                command.Parameters.AddWithValue("@CNAE_COD", reader.Value.ToString());
                                break;
                            case "COBRANCA":
                                this.cm += "COBRANCA";
                                this.pm += "@COBRANCA";
                                command.Parameters.AddWithValue("@COBRANCA", reader.Value.ToString());
                                break;
                            case "FCH":
                                this.cm += "FCH";
                                this.pm += "@FCH";
                                command.Parameters.AddWithValue("@FCH", reader.Value.ToString());
                                break;
                            case "VL_VIDA":
                                this.cm += "VL_VIDA";
                                this.pm += "@VL_VIDA";
                                command.Parameters.AddWithValue("@VL_VIDA", reader.Value.ToString());
                                break;
                            case "COBRARSITE":
                                this.cm += "COBRARSITE";
                                this.pm += "@COBRARSITE";
                                command.Parameters.AddWithValue("@COBRARSITE", reader.Value.ToString());
                                break;
                            case "DT_CONT_LTCAT":
                                this.cm += "DT_CONT_LTCAT";
                                this.pm += "@DT_CONT_LTCAT";
                                command.Parameters.AddWithValue("@DT_CONT_LTCAT", reader.Value.ToString());
                                break;
                            case "DT_CONT_PPRA":
                                this.cm += "DT_CONT_PPRA";
                                this.pm += "@DT_CONT_PPRA";
                                command.Parameters.AddWithValue("@DT_CONT_PPRA", reader.Value.ToString());
                                break;
                            case "TIPO_COBRANCA":
                                this.cm += "TIPO_COBRANCA";
                                this.pm += "@TIPO_COBRANCA";
                                command.Parameters.AddWithValue("@TIPO_COBRANCA", reader.Value.ToString());
                                break;
                            case "RAZAO":
                                this.cm += "RAZAO";
                                this.pm += "@RAZAO";
                                command.Parameters.AddWithValue("@RAZAO", reader.Value.ToString());
                                break;
                            case "ATIVO":
                                this.cm += "ATIVO";
                                this.pm += "@ATIVO";
                                command.Parameters.AddWithValue("@ATIVO", reader.Value.ToString());
                                break;
                            case "RADARCODCLI":
                                this.cm += "RADARCODCLI";
                                this.pm += "@RADARCODCLI";
                                command.Parameters.AddWithValue("@RADARCODCLI", reader.Value.ToString());
                                break;
                            case "DT_VENCTO_CIPA":
                                this.cm += "DT_VENCTO_CIPA";
                                this.pm += "@DT_VENCTO_CIPA";
                                command.Parameters.AddWithValue("@DT_VENCTO_CIPA", reader.Value.ToString());
                                break;
                            case "DT_VENCTO_PER":
                                this.cm += "DT_VENCTO_PER";
                                this.pm += "@DT_VENCTO_PER";
                                command.Parameters.AddWithValue("@DT_VENCTO_PER", reader.Value.ToString());
                                break;
                            case "DS_OBSERVACAO":
                                this.cm += "DS_OBSERVACAO";
                                this.pm += "@DS_OBSERVACAO";
                                command.Parameters.AddWithValue("@DS_OBSERVACAO", reader.Value.ToString());
                                break;
                            case "CD_RH":
                                this.cm += "CD_RH";
                                this.pm += "@CD_RH";
                                command.Parameters.AddWithValue("@CD_RH", reader.Value.ToString());
                                break;
                            case "CD_ARQUIVO":
                                this.cm += "CD_ARQUIVO";
                                this.pm += "@CD_ARQUIVO";
                                command.Parameters.AddWithValue("@CD_ARQUIVO", reader.Value.ToString());
                                break;
                            case "CD_CEI":
                                this.cm += "CD_CEI";
                                this.pm += "@CD_CEI";
                                command.Parameters.AddWithValue("@CD_CEI", reader.Value.ToString());
                                break;
                            case "DS_CNAE":
                                this.cm += "DS_CNAE";
                                this.pm += "@DS_CNAE";
                                command.Parameters.AddWithValue("@DS_CNAE", reader.Value.ToString());
                                break;
                            case "CD_TIPO_CNAE":
                                this.cm += "CD_TIPO_CNAE";
                                this.pm += "@CD_TIPO_CNAE";
                                command.Parameters.AddWithValue("@CD_TIPO_CNAE", reader.Value.ToString());
                                break;
                            case "CD_CNAE20":
                                this.cm += "CD_CNAE20";
                                this.pm += "@CD_CNAE20";
                                command.Parameters.AddWithValue("@CD_CNAE20", reader.Value.ToString());
                                break;
                            case "CD_CNAELIVRE":
                                this.cm += "CD_CNAELIVRE";
                                this.pm += "@CD_CNAELIVRE";
                                command.Parameters.AddWithValue("@CD_CNAELIVRE", reader.Value.ToString());
                                break;
                            case "CD_CNAE7":
                                this.cm += "CD_CNAE7";
                                this.pm += "@CD_CNAE7";
                                command.Parameters.AddWithValue("@CD_CNAE7", reader.Value.ToString());
                                break;
                            case "DS_CNAE7":
                                this.cm += "DS_CNAE7";
                                this.pm += "@DS_CNAE7";
                                command.Parameters.AddWithValue("@DS_CNAE7", reader.Value.ToString());
                                break;
                            case "TP_CNPJ_CEI":
                                this.cm += "TP_CNPJ_CEI";
                                this.pm += "@TP_CNPJ_CEI";
                                command.Parameters.AddWithValue("@TP_CNPJ_CEI", reader.Value.ToString());
                                break;
                            case "IC_CONGELA_INVENTARIO":
                                this.cm += "IC_CONGELA_INVENTARIO";
                                this.pm += "@IC_CONGELA_INVENTARIO";
                                command.Parameters.AddWithValue("@IC_CONGELA_INVENTARIO", reader.Value.ToString());
                                break;
                            case "NR_ENDERECO":
                                this.cm += "NR_ENDERECO";
                                this.pm += "@NR_ENDERECO";
                                command.Parameters.AddWithValue("@NR_ENDERECO", reader.Value.ToString());
                                break;
                            case "NM_COMPLEMENTO_ENDERECO":
                                this.cm += "NM_COMPLEMENTO_ENDERECO";
                                this.pm += "@NM_COMPLEMENTO_ENDERECO";
                                command.Parameters.AddWithValue("@NM_COMPLEMENTO_ENDERECO", reader.Value.ToString());
                                break;
                            case "CD_UNIDADE_VISITNET":
                                this.cm += "CD_UNIDADE_VISITNET";
                                this.pm += "@CD_UNIDADE_VISITNET";
                                command.Parameters.AddWithValue("@CD_UNIDADE_VISITNET", reader.Value.ToString());
                                break;
                            case "DT_CONTAGEM":
                                this.cm += "DT_CONTAGEM";
                                this.pm += "@DT_CONTAGEM";
                                command.Parameters.AddWithValue("@DT_CONTAGEM", reader.Value.ToString());
                                break;
                            case "IC_DADOS_ALTERADOS":
                                this.cm += "IC_DADOS_ALTERADOS";
                                this.pm += "@IC_DADOS_ALTERADOS";
                                command.Parameters.AddWithValue("@IC_DADOS_ALTERADOS", reader.Value.ToString());
                                break;
                            case "CD_TIPO_RADAR":
                                this.cm += "CD_TIPO_RADAR";
                                this.pm += "@CD_TIPO_RADAR";
                                command.Parameters.AddWithValue("@CD_TIPO_RADAR", reader.Value.ToString());
                                break;
                            case "CD_MUNICIPIO_RADAR":
                                this.cm += "CD_MUNICIPIO_RADAR";
                                this.pm += "@CD_MUNICIPIO_RADAR";
                                command.Parameters.AddWithValue("@CD_MUNICIPIO_RADAR", reader.Value.ToString());
                                break;
                            case "IC_EXPORTA_RADAR":
                                this.cm += "IC_EXPORTA_RADAR";
                                this.pm += "@IC_EXPORTA_RADAR";
                                command.Parameters.AddWithValue("@IC_EXPORTA_RADAR", reader.Value.ToString());
                                break;
                            case "CD_CLASSIFICACAO_RADAR":
                                this.cm += "CD_CLASSIFICACAO_RADAR";
                                this.pm += "@CD_CLASSIFICACAO_RADAR";
                                command.Parameters.AddWithValue("@CD_CLASSIFICACAO_RADAR", reader.Value.ToString());
                                break;
                            case "DT_EXCLUSAO_LOCAL":
                                this.cm += "DT_EXCLUSAO_LOCAL";
                                this.pm += "@DT_EXCLUSAO_LOCAL";
                                command.Parameters.AddWithValue("@DT_EXCLUSAO_LOCAL", reader.Value.ToString());
                                break;
                            case "CD_LOCAL_SIGEPS":
                                this.cm += "CD_LOCAL_SIGEPS";
                                this.pm += "@CD_LOCAL_SIGEPS";
                                command.Parameters.AddWithValue("@CD_LOCAL_SIGEPS", reader.Value.ToString());
                                break;
                            case "IC_EXPORTA":
                                this.cm += "IC_EXPORTA";
                                this.pm += "@IC_EXPORTA";
                                command.Parameters.AddWithValue("@IC_EXPORTA", reader.Value.ToString());
                                break;
                            case "DS_LOCAL":
                                this.cm += "DS_LOCAL";
                                this.pm += "@DS_LOCAL";
                                command.Parameters.AddWithValue("@DS_LOCAL", reader.Value.ToString());
                                break;
                            case "DS_OBSERVACAO_PPP":
                                this.cm += "DS_OBSERVACAO_PPP";
                                this.pm += "@DS_OBSERVACAO_PPP";
                                command.Parameters.AddWithValue("@DS_OBSERVACAO_PPP", reader.Value.ToString());
                                break;
                            case "LOC_CD_MUNIC_IBGE":
                                this.cm += "LOC_CD_MUNIC_IBGE";
                                this.pm += "@LOC_CD_MUNIC_IBGE";
                                command.Parameters.AddWithValue("@LOC_CD_MUNIC_IBGE", reader.Value.ToString());
                                break;
                            case "IC_FATURA":
                                this.cm += "IC_FATURA";
                                this.pm += "@IC_FATURA";
                                command.Parameters.AddWithValue("@IC_FATURA", reader.Value.ToString());
                                break;
                            case "DS_OBSERVACAO_RECIBO":
                                this.cm += "DS_OBSERVACAO_RECIBO";
                                this.pm += "@DS_OBSERVACAO_RECIBO";
                                command.Parameters.AddWithValue("@DS_OBSERVACAO_RECIBO", reader.Value.ToString());
                                break;
                            case "DS_OBSERVACAO_ASO":
                                this.cm += "DS_OBSERVACAO_ASO";
                                this.pm += "@DS_OBSERVACAO_ASO";
                                command.Parameters.AddWithValue("@DS_OBSERVACAO_ASO", reader.Value.ToString());
                                break;
                            case "CD_TERMO_ADESAO":
                                this.cm += "CD_TERMO_ADESAO";
                                this.pm += "@CD_TERMO_ADESAO";
                                command.Parameters.AddWithValue("@CD_TERMO_ADESAO", reader.Value.ToString());
                                break;
                            case "INSCR_MUN":
                                this.cm += "INSCR_MUN";
                                this.pm += "@INSCR_MUN";
                                command.Parameters.AddWithValue("@INSCR_MUN", reader.Value.ToString());
                                break;
                            case "COD":
                                this.cm += "COD";
                                this.pm += "@COD";
                                command.Parameters.AddWithValue("@COD", reader.Value.ToString());
                                break;
                            case "contrato":
                                this.cm += "contrato";
                                this.pm += "@contrato";
                                command.Parameters.AddWithValue("@contrato", reader.Value.ToString());
                                break;
                            case "visivel_aso":
                                this.cm += "visivel_aso";
                                this.pm += "@visivel_aso";
                                command.Parameters.AddWithValue("@visivel_aso", reader.Value.ToString());
                                break;
                            case "usu_cad":
                                this.cm += "usu_cad";
                                this.pm += "@usu_cad";
                                command.Parameters.AddWithValue("@usu_cad", reader.Value.ToString());
                                break;
                            case "grupo_fatura":
                                this.cm += "grupo_fatura";
                                this.pm += "@grupo_fatura";
                                command.Parameters.AddWithValue("@grupo_fatura", reader.Value.ToString());
                                break;
                            default:
                                break;
                        }
                        break;
                    case XmlNodeType.EndElement:
                        tagAtual = reader.Name.ToString();
                        switch (tagAtual)
                        {
                            case "funcionario":
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