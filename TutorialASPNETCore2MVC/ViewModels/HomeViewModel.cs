using TutorialASPNETCore2MVC.Models;
using System.Collections.Generic;

namespace TutorialASPNETCore2MVC.ViewModels
{
    public class HomeViewModel
    {
        public string Title { get; set; }
        public List<Pie> Pies { get; set; }
    }
}
