using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeellOfFate
{
    public class BusinessRules//I prefer a separate class because in the exercises it's mentioned that in the future the business rules can suffer changes.
    {

        //-->aici o sa vin cu o lista de BAU de ingieri selectati pe ture si ii verific daca nu e ok mai chem odata metodele din BAU
        //bun! aici sa vad cum implementez lista cu ingineri, mai verific o data prin business rules si o trimit; => cumva respect deja regulile de business prin shuffle ala ...

        //TO DO: aici cred ca o sa am logica aia legata de cerinte 
        //Un inginer poate face cel mult o schimbare de o jumătate de zi într-o zi.
        //Un inginer nu poate avea schimbări de jumătate de zi în zile consecutive.
        //Fiecare inginer ar fi trebuit să aibă o întreagă zi de sprijin în orice perioadă de 2 săptămâni.

        static List<Engineer> listaInternaBusiness = new List<Engineer>();//am o lista de ingieri

        public BusinessRules(List<Engineer> lista)//acum preiau lista de afara si o trimit in lista interna de ingineri
        {
            listaInternaBusiness = lista;
        }
    //    public Schedule oZiDeLucru = new Schedule(listaInternaBusiness[0], listaInternaBusiness[1]);//cumva asta respecta prima cerinta, de o schimbare pe zi

        //public Workflow[] 5zile = new Workflow[5];
    }
}
