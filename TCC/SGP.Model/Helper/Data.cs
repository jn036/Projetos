using SGP.Model.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGP.Model
{
    class Data
    {
        public static UsinaEntities getContexto()
        {
            UsinaEntities odb = new UsinaEntities(); // instancia a conexão com o Banco de dados
            odb.Configuration.ProxyCreationEnabled = false; // desabilita o proxy
            return odb; // retorna a conexão com Banco de Dados
        }
    }
}
