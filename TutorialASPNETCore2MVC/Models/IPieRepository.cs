using System;
using System.Collections.Generic;

namespace TutorialASPNETCore2MVC.Models
{
    public interface IPieRepository
    {
        IEnumerable<Pie> GetAllPies();
        Pie GetPieById(int pieId);
    }
}
