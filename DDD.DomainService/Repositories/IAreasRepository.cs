using System.Collections.Generic;
using DDD.DomainService.Entities;

namespace DDD.DomainService.Repositories
{
    /// <summary>
    /// Areas のリポジトリ
    /// </summary>
    public interface IAreasRepository
    {
        /// <summary>
        /// 地域の情報を得る
        /// </summary>
        /// <returns>地域の情報</returns>
        IReadOnlyList<AreaEntity> GetAreas();
    }
}
