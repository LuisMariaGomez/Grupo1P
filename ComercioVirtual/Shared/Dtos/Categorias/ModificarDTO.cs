﻿using Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Dtos.Categorias
{
    public class ModificarDTO
    {
        public string? Nombre { get; set; }
        public Estados? estado { get; set; }
    }
}
