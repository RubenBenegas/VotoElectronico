using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Reglas
{
   public class AdministradorMapper: BaseMapper<Administrador>
    {
        public Administrador ObtenerPorContraseña(string contraseña)
        {


            //ObtenerTodas().FirstOrDefault(v => v.Documento == documento);

            foreach (var admin in ObtenerTodas())
            {
                if (admin.Contraseña == contraseña)
                {
                    return admin;
                }

            }

            return null;


        }
    }
}
