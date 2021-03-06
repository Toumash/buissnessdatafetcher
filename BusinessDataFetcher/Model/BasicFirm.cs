﻿namespace BusinessDataFetcher
{
    namespace Model
    {
        public class BasicFirm
        {
            public Address Address;
            public string Description;
            public string Name;
            public string Url;

            public BasicFirm(string url, string name, Address address, string description)
            {
                this.Url = url;
                this.Name = name;
                this.Address = address;
                this.Description = description;
            }

            public override string ToString()
            {
                return this.Name + " " + Address.Wojewodztwo + " " + Address.City + " " + Address.Street;
            }
        }
    }
}