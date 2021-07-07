using System;
using SimplCommerce.Infrastructure.Models;

namespace SimplCommerce.Module.Core.Models
{
    public class UserRegion : EntityBase
    {
        public UserRegion()
        {
            CreateOn = DateTimeOffset.Now;
        }
        public long UserId { get; set; }
        public User User { get; set; }
        public string CountryId { get; set; }
        public Country Country { get; set; }
        public DateTimeOffset CreateOn { get; set; }
    }
}