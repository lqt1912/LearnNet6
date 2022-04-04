using AutoMapper;
using LearnNet6.Data.Entity;
using LearnNet6.Mappers.MappingAction;
using LearnNet6.Models;
using LearnNet6.Models.Requests;
using LearnNet6.Models.Responses;

namespace LearnNet6.Mappers
{
    public class MappingProfile :Profile
    {
        public MappingProfile()
        {
            CreateMap<AddPostRequest, Post>();
            CreateMap<Post, PostResponse>().AfterMap<PostConvertAction>();
            CreateMap<RefreshToken, RefreshTokenViewModel>();
        }
    }
}
