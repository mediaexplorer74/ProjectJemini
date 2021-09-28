using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Autofac;
using CrossPlatformApp.Models;
using CrossPlatformApp.UWP.Models;

namespace CrossPlatformApp.UWP.IoC
{
    class PlatformModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            builder.RegisterType<ClickModel>().As<IClickModel>();
        }
    }
}