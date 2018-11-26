using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;

namespace EffectsViewModel.Herramientas
{
    public class ConexionBaseDatos
    {
        private  static string conexionStrSql;
        public ConexionBaseDatos() { }
        public ConexionBaseDatos(string cadenacnx) => conexionStrSql = cadenacnx;

        public static string  ConexionStrSql { get => conexionStrSql; set => conexionStrSql = value; }

        public SQLiteConnection Abreconexion()
        {
            try
            {
                
                SQLiteConnectionStringBuilder sqlite_strcnx = new SQLiteConnectionStringBuilder();
                sqlite_strcnx.DataSource = conexionStrSql;

                SQLiteConnection sqlite_cnx = new SQLiteConnection(sqlite_strcnx.ConnectionString, false);
                if (sqlite_cnx.State != System.Data.ConnectionState.Open)
                {
                    sqlite_cnx.Open();
                    return sqlite_cnx;
                }
                else { return null; }
            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message);
                return null;
            }
        }

    }
}
