using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe.AudioPlayer
{
    internal class MP3File : AudioFile
    {
        public MP3File(string fileName) : base(fileName)
        {
        }

        public override string Play()
        {
            return ($"\t|\t Type: MP3 \t|\t FileName: {fileName} \t|\t is playing right now.");
        }
    }
}
