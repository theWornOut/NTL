using System.Collections.Generic;
using NTL.Infrastructure.Entity;
using NTL.Presentation.App_Start;

namespace NTL.Presentation.Models
{
    public static class MappingExtensions
    {
        #region Task
        public static IEnumerable<TaskModels> ToModel(this IEnumerable<TaskTable> entity)
        {
            var mapper = MapperConfig.Instance;

            return mapper.Map<IEnumerable<TaskModels>>(entity);
        }

        public static TaskModels ToModel(this TaskTable entity)
        {
            var mapper = MapperConfig.Instance;

            return mapper.Map<TaskModels>(entity);
        }

        public static TaskTable ToEntity(this TaskModels model)
        {
            var mapper = MapperConfig.Instance;

            return mapper.Map<TaskTable>(model);
        }
        #endregion

        #region Todo
        public static IEnumerable<TodoModels> ToModel(this IEnumerable<TodoTable> entity)
        {
            var mapper = MapperConfig.Instance;

            return mapper.Map<IEnumerable<TodoModels>>(entity);
        }

        public static TodoModels ToModel(this TodoTable entity)
        {
            var mapper = MapperConfig.Instance;

            return mapper.Map<TodoModels>(entity);
        }

        public static TodoTable ToEntity(this TodoModels model)
        {
            var mapper = MapperConfig.Instance;

            return mapper.Map<TodoTable>(model);
        }
        #endregion
    }
}