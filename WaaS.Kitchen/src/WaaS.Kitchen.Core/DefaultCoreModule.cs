using Autofac;
using WaaS.Kitchen.Core.Interfaces;
using WaaS.Kitchen.Core.Services;

namespace WaaS.Kitchen.Core
{
    public class DefaultCoreModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ToDoItemSearchService>()
                .As<IToDoItemSearchService>().InstancePerLifetimeScope();
        }
    }
}
