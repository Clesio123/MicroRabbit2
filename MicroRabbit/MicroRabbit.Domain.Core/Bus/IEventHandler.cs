using System;
using MicroRabbit.Domain.Core.Events;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Domain.Core.Bus
{
   public class IEventHandler
        where TEvent : Event
    {

        Task Handle(TEvent @event);
    }

    public interface EventHandler
    {

    }
}
