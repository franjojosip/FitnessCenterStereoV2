using Autofac;
using FitnessCenterStereo.Common;

namespace FitnessCenterStereo.WebApi.Infrastracture
{
    public class DIModule : Module
    {
        #region Methods

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<Filter>().As<IFilter>();
        }

        #endregion Methods
    }
}