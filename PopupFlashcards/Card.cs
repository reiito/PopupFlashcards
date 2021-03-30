namespace PopupFlashcards
{
	public class Card
	{
		public string Japanese { get; set; }
		public string English { get; set; }
		public string Hints { get; set; }
		public string Type { get; set; }

		public string[] GetJapaneseQuestions(string difficulty)
		{
			string[] japaneseArray = Japanese.Split(';');
			switch (difficulty)
			{
				case "Easy":
					return new string[] { japaneseArray[1], japaneseArray[2] };
				case "Medium":
					return new string[] { japaneseArray[0], japaneseArray[1] };
				case "Hard":
					return new string[] { japaneseArray[0], "" };
				default:
					return japaneseArray;
			}
		}

		public string[] GetEnglishAnswers()
		{
			return English.Split(';');
		}

		public string[] GetHints()
		{
			return Hints.Split(';');
		}
	}
}
