//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Telecom_Neva_Svyaz
{
    using System;
    using System.Collections.Generic;
    
    public partial class Passport
    {
        public int ID_passport { get; set; }
        public int ID_subscriber { get; set; }
        public int Passport_Series { get; set; }
        public int Passport_number { get; set; }
        public System.DateTime Issue_date { get; set; }
        public string Issued_by { get; set; }
    
        public virtual Subscriber Subscriber { get; set; }
    }
}
