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
		public string CurrentLesson { get; set; }
		public decimal Frequency { get; set; }
		public string VocabList { get; set; }
		public bool KanjiOnly { get; set; }

		public int GetPopupTimeInMilliseconds()
		{
			return PopupTime * 60000;
		}

		public Settings()
		{
		}

		public Settings(int time, string currLess, decimal freq, string vocab, bool kanji)
		{
			PopupTime = time;
			CurrentLesson = currLess;
			Frequency = freq;
			VocabList = vocab;
			KanjiOnly = kanji;
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
				CurrentLesson = settings.CurrentLesson;
				Frequency = settings.Frequency;
				VocabList = settings.VocabList;
				KanjiOnly = Convert.ToBoolean(settings.KanjiOnly);
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
