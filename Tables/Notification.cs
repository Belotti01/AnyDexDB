using System;
using System.Collections.Generic;

namespace AnyDexDB.Tables
{
    public partial class Notification
    {
        public ulong Id { get; set; }
        public ulong UserId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }
        public DateTime Date { get; set; }

        public virtual User User { get; set; }
    }
}
