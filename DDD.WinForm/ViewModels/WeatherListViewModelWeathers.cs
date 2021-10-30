using DDD.DomainService.Entities;

namespace DDD.WinForm.ViewModels
{
    /// <summary>
    /// WeatherEntity を一覧に表示するためにデータをStringとして保持するクラス
    /// </summary>
    public sealed class WeatherListViewModelWeathers
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="entity">WeatherEntity データ</param>
        public WeatherListViewModelWeathers(WeatherEntity entity)
        {
            AreaId = entity.AreaId.DisplayValue;
            AreaName = entity.AreaName.ToString();
            DataDate = entity.DataDate.ToString();
            Condition = entity.Condition.DisplayValue;
            Temperature = entity.Temperature.DisplayValueWithSpaceUnit;
        }

        /// <summary>
        /// Gets areaID
        /// </summary>
        public string AreaId { get; } = string.Empty;

        /// <summary>
        /// Gets areaName
        /// </summary>
        public string AreaName { get; } = string.Empty;

        /// <summary>
        /// Gets dataDate
        /// </summary>
        public string DataDate { get; } = string.Empty;

        /// <summary>
        /// Gets condition
        /// </summary>
        public string Condition { get; } = string.Empty;

        /// <summary>
        /// Gets temperature
        /// </summary>
        public string Temperature { get; } = string.Empty;
    }
}
