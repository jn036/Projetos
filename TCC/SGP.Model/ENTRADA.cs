//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SGP.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class ENTRADA
    {
        public int ID { get; set; }
        public int IDFornecedor { get; set; }
        public int IDColaborador { get; set; }
        public string Insumo { get; set; }
        public System.DateTime DataEntrada { get; set; }
        public string NF { get; set; }
        public double QtdEntrada { get; set; }
    
        public virtual COLABORADOR COLABORADOR { get; set; }
        public virtual FORNECEDOR FORNECEDOR { get; set; }
    }
}
