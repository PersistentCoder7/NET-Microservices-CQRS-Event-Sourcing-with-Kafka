using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS.Core.Events
{
    public class PostCreatedEvent : BaseEvent
    {
        public string Author { get; set; }
        public string Message { get; set; }
        public DateTime DatePosted { get; set; }
        public PostCreatedEvent() : base(nameof(PostCreatedEvent))
        {

        }
    }
}
