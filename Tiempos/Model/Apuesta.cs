using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Tiempos.Model
{
    class Apuesta : DBAccess.ErrorHandler
    {
        public int id { get; set; }
        public double monto { get; set; }
        public int numero { get; set; }
        public DateTime fecha { get; set; }

        public Apuesta()
        {

        }

        public Apuesta(int id, double monto, int numero, DateTime fecha)
        {
            this.id = id;
            this.monto = monto;
            this.numero = numero;
            this.fecha = fecha;
        }

        public DataTable Select(int id, double monto, int numero, DateTime fecha)
        {
            Dictionary<double, object> parametros = new Dictionary<double, object>();
            StringBuilder sql_builder = new StringBuilder();

            string sql = "select * from apuesta";
            if (parametros.Count > 0)
            {

                sql += "where " + sql_builder.ToString();
            }

            DataTable result = Program.da.SqlQuery(sql, parametros);
            if (Program.da.isError)
            {
                this.isError = true;
                this.errorDescription = Program.da.errorDescription;
            }
            return result;
        }

    }
}
