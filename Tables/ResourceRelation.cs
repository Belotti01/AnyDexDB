using System;
using System.Collections.Generic;

namespace AnyDexDB.Tables
{
    public partial class ResourceRelation
    {
        [Column("id"), Display(Name = "Id", ResourceType = typeof(Localization))]
        [Key]
        public ulong Id { get; set; }
        [Column("type"), Display(Name = "Type", ResourceType = typeof(Localization))]
        public byte Type { get; set; }
        [Column("resource_id"), Display(Name = "Resource Id", ResourceType = typeof(Localization))]
        [ForeignKey("resource")]
        public ulong ResourceId { get; set; }
        [Column("related_resource_id"), Display(Name = "Related Resource Id", ResourceType = typeof(Localization))]
        [ForeignKey("resource")]
        public ulong RelatedResourceId { get; set; }

        [Display(Name = "Resource", ResourceType = typeof(Localization))]
        public virtual Resource Resource { get; set; }
        [Display(Name = "Related Resource", ResourceType = typeof(Localization))]
        public virtual Resource RelatedResource { get; set; }
    }
}
