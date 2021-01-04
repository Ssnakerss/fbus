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
    public class Answer
    {
        public AnswerEventTypeEnum Type { get; set; }
        public String Value { get; set; }
    }
    public class AnswerEvent
    {
        public Guid Id { get; set; }
        public Guid AnswerId { get; set; }
        public DateTime ClientTime { get; set; }
        // public List<Answer> Answer { get; set; }
        public string Answer { get; set; }
    }

}