using AutoMapper;
using AutoMapperTest.Enity;
using Microsoft.AspNetCore.Server.Kestrel.Transport.Sockets.Internal;

namespace AutoMapperTest
{
    public class AutoMapperConfigProfile:Profile,IProfile
    {
        public AutoMapperConfigProfile()
        {
            CreateMap<Users, UserDTO>()
                .ForMember(des=>des.UserName,opt=>opt.MapFrom(src=>src.Name))
                .ForMember(des=>des.CreateTime,opt=>opt.MapFrom(src=>src.CreateTime.ToString("G")));
            CreateMap<UserDTO, Users>()
                .ForMember(des=>des.Name,opt=>opt.MapFrom(src=>src.UserName));
        }
        
    }
}