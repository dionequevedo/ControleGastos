using ControleGastos.Controllers;
using ControleGastos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleGastos.Models
{
    class CompetenciasModels
    {
        public static int Inserir(Competencias obj)
        {
            return new Competencia_Controller().Inserir(obj);
        }

        public static List<Competencias> Buscar(Competencias obj)
        {
            return new Competencia_Controller().Buscar(obj);
        }

        public List<Competencias> Listar()
        {
            return new Competencia_Controller().Listar();
        }

        public static int Editar(Competencias obj)
        {
            return new Competencia_Controller().Editar(obj);
        }

        public static int Deletar(Competencias obj)
        {
            return new Competencia_Controller().Deletar(obj);
        }
    }
}
