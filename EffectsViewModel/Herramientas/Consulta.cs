using System;
using System.Diagnostics;
using System.Data;
using System.Data.SQLite;


namespace EffectsViewModel.Herramientas
{
    public class Consulta:ConexionBaseDatos
    {
        
        public DataTable cargaConsulta(string select)
        {
            DataTable dt = new DataTable();
            try
            {
                SQLiteConnection sqlite_cnx = Abreconexion();
                if (sqlite_cnx.State != ConnectionState.Open)
                    sqlite_cnx.Open();
                SQLiteCommand sql_cmd = sqlite_cnx.CreateCommand();
                sql_cmd.CommandText = select;
                SQLiteDataAdapter sda = new SQLiteDataAdapter(sql_cmd);
                sda.Fill(dt);
                sda.Dispose();
                sql_cmd.Connection.Close();
            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message);
            }
            return dt;
        }

    }
}
