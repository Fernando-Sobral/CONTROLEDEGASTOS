using CONTROLEDEGASTOS_V2.Controllers;
using CONTROLEDEGASTOS_V2.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLEDEGASTOS_V2.Models
{
    public class LancModel
    {
        public static int Inserir(Lancamentos obj)
        {
            return new LancController().Inserir(obj);
        }
        public static int Editar(Lancamentos obj)
        {
            return new LancController().Editar(obj);
        }
        public static int Deletar(Lancamentos obj)
        {
            return new LancController().Deletar(obj);
        }
        public List<Lancamentos> Buscar(Lancamentos obj)
        {
            return new LancController().Buscar(obj);
        }
        public List<Lancamentos> BuscarTipo(Lancamentos obj)
        {
            return new LancController().Buscar(obj);
        }
        public List<Lancamentos> BuscarDataTipoEntrada(Lancamentos obj)
        {
            return new LancController().BuscarDataTipoEntrada(obj);
        }
        public List<Lancamentos> BuscarDataTipoSaida(Lancamentos obj)
        {
            return new LancController().BuscarDataTipoSaida(obj);
        }
        public List<Lancamentos> Listar()
        {
            return new LancController().Listar();
        }
       
    }
}
