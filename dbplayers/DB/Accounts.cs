//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace dbplayers.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Accounts
    {
        public int ID_account { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public int ID_role { get; set; }
    
        public virtual Role Role { get; set; }
    }
}
