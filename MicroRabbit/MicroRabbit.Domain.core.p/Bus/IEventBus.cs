using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Domain.core.p.Bus
{
    public interface IEventBus
    {
        Task SendCommand<T>(T command) where T : command;
        void publish<T>(T @event) where T : Event;

        void Subscribe<T, TH>()
            where TH : Event
            where TH : IEventHandler<T>;
            
            }
}
