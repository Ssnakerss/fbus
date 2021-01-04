using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace fbus.Models
{
    public class AnswerAttachment
    {
        public Guid Id { get; set; }
        public Guid AnswerId { get; set; }
        public DateTime Created { get; set; }
        public String FileName { get; set; }
        public String MimeType { get; set; }
        public Int32 Size { get; set; }

       
    }

}