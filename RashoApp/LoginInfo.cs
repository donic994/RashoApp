using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// U ovu klasu se spremaju podaci o prijavljenom korisniku. Pri zatvaranju sesije, ti podaci se brišu.
/// </summary>
namespace RashoApp {
    public static class LoginInfo {

        public static int UserID { get; set; }
        public static string Username { get; set; }
        public static int Role { get; set; }

        public static void CloseSession() {
            UserID = -1;
            Username = "";
            Role = -1;
        }

    }
}
