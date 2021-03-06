using System;
using System.Collections.Generic;

namespace CharSheet.Api.Models
{
    public class FormTemplateModel
    {
        public Guid FormTemplateId { get; set; }

        // Form type.
        public string Type { get; set; }

        // Form title.
        public string Title { get; set; }

        // Positional properties.
        public int OffsetTop { get; set; }
        public int OffsetLeft { get; set; }
        public int XPos { get; set; }
        public int YPos { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        // Labels.
        public IEnumerable<string> Labels { get; set; }
    }
}