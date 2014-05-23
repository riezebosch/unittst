using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HRM
{
    public class SalarisAdministratie
    {
        private IPersoneelsAdministratie _pa;
        public SalarisAdministratie(IPersoneelsAdministratie pa)
        {
            _pa = pa;
        }

        public SalarisAdministratie()
            : this(new PersoneelsAdministratie())
        {

        }

        public bool Verhoog(int id, decimal salaris)
        {
            Persoon p = _pa.Zoek(id);

            if (p.DatumInDienst.AddYears(5) < DateTime.Today)
            {
                p.Salaris += salaris;
                return true;
            }

            return false;
        }
    }
}
