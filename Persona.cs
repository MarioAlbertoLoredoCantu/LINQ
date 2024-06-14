using System.Diagnostics;

namespace LINQ2
{
    [DebuggerDisplay("{Nombre}")]
    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad {get; set; }
        public bool Soltero { get; set; }
        public DateTime FechaIngresoAlaEmpresa { get; set; }
        public List<string> Telefono = new List<string>();

        public int EmpresaId { get; set; }
        
    }
}