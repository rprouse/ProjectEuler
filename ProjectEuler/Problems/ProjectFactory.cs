using System.Collections.Generic;
using Ninject;
using Ninject.Extensions.Conventions;

namespace Project.Euler.Problems
{
   public static class ProjectFactory
   {
      private static IKernel _kernel;

      static ProjectFactory()
      {
         _kernel = new StandardKernel();
         _kernel.Scan(x =>
         {
            x.FromCallingAssembly();
            x.WhereTypeInheritsFrom(typeof(IProblem));
            x.BindWith( new InterfaceBindingGenerator( typeof( IProblem ) ) );
         });
      }

      public static IEnumerable<IProblem> Problems
      {
         get { return _kernel.GetAll<IProblem>(); }
      }
   }
}
