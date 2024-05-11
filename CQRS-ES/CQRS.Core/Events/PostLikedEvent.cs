using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS.Core.Events
{
    public class PostLikedEvent: BaseEvent
    {
        public PostLikedEvent(): base(nameof(PostLikedEvent))
        {
        }
        
    }
}
