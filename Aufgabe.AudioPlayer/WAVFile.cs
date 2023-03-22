using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe.AudioPlayer
{
    internal class WAVFile : AudioFile
    {
        public WAVFile(string fileName) : base(fileName)
        {
        }
        public override string Play()
        {
            return ($"\t|\t Type: WAV \t|\t FileName: {fileName} \t|\t is playing right now.");
        }
    }
}
