using System;
using System.Collections.Generic;
using Rz.GangOfFour.Behavioral.Mediator.Messages;

namespace Rz.GangOfFour.Behavioral.Mediator
{
    public class Mediator
    {
        private readonly Dictionary<Type, List<(object, Action<MessageBase>)>> registrations =
            new Dictionary<Type, List<(object, Action<MessageBase>)>>();

        public void RegisterForMessages<TMessage>(Action<TMessage> callback) where TMessage:MessageBase
        {
            if (!registrations.TryGetValue(typeof(TMessage),
                out List<(object,Action<MessageBase>)> currentRegistrationsForMessageType))
            {
                currentRegistrationsForMessageType = new List<(object,Action<MessageBase>)>();
                registrations[typeof(TMessage)] = currentRegistrationsForMessageType;
            }

            currentRegistrationsForMessageType.Add((callback.Target,x=>callback((TMessage)x)));
        }

        public void Send(MessageBase message)
        {
            if (!registrations.TryGetValue(message.GetType(),
                out List<(object, Action<MessageBase>)> currentRegistrationsForMessageType))
            {
                currentRegistrationsForMessageType = new List<(object, Action<MessageBase>)>();
                registrations[message.GetType()] = currentRegistrationsForMessageType;
            }

            foreach (var targetAndAction in currentRegistrationsForMessageType)
            {
                var target = targetAndAction.Item1;
                var action = targetAndAction.Item2;

                if(target == message.Source) continue;
                
                action.Invoke(message);
            }
        }
    }
}
