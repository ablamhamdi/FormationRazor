using Foramation.DTO;

namespace Foramation.Repo
{
    public interface Irepo
    {
        public List<Resto> Resto { get; set; }
        void DeleteRestaurant(int id);
        List<Resto> GetResautrants();

        bool addResto(Resto resto);
        Resto getRestoById(int id);
        bool UpdateResto(Resto resto);

    }
}
