using System;
using AutoMapper;
using NTL.Infrastructure.Entity;
using NTL.Presentation.Models;

namespace NTL.Presentation.App_Start
{
    public sealed class MapperConfig
    {
        private static readonly Lazy<IMapper> Mapper = new Lazy<IMapper>(() => Config.CreateMapper());

        public static IMapper Instance => Mapper.Value;

        private static readonly MapperConfiguration Config = new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<TaskTable, TaskModels>().ReverseMap();
            cfg.CreateMap<TodoTable, TodoModels>().ReverseMap();
        });
    }
}