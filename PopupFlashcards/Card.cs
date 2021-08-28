namespace PopupFlashcards
{
	public class Card
	{
		public string Set { get; set; }
		public string Word { get; set; }
		public string Kanji { get; set; }
		public string Meaning { get; set; }

		public string GetAnswer()
		{
			if (Meaning.Contains("("))
			{
				string splitAnswer;
				if (Meaning.Split('(')[0] != "")
					splitAnswer = Meaning.Split('(')[0].Trim();
				else
					splitAnswer = Meaning.Split(')')[1].Trim();

				return splitAnswer;
			}
			else
				return Meaning;
		}

		public string[] GetAnswers()
		{
			string aloneAnswer;
			string[] splitAnswer;

			if (Meaning.Contains("("))
			{
				if (Meaning.Split('(')[0] != "")
					aloneAnswer = Meaning.Split('(')[0].Trim();
				else
					aloneAnswer = Meaning.Split(')')[1].Trim();
			}
			else
				aloneAnswer = Meaning;

			splitAnswer = aloneAnswer.Split('/');
			for (int i = 0; i < splitAnswer.Length; i++)
				splitAnswer[i] = splitAnswer[i].Trim();

			return splitAnswer;
		}

		public string GetAnswerNote()
		{
			if (Meaning.Contains("("))
				return Meaning.Split('(', ')')[1];
			else
				return "";
		}
	}
}
