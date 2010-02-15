using System;
using FubuMVC.Core.View;

namespace MVCForum.Controllers.Home
{
    public class HomeInputModel
    { 
    }

    public class HomeViewModel
    { 
    }

    public class HomeView : FubuPage<HomeViewModel>
    { 
    }

    public class HomeController
    {
        public HomeViewModel Home(HomeInputModel input)
        {
            return new HomeViewModel();
        }
    }
}
