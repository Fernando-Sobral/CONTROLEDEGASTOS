using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLEDEGASTOS_V2.Entidades
{
    public class Lancamentos
    {
        int id_lancamentos;
        string tipo;
        string descricao;
        decimal valor;
        string mes;
        int ano;
        DateTime data;
        

        public int Id_lancamentos { get => id_lancamentos; set => id_lancamentos = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public decimal Valor { get => valor; set => valor = value; }
        public string Mes { get => mes; set => mes = value; }
        public int Ano { get => ano; set => ano = value; }
        public DateTime  Data { get => data; set => data = value; }
    }
}
