using System;
using System.Collections.Generic;
using System.IO.Enumeration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe.AudioPlayer
{
    internal abstract class AudioFile
    {
        protected string fileName;

        public AudioFile(string fileName)
        {
            this.fileName = fileName;
        }
        public abstract string Play();
    }
}
