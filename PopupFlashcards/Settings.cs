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
		public string Difficulty { get; set; }
		public string VocabList { get; set; }
		public string PracticeType { get; set; }
		public string AnswersIn { get; set; }

		public int GetPopupTimeInMilliseconds()
		{
			return PopupTime * 60000;
		}

		public Settings()
		{
		}

		public Settings(int time, string diff, string vocab, string type, string ans)
		{
			PopupTime = time;
			Difficulty = diff;
			VocabList = vocab;
			PracticeType = type;
			AnswersIn = ans;
		}

		public void Load()
		{
			List<Settings> loadedSettings = new List<Settings>();

			using (var reader = new StreamReader(FileManager.SettingsLocation))
			using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
			{
				loadedSettings = csv.GetRecords<Settings>().ToList();
			}

			foreach (Settings settings in loadedSettings)
			{
				PopupTime = settings.PopupTime;
				Difficulty = settings.Difficulty;
				VocabList = settings.VocabList;
				PracticeType = settings.PracticeType;
				AnswersIn = settings.AnswersIn;
			}
		}

		public void Save()
		{
			List<Settings> newSettings = new List<Settings>();

			newSettings.Add(this);

			using (var writer = new StreamWriter(FileManager.SettingsLocation))
			using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
			{
				csv.WriteRecords(newSettings);
			}
		}
	}
}
