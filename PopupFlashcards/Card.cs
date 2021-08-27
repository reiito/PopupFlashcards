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
				return Meaning.Split('(')[0];
			else
				return Meaning;
		}

		public string[] GetAnswers()
		{
			string aloneAnswer;
			string[] splitAnswer;

			if (Meaning.Contains("("))
				aloneAnswer = Meaning.Split('(')[0];
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
				return Meaning.Split('(')[1].Replace(")", "");
			else
				return "";
		}
	}
}
