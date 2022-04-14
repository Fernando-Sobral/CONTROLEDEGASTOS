using CONTROLEDEGASTOS_V2.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLEDEGASTOS_V2.Controllers
{
    class AnoController
    {
        public int Inserir(Anos obj)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Setting;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "INSERT INTO ano ([ano]) VALUES (@ano)";
                cn.Parameters.Add("ano", SqlDbType.Int).Value = obj.Ano;
                cn.Connection = con;

                int qtd = cn.ExecuteNonQuery();
                return qtd;

            }
        }

        public List<Anos> Buscar (Anos obj)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Setting;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "SELECT * FROM ano WHERE ano = @ano";
                cn.Parameters.Add("ano", SqlDbType.Int).Value = obj.Ano;
                cn.Connection = con;

                SqlDataReader dr;
                List<Anos> lista = new List<Anos>();
                dr = cn.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Anos dado = new Anos();
                        dado.Id_ano = Convert.ToInt32(dr["id_ano"]);
                        dado.Ano = Convert.ToInt32(dr["ano"]);
                        lista.Add(dado);
                    }
                    
                }
                return lista;
            }
        }
        public List<Anos> Listar()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Setting;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "SELECT * FROM ano";

                cn.Connection = con;

                SqlDataReader dr;
                List<Anos> lista = new List<Anos>();
                dr = cn.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Anos dado = new Anos();
                        dado.Id_ano = Convert.ToInt32(dr["id_ano"]);
                        dado.Ano = Convert.ToInt32(dr["ano"]);
                        lista.Add(dado);
                    }

                }
                return lista;
            }
        }
        public int Editar(Anos obj)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Setting;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "UPDATE ano SET ano = @ano WHERE id_ano = @id";
                cn.Parameters.Add("ano", SqlDbType.Int).Value = obj.Ano;
                cn.Parameters.Add("id", SqlDbType.Int).Value = obj.Id_ano;
                cn.Connection = con;

                int qtd = cn.ExecuteNonQuery();
                return qtd;

            }
        }
        public int Deletar(Anos obj)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Setting;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "DELETE FROM ano WHERE id_ano = @id";
                cn.Parameters.Add("id", SqlDbType.Int).Value = obj.Id_ano;
                cn.Connection = con;

                int qtd = cn.ExecuteNonQuery();
                return qtd;

            }
        }

    }
}
