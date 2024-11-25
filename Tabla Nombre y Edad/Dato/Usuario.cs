using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tabla_Nombre_y_Edad.Modelo;

namespace Tabla_Nombre_y_Edad.Dato
{
    public class Usuario
    {
        List<UsuarioModel> lista = new List <UsuarioModel>();
        public void Guardar(UsuarioModel modelo)
        {
            lista.Add(modelo);
        } 
        public List<UsuarioModel> Consultar()
        {
            return lista;
        }
    }
}
