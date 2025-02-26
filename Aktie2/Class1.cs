namespace Aktie
{
    /// <summary>
    /// Repræsenterer en aktie med dens navn, antal aktier, købs- og salgskurs.
    /// </summary>
    public class Stock
    {
        /// <summary>
        /// Får eller sætter navnet på aktien.
        /// </summary>
        public string AktieNavn { get; set; }

        /// <summary>
        /// Får eller sætter antallet af aktier.
        /// </summary>
        public int antalAktier { get; set; }

        /// <summary>
        /// Får eller sætter købsprisen pr. aktie.
        /// </summary>
        public int KøbsKurs { get; set; }

        /// <summary>
        /// Får eller sætter salgsprisen pr. aktie.
        /// </summary>
        public int SalgsKurs { get; set; }


        /// <summary>
        /// Beregner overskud eller tab på den pågældende aktie.
        /// </summary>
        /// <returns>Overskud eller tab beregnet som (SalgsKurs - KøbsKurs) * antalAktier.</returns>
        public int Afkast()
        {
            return (SalgsKurs - KøbsKurs) * antalAktier;
        }


    }
}
