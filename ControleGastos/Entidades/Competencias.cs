using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleGastos.Entidades
{
    public class Competencias
    {
        private int _id_competencia;
        private string _descr_competencia;


        public int Get_Id_Competencia()
        {
            return _id_competencia;
        }

        public void Set_Id_Competencia(int value)
        {
            this._id_competencia = value;
        }

        public string Get_Descr_Competencia()
        {
            return _descr_competencia;
        }

        public void Set_Descr_Competencia(string value)
        {
            this._descr_competencia = value;
        }
    }
}
