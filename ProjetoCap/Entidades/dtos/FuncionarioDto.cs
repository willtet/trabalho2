using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoCap.Dominio.Interfaces;

namespace ProjetoCap.Dominio.Entidades.dtos
{
    public class FuncionarioDto
    {

        public int CodFuncionario { get; set; }
        public string NomeD { get; set; }
        public string ApelidoD { get; set; }
        public string RegimeD { get; set; }
        public string TipoD { get; set; }
        public string CargaHorariaD { get; set; }
        public decimal SalarioD { get; set; }
    }
}
