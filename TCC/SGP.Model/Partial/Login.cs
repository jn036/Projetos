using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGP.Model
{
    public class Login
    {
        [DisplayName("Login")]
        public string Usuario { get; set; }

        [DisplayName("Senha")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }
    }
}
