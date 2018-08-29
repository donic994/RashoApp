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

        public static int KorisnikID { get; set; }
        public static string KorisnickoIme { get; set; }
        public static int UlogaKorisnika { get; set; }

        public static void OtvoriSesiju(Baza18043_DBDataSet.KorisnikRow korisnik) {
            KorisnikID = korisnik.ID;
            KorisnickoIme = korisnik.korisnickoIme;
            UlogaKorisnika = korisnik.id_uloga;
        }

        public static void ZatvoriSesiju() {
            KorisnikID = -1;
            KorisnickoIme = "";
            UlogaKorisnika = -1;
        }

    }
}
