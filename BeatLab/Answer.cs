//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BeatLab
{
    using System;
    using System.Collections.Generic;
    
    public partial class Answer
    {
        public int Id { get; set; }
        public int OptionId { get; set; }
        public int UserId { get; set; }
    
        public virtual Option Option { get; set; }
    }
}
