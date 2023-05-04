using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationApplication
{
    internal class Çağrılan
    {
        public string çağrılanidarecino { get; set; }
        public string idareciisimsoyisim { get; set; }
        public string çağıranidareciisim { get; set; }
        public string çağıranidarecisoyisim { get; set; }
        public string çağıranidarecigorev { get; set; }
        public string acıklama { get; set; }

        public Çağrılan()
        {
            
        }

        public Çağrılan(string çağrılanNO, string isimSoyisim, string çağıranİdareciİsim, string çağıranİdareciSoyisim, string çağıranİdareciGorev, string acıklama)
        {
            this.çağrılanidarecino = çağrılanNO;
            this.idareciisimsoyisim = isimSoyisim;
            this.çağıranidareciisim = çağıranİdareciİsim;
            this.çağıranidarecisoyisim = çağıranİdareciSoyisim;
            this.çağıranidarecigorev = çağıranİdareciGorev;
            this.acıklama = acıklama;
        }

        internal void setÇağrılanNo(string no)
        {
            this.çağrılanidarecino = no;
        }

        internal string getÇağrılanNo()
        {
            return this.çağrılanidarecino;
        }

        

    }
}
