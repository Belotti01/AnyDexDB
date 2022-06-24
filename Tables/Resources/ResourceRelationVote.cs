using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnyDexDB.Tables {
	[Table("resource_relation_vote")]
	public class ResourceRelationVote : VoteBase<ResourceRelation> {
		[Required, ForeignKey("resource_relation")]
		public override int TargetId { get; set; }
	}
}
