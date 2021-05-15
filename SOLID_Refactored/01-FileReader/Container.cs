using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using _01_FileReader.Caching;
using _01_FileReader.File;
using _01_FileReader.Logging;

namespace _01_FileReader
{
    public static class Container
    {
        private static WindsorContainer container;
        public static T Resolve<T>()
        {
            return container.Resolve<T>();
        }

        public static void Release(object obj)
        {
            container.Release(obj);
        }

        public static void Setup()
        {
            container = new WindsorContainer();

            //default lifestyle is singleton
            container.Register(Component.For<ILogger>().LifestyleSingleton().UsingFactoryMethod(a => LoggerFactory.Create()));


            container.Register(Component.For<ICacheManager>().ImplementedBy<CacheManager>().LifestyleSingleton());

            container.Register(Component.For<IFileReader>()
                                        .ImplementedBy<FileReader>()
                                        .LifestyleBoundTo<FileStorage>());

            container.Register(Component.For<FileStorage>().LifestyleTransient());

        }
    }
}
