using PostSharp.Aspects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingWithAop.Aspects
{
    /// <summary>
    /// Aspect sttribute class for logging phases of test methods
    /// </summary>
    [Serializable]
    public class TestTrace : OnMethodBoundaryAspect
    {

        public sealed override void OnEntry(MethodExecutionArgs args)
        {
            Console.WriteLine("Entrying Test Method : " + args.Method.Name);
        }

        public sealed override void OnExit(MethodExecutionArgs args)
        {
            Console.WriteLine("Exiting Test Method : " + args.Method.Name);
        }

        public sealed override void OnException(MethodExecutionArgs args)
        {
            Console.WriteLine("Exception in Test : " + args.Method.Name);
            Console.WriteLine("Message : " + args.Exception.Message);
            Console.WriteLine("Stack Trace : " + args.Exception.StackTrace);
        }

    }
}
