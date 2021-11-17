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
    
    public partial class Coaches
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Coaches()
        {
            this.Clubs = new HashSet<Clubs>();
        }
    
        public int ID_coach { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Middlename { get; set; }
        public int ID_place_birth { get; set; }
        public int ID_nation { get; set; }
        public Nullable<System.DateTime> Date_birth { get; set; }
        public Nullable<System.DateTime> Contract_started { get; set; }
        public Nullable<System.DateTime> Contract_date { get; set; }
        public int ID_game_layout { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Clubs> Clubs { get; set; }
        public virtual Game_layouts Game_layouts { get; set; }
        public virtual Nations Nations { get; set; }
        public virtual Place_birth Place_birth { get; set; }
    }
}
