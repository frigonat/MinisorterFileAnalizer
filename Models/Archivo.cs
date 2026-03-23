using System;
using System.Collections.Generic;
using System.Text;

namespace MinisorterFileAnalizer.Models
{
    public class Archivo
    {
        public string Nombre { get; set; }
        public int Size { get; set; }
        public int CantidadDeRegistros { get; set; }
    }
}
