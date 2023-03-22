namespace Aufgabe.AudioPlayer
{
    internal class AudioPlayer
    {
        private List<AudioFile> audioFiles = new List<AudioFile>();
        private AudioFile[] audioFilesShuffled;
        private Random random = new Random();
        public void AddFile(AudioFile audioFile)
        {
            audioFiles.Add(audioFile);
        }
        public void RemoveFile(int id)
        {
            id = testID(id);
            audioFiles.RemoveAt(id);
        }
        public void Play(int id)
        {
            id = testID(id);
            Console.WriteLine($"ID: {(id + 1),3:D} {audioFiles[id].Play()}");
        }
        public void PlayAll(bool shufflePlay = false)
        {
            if (shufflePlay)
            {
                foreach (AudioFile audioFile in Shuffle(audioFiles))
                {
                    Console.WriteLine($"ID: {(audioFiles.IndexOf(audioFile) + 1),3:D} {audioFile.Play()}");
                }
            }
            else
            {
                foreach (AudioFile audioFile in audioFiles)
                {
                    Console.WriteLine($"ID: {(audioFiles.IndexOf(audioFile) + 1),3:D} {audioFile.Play()}");
                }
            }
        }
        private AudioFile[] Shuffle(List<AudioFile> audioFiles)
        {
            audioFilesShuffled = new AudioFile[audioFiles.Count()];
            foreach (AudioFile audioFile in audioFiles)
            {
                while (true)
                {
                    int i = random.Next(0, audioFiles.Count());
                    if (audioFilesShuffled[i] is null)
                    {
                        audioFilesShuffled[i] = audioFile;
                        break;
                    }
                }
            }
            return audioFilesShuffled;
        }
        private int testID(int id)
        {
            if (id >= audioFiles.Count())
            {
                id = audioFiles.Count() - 1;
            }
            else if (id < 0)
            {
                id = 0;
            }
            return id;
        }
    }
}
