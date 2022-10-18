using SGP.Model;
using SGP.Model.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGP.Control
{
    public class CUsuario : IDisposable
    {
        RepositoryUsuario _Repository;

        public CUsuario()
        {
            _Repository = new RepositoryUsuario();
        }

        public void Incluir(USUARIO oUsuario)
        {
            _Repository.Incluir(oUsuario);
        }


        public USUARIO UltimoUsuario()
        {
            return _Repository.UltimoUsuario();
        }

        public void Dispose()
        {
            _Repository.Dispose();
        }

    }
}
