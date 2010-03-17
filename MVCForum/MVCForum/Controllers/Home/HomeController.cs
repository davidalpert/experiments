using System;
using FubuMVC.Core.View;

namespace MVCForum.Controllers.Home
{
    public class HomeController
    {
        public HomeViewModel Home(HomeInputModel input)
        {
            return new HomeViewModel();
        }
    }
}
