﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCap.Dominio.Entidades.dtos
{
    public class FuncionarioNovoDto
    {
        public int CodFuncionario { get; set; }
        public string NomeBase { get; set; }
        public string ApelidoBase { get; set; }
        public bool Ativo { get; set; }
    }
}
