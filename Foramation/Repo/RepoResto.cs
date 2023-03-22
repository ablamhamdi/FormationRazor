using Foramation.DTO;

namespace Foramation.Repo
{


    public class RepoResto:Irepo
    {
        public List<Resto> Resto { get ; set ; }

        public RepoResto()
        {
         this.Resto =
                new List<Resto>()
         {
             new Resto
             {
                 id = 1,
                 name = "Test",
                 Discription = "TestTestTestTestTestTest",
                 Address = "Adress1",
                 PhoneNumber = "0659821423",
             }
             , new Resto
             {
                 id = 2,
                 name = "Test",
                 Discription = "TestTestTestTestTestTest",
                 Address = "Adress2",
                 PhoneNumber = "0659821423",
             }
             , new Resto
               {
                   id = 3,
                   name = "Test",
                   Discription = "TestTestTestTestTestTest",
                   Address = "Adress3",
                   PhoneNumber = "0659821423",
               }
        };
        }

        public void DeleteRestaurant(int id)
        {
            var resto = Resto.Where(resto => resto.id == id).FirstOrDefault();
            if (resto != null)
            {
                Resto.Remove(resto);
            }
            else
            {
                throw new Exception("there is no resto with this Id");

            }
        }

        public List<Resto> GetResautrants()
        {
            return Resto;
        }

        public bool addResto(Resto resto)
        {
            if(resto != null) {
                Resto.Add(resto);
                return true;
            }
            return false;
           
        }

        public Resto getRestoById(int id)
        {
            var Rest = Resto.Where(resto => resto.id == id).FirstOrDefault();
            if (Rest != null) return Rest;
            throw new Exception("there is no resto with this Id");
        }

        public bool UpdateResto(Resto resto)
        {
           var Updated = getRestoById(resto.id);

            if (Updated != null)
            {
                Updated.id = resto.id;
                Updated.name = resto.name;
                Updated.Address = resto.Address;
                Updated.PhoneNumber= resto.PhoneNumber;
                Updated.Discription = resto.Discription;
                return true;
            }
            return false;
        }
    }
}
