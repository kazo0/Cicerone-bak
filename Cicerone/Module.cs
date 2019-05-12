using System;
using Autofac;
using Cicerone.Services;
using Cicerone.Services.Untappd;

namespace Cicerone
{
	public class Module
	{
		public static IContainer _container;

		public static void Init()
		{
			var builder = new ContainerBuilder();
			RegisterServices(builder);
			_container = builder.Build();

		}

		private static void RegisterServices(ContainerBuilder builder)
		{
			builder.RegisterType<UntappdService>().As<IUntappdService>();
		}
	}
}
