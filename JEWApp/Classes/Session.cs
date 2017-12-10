using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace JEWApp
{
    public static class Session
    {
        public static bool sesionIniciada;
        public static int empleadoId;
        public static string empleadoEmail;
        public static DataTable empleadoPermisos;
    }
}
