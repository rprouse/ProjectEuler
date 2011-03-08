using System;
using Ninject;
using Ninject.Activation;
using Ninject.Extensions.Conventions;

namespace Project.Euler.Problems
{
   public class InterfaceBindingGenerator :IBindingGenerator
   {
      private Type _interface;

      public InterfaceBindingGenerator( Type type )
      {
         if ( !type.IsInterface )
         {
            throw new ArgumentException( "type must be an interface", "type" );
         }
         _interface = type;
      }

      public void Process(Type type, Func<IContext, object> scopeCallback, IKernel kernel)
      {
         if ( type.IsInterface || type.IsAbstract )
         {
            return;
         }

         if ( _interface.IsAssignableFrom( type ) )
         {
            kernel.Bind( _interface ).To( type ).InScope( scopeCallback );
         }
      }
   }
}
