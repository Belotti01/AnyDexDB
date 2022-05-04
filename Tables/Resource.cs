using System;
using System.Collections.Generic;

namespace AnyDexDB.Tables
{
    public partial class Resource
    {
        public Resource()
        {
            Bookmarks = new HashSet<Bookmark>();
            Categoryratings = new HashSet<CategoryRating>();
            Learningsteps = new HashSet<LearningStep>();
            Materials = new HashSet<Material>();
            Progresses = new HashSet<Progress>();
            Ratings = new HashSet<Rating>();
            Resourcequizzes = new HashSet<ResourceQuiz>();
            RelatedResources = new HashSet<ResourceRelation>();
            RelationResources = new HashSet<ResourceRelation>();
        }

        public ulong Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Creator { get; set; }
        public DateTime? ReleaseDate { get; set; }

        public virtual ICollection<Bookmark> Bookmarks { get; set; }
        public virtual ICollection<CategoryRating> Categoryratings { get; set; }
        public virtual ICollection<LearningStep> Learningsteps { get; set; }
        public virtual ICollection<Material> Materials { get; set; }
        public virtual ICollection<Progress> Progresses { get; set; }
        public virtual ICollection<Rating> Ratings { get; set; }
        public virtual ICollection<ResourceQuiz> Resourcequizzes { get; set; }
        public virtual ICollection<ResourceRelation> RelatedResources { get; set; }
        public virtual ICollection<ResourceRelation> RelationResources { get; set; }
    }
}
