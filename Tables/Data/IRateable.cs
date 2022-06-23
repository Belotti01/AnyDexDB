namespace AnyDexDB.Tables.Data {
	public interface IRateable<TSelf, TRaing> 
		where TSelf : IIdentifiable<int> 
		where TRaing : RatingBase<TSelf> {
		
		// Gets overridden internally by EF Core
		public virtual ICollection<TRaing> Ratings { 
			get => throw new NotImplementedException(); 
			set => throw new NotImplementedException(); 
		}
	}
}
