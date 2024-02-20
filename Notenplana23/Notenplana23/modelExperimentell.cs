using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notenplana23
{
    internal class modelExperimentell : IModelProfile
    {
        void IModelProfile.ausgeben(Profil profil)
        {
            throw new NotImplementedException();
        }

        bool IModelProfile.check(string Benutzername, string Passwort)
        {
            throw new NotImplementedException();
        }

        void IModelProfile.speichern(string Benutzername, string Passwort)
        {
            throw new NotImplementedException();
        }
    }
}
