using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetCore.Models
{
    public class EmpleadosDatos
    {
        public List<string> empleados { get; set; }
        public int suma { get; set; }
        public int media { get; set; }
        public int personas { get; set; }
    }
}
