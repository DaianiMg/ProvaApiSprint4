﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPokemon.Controller.Data.Dtos
{
    public class CreatePokemon
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Tipo { get; set; }
    }
}