using System;
using System.Collections.Generic;

namespace AnyDexDB.Tables
{
    public partial class MaterialLink
    {
        public ulong Id { get; set; }
        public ulong MaterialId { get; set; }
        public string Link { get; set; }
        public string Description { get; set; }
        public DateTime? ReleaseDate { get; set; }

        public virtual Material Material { get; set; }
    }
}
