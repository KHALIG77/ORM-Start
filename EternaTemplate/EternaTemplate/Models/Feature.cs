using System.ComponentModel.DataAnnotations;

namespace EternaTemplate.Models
{
	public class Feature
	{
		public int Id { get; set; }
		
		public string Icon {get; set; }
		[Required]
		[MaxLength(50)]
		public string Title { get; set; }

		public string Description { get; set; }
	}
}
