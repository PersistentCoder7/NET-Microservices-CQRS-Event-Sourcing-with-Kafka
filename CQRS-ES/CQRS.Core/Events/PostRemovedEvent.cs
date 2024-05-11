using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS.Core.Events
{
    public class PostRemovedEvent: BaseEvent
    {
        public PostRemovedEvent(): base(nameof(PostRemovedEvent))
        {
        }
        
    }
}
