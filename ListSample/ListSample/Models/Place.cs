using System;
using System.Collections.Generic;
using System.Text;

namespace ListSample.Models
{
    public class Place
    {
        public Place(string name, string category)
        {
            Name = name;
            Category = category;
        }

        public string Name { get; set; }
        public string Category { get; set; }

    }
}
