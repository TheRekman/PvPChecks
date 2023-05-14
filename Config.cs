using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace PvPChecks
{
    public class Config
    {
        public List<int> weaponBans = new List<int>();
        public List<int> accsBans = new List<int>();
        public List<int> armorBans = new List<int>();
        public List<int> buffBans = new List<int>();
        public List<int> projBans = new List<int>();
        public bool portalGunBlock = true;
    }
}
