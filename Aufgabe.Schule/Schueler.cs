using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe.Schule
{
    internal class Schueler
    {
        private string name;
        private int alter;
        private bool eingeschult;

        public Schueler(string name, int alter)
        {
            this.name = name;
            this.alter = alter;
        }
        public string GetName()
        {
            return name;
        }
        public bool GetEingeschult()
        {
            return eingeschult;
        }
        public void SetEingeschult(bool eingeschult)
        {
            this.eingeschult = eingeschult;
        }
    }
}