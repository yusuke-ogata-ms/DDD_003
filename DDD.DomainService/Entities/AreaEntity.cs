using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.DomainService.Entities
{
    /// <summary>
    /// 地域の種類
    /// </summary>
    public sealed class AreaEntity
    {
        /// <summary>
        /// 完全コンストラクタ
        /// </summary>
        /// <param name="areaId">地域に割り当てられている値</param>
        /// <param name="areaName">地域の名前</param>
        public AreaEntity(int areaId, string areaName)
        {
            AreaId = areaId;
            AreaName = areaName;
        }

        /// <summary>
        /// Gets 地域に割り当てられている値
        /// </summary>
        public int AreaId { get; }

        /// <summary>
        /// Gets 地域の名称
        /// </summary>
        public string AreaName { get; }
    }
}
