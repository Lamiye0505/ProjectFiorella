namespace LoginPage2.Entities
{
	public class FlowerExpert
	{
		public int Id { get; set; }
        public string Name { get; set; }
		public string Surname { get; set; }
		public string Job { get; set; }
        public DateTime CreatedAt { get; set; }
		public DateTime? ModifiedAt { get; set; }
		public bool IsDeleted { get; set; }
	}
}

