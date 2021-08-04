using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace Thales
{
    public class DataBaseConnection
    {
        private static SQLiteConnection sqliteConnection;

        public DataBaseConnection()
        { }

        public static SQLiteConnection DbConnection()
        {
            sqliteConnection = new SQLiteConnection("Data Source = c:\\teste\\acme.sqlite; Version = 3;");
            sqliteConnection.Open();
            return sqliteConnection;
        }

        public static void CriarTabela()
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS TB_VOO(ID_VOO INTEGER NOT NULL PRIMARY KEY, DATA_VOO DATETIME, CUSTO NUMERIC(10,2), DISTANCIA INT, CAPTURA CHAR(1), NIVEL_DOR INT)";
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable Get()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT ID_VOO, strftime('%d-%m-%Y',DATA_VOO), CAPTURA, NIVEL_DOR FROM TB_VOO";
                    da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable GetVOO(int ID_VOO)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT strftime('%d-%m-%Y',DATA_VOO), CUSTO,DISTANCIA, CAPTURA, NIVEL_DOR FROM TB_VOO WHERE ID_VOO =" + ID_VOO;
                    da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Add(VOO tb_VOO)
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO TB_VOO(DATA_VOO, CUSTO, DISTANCIA, CAPTURA, NIVEL_DOR) VALUES (@DATA_VOO, @CUSTO, @DISTANCIA, @CAPTURA, @NIVEL_DOR)";
                    cmd.Parameters.AddWithValue("@DATA_VOO", tb_VOO.DATA_VOO);
                    cmd.Parameters.AddWithValue("@CUSTO", tb_VOO.CUSTO);
                    cmd.Parameters.AddWithValue("@DISTANCIA", tb_VOO.DISTANCIA);
                    cmd.Parameters.AddWithValue("@CAPTURA", tb_VOO.CAPTURA.ToString());
                    cmd.Parameters.AddWithValue("@NIVEL_DOR", tb_VOO.NIVEL_DOR);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Update(VOO tb_VOO)
        {
            try
            {
                using (var cmd = new SQLiteCommand(DbConnection()))
                {
                        cmd.CommandText = "UPDATE TB_VOO SET DATA_VOO = @DATA_VOO, CUSTO = @CUSTO, DISTANCIA = @DISTANCIA, CAPTURA = @CAPTURA, NIVEL_DOR = @NIVEL_DOR WHERE ID_VOO = @ID_VOO";
                        cmd.Parameters.AddWithValue("@ID_VOO", tb_VOO.ID_VOO);
                        cmd.Parameters.AddWithValue("@DATA_VOO", tb_VOO.DATA_VOO);
                        cmd.Parameters.AddWithValue("@CUSTO", tb_VOO.CUSTO);
                        cmd.Parameters.AddWithValue("@DISTANCIA", tb_VOO.DISTANCIA);
                        cmd.Parameters.AddWithValue("@CAPTURA", tb_VOO.CAPTURA.ToString());
                        cmd.Parameters.AddWithValue("@NIVEL_DOR", tb_VOO.NIVEL_DOR);
                        cmd.ExecuteNonQuery();
                };
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Delete(int ID_VOO)
        {
            try
            {
                using (var cmd = new SQLiteCommand(DbConnection()))
                {
                    cmd.CommandText = "DELETE FROM TB_VOO Where ID_VOO=@ID_VOO";
                    cmd.Parameters.AddWithValue("@ID_VOO", ID_VOO);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
