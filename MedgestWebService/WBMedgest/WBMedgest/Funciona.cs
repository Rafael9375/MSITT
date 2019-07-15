using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Xml;

namespace WBMedgest
{
    public class Funciona : ParametroPadrao
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
                        if (tagAtual != "funcionario" && 
                            tagAtual != "funcionarios" && 
                            this.cm.Substring(this.cm.Length - 1, 1) != "(")
                        {
                            this.cm += ", ";
                            this.pm += ", ";
                        }
                        break;
                    case XmlNodeType.Text:
                        switch (tagAtual)
                        {
                            case "MATRICULA":
                                this.cm += "MATRICULA";
                                this.pm += "@MATRICULA";
                                command.Parameters.AddWithValue("@MATRICULA", reader.Value.ToString());
                                break;
                            case "ADMISSAO":
                                this.cm += "ADMISSAO";
                                this.pm += "@ADMISSAO";
                                command.Parameters.AddWithValue("@ADMISSAO", reader.Value.ToString());
                                break;
                            case "DEMISSAO":
                                this.cm += "DEMISSAO";
                                this.pm += "@DEMISSAO";
                                command.Parameters.AddWithValue("@DEMISSAO", reader.Value.ToString());
                                break;
                            case "EMP":
                                this.cm += "EMP";
                                this.pm += "@EMP";
                                command.Parameters.AddWithValue("@EMP", reader.Value.ToString());
                                break;
                            case "RG":
                                this.cm += "RG";
                                this.pm += "@RG";
                                command.Parameters.AddWithValue("@RG", reader.Value.ToString());
                                break;
                            case "UFRG":
                                this.cm += "UFRG";
                                this.pm += "@UFRG";
                                command.Parameters.AddWithValue("@UFRG", reader.Value.ToString());
                                break;
                            case "NOME":
                                this.cm += "NOME";
                                this.pm += "@NOME";
                                command.Parameters.AddWithValue("@NOME", reader.Value.ToString());
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
                            case "TELRES":
                                this.cm += "TELRES";
                                this.pm += "@TELRES";
                                command.Parameters.AddWithValue("@TELRES", reader.Value.ToString());
                                break;
                            case "TELCEL":
                                this.cm += "TELCEL";
                                this.pm += "@TELCEL";
                                command.Parameters.AddWithValue("@TELCEL", reader.Value.ToString());
                                break;
                            case "DT_NASC":
                                this.cm += "DT_NASC";
                                this.pm += "@DT_NASC";
                                command.Parameters.AddWithValue("@DT_NASC", reader.Value.ToString());
                                break;
                            case "CPF":
                                this.cm += "CPF";
                                this.pm += "@CPF";
                                command.Parameters.AddWithValue("@CPF", reader.Value.ToString());
                                break;
                            case "EMAIL":
                                this.cm += "EMAIL";
                                this.pm += "@EMAIL";
                                command.Parameters.AddWithValue("@EMAIL", reader.Value.ToString());
                                break;
                            case "TELCOM":
                                this.cm += "TELCOM";
                                this.pm += "@TELCOM";
                                command.Parameters.AddWithValue("@TELCOM", reader.Value.ToString());
                                break;
                            case "CONTATO":
                                this.cm += "CONTATO";
                                this.pm += "@CONTATO";
                                command.Parameters.AddWithValue("@CONTATO", reader.Value.ToString());
                                break;
                            case "PARENTESCO":
                                this.cm += "PARENTESCO";
                                this.pm += "@PARENTESCO";
                                command.Parameters.AddWithValue("@PARENTESCO", reader.Value.ToString());
                                break;
                            case "TEL_CONT":
                                this.cm += "TEL_CONT";
                                this.pm += "@TEL_CONT";
                                command.Parameters.AddWithValue("@TEL_CONT", reader.Value.ToString());
                                break;
                            case "END_CONT":
                                this.cm += "END_CONT";
                                this.pm += "@END_CONT";
                                command.Parameters.AddWithValue("@END_CONT", reader.Value.ToString());
                                break;
                            case "EST_CIVIL":
                                this.cm += "EST_CIVIL";
                                this.pm += "@EST_CIVIL";
                                command.Parameters.AddWithValue("@EST_CIVIL", reader.Value.ToString());
                                break;
                            case "COR":
                                this.cm += "COR";
                                this.pm += "@COR";
                                command.Parameters.AddWithValue("@COR", reader.Value.ToString());
                                break;
                            case "NATURALIDADE":
                                this.cm += "NATURALIDADE";
                                this.pm += "@NATURALIDADE";
                                command.Parameters.AddWithValue("@NATURALIDADE", reader.Value.ToString());
                                break;
                            case "SEXO":
                                this.cm += "SEXO";
                                this.pm += "@SEXO";
                                command.Parameters.AddWithValue("@SEXO", reader.Value.ToString());
                                break;
                            case "SANGUE":
                                this.cm += "SANGUE";
                                this.pm += "@SANGUE";
                                command.Parameters.AddWithValue("@SANGUE", reader.Value.ToString());
                                break;
                            case "REGIME":
                                this.cm += "REGIME";
                                this.pm += "@REGIME";
                                command.Parameters.AddWithValue("@REGIME", reader.Value.ToString());
                                break;
                            case "ANTECEDENTES":
                                this.cm += "ANTECEDENTES";
                                this.pm += "@ANTECEDENTES";
                                command.Parameters.AddWithValue("@ANTECEDENTES", reader.Value.ToString());
                                break;
                            case "VACINAS":
                                this.cm += "VACINAS";
                                this.pm += "@VACINAS";
                                command.Parameters.AddWithValue("@VACINAS", reader.Value.ToString());
                                break;
                            case "FUMA":
                                this.cm += "FUMA";
                                this.pm += "@FUMA";
                                command.Parameters.AddWithValue("@FUMA", reader.Value.ToString());
                                break;
                            case "OUTROS_FUM":
                                this.cm += "OUTROS_FUM";
                                this.pm += "@OUTROS_FUM";
                                command.Parameters.AddWithValue("@OUTROS_FUM", reader.Value.ToString());
                                break;
                            case "DT_CAD_MEDICO":
                                this.cm += "DT_CAD_MEDICO";
                                this.pm += "@DT_CAD_MEDICO";
                                command.Parameters.AddWithValue("@DT_CAD_MEDICO", reader.Value.ToString());
                                break;
                            case "HISTORICO":
                                this.cm += "HISTORICO";
                                this.pm += "@HISTORICO";
                                command.Parameters.AddWithValue("@HISTORICO", reader.Value.ToString());
                                break;
                            case "MEDICO":
                                this.cm += "MEDICO";
                                this.pm += "@MEDICO";
                                command.Parameters.AddWithValue("@MEDICO", reader.Value.ToString());
                                break;
                            case "SITE":
                                this.cm += "SITE";
                                this.pm += "@SITE";
                                command.Parameters.AddWithValue("@SITE", reader.Value.ToString());
                                break;
                            case "CARGO":
                                this.cm += "CARGO";
                                this.pm += "@CARGO";
                                command.Parameters.AddWithValue("@CARGO", reader.Value.ToString());
                                break;
                            case "SETOR":
                                this.cm += "SETOR";
                                this.pm += "@SETOR";
                                command.Parameters.AddWithValue("@SETOR", reader.Value.ToString());
                                break;
                            case "TEMPO_FUM":
                                this.cm += "TEMPO_FUM";
                                this.pm += "@TEMPO_FUM";
                                command.Parameters.AddWithValue("@TEMPO_FUM", reader.Value.ToString());
                                break;
                            case "DOSE":
                                this.cm += "DOSE";
                                this.pm += "@DOSE";
                                command.Parameters.AddWithValue("@DOSE", reader.Value.ToString());
                                break;
                            case "EXERCICIOS":
                                this.cm += "EXERCICIOS";
                                this.pm += "@EXERCICIOS";
                                command.Parameters.AddWithValue("@EXERCICIOS", reader.Value.ToString());
                                break;
                            case "DS_ATIVIDADES":
                                this.cm += "DS_ATIVIDADES";
                                this.pm += "@DS_ATIVIDADES";
                                command.Parameters.AddWithValue("@DS_ATIVIDADES", reader.Value.ToString());
                                break;
                            case "OBSHIST":
                                this.cm += "OBSHIST";
                                this.pm += "@OBSHIST";
                                command.Parameters.AddWithValue("@OBSHIST", reader.Value.ToString());
                                break;
                            case "CID_ANT":
                                this.cm += "CID_ANT";
                                this.pm += "@CID_ANT";
                                command.Parameters.AddWithValue("@CID_ANT", reader.Value.ToString());
                                break;
                            case "FERMENTADO":
                                this.cm += "FERMENTADO";
                                this.pm += "@FERMENTADO";
                                command.Parameters.AddWithValue("@FERMENTADO", reader.Value.ToString());
                                break;
                            case "DESTILADO":
                                this.cm += "DESTILADO";
                                this.pm += "@DESTILADO";
                                command.Parameters.AddWithValue("@DESTILADO", reader.Value.ToString());
                                break;
                            case "DT_ULTMOV":
                                this.cm += "DT_ULTMOV";
                                this.pm += "@DT_ULTMOV";
                                command.Parameters.AddWithValue("@DT_ULTMOV", reader.Value.ToString());
                                break;
                            case "ALERTA":
                                this.cm += "ALERTA";
                                this.pm += "@ALERTA";
                                command.Parameters.AddWithValue("@ALERTA", reader.Value.ToString());
                                break;
                            case "FUNCAO":
                                this.cm += "FUNCAO";
                                this.pm += "@FUNCAO";
                                command.Parameters.AddWithValue("@FUNCAO", reader.Value.ToString());
                                break;
                            case "OBSDEF":
                                this.cm += "OBSDEF";
                                this.pm += "@OBSDEF";
                                command.Parameters.AddWithValue("@OBSDEF", reader.Value.ToString());
                                break;
                            case "DEFICIENTE":
                                this.cm += "DEFICIENTE";
                                this.pm += "@DEFICIENTE";
                                command.Parameters.AddWithValue("@DEFICIENTE", reader.Value.ToString());
                                break;
                            case "PIS":
                                this.cm += "PIS";
                                this.pm += "@PIS";
                                command.Parameters.AddWithValue("@PIS", reader.Value.ToString());
                                break;
                            case "CTPS":
                                this.cm += "CTPS";
                                this.pm += "@CTPS";
                                command.Parameters.AddWithValue("@CTPS", reader.Value.ToString());
                                break;
                            case "TIPOC":
                                this.cm += "TIPOC";
                                this.pm += "@TIPOC";
                                command.Parameters.AddWithValue("@TIPOC", reader.Value.ToString());
                                break;
                            case "REQUISITOS_FUNCAO":
                                this.cm += "REQUISITOS_FUNCAO";
                                this.pm += "@REQUISITOS_FUNCAO";
                                command.Parameters.AddWithValue("@REQUISITOS_FUNCAO", reader.Value.ToString());
                                break;
                            case "MOSTRAR_DS":
                                this.cm += "MOSTRAR_DS";
                                this.pm += "@MOSTRAR_DS";
                                command.Parameters.AddWithValue("@MOSTRAR_DS", reader.Value.ToString());
                                break;
                            case "GFIP":
                                this.cm += "GFIP";
                                this.pm += "@GFIP";
                                command.Parameters.AddWithValue("@GFIP", reader.Value.ToString());
                                break;
                            case "CCUSTO":
                                this.cm += "CCUSTO";
                                this.pm += "@CCUSTO";
                                command.Parameters.AddWithValue("@CCUSTO", reader.Value.ToString());
                                break;
                            case "SIT":
                                this.cm += "SIT";
                                this.pm += "@SIT";
                                command.Parameters.AddWithValue("@SIT", reader.Value.ToString());
                                break;
                            case "HERANCA":
                                this.cm += "HERANCA";
                                this.pm += "@HERANCA";
                                command.Parameters.AddWithValue("@HERANCA", reader.Value.ToString());
                                break;
                            case "NRISCO":
                                this.cm += "NRISCO";
                                this.pm += "@NRISCO";
                                command.Parameters.AddWithValue("@NRISCO", reader.Value.ToString());
                                break;
                            case "DT_AFASTA":
                                this.cm += "DT_AFASTA";
                                this.pm += "@DT_AFASTA";
                                command.Parameters.AddWithValue("@DT_AFASTA", reader.Value.ToString());
                                break;
                            case "DT_CADASTRO":
                                this.cm += "DT_CADASTRO";
                                this.pm += "@DT_CADASTRO";
                                command.Parameters.AddWithValue("@DT_CADASTRO", reader.Value.ToString());
                                break;
                            case "NM_MAE_FUNCIONARIO":
                                this.cm += "NM_MAE_FUNCIONARIO";
                                this.pm += "@NM_MAE_FUNCIONARIO";
                                command.Parameters.AddWithValue("@NM_MAE_FUNCIONARIO", reader.Value.ToString());
                                break;
                            case "DT_EMISSAO_CPROF":
                                this.cm += "DT_EMISSAO_CPROF";
                                this.pm += "@DT_EMISSAO_CPROF";
                                command.Parameters.AddWithValue("@DT_EMISSAO_CPROF", reader.Value.ToString());
                                break;
                            case "DT_RG":
                                this.cm += "DT_RG";
                                this.pm += "@DT_RG";
                                command.Parameters.AddWithValue("@DT_RG", reader.Value.ToString());
                                break;
                            case "NM_ORG_EMISS":
                                this.cm += "NM_ORG_EMISS";
                                this.pm += "@NM_ORG_EMISS";
                                command.Parameters.AddWithValue("@NM_ORG_EMISS", reader.Value.ToString());
                                break;
                            case "REABILITADO":
                                this.cm += "REABILITADO";
                                this.pm += "@REABILITADO";
                                command.Parameters.AddWithValue("@REABILITADO", reader.Value.ToString());
                                break;
                            case "REGIME_TRAB":
                                this.cm += "REGIME_TRAB";
                                this.pm += "@REGIME_TRAB";
                                command.Parameters.AddWithValue("@REGIME_TRAB", reader.Value.ToString());
                                break;
                            case "OBSPPP":
                                this.cm += "OBSPPP";
                                this.pm += "@OBSPPP";
                                command.Parameters.AddWithValue("@OBSPPP", reader.Value.ToString());
                                break;
                            case "DOADOR_DE_SANGUE":
                                this.cm += "DOADOR_DE_SANGUE";
                                this.pm += "@DOADOR_DE_SANGUE";
                                command.Parameters.AddWithValue("@DOADOR_DE_SANGUE", reader.Value.ToString());
                                break;
                            case "CNPJ":
                                this.cm += "CNPJ";
                                this.pm += "@CNPJ";
                                command.Parameters.AddWithValue("@CNPJ", reader.Value.ToString());
                                break;
                            case "RAZAO_SOCIAL":
                                this.cm += "RAZAO_SOCIAL";
                                this.pm += "@RAZAO_SOCIAL";
                                command.Parameters.AddWithValue("@RAZAO_SOCIAL", reader.Value.ToString());
                                break;
                            case "UNIDADE_CONTRATANTE":
                                this.cm += "UNIDADE_CONTRATANTE";
                                this.pm += "@UNIDADE_CONTRATANTE";
                                command.Parameters.AddWithValue("@UNIDADE_CONTRATANTE", reader.Value.ToString());
                                break;
                            case "TURNO":
                                this.cm += "TURNO";
                                this.pm += "@TURNO";
                                command.Parameters.AddWithValue("@TURNO", reader.Value.ToString());
                                break;
                            case "CLASSDEF":
                                this.cm += "CLASSDEF";
                                this.pm += "@CLASSDEF";
                                command.Parameters.AddWithValue("@CLASSDEF", reader.Value.ToString());
                                break;
                            case "CONLTCAT":
                                this.cm += "CONLTCAT";
                                this.pm += "@CONLTCAT";
                                command.Parameters.AddWithValue("@CONLTCAT", reader.Value.ToString());
                                break;
                            case "DT_ULTDOACSAN":
                                this.cm += "DT_ULTDOACSAN";
                                this.pm += "@DT_ULTDOACSAN";
                                command.Parameters.AddWithValue("@DT_ULTDOACSAN", reader.Value.ToString());
                                break;
                            case "SERIECTPS":
                                this.cm += "SERIECTPS";
                                this.pm += "@SERIECTPS";
                                command.Parameters.AddWithValue("@SERIECTPS", reader.Value.ToString());
                                break;
                            case "CD_CIPEIRO":
                                this.cm += "CD_CIPEIRO";
                                this.pm += "@CD_CIPEIRO";
                                command.Parameters.AddWithValue("@CD_CIPEIRO", reader.Value.ToString());
                                break;
                            case "SITUACAO_MAE":
                                this.cm += "SITUACAO_MAE";
                                this.pm += "@SITUACAO_MAE";
                                command.Parameters.AddWithValue("@SITUACAO_MAE", reader.Value.ToString());
                                break;
                            case "DT_ULT_ALTERACAO":
                                this.cm += "DT_ULT_ALTERACAO";
                                this.pm += "@DT_ULT_ALTERACAO";
                                command.Parameters.AddWithValue("@DT_ULT_ALTERACAO", reader.Value.ToString());
                                break;
                            case "ORIGEM_ULT_ALTERACAO":
                                this.cm += "ORIGEM_ULT_ALTERACAO";
                                this.pm += "@ORIGEM_ULT_ALTERACAO";
                                command.Parameters.AddWithValue("@ORIGEM_ULT_ALTERACAO", reader.Value.ToString());
                                break;
                            case "USU_ULT_ALT":
                                this.cm += "USU_ULT_ALT";
                                this.pm += "@USU_ULT_ALT";
                                command.Parameters.AddWithValue("@USU_ULT_ALT", reader.Value.ToString());
                                break;
                            case "DT_IMPORTACAO":
                                this.cm += "DT_IMPORTACAO";
                                this.pm += "@DT_IMPORTACAO";
                                command.Parameters.AddWithValue("@DT_IMPORTACAO", reader.Value.ToString());
                                break;
                            case "IDADE_AVO_MATERNA":
                                this.cm += "IDADE_AVO_MATERNA";
                                this.pm += "@IDADE_AVO_MATERNA";
                                command.Parameters.AddWithValue("@IDADE_AVO_MATERNA", reader.Value.ToString());
                                break;
                            case "IDADE_AVO_MATERNO":
                                this.cm += "IDADE_AVO_MATERNO";
                                this.pm += "@IDADE_AVO_MATERNO";
                                command.Parameters.AddWithValue("@IDADE_AVO_MATERNO", reader.Value.ToString());
                                break;
                            case "IDADE_AVO_PATERNA":
                                this.cm += "IDADE_AVO_PATERNA";
                                this.pm += "@IDADE_AVO_PATERNA";
                                command.Parameters.AddWithValue("@IDADE_AVO_PATERNA", reader.Value.ToString());
                                break;
                            case "IDADE_AVO_PATERNO":
                                this.cm += "IDADE_AVO_PATERNO";
                                this.pm += "@IDADE_AVO_PATERNO";
                                command.Parameters.AddWithValue("@IDADE_AVO_PATERNO", reader.Value.ToString());
                                break;
                            case "IDADE_PAI":
                                this.cm += "IDADE_PAI";
                                this.pm += "@IDADE_PAI";
                                command.Parameters.AddWithValue("@IDADE_PAI", reader.Value.ToString());
                                break;
                            case "IDADE_MAE":
                                this.cm += "IDADE_MAE";
                                this.pm += "@IDADE_MAE";
                                command.Parameters.AddWithValue("@IDADE_MAE", reader.Value.ToString());
                                break;
                            case "SITUACAO_PAI":
                                this.cm += "SITUACAO_PAI";
                                this.pm += "@SITUACAO_PAI";
                                command.Parameters.AddWithValue("@SITUACAO_PAI", reader.Value.ToString());
                                break;
                            case "SITUACAO_AVO_MATERNA":
                                this.cm += "SITUACAO_AVO_MATERNA";
                                this.pm += "@SITUACAO_AVO_MATERNA";
                                command.Parameters.AddWithValue("@SITUACAO_AVO_MATERNA", reader.Value.ToString());
                                break;
                            case "SITUACAO_AVO_MATERNO":
                                this.cm += "SITUACAO_AVO_MATERNO";
                                this.pm += "@SITUACAO_AVO_MATERNO";
                                command.Parameters.AddWithValue("@SITUACAO_AVO_MATERNO", reader.Value.ToString());
                                break;
                            case "SITUACAO_AVO_PATERNO":
                                this.cm += "SITUACAO_AVO_PATERNO";
                                this.pm += "@SITUACAO_AVO_PATERNO";
                                command.Parameters.AddWithValue("@SITUACAO_AVO_PATERNO", reader.Value.ToString());
                                break;
                            case "SITUACAO_AVO_PATERNA":
                                this.cm += "SITUACAO_AVO_PATERNA";
                                this.pm += "@SITUACAO_AVO_PATERNA";
                                command.Parameters.AddWithValue("@SITUACAO_AVO_PATERNA", reader.Value.ToString());
                                break;
                            case "SAUDE_MAE":
                                this.cm += "SAUDE_MAE";
                                this.pm += "@SAUDE_MAE";
                                command.Parameters.AddWithValue("@SAUDE_MAE", reader.Value.ToString());
                                break;
                            case "SAUDE_PAI":
                                this.cm += "SAUDE_PAI";
                                this.pm += "@SAUDE_PAI";
                                command.Parameters.AddWithValue("@SAUDE_PAI", reader.Value.ToString());
                                break;
                            case "SAUDE_AVO_MATERNO":
                                this.cm += "SAUDE_AVO_MATERNO";
                                this.pm += "@SAUDE_AVO_MATERNO";
                                command.Parameters.AddWithValue("@SAUDE_AVO_MATERNO", reader.Value.ToString());
                                break;
                            case "SAUDE_AVO_MATERNA":
                                this.cm += "SAUDE_AVO_MATERNA";
                                this.pm += "@SAUDE_AVO_MATERNA";
                                command.Parameters.AddWithValue("@SAUDE_AVO_MATERNA", reader.Value.ToString());
                                break;
                            case "SAUDE_AVO_PATERNO":
                                this.cm += "SAUDE_AVO_PATERNO";
                                this.pm += "@SAUDE_AVO_PATERNO";
                                command.Parameters.AddWithValue("@SAUDE_AVO_PATERNO", reader.Value.ToString());
                                break;
                            case "SAUDE_AVO_PATERNA":
                                this.cm += "SAUDE_AVO_PATERNA";
                                this.pm += "@SAUDE_AVO_PATERNA";
                                command.Parameters.AddWithValue("@SAUDE_AVO_PATERNA", reader.Value.ToString());
                                break;
                            case "CHARUTO":
                                this.cm += "CHARUTO";
                                this.pm += "@CHARUTO";
                                command.Parameters.AddWithValue("@CHARUTO", reader.Value.ToString());
                                break;
                            case "CIGARRO":
                                this.cm += "CIGARRO";
                                this.pm += "@CIGARRO";
                                command.Parameters.AddWithValue("@CIGARRO", reader.Value.ToString());
                                break;
                            case "CACHIMBO":
                                this.cm += "CACHIMBO";
                                this.pm += "@CACHIMBO";
                                command.Parameters.AddWithValue("@CACHIMBO", reader.Value.ToString());
                                break;
                            case "CD_MEDICO_DEFICIENTE":
                                this.cm += "CD_MEDICO_DEFICIENTE";
                                this.pm += "@CD_MEDICO_DEFICIENTE";
                                command.Parameters.AddWithValue("@CD_MEDICO_DEFICIENTE", reader.Value.ToString());
                                break;
                            case "CID_DEFICIENTE":
                                this.cm += "CID_DEFICIENTE";
                                this.pm += "@CID_DEFICIENTE";
                                command.Parameters.AddWithValue("@CID_DEFICIENTE", reader.Value.ToString());
                                break;
                            case "DT_INCLUSAO":
                                this.cm += "DT_INCLUSAO";
                                this.pm += "@DT_INCLUSAO";
                                command.Parameters.AddWithValue("@DT_INCLUSAO", reader.Value.ToString());
                                break;
                            case "DT_INICIO_MANDATO_CIPA":
                                this.cm += "DT_INICIO_MANDATO_CIPA";
                                this.pm += "@DT_INICIO_MANDATO_CIPA";
                                command.Parameters.AddWithValue("@DT_INICIO_MANDATO_CIPA", reader.Value.ToString());
                                break;
                            case "DT_FIM_MANDATO_CIPA":
                                this.cm += "DT_FIM_MANDATO_CIPA";
                                this.pm += "@DT_FIM_MANDATO_CIPA";
                                command.Parameters.AddWithValue("@DT_FIM_MANDATO_CIPA", reader.Value.ToString());
                                break;
                            case "SENHA":
                                this.cm += "SENHA";
                                this.pm += "@SENHA";
                                command.Parameters.AddWithValue("@SENHA", reader.Value.ToString());
                                break;
                            case "DT_INATIVACAO":
                                this.cm += "DT_INATIVACAO";
                                this.pm += "@DT_INATIVACAO";
                                command.Parameters.AddWithValue("@DT_INATIVACAO", reader.Value.ToString());
                                break;
                            case "DT_DEMISSIONAL_CARTA":
                                this.cm += "DT_DEMISSIONAL_CARTA";
                                this.pm += "@DT_DEMISSIONAL_CARTA";
                                command.Parameters.AddWithValue("@DT_DEMISSIONAL_CARTA", reader.Value.ToString());
                                break;
                            case "TP_DECRETO_LAUDO":
                                this.cm += "TP_DECRETO_LAUDO";
                                this.pm += "@TP_DECRETO_LAUDO";
                                command.Parameters.AddWithValue("@TP_DECRETO_LAUDO", reader.Value.ToString());
                                break;
                            case "CD_ORIGINAL_EMPRESA_CLIENTE":
                                this.cm += "CD_ORIGINAL_EMPRESA_CLIENTE";
                                this.pm += "@CD_ORIGINAL_EMPRESA_CLIENTE";
                                command.Parameters.AddWithValue("@CD_ORIGINAL_EMPRESA_CLIENTE", reader.Value.ToString());
                                break;
                            case "CD_RH_FUNCIONA":
                                this.cm += "CD_RH_FUNCIONA";
                                this.pm += "@CD_RH_FUNCIONA";
                                command.Parameters.AddWithValue("@CD_RH_FUNCIONA", reader.Value.ToString());
                                break;
                            case "CD_UNIMED_USUARIO":
                                this.cm += "CD_UNIMED_USUARIO";
                                this.pm += "@CD_UNIMED_USUARIO";
                                command.Parameters.AddWithValue("@CD_UNIMED_USUARIO", reader.Value.ToString());
                                break;
                            case "CD_UNIMED_SEQ_USUARIO":
                                this.cm += "CD_UNIMED_SEQ_USUARIO";
                                this.pm += "@CD_UNIMED_SEQ_USUARIO";
                                command.Parameters.AddWithValue("@CD_UNIMED_SEQ_USUARIO", reader.Value.ToString());
                                break;
                            case "CD_UNIMED_DIG_USUARIO":
                                this.cm += "CD_UNIMED_DIG_USUARIO";
                                this.pm += "@CD_UNIMED_DIG_USUARIO";
                                command.Parameters.AddWithValue("@CD_UNIMED_DIG_USUARIO", reader.Value.ToString());
                                break;
                            case "assinatura":
                                this.cm += "assinatura";
                                this.pm += "@assinatura";
                                command.Parameters.AddWithValue("@assinatura", reader.Value.ToString());
                                break;
                            case "NR_ENDERECO":
                                this.cm += "NR_ENDERECO";
                                this.pm += "@NR_ENDERECO";
                                command.Parameters.AddWithValue("@NR_ENDERECO", reader.Value.ToString());
                                break;
                            case "NM_COMPLEMENTO":
                                this.cm += "NM_COMPLEMENTO";
                                this.pm += "@NM_COMPLEMENTO";
                                command.Parameters.AddWithValue("@NM_COMPLEMENTO", reader.Value.ToString());
                                break;
                            case "IC_BLOQUEIA_ALTERACAO":
                                this.cm += "IC_BLOQUEIA_ALTERACAO";
                                this.pm += "@IC_BLOQUEIA_ALTERACAO";
                                command.Parameters.AddWithValue("@IC_BLOQUEIA_ALTERACAO", reader.Value.ToString());
                                break;
                            case "DT_ATUALIZACAO":
                                this.cm += "DT_ATUALIZACAO";
                                this.pm += "@DT_ATUALIZACAO";
                                command.Parameters.AddWithValue("@DT_ATUALIZACAO", reader.Value.ToString());
                                break;
                            case "DS_OBSERVACAO_ASO":
                                this.cm += "DS_OBSERVACAO_ASO";
                                this.pm += "@DS_OBSERVACAO_ASO";
                                command.Parameters.AddWithValue("@DS_OBSERVACAO_ASO", reader.Value.ToString());
                                break;
                            case "UF_CTPS":
                                this.cm += "UF_CTPS";
                                this.pm += "@UF_CTPS";
                                command.Parameters.AddWithValue("@UF_CTPS", reader.Value.ToString());
                                break;
                            case "DT_INICIO_VIGENCIA_SIGEPS":
                                this.cm += "DT_INICIO_VIGENCIA_SIGEPS";
                                this.pm += "@DT_INICIO_VIGENCIA_SIGEPS";
                                command.Parameters.AddWithValue("@DT_INICIO_VIGENCIA_SIGEPS", reader.Value.ToString());
                                break;
                            case "DT_EMISSAO_LAUDO":
                                this.cm += "DT_EMISSAO_LAUDO";
                                this.pm += "@DT_EMISSAO_LAUDO";
                                command.Parameters.AddWithValue("@DT_EMISSAO_LAUDO", reader.Value.ToString());
                                break;
                            case "CD_JOB":
                                this.cm += "CD_JOB";
                                this.pm += "@CD_JOB";
                                command.Parameters.AddWithValue("@CD_JOB", reader.Value.ToString());
                                break;
                            case "CD_ORIGEM_DEFICIENCIA":
                                this.cm += "CD_ORIGEM_DEFICIENCIA";
                                this.pm += "@CD_ORIGEM_DEFICIENCIA";
                                command.Parameters.AddWithValue("@CD_ORIGEM_DEFICIENCIA", reader.Value.ToString());
                                break;
                            case "CD_PARECER_LAUDO":
                                this.cm += "CD_PARECER_LAUDO";
                                this.pm += "@CD_PARECER_LAUDO";
                                command.Parameters.AddWithValue("@CD_PARECER_LAUDO", reader.Value.ToString());
                                break;
                            case "DS_OBS_DEFIC_COMPLEMENTAR":
                                this.cm += "DS_OBS_DEFIC_COMPLEMENTAR";
                                this.pm += "@DS_OBS_DEFIC_COMPLEMENTAR";
                                command.Parameters.AddWithValue("@DS_OBS_DEFIC_COMPLEMENTAR", reader.Value.ToString());
                                break;
                            case "CD_TIPO_LICENCA":
                                this.cm += "CD_TIPO_LICENCA";
                                this.pm += "@CD_TIPO_LICENCA";
                                command.Parameters.AddWithValue("@CD_TIPO_LICENCA", reader.Value.ToString());
                                break;
                            case "subsetor":
                                this.cm += "subsetor";
                                this.pm += "@subsetor";
                                command.Parameters.AddWithValue("@subsetor", reader.Value.ToString());
                                break;
                            case "usu_cad":
                                this.cm += "usu_cad";
                                this.pm += "@usu_cad";
                                command.Parameters.AddWithValue("@usu_cad", reader.Value.ToString());
                                break;
                            case "foto":
                                this.cm += "foto";
                                this.pm += "@foto";
                                command.Parameters.AddWithValue("@foto", reader.Value.ToString());
                                break;
                            case "dt_cobranca":
                                this.cm += "dt_cobranca";
                                this.pm += "@dt_cobranca";
                                command.Parameters.AddWithValue("@dt_cobranca", reader.Value.ToString());
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