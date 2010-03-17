using System;
using FubuMVC.Core;
using FubuMVC.StructureMap.Bootstrap;

namespace MVCForum.Infrastructure
{
    public class MVCForumApplication : FubuStructureMapApplication
    {
        public override FubuRegistry GetMyRegistry()
        {
            return new MVCForumFubuRegistry();
        }

        //protected override void InitializeStructureMap(IInitializationExpression ex)
        //{
        //    // ex.For<IHttpSession>().Use<CurrentHttpContextSession>();
        //    base.InitializeStructureMap(ex);
        //}
    }
}
