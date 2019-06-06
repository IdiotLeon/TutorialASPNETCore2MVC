using System.Linq;
using System.Collections.Generic;

namespace TutorialASPNETCore2MVC.Models
{
    public class MockPieRepository:IPieRepository
    {
        private List<Pie> _pies;

        public MockPieRepository()
        {
            if (_pies == null)
            {
                InitializePies();
            }
        }

        public IEnumerable<Pie> GetAllPies()
        {
            return _pies;
        }

        public Pie GetPieById(int pieId)
        {
            return _pies.FirstOrDefault(p => p.Id == pieId);
        }

        private void InitializePies() {
            _pies = new List<Pie>
            {
                new Pie{ Id = 1, Name = "Apple Pie", Price = 12.95M, ShortDescription = "Our famous apple pies", LongDescription="Icing carrot cake jelly-"},
                new Pie{ Id = 2, Name = "Blueberry Cheese Cake", Price = 18M, ShortDescription = "You'll love it!", LongDescription="Icing carrot cake jelly"},
                new Pie{ Id = 3, Name = "Cheese Cake", Price = 18.95M, ShortDescription = "Plain cheese cake. Plain pleasure.", LongDescription=""},
                new Pie{ Id = 4, Name = "Cherry Pie", Price = 15.95M, ShortDescription = "A summer classic!", LongDescription=""}
            };
        }
    }
}
