using System.Collections.Generic;
using DDD.DomainService.Entities;

namespace DDD.DomainService.Repositories
{
    /// <summary>
    /// 天気の情報を取得するリポジトリインタフェース
    /// </summary>
    public interface IWeatherRepository
    {
        /// <summary>
        /// 地域の最新の情報を取得する
        /// </summary>
        /// <param name="areaId">地域</param>
        /// <returns>その地域の最新の情報</returns>
        WeatherEntity GetLatest(int areaId);

        /// <summary>
        /// 一覧データを取得する
        /// </summary>
        /// <returns>一覧データ</returns>
        IReadOnlyList<WeatherEntity> GetList();
    }
}