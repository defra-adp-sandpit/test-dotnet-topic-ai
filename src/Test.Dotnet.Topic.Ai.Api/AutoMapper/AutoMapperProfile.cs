using Test.Dotnet.Topic.Ai.Api.Models;
using Test.Dotnet.Topic.Ai.Core.Entities;

using AutoMapper;

namespace Test.Dotnet.Topic.Ai.Api.AutoMapper;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<ItemRequest, Item>();
    }
}
