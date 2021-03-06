using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site01.Models
{
    public class Palavra
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public byte Nivel { get; set; } //1 - fácil, 2 - Médio, 3 - Dificil
    }
}
