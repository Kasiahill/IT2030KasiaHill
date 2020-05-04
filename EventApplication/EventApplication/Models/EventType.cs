using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventApplication.Models
{
    public class EventType
    {
        #region Properties
        public virtual long EventTypeID { get; set; }

        [Required]
        [MaxLength(length: 50, ErrorMessage = "The Event Type cannot be longer than 50 characters.")]
        public virtual string Type { get; set; }
        #endregion
    }
}
    }
}