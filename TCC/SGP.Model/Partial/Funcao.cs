using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Supervisorio.Model
{
    [MetadataType(typeof(MD_FUNCAO))]
    public partial class FUNCAO
    {
        internal class MD_FUNCAO
        {
            [DisplayName("ID")]
            public object ID { get; set; }
            [DisplayName("Função")]
            public object Nome { get; set; }
        }
    }
}
