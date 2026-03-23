using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Xml;

namespace MinisorterFileAnalizer.Models
{
    public class FormDataResponse
    {
        public int StatusCode { get; set; }
        public FormData? Data { get; set; }
        public string? Message { get; set; }

    }
}
