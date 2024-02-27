namespace S5L1.Models
{
    public static class StaticDB
    {
        private static int _maxId = 3;
        private static List<Dipendente> _dipendenti = [
            new Dipendente() { Id = 1, Nome = "Giorgio", Cognome = "Giovanni", CodiceFiscale = "NEKIVN352NF", Indirizzo = "Via Mazzini", StatoCivile = "Celibe", FigliCarico = 0, Mansione = "Operaio"},
            new Dipendente() { Id = 2, Nome = "Alberto", Cognome = "Rossi", CodiceFiscale = "ASCQ32523V", Indirizzo = "Via Garibaldi", StatoCivile = "Sposato", FigliCarico = 4, Mansione = "Operaio" },
            new Dipendente() { Id = 3, Nome = "Giacomo", Cognome = "Bianchi", CodiceFiscale = "QWSC4HVG34", Indirizzo = "Via della Repubblica", StatoCivile = "Sposato", FigliCarico = 1, Mansione = "Operaio" },
        ];

        public static List<Dipendente> GetAll()
        { return _dipendenti; }

        public static Dipendente? GetbyID(int? Id)
        {
            if (Id is null) return null;
            for (int i = 0; i<_dipendenti.Count; i++)
            {
                Dipendente dipendente = _dipendenti[i];
                if (dipendente.Id == Id) return dipendente;
            }
            return null;
        }

        public static Dipendente Add(string Nome, string Cognome, string CodiceFiscale, string Indirizzo, string StatoCivile, int FigliCarico, string Mansione)
        {
            _maxId++;
            var dipendente = new Dipendente() { Id = _maxId, Nome = Nome, Cognome = Cognome, CodiceFiscale= CodiceFiscale, Indirizzo = Indirizzo, StatoCivile = StatoCivile, FigliCarico = FigliCarico, Mansione = Mansione };
            _dipendenti.Add(dipendente);
            return dipendente;
        }
    }
}
