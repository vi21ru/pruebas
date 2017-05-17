using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    
    public class Document
    {
        [JsonProperty(PropertyName = "date")]
        public string DateTime { get; set; }

        [JsonProperty(PropertyName = "list")]
        public List[] List { get; set; }
    }
    public class Element
    {
        [JsonProperty(PropertyName = "attribute")]
        public Attribute[] Attribute { get; set; }
    }
    public class List
    {
        [JsonProperty(PropertyName = "element")]
        public Element Element { get; set; }
    }

    public class Attribute
    {
        [JsonProperty(PropertyName ="name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName ="valor")]
        public object Valor { get; set; }

        [JsonProperty(PropertyName ="string")]
        public string String { get; set; }

        [JsonProperty(PropertyName ="LocalidadPadre")]
        public string LocalidadPadre { get; set; }
    }
}
