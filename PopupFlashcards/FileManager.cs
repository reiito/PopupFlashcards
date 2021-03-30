using System;
using System.IO;

namespace PopupFlashcards
{
	class FileManager
	{
#if DEBUG
		static readonly string resourcesFolderPath = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\resources\\";
#else
		static readonly string resourcesFolderPath = AppContext.BaseDirectory + "resources\\";
#endif
		public static readonly string SettingsLocation = resourcesFolderPath + "settings.csv";
		public static readonly string VocabPath = resourcesFolderPath + "vocab\\";
		public static readonly string DictionaryLocation = resourcesFolderPath + "frequency_dictionary_en_82_765.txt";
		public static readonly string PopupSoundLocation = resourcesFolderPath + "notification.wav";
		public static readonly string CorrectSoundLocation = resourcesFolderPath + "correct.wav";
		public static readonly string IncorrectSoundLocation = resourcesFolderPath + "incorrect.wav";

		public static void CreateFolders()
		{
			if (!Directory.Exists(resourcesFolderPath))
				Directory.CreateDirectory(resourcesFolderPath);

			if (!Directory.Exists(VocabPath))
				Directory.CreateDirectory(VocabPath);
		}
	}
}
