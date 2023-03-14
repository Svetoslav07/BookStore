using AutoMapper;

namespace BookStore.AutoMapper

public class AutoMapperProfile : Profile

{
    public AutoMapperProfile())
        
        
        {
             CreateMap<AddAuthorRequest, Author>();
        
        }
}

