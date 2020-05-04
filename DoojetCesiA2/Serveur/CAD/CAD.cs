using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoojetCesiA2
{
    public class CAD
    {
        private string cnxString;
        private string req_sql;
        private System.Data.SqlClient.SqlDataAdapter oDa;
        private System.Data.SqlClient.SqlConnection oCnx;
        private System.Data.SqlClient.SqlCommand oCmd;
        private System.Data.DataSet ods;

        public CAD()
        {
            this.req_sql = "RIEN";
            this.cnxString = @"Data Source=192.168.159.130;Initial Catalog=Projet.NET;User ID=CNX_USER;Password=cesi";
            this.oCnx = new System.Data.SqlClient.SqlConnection(cnxString);
            this.oCmd = new System.Data.SqlClient.SqlCommand(req_sql, oCnx);
            this.oDa = new System.Data.SqlClient.SqlDataAdapter(oCmd);


        }

        public System.Data.DataSet getRows(string rq_sql, string rowsName)
        {
            this.ods = new System.Data.DataSet();
            this.req_sql = rq_sql;
            this.oCmd.CommandType = System.Data.CommandType.Text;
            this.oCmd.CommandText = this.req_sql;
            this.oDa.Fill(this.ods, rowsName);

            return this.ods;
        }
    }
}
