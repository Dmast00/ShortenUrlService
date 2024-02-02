using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ShortenUrl
    {
        public int ShortenId { get; set; }

        public string OriginalUrl { get; set; }

        public string ShortUrl { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
