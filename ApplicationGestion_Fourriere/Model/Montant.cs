//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Montant
    {
        public System.DateTime Date_Montant { get; set; }
        public Nullable<double> Montant1 { get; set; }
        public string Nom_Fourriere { get; set; }
        public Nullable<int> Login_Agent { get; set; }
    
        public virtual Agent Agent { get; set; }
    }
}
