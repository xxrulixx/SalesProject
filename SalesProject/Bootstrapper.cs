using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows;
using Caliburn.Micro;
using SalesProject.ViewModels;
using SimpleInjector;

namespace SalesProject
{
    public class AppBootstrapper : BootstrapperBase
    {

        public static readonly DependencyInjector Injector = new DependencyInjector();
        public static Container ContainerInstance;

        public AppBootstrapper()
        {
            //LogManager.GetLog = type => new DebugLogger(type);
            Initialize();
        }

        protected override void Configure()
        {
            Injector.Initialize();
            ContainerInstance = Injector.Container;
            // ContainerInstance.Verify();
        }

        protected override void OnStartup(object sender, System.Windows.StartupEventArgs e)
        {
            DisplayRootViewFor<ShellViewModel>();
        }

        protected override IEnumerable<object> GetAllInstances(Type service)
        {
            // This line was throwing exception when running the application after installing SimpleInjector v3.0
            // Error: 
            // ---> An exception of type 'SimpleInjector.ActivationException' occurred in SimpleInjector.dll
            // ---> Additional information: No registration for type IEnumerable<MainWindowView> could be found. 
            // ---> No registration for type IEnumerable<MainWindowView> could be found. 
            // return ContainerInstance.GetAllInstances(service);

            IServiceProvider provider = ContainerInstance;
            Type collectionType = typeof(IEnumerable<>).MakeGenericType(service);
            var services = (IEnumerable<object>)provider.GetService(collectionType);
            return services ?? Enumerable.Empty<object>();
        }

        protected override object GetInstance(System.Type service, string key)
        {
            return ContainerInstance.GetInstance(service);
        }

        protected override IEnumerable<Assembly> SelectAssemblies()
        {
            return new[] {
                    Assembly.GetExecutingAssembly()
                };
        }

        protected override void BuildUp(object instance)
        {
            var registration = ContainerInstance.GetRegistration(instance.GetType(), true);
            registration.Registration.InitializeInstance(instance);
        }
    }

}