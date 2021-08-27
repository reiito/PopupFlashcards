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
		public static readonly string VocabLocation = resourcesFolderPath + "vocab.csv";
		public static readonly string PopupSoundLocation = resourcesFolderPath + "notification.wav";
		public static readonly string CorrectSoundLocation = resourcesFolderPath + "correct.wav";
		public static readonly string IncorrectSoundLocation = resourcesFolderPath + "incorrect.wav";

		public static void CreateFolders()
		{
			if (!Directory.Exists(resourcesFolderPath))
				Directory.CreateDirectory(resourcesFolderPath);
		}
	}
}
