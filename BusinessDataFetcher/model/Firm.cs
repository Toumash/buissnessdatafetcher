﻿namespace BusinessDataFetcher.Model
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    namespace Model
    {
        public class Firm
        {
            public string Url;
            public string Name;

            public Firm(string url, string name)
            {
                this.Url = url;
                this.Name = name;
            }
        }
    }
}