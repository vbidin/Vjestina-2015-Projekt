using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SuperSubtitles.Models
{
	public class Subtitle
	{
		public int SubtitleId { get; set; }

		public string AuthorId { get; set; }

		[Required]
		public string Name { get; set; }

		[Required]
		public string Movie { get; set; }

		public string Date { get; set; }

		public byte[] File { get; set; }
	}

	public class SubtitleSearchModel
	{
		public string Movie { get; set; }
	}
}