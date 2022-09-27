using Materials.Core;
using MongoDB.Driver;

namespace LearningDiary.Context
{
    public interface IMaterialContext
    {
        IMongoCollection<Material> Materials { get; }
    }
}
