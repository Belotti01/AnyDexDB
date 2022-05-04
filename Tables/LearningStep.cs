using System;
using System.Collections.Generic;

namespace AnyDexDB.Tables
{
    public partial class LearningStep
    {
        public ulong Id { get; set; }
        public ulong LearningPathId { get; set; }
        public ulong ResourceId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public virtual LearningPath LearningPath { get; set; }
        public virtual Resource Resource { get; set; }
    }
}
