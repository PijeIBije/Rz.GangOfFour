using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;
using System.Text;

namespace Rz.GangOfFour.Behavioral.ChainOfResponsibility.ShotHandlers
{
    public class Handlers:Dictionary<Type,object>
    {
        public THandler Get<THandler>() => (THandler)this[typeof(THandler)];

        public void Add(object handler) => this[handler.GetType()] = handler;
    }
}
