using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe.AudioPlayer
{
    internal class FLACFile : AudioFile
    {
        public FLACFile(string fileName) : base(fileName)
        {
        }
        public override string Play()
        {
            return ($"\t|\t Type: FLAC \t|\t FileName: {fileName} \t|\t is playing right now.");
        }
    }
}
