using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMark2.Model
{
    public class DATA
    {
        public static ClassMarkEntities getContexto()
        {
            ClassMarkEntities odb = new ClassMarkEntities();
            odb.Configuration.ProxyCreationEnabled = false;
            return odb;
        }
    }
}
