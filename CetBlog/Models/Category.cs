using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CetBlog.Models
{
	public class Category
	{
		public int id { get; set; }
		[Required]
		[StringLength(50)]
		public string name { get; set; }
		public virtual IList<Post> posts { get; set; }

		
	}

	public class Post
	{
		public int Id { get; set; }
		[Required]
		[StringLength(250, MinimumLength = 3)]

		public string Title { get; set; }
			[Required]

			public string Content { get; set; }


		public string ImageUr1 { get; set; }
		public int CategoryId { get; set; }
		public virtual Category category { get; set; }
		public virtual IList<Comment> posts { get; }
	}
	public class Comment
	{
		public int Id { get; set; }
		[Required]
		[StringLength(250)]
		public string UserFullName { get; set; }
		[Required]
		[StringLength(1000)]

		public string Content { get; set; }
		public DateTime CreateDate { get; set; }
		public int PostId { get; set; }
		public virtual Post Post { get; set; }

		public int? ParentCommentId {get; set;}
		[ForeignKey("ParentCommentId")]
		public Comment ParentComment { get; set; }
	}

}
