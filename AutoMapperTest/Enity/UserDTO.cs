using System;

namespace AutoMapperTest.Enity
{
    public class UserDTO
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public DateTime CreateTime { get; set; }
    }
}