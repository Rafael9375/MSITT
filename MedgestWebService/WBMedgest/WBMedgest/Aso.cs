using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Xml;

namespace WBMedgest
{
    internal class Aso : ParametroPadrao
    {
        public InfraDados<Aso> infra { get; set; }
        internal string GerarXmlTodos(string local)
        {
            var formaXml = "";
            local += @"\funcionario.xml";
            //local = local.Replace(@"\", @"\");
            XmlTextWriter writer = new XmlTextWriter(local, null);
            writer.WriteStartDocument();
            this.command = new SqlCommand("Select " +
                "exame.QCH, " +
                "resultado.EMP, " +
                "ficha.codficha, " +
                "ficha.COD, " +
                "resultado.codi, " +
                "CONVERT(VARCHAR(10),CAST(ficha.DT_FICHA AS date), 103) AS DT_FICHA, " +
                "ficha.MEDICO, " +
                "ficha.OBS1, " +
                "ficha.PARASO, " +
                "CONVERT(VARCHAR(10),CAST(resultado.DATA AS date), 103) AS DATA, " +
                "resultado.EXAME, " +
                "resultado.TP_EXAME, " +
                "resultado.OCUP, " +
                "ficha.CD_CID, " +
                "resultado.AGRAV, " +
                "resultado.RESULTADO, " +
                "resultado.OBS " +
                "from ficha " +
                "join resultado on ficha.codficha = resultado.codficha " +
                "join exame on resultado.EXAME = exame.COD ", this.con);
            if (this.emp != "" && this.emp != null)
            {
                this.command.CommandText += "where resultado.EMP = @EMP ";
            }
            this.command.Parameters.AddWithValue("@EMP", this.emp);
            DataSet dataset = new DataSet();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(this.command);
            this.con.Open();
            dataAdapter.Fill(dataset);
            this.con.Close();
            DataTable table = dataset.Tables[0];
            var codAtual = "";
            var codAntiga = "";
            var tpExame = "";
            writer.WriteStartElement("REGISTRO");
            foreach (DataRow row in table.Rows)
            {
                codAtual = row["codficha"].ToString();
                if (codAtual != codAntiga)
                {
                    writer.WriteStartElement("CONSULTA");
                    writer.WriteElementString("IDCONSULTA", "");
                    writer.WriteElementString("CODENTIDADE", row["QCH"].ToString());
                    writer.WriteElementString("CODCONSULTA", row["codficha"].ToString());
                    writer.WriteElementString("CODPESSOA", row["COD"].ToString());
                    writer.WriteElementString("CHAPA", row["COD"].ToString());
                    writer.WriteElementString("CODMEDICO", row["MEDICO"].ToString());
                    tpExame = row["TP_EXAME"].ToString();
                    switch (tpExame)
                    {
                        case "1":
                            writer.WriteElementString("CODTIPOCONSULTA", "0");
                            writer.WriteElementString("CODTIPOCONSULTAESOCIAL", "0");
                            break;
                        case "2":
                            writer.WriteElementString("CODTIPOCONSULTA", "1");
                            writer.WriteElementString("CODTIPOCONSULTAESOCIAL", "1");
                            break;
                        case "3":
                            writer.WriteElementString("CODTIPOCONSULTA", "2");
                            writer.WriteElementString("CODTIPOCONSULTAESOCIAL", "2");
                            break;
                        case "4":
                            writer.WriteElementString("CODTIPOCONSULTA", "3");
                            writer.WriteElementString("CODTIPOCONSULTAESOCIAL", "3");
                            break;
                        case "5":
                            writer.WriteElementString("CODTIPOCONSULTA", "9");
                            writer.WriteElementString("CODTIPOCONSULTAESOCIAL", "9");
                            break;
                        default:
                            writer.WriteElementString("CODTIPOCONSULTA", "");
                            writer.WriteElementString("CODTIPOCONSULTAESOCIAL", "");
                            break;
                    }
                    writer.WriteElementString("CODTIPOCONSULTAESOCIAL", "");
                    writer.WriteElementString("DATACONSULTA", row["DT_FICHA"].ToString());
                    switch (row["PARASO"].ToString())
                    {
                        case "1":
                            writer.WriteElementString("APTO", "1");
                            break;
                        case "3":
                            writer.WriteElementString("APTO", "0");
                            break;
                        default:
                            writer.WriteElementString("APTO", "");
                            break;
                    }
                    writer.WriteElementString("OBSERVACAO", row["OBS1"].ToString());
                    writer.WriteEndElement();
                    codAntiga = codAtual;
                }
                if (row == table.Rows[0])
                {
                    codAntiga = row["codficha"].ToString();
                }
                writer.WriteStartElement("RESULTADO");
                writer.WriteElementString("IDCONSULTA", "");
                writer.WriteElementString("CODCONSULTA", row["codficha"].ToString());
                writer.WriteElementString("EXAME", row["EXAME"].ToString());
                switch (tpExame)
                {
                    case "1":
                        writer.WriteElementString("TIPOEXAME", "A");
                        break;
                    case "2":
                        writer.WriteElementString("TIPOEXAME", "P");
                        break;
                    case "3":
                        writer.WriteElementString("TIPOEXAME", "R");
                        break;
                    case "4":
                        writer.WriteElementString("TIPOEXAME", "M");
                        break;
                    case "5":
                        writer.WriteElementString("TIPOEXAME", "D");
                        break;
                    default:
                        writer.WriteElementString("TIPOEXAME", "");
                        break;
                }
                writer.WriteElementString("CID", row["CD_CID"].ToString());
                writer.WriteElementString("CODENTIDADE", row["EMP"].ToString());
                writer.WriteElementString("DATAEXAME", row["DATA"].ToString());
                writer.WriteElementString("EXAMEREFERENCIAL", "");
                switch (row["OCUP"].ToString())
                {
                    case "1":
                        writer.WriteElementString("ATIVOOCUPACIONAL", "1");
                        break;
                    default:
                        writer.WriteElementString("ATIVOOCUPACIONAL", "");
                        break;
                }
                writer.WriteElementString("RESULTNORMAL", "");
                writer.WriteElementString("TIPOANORMALIDADE", row["AGRAV"].ToString());
                switch (row["PARASO"].ToString())
                {
                    case "1":
                        writer.WriteElementString("APTO", "1");
                        break;
                    case "3":
                        writer.WriteElementString("APTO", "0");
                        break;
                    default:
                        writer.WriteElementString("APTO", "");
                        break;
                }
                writer.WriteElementString("DESCANORMAL", "");
                writer.WriteElementString("INTERPREXM", row["RESULTADO"].ToString());
                writer.WriteElementString("OBSERVACAO", "");
                writer.WriteElementString("CAMPOTEXTOLONGO", "");
                writer.WriteElementString("CAMPONUMERICO", "");
                writer.WriteElementString("CAMPOTEXTO", "");
                writer.WriteElementString("CAMPOTABDINAM", "");
                writer.WriteEndElement();
            }
            writer.WriteEndElement();
            writer.Formatting = Formatting.Indented;
            writer.Close();
            return formaXml;
        }
        public Aso(SqlConnection _con)
        {
            this.con = _con;
            infra = new InfraDados<Aso>(this.con);
        }
        internal void ExecutarComando()
        {
            XmlTextReader reader = new XmlTextReader(this.url);
            reader.Read();
            bool primeiroRes = false;
            infra.ConfiguraCmdTxt();
            infra.emp = this.emp;
            this.cm = infra.cm;
            this.pm = infra.pm;
            this.command = new SqlCommand();
            var tagAtual = "";
            var tagMae = "";
            var riscoaso = "";
            int idConsulta = 0;
            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element:
                        tagAtual = reader.Name.ToString();
                        if (tagAtual == "RESULTADO")
                        {
                            tagMae = tagAtual;
                        }
                        else if (tagAtual == "CONSULTA")
                        {
                            primeiroRes = true;
                            tagMae = tagAtual;
                        }
                        break;
                    case XmlNodeType.Text:
                        switch (tagAtual)
                        {
                            //case "IDCONSULTA":
                            //    cm += ", codficha";
                            //    pm += ", @codficha";
                            //    command.Parameters.AddWithValue("@codficha", reader.Value.ToString());
                            //    break;
                            //case "CODENTIDADE":
                            //    cm += ", CODENTIDADE";
                            //    pm += ", @CODENTIDADE";
                            //    command.Parameters.AddWithValue("@CODENTIDADE", reader.Value.ToString());
                            //    break;
                            case "CODPESSOA":
                                cm += "COD";
                                pm += "@COD";
                                command.Parameters.AddWithValue("@COD", reader.Value.ToString());
                                break;
                            //case "CHAPA":
                            //    cm += ", CHAPA";
                            //    pm += ", @CHAPA";
                            //    command.Parameters.AddWithValue("@CHAPA", reader.Value.ToString());
                            //    break;
                            case "CODMEDICO":
                                cm += ", MEDICO";
                                pm += ", @MEDICO";
                                command.Parameters.AddWithValue("@MEDICO", reader.Value.ToString());
                                break;
                            //case "CODTIPOCONSULTA":
                            //    cm += ", CODTIPOCONSULTA";
                            //    pm += ", @CODTIPOCONSULTA";
                            //    command.Parameters.AddWithValue("@CODTIPOCONSULTA", reader.Value.ToString());
                            //    break;
                            //case "CODTIPOCONSULTAESOCIAL":
                            //    cm += ", CODTIPOCONSULTAESOCIAL";
                            //    pm += ", @CODTIPOCONSULTAESOCIAL";
                            //    command.Parameters.AddWithValue("@CODTIPOCONSULTAESOCIAL", reader.Value.ToString());
                            //    break;
                            case "DATACONSULTA":
                                cm += ", DT_FICHA";
                                pm += ", @DT_FICHA";
                                command.Parameters.AddWithValue("@DT_FICHA", reader.Value.ToString());
                                break;
                            case "RISCO":
                                if (riscoaso == "")
                                {
                                    cm += ", RISCOASO";
                                    pm += ", @RISCOASO";
                                    riscoaso += reader.Value.ToString();
                                }
                                else
                                {
                                    riscoaso += "," + reader.Value.ToString();
                                }
                                break;
                            case "OBSERVACAO":
                                if (tagMae == "CONSULTA")
                                {
                                    cm += ", OBS1";
                                    pm += ", @OBS1";
                                    command.Parameters.AddWithValue("@OBS1", reader.Value.ToString());
                                    
                                }
                                else
                                {
                                    cm += ", OBS";
                                    pm += ", @OBS";
                                    command.Parameters.AddWithValue("@OBS", reader.Value.ToString());
                                }
                                break;
                            //------------------------------[tblResultado]---------------------------
                            //case "CODCONSULTA": // tblResultado
                            //    if (reader.Value != null && reader.Value != "")
                            //    {
                            //        idConsulta = int.Parse(reader.Value);
                            //    }
                            //    break;
                            case "EXAME":
                                if (primeiroRes)
                                {
                                    infra._tipoId = "codficha";
                                    idConsulta = ExecCmd("ficha");
                                    primeiroRes = false;
                                }
                                cm += "EXAME";
                                pm += "@EXAME";
                                command.Parameters.AddWithValue("@EXAME", reader.Value.ToString());
                                break;
                            case "TIPOEXAME":
                                cm += ", TP_EXAME";
                                pm += ", @TP_EXAME";
                                command.Parameters.AddWithValue("@TP_EXAME", reader.Value.ToString());
                                break;
                            //case "CID": //tblFicha
                            //    cm += ", CD_CID";
                            //    pm += ", @CD_CID";
                            //    command.Parameters.AddWithValue("@CD_CID", reader.Value.ToString());
                            //    break;
                            case "DATAEXAME":
                                cm += ", DATA";
                                pm += ", @DATA";
                                command.Parameters.AddWithValue("@DATA", reader.Value.ToString());
                                break;
                            case "EXAMEREFERENCIAL":
                                cm += ", REFE";
                                pm += ", @REFE";
                                command.Parameters.AddWithValue("@REFE", reader.Value.ToString());
                                break;
                            case "ATIVOOCUPACIONAL": //0 E 1
                                cm += ", OCUP";
                                pm += ", @OCUP";
                                command.Parameters.AddWithValue("@OCUP", reader.Value.ToString());
                                break;
                            case "ALTERADO":
                                cm += ", ALTERADO";
                                pm += ", @ALTERADO";
                                command.Parameters.AddWithValue("@ALTERADO", reader.Value.ToString());
                                break;
                            //case "TIPOANORMALIDADE":
                            //    cm += ", TIPOANORMALIDADE";
                            //    pm += ", @TIPOANORMALIDADE";
                            //    command.Parameters.AddWithValue("@TIPOANORMALIDADE", reader.Value.ToString());
                            //    break;

                            //case "DESCANORMAL":
                            //    cm += ", DESCANORMAL";
                            //    pm += ", @DESCANORMAL";
                            //    command.Parameters.AddWithValue("@DESCANORMAL", reader.Value.ToString());
                            //    break;
                            //case "INTERPREXM":
                            //    cm += ", INTERPREXM";
                            //    pm += ", @INTERPREXM";
                            //    command.Parameters.AddWithValue("@INTERPREXM", reader.Value.ToString());
                            //    break;
                            case "APTO":
                                if (tagMae == "CONSULTA")
                                {
                                    cm += ", PARASO";
                                    pm += ", @PARASO";
                                    command.Parameters.AddWithValue("@PARASO", reader.Value.ToString());
                                }
                                else
                                {
                                    cm += ", ALTERADO";
                                    pm += ", @ALTERADO";
                                    command.Parameters.AddWithValue("@ALTERADO", reader.Value.ToString());
                                }
                                break;
                                //case "CAMPOTEXTOLONGO":
                                //    cm += ", CAMPOTEXTOLONGO";
                                //    pm += ", @CAMPOTEXTOLONGO";
                                //    command.Parameters.AddWithValue("@CAMPOTEXTOLONGO", reader.Value.ToString());
                                //    break;
                                //case "CAMPONUMERICO":
                                //    cm += ", CAMPONUMERICO";
                                //    pm += ", @CAMPONUMERICO";
                                //    command.Parameters.AddWithValue("@CAMPONUMERICO", reader.Value.ToString());
                                //    break;
                                //case "CAMPOTEXTO":
                                //    cm += ", CAMPOTEXTO";
                                //    pm += ", @CAMPOTEXTO";
                                //    command.Parameters.AddWithValue("@CAMPOTEXTO", reader.Value.ToString());
                                //    break;
                                //case "CAMPOTABDINAM":
                                //    cm += ", CAMPOTABDINAM";
                                //    pm += ", @CAMPOTABDINAM";
                                //    command.Parameters.AddWithValue("@CAMPOTABDINAM", reader.Value.ToString());
                                //    break;
                        }

                        break;

                    case XmlNodeType.EndElement:
                        tagAtual = reader.Name;
                        switch (tagAtual)
                        {
                            case "CONSULTA":
                                if (idConsulta == 0)
                                {
                                    ExecCmd("ficha");
                                    idConsulta = 0;
                                }
                                idConsulta = 0;
                                break;
                            case "RESULTADO":
                                if (idConsulta > 0)
                                {
                                    command.Parameters.AddWithValue("@codficha", idConsulta);
                                    this.cm += ", codficha";
                                    this.pm += ", @codficha";
                                    ExecCmd("resultado");
                                }
                                break;
                            case "RISCOASO":
                                this.command.Parameters.AddWithValue("@RISCOASO", riscoaso);
                                riscoaso = "";
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

        private int ExecCmd(string classe)
        {
            infra.command = this.command;
            infra.cm = this.cm;
            infra.pm = this.pm;
            infra.classe = classe;
            var ret = infra.ExecInsert();
            infra.ConfiguraCmdTxt();
            this.cm = infra.cm;
            this.pm = infra.pm;
            this.command = infra.command;
            return ret;
        }
    }
}