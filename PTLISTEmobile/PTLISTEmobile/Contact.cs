using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace PTLISTEmobile
{
    public class Contact
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string name { get; set; }
        public string status { get; set; }
        public string imagesource { get; set; }
    }
}
