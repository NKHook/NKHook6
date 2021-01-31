using System;
using System.Reflection;

namespace NKHook6_Impl
{
    /// <summary>
    /// A base for implementation types
    /// </summary>
    /// <typeparam name="TI">Type instance</typeparam>
    /// <typeparam name="TMO">Type model object</typeparam>
    /// <typeparam name="TM">Type model</typeparam>
    public abstract class ImplementationInstanceBase<TI, TMO, TM> where TMO : ImplementationBase<TM>
    {
        private TI theObject;
        public ImplementationInstanceBase(TI theObject)
        {
            this.theObject = theObject;
        }

        public TI getType()
        {
            return theObject;
        }
    }
}