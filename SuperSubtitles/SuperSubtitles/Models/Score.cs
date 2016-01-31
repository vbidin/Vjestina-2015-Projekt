using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SuperSubtitles.Models
{
	public class Score
	{
		public int ScoreId { get; set; }
		public int UserId { get; set; }
		public int SubtitleId { get; set; }
		public int Value { get; set; } // -1, 0, or 1
	}
}