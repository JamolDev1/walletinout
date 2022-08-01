using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace walletinout.Models
{
	public class CategoryModel
	{
		public int Id { get; set; }
        
		[Required]
		[Remote("IsUnique", "Home")]
		public string Name { get; set; }
	}
}
