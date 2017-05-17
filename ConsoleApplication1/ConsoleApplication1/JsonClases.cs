using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class JsonClases
    {
        public class Rootobject
        {
            public Document document { get; set; }
        }

        public class Document
        {
            public string date { get; set; }
            public List[] list { get; set; }
        }

        public class List
        {
            public Element element { get; set; }
        }

        public class Element
        {
            public Attribute[] attribute { get; set; }
        }

        public class Attribute
        {
            public string name { get; set; }
            public object valor { get; set; }
            public string _string { get; set; }
            public string LocalidadPadre { get; set; }
        }

    }
}
