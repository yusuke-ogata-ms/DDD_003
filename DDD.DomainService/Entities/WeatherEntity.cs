using System;
using DDD.DomainService.ValueObjects;

namespace DDD.DomainService.Entities
{
    /// <summary>
    /// WeatherView の Entity
    /// </summary>
    public sealed class WeatherEntity
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="areaId">地域</param>
        /// <param name="dateDate">日時</param>
        /// <param name="condition">状態</param>
        /// <param name="temperature">温度</param>
        public WeatherEntity(
            int areaId,
            DateTime dateDate,
            int condition,
            float temperature)
            : this(areaId, null, dateDate, condition, temperature)
        {
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="areaId">地域</param>
        /// <param name="areaName">地域の名前</param>
        /// <param name="dateDate">日時</param>
        /// <param name="condition">状態</param>
        /// <param name="temperature">温度</param>
        public WeatherEntity(
            int areaId,
            string areaName,
            DateTime dateDate,
            int condition,
            float temperature)
        {
            AreaId = new AreaId(areaId);
            AreaName = areaName;
            DataDate = dateDate;
            Condition = new Condition(condition);
            Temperature = new Temperature(temperature);
        }

        /// <summary>
        /// Gets 地域のプロパティ
        /// </summary>
        public AreaId AreaId { get; }

        /// <summary>
        /// Gets 地域の名前
        /// </summary>
        public string AreaName { get; }

        /// <summary>
        /// Gets 日時のプロパティ
        /// </summary>
        public DateTime DataDate { get; }

        /// <summary>
        /// Gets 状態のプロパティ
        /// </summary>
        public Condition Condition { get; }

        /// <summary>
        /// Gets 温度のプロパティ
        /// </summary>
        public Temperature Temperature { get; }
    }
}
