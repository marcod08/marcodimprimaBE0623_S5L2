namespace S5L1.Models
{
    public class Dipendente
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Cognome { get; set; }
        public string? Indirizzo { get; set; }
        public string? CodiceFiscale {  get; set; }
        public string? StatoCivile { get; set; }
        public int FigliCarico { get; set; }
        public string? Mansione { get; set; }
    }
}
