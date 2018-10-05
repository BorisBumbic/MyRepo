

using System;

namespace NewsApp.Models
{
    public class News
    {
        public int Id { get; set; }
        public string Header { get; set; }
        public string  Info { get; set; }
        public string Body { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime CreatDatTime { get; set; }

    }
}
