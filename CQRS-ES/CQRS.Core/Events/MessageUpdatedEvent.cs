using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS.Core.Events
{
    public class MessageUpdatedEvent : BaseEvent
    {

        public string Message { get; set; }

        public MessageUpdatedEvent() : base(nameof(MessageUpdatedEvent))
        {
        }
    }
}
