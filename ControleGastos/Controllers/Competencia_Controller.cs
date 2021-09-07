using ControleGastos.Entidades;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using NpgsqlTypes;

namespace ControleGastos.Controllers
{
    public class Competencia_Controller
    {
        public int Inserir(Competencias obj)
        {
            using (NpgsqlConnection con = new NpgsqlConnection())
            {
                con.ConnectionString = "database = gastos; server = 127.0.0.1; port = 5432; uid = postgres; pwd=postgres;";

                NpgsqlCommand cn = con.CreateCommand();

                cn.CommandType  =   CommandType.Text;
                
                con.Open();

                cn.CommandText = "INSERT INTO dbo.competencias (descr_competencia) VALUES (@descr_competencia)";
                cn.Parameters.Add("descr_competencia", NpgsqlDbType.Varchar).Value = obj.Get_Descr_Competencia();
                cn.Connection = con;                

                int result = cn.ExecuteNonQuery();
                con.Close();
                return result;
            }
        }

        public int Editar(Competencias obj)
        {
            using (NpgsqlConnection con = new NpgsqlConnection())
            {
                con.ConnectionString = "database = gastos; server = 127.0.0.1; port = 5432; uid = postgres; pwd=postgres;";

                NpgsqlCommand cn = con.CreateCommand();

                cn.CommandType = CommandType.Text;

                con.Open();

                cn.CommandText = "UPDATE dbo.competencias SET descr_competencia = @descr_competencia WHERE id_competencia = @id_competencia";
                cn.Parameters.Add("descr_competencia", NpgsqlDbType.Varchar).Value = obj.Get_Descr_Competencia();
                cn.Parameters.Add("id_competencia", NpgsqlDbType.Integer).Value = obj.Get_Id_Competencia();
                cn.Connection = con;

                int result = cn.ExecuteNonQuery();
                con.Close();
                return result;
            }
        }

        public int Deletar(Competencias obj)
        {
            using (NpgsqlConnection con = new NpgsqlConnection())
            {
                con.ConnectionString = "database = gastos; server = 127.0.0.1; port = 5432; uid = postgres; pwd=postgres;";

                NpgsqlCommand cn = con.CreateCommand();

                cn.CommandType = CommandType.Text;

                con.Open();

                cn.CommandText = "DELETE FROM dbo.competencias WHERE id_competencia = @id_competencia AND descr_competencia = @descr_competencia";
                cn.Parameters.Add("descr_competencia", NpgsqlDbType.Varchar).Value = obj.Get_Descr_Competencia();
                cn.Parameters.Add("id_competencia", NpgsqlDbType.Integer).Value = obj.Get_Id_Competencia();
                cn.Connection = con;

                int result = cn.ExecuteNonQuery();
                con.Close();
                return result;
            }
        }

        public List<Competencias> Buscar(Competencias obj)
        {
            using (NpgsqlConnection con = new NpgsqlConnection())
            {
                con.ConnectionString = "database = gastos; server = 127.0.0.1; port = 5432; uid = postgres; pwd=postgres;";
                NpgsqlCommand cn = con.CreateCommand();
                cn.CommandType = CommandType.Text;
                con.Open();


                cn.CommandText = $"SELECT id_competencia, descr_competencia FROM dbo.competencias WHERE descr_competencia ilike \'{obj.Get_Descr_Competencia()}%\'";                
                cn.Connection = con;

                NpgsqlDataReader dr = cn.ExecuteReader();
                
                List<Competencias> lista = new List<Competencias>();
                

                
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Competencias dado = new Competencias();
                        dado.Set_Id_Competencia(Convert.ToInt32(dr["id_competencia"]));
                        dado.Set_Descr_Competencia(Convert.ToString(dr["descr_competencia"]));
                        lista.Add(dado);
                    }                    
                }

                con.Close();
                return lista;
            }
        }


        public List<Competencias> Listar()
        {
            using (NpgsqlConnection con = new NpgsqlConnection())
            {
                con.ConnectionString = "database = gastos; server = 127.0.0.1; port = 5432; uid = postgres; pwd=postgres;";                
                con.Open();

                NpgsqlCommand cn = con.CreateCommand();
                cn.CommandType = CommandType.Text;                
                cn.CommandText = "SELECT id_competencia, descr_competencia FROM dbo.competencias ORDER BY id_competencia";
                cn.Connection = con;

                NpgsqlDataReader dr = cn.ExecuteReader();

                List<Competencias> lista = new List<Competencias>();

                if (dr.HasRows)
                {                    
                    while (dr.Read())
                    {
                        Competencias dado = new Competencias();
                        dado.Set_Id_Competencia(Convert.ToInt32(dr["id_competencia"]));
                        dado.Set_Descr_Competencia(Convert.ToString(dr["descr_competencia"]));
                        lista.Add(dado);
                    }
                }
                return lista;
            }
        }        
    }
}
