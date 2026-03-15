namespace TP_MODUL4_103022400072
{
    internal class KodePos
    {
        public string getKodePos(string kelurahan)
        {
            if (kelurahan == "Batununggal") return "40266";
            if (kelurahan == "Kujangsari") return "40287";
            if (kelurahan == "Mengger") return "40267";
            if (kelurahan == "Wates") return "40256";
            if (kelurahan == "Cijaura") return "40287";
            if (kelurahan == "Jatisari") return "40286";
            if (kelurahan == "Margasari") return "40286";
            if (kelurahan == "Sekejati") return "40286";
            if (kelurahan == "Kebonwaru") return "40272";
            if (kelurahan == "Maleer") return "40274";

            return "Tidak ditemukan";
        }
    }
}