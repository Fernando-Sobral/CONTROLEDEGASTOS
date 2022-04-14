using CONTROLEDEGASTOS_V2.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLEDEGASTOS_V2.Controllers
{
    public class LancController
    {

        public int Inserir(Lancamentos obj)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Setting;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "INSERT INTO lancamento ([tipo], [descricao],[valor],[mes],[id_ano],[dataoperaco]) VALUES (@tipo,@descricao,@valor,@mes,@id_ano,@dataoperaco)";
                cn.Parameters.Add("tipo", SqlDbType.VarChar).Value = obj.Tipo;
                cn.Parameters.Add("descricao", SqlDbType.VarChar).Value = obj.Descricao;
                cn.Parameters.Add("valor", SqlDbType.Decimal).Value = obj.Valor;
                cn.Parameters.Add("mes", SqlDbType.VarChar).Value = obj.Mes;
                cn.Parameters.Add("id_ano", SqlDbType.Int).Value = obj.Ano;
                cn.Parameters.Add("dataoperaco", SqlDbType.Date).Value = obj.Data;
                cn.Connection = con;

                int qtd = cn.ExecuteNonQuery();
                return qtd;
            }
        }
        public List<Lancamentos> Buscar(Lancamentos obj)
        {

            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Setting;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "SELECT * FROM lancamento WHERE dataoperaco = @dataoperaco";
                cn.Parameters.Add("dataoperaco", SqlDbType.DateTime).Value = DateTime.Now;
                //cn.Parameters.Add("dataoperaco", SqlDbType.DateTime).Value = obj.Data;
                cn.Connection = con;

                SqlDataReader dr;
                List<Lancamentos> lista = new List<Lancamentos>();
                dr = cn.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Lancamentos dado = new Lancamentos();
                        dado.Id_lancamentos = Convert.ToInt32(dr["id_lancamento"]);
                        dado.Tipo = Convert.ToString(dr["tipo"]);
                        dado.Descricao = Convert.ToString(dr["descricao"]);
                        dado.Valor = Convert.ToDecimal(dr["valor"]);
                        dado.Mes = Convert.ToString(dr["mes"]);
                        dado.Ano = Convert.ToInt32(dr["id_ano"]);
                        dado.Data = Convert.ToDateTime(dr["dataoperaco"]);
                        lista.Add(dado);
                    }
                }
                return lista;
            }
        }
        public List<Lancamentos> BuscarTipo(Lancamentos obj)
        {


            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Setting;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "SELECT * FROM lancamento WHERE tipo = @tipo";
                cn.Parameters.Add("tipo", SqlDbType.VarChar).Value = obj.Tipo;
                cn.Connection = con;

                SqlDataReader dr;
                List<Lancamentos> lista = new List<Lancamentos>();
                dr = cn.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Lancamentos dado = new Lancamentos();
                        dado.Id_lancamentos = Convert.ToInt32(dr["id_lancamento"]);
                        dado.Tipo = Convert.ToString(dr["tipo"]);
                        dado.Descricao = Convert.ToString(dr["descricao"]);
                        dado.Valor = Convert.ToDecimal(dr["valor"]);
                        dado.Mes = Convert.ToString(dr["mes"]);
                        dado.Ano = Convert.ToInt32(dr["id_ano"]);
                        dado.Data = Convert.ToDateTime(dr["dataoperaco"]);
                        lista.Add(dado);
                    }
                }
                return lista;
            }
        }
        public List<Lancamentos> BuscarDataTipoEntrada(Lancamentos obj)
        {

            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Setting;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "SELECT * FROM lancamento WHERE dataoperaco = @dataoperaco and tipo = @tipo";
                cn.Parameters.Add("dataoperaco", SqlDbType.DateTime).Value = DateTime.Now;
                cn.Parameters.Add("tipo", SqlDbType.VarChar).Value = "Entrada";
                cn.Connection = con;

                SqlDataReader dr;
                List<Lancamentos> lista = new List<Lancamentos>();
                dr = cn.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Lancamentos dado = new Lancamentos();
                        dado.Id_lancamentos = Convert.ToInt32(dr["id_lancamento"]);
                        dado.Tipo = Convert.ToString(dr["tipo"]);
                        dado.Descricao = Convert.ToString(dr["descricao"]);
                        dado.Valor = Convert.ToDecimal(dr["valor"]);
                        dado.Mes = Convert.ToString(dr["mes"]);
                        dado.Ano = Convert.ToInt32(dr["id_ano"]);
                        dado.Data = Convert.ToDateTime(dr["dataoperaco"]);
                        lista.Add(dado);
                    }
                }
                return lista;
            }
        }
        public List<Lancamentos> BuscarDataTipoSaida(Lancamentos obj)
        {

            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Setting;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "SELECT * FROM lancamento WHERE dataoperaco = @dataoperaco and tipo = @tipo";
                cn.Parameters.Add("dataoperaco", SqlDbType.DateTime).Value = DateTime.Now;
                cn.Parameters.Add("tipo", SqlDbType.VarChar).Value = "Saida";
                cn.Connection = con;

                SqlDataReader dr;
                List<Lancamentos> lista = new List<Lancamentos>();
                dr = cn.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Lancamentos dado = new Lancamentos();
                        dado.Id_lancamentos = Convert.ToInt32(dr["id_lancamento"]);
                        dado.Tipo = Convert.ToString(dr["tipo"]);
                        dado.Descricao = Convert.ToString(dr["descricao"]);
                        dado.Valor = Convert.ToDecimal(dr["valor"]);
                        dado.Mes = Convert.ToString(dr["mes"]);
                        dado.Ano = Convert.ToInt32(dr["id_ano"]);
                        dado.Data = Convert.ToDateTime(dr["dataoperaco"]);
                        lista.Add(dado);
                    }
                }
                return lista;
            }
        }
        public List<Lancamentos> Listar()
        {         
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Setting;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "SELECT * FROM lancamento";

                cn.Connection = con;

                SqlDataReader dr;
                List<Lancamentos> lista = new List<Lancamentos>();
                dr = cn.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Lancamentos dado = new Lancamentos();
                        dado.Id_lancamentos = Convert.ToInt32(dr["id_lancamento"]);
                        dado.Tipo = Convert.ToString(dr["tipo"]);
                        dado.Descricao = Convert.ToString(dr["descricao"]);
                        dado.Valor = Convert.ToDecimal(dr["valor"]);
                        dado.Mes = Convert.ToString(dr["mes"]);
                        dado.Ano = Convert.ToInt32(dr["id_ano"]);
                        dado.Data = Convert.ToDateTime(dr["dataoperaco"]);
                        lista.Add(dado);
                    }

                }
                return lista;
            }
        }
        public int Editar(Lancamentos obj)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Setting;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "UPDATE lancamento SET tipo = @tipo,descricao = @descricao, valor = @valor,mes = @mes,id_ano = @id_ano, dataoperaco = @dataoperaco WHERE id_lancamento = @id_lancamento";
                cn.Parameters.Add("tipo", SqlDbType.VarChar).Value = obj.Tipo;
                cn.Parameters.Add("descricao", SqlDbType.VarChar).Value = obj.Descricao;
                cn.Parameters.Add("valor", SqlDbType.Decimal).Value = obj.Valor;
                cn.Parameters.Add("mes", SqlDbType.VarChar).Value = obj.Mes;
                cn.Parameters.Add("id_ano", SqlDbType.Int).Value = obj.Ano;
                cn.Parameters.Add("data", SqlDbType.DateTime).Value = obj.Data;
                cn.Parameters.Add("id_lancamento", SqlDbType.Int).Value = obj.Id_lancamentos;
                cn.Connection = con;

                int qtd = cn.ExecuteNonQuery();
                return qtd;

            }
        }
        public int Deletar(Lancamentos obj)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Setting;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "DELETE FROM lancamento WHERE id_lancamento = @id_lancamento";
                cn.Parameters.Add("id_lancamento", SqlDbType.Int).Value = obj.Id_lancamentos;
                cn.Connection = con;

                int qtd = cn.ExecuteNonQuery();
                return qtd;

            }
        }
    }
}
