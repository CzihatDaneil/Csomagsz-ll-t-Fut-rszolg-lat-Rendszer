using Csomagszállító_Futárszolgálat_Rendszer;
using System.IO;

List<Csomag> aruk = new List<Csomag>(); 
if (File.Exists("Csomagok.txt"))
{
    foreach(string sor in File.ReadAllLines("csomagok.txt"))
    {
        string[] adatok = sor.Split(';');
        int db = sor.Count();
        if db<3
    }
}
