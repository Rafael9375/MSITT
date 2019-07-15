using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Web;

namespace WBMedgest
{
    public class InfraDados<T> : ParametroPadrao where T : class
    {
        internal string _tipoId { get; set; }
        public string classe { get; set; }
        
        public InfraDados(SqlConnection _con)
        {
            this.classe = typeof(T).Name;
            //this.classe = this.classe.Replace(this.classe[0].ToString(), this.classe[0].ToString().ToLower());
            this.con = _con;
            this._tipoId = "";
        }
        internal void ConfiguraCmdTxt()
        {
            this.cm = "(";
            this.pm = "values(";
            this._tipoId = "";
            this.command = new SqlCommand("");
        }

        public int ExecInsert()
        {
            var num = 0;
            if (this.emp != "" && this.emp != null)
            {
                this.cm += ", EMP";
                this.pm += ", @EMP";
                command.Parameters.AddWithValue("@EMP", this.emp);
            }
            this.cm += ") ";
            this.pm += ")";
            var _cm = "insert into " + this.classe + cm;
            if (_tipoId != "")
            {
                _cm += "output inserted." + _tipoId + " ";
            }
            command.Connection = this.con;
            command.CommandText = _cm + pm;
            this.con.Open();
            if (_tipoId != "")
            {
                num = (int)command.ExecuteScalar();
            }
            else
            {
                command.ExecuteNonQuery();
            }
            this.con.Close();
            return num;
        }
    }
}