//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Projeto
{
    using System;
    using System.Collections.Generic;
    
    public partial class Jornada
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Jornada()
        {
            this.Funcionario = new HashSet<Funcionario>();
        }
    
        public int Id { get; set; }
        public string descricao { get; set; }
        public string entrada1 { get; set; }
        public string saida1 { get; set; }
        public string entrada2 { get; set; }
        public string saida2 { get; set; }
        public Nullable<int> segundaFeira { get; set; }
        public Nullable<int> tercaFeira { get; set; }
        public Nullable<int> quartaFeira { get; set; }
        public Nullable<int> quintaFeira { get; set; }
        public Nullable<int> sextaFeira { get; set; }
        public Nullable<int> sabado { get; set; }
        public Nullable<int> domingo { get; set; }
        public Nullable<int> indeterminado { get; set; }
        public string totalJornada { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Funcionario> Funcionario { get; set; }
    }
}
