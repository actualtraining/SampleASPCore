using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PDGICoreApps.Models
{
    public class Dokter
    {
        public string UserID { get; set; }
        public string NIP { get; set; }
        public string Nama { get; set; }
        public string Alamat { get; set; }
        public string Telpon { get; set; }
        public DateTime TanggalLahir { get; set; }
        public string NoSIP { get; set; }
    }
}
