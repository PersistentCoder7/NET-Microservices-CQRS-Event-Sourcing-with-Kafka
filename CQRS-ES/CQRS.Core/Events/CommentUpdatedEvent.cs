using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS.Core.Events
{
    public class CommentUpdatedEvent: BaseEvent
    {
        public Guid CommentId { get; set; }
        public string UserName { get; set; }
        public DateTime EditDate { get; set; }
        public string Comment { get; set; }

        public CommentUpdatedEvent() : base(nameof(CommentUpdatedEvent))
        {
        }
    }
}
