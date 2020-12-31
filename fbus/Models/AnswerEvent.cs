using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace fbus.Models
{
    public enum AnswerEventTypeEnum
    {
        Click = 1,
        Move,
        Drag,
        Press,
        Other
    }
    public class AnswerEvent
    {
        public Guid Id { get; set; }
        public Guid AnswerId { get; set; }
        public DateTime Created { get; set; }
        public String Value { get; set; }
        public AnswerEventTypeEnum Type { get; set; }

    }

}