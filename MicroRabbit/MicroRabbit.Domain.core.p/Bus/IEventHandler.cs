using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Domain.core.p.Bus
{
    public interface IEventHandler< in TEvent> : IEventHandler
        where TEvent : Event
    {
        Task Handle(TEvent @event);
    }

    public interface IEventHandler
    {

    }
}
