using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopupFlashcards
{
	class Card
	{
		public string Kanji { get; set; }
		public string Hiragana { get; set; }
		public string Romanji { get; set; }
		public string English { get; set; }
		public string HardHint { get; set; }
		public string EasyHint { get; set; }
		public string Type { get; set; }
	}
}
