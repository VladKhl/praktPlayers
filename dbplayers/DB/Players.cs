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
    
    public partial class Players
    {
        public int ID_player { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Middlename { get; set; }
        public int ID_place_birth { get; set; }
        public Nullable<int> Height { get; set; }
        public Nullable<int> Weight { get; set; }
        public int ID_working_leg { get; set; }
        public int ID_position { get; set; }
        public Nullable<System.DateTime> Contract_date { get; set; }
        public int ID_club { get; set; }
        public Nullable<int> Goals { get; set; }
        public Nullable<int> Assists { get; set; }
        public Nullable<System.DateTime> Date_birth { get; set; }
        public Nullable<int> Play_number { get; set; }
        public Nullable<int> Cost { get; set; }
        public int ID_nation { get; set; }
        public int ID_national_team { get; set; }
        public int ID_agency { get; set; }
        public int ID_technical_sponsor { get; set; }
        public Nullable<int> Penalty_goals { get; set; }
        public Nullable<int> Yellow_card { get; set; }
        public Nullable<int> Red_card { get; set; }
        public int ID_photo { get; set; }
    
        public virtual Agency Agency { get; set; }
        public virtual Clubs Clubs { get; set; }
        public virtual National_teams National_teams { get; set; }
        public virtual Nations Nations { get; set; }
        public virtual Place_birth Place_birth { get; set; }
        public virtual Position Position { get; set; }
        public virtual Technical_sponsors Technical_sponsors { get; set; }
        public virtual Working_leg Working_leg { get; set; }
        public virtual Photos Photos { get; set; }
    }
}
