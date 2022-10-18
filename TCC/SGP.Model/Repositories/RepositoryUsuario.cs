using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGP.Model.Repositories
{
    public class RepositoryUsuario : IDisposable
    {
        private UsinaEntities odb;
        private bool LiberaContexto = false;
        //private bool attach = false;

        // Repositorio padrão
        public RepositoryUsuario()
        {
            odb = SGP.Model.Data.getContexto();
            LiberaContexto = true;
        }

        public RepositoryUsuario(UsinaEntities obd)
        {
            obd = odb;
        }

        public USUARIO UltimoUsuario()
        {
            List<USUARIO> Usuarios = odb.USUARIO.OrderBy(p => p.ID).ToList();
            return Usuarios.Last();
        }

        public void Incluir(USUARIO oUsuario)
        {
            odb.USUARIO.Add(oUsuario);
            odb.SaveChanges();
        }

        public void Dispose()
        {
            if (LiberaContexto)
            {
                odb.Dispose();
            }
        }
    }
}
