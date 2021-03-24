using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace PopupFlashcards
{
	public class Settings
	{
		public int PopupTime { get; set; }
		public string PracticeType { get; set; }
		public string AnswersIn { get; set; }

		public int GetPopupTimeInMilliseconds()
		{
			return PopupTime * 60000;
		}

		public void Load(string filePath)
		{
			List<Settings> loadedSettings = new List<Settings>();

			using (var reader = new StreamReader(filePath))
			using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
			{
				loadedSettings = csv.GetRecords<Settings>().ToList();
			}

			foreach (Settings settings in loadedSettings)
			{
				PopupTime = settings.PopupTime;
				PracticeType = settings.PracticeType;
				AnswersIn = settings.AnswersIn;
			}
		}

		public void Save(string filePath)
		{
			List<Settings> newSettings = new List<Settings>();

			newSettings.Add(this);

			using (var writer = new StreamWriter(filePath))
			using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
			{
				csv.WriteRecords(newSettings);
			}
		}
	}
}
