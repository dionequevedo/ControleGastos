using ControleGastos.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleGastos.Entidades
{
    class Lancamentos
    {
        private int _id_lancamento;
        private string _tipo;
        private string _descricao;
        private decimal _valor;
        private int _id_competencia;
        private Status _status;

        public Lancamentos(int id_lancamento, string tipo, string descricao, decimal valor, int id_competencia)
        {
            _id_lancamento = id_lancamento;
            _tipo = tipo;
            _descricao = descricao;
            _valor = valor;
            _id_competencia = id_competencia;
            Status = Status.Ativo;
        }

        public Lancamentos()
        {

        }

        public string Tipo { get => _tipo; set => _tipo = value; }
        public string Descricao { get => _descricao; set => _descricao = value; }
        public int Id_lancamento { get => _id_lancamento; set => _id_lancamento = value; }
        public decimal Valor { get => _valor; set => _valor = value; }
        public int Id_competencia { get => _id_competencia; set => _id_competencia = value; }
        public Status Status { get => _status; set => _status = value; }
    }
}
