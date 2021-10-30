using System;
using System.Collections.Generic;
using System.Data.SQLite;
using DDD.DomainService.Entities;
using DDD.DomainService.Repositories;

namespace DDD.Infrastracture.SQLite
{
    /// <summary>
    /// Weatherテーブルから値を取得する
    /// </summary>
    public class WeatherSQLite : IWeatherRepository
    {
        /// <summary>
        /// 地域の最新の値を取得する
        /// </summary>
        /// <param name="areaId">地域</param>
        /// <returns>地域の最新の天気情報</returns>
        public WeatherEntity GetLatest(int areaId)
        {
            string sql = @"
                        select DataDate,
                            Condition,
                            Temperature
                        from Weather
                        where AreaId = @AreaIdInput
                        order by DataDate desc
                        LIMIT 1";

            using (var connection = new SQLiteConnection(SQLiteHelper.ConnectionString))
            using (var command = new SQLiteCommand(sql, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@AreaIdInput", areaId);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        return new WeatherEntity(
                            areaId,
                            Convert.ToDateTime(reader["DataDate"]),
                            Convert.ToInt32(reader["Condition"]),
                            Convert.ToSingle(reader["Temperature"]));
                    }
                }
            }

            return null;
        }

        /// <summary>
        /// areaID、areaName、dataDate、condition、temperatureのデータリスト読み込む
        /// </summary>
        /// <returns>読み込んだデータのリスト</returns>
        public IReadOnlyList<WeatherEntity> GetList()
        {
            string sql = @"
                        select A.AreaId,
                               ifnull(B.AreaName,'') as AreaName,
                               A.DataDate,
                               A.Condition,
                               A.Temperature
                        from Weather A
                        left outer join Areas B
                        on A.AreaId = B.AreaId";

            var weathers = new List<WeatherEntity>();

            using (var connection = new SQLiteConnection(SQLiteHelper.ConnectionString))
            using (var command = new SQLiteCommand(sql, connection))
            {
                connection.Open();

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        weathers.Add(
                            new WeatherEntity(
                                Convert.ToInt32(reader["AreaId"]),
                                Convert.ToString(reader["AreaName"]),
                                Convert.ToDateTime(reader["DataDate"]),
                                Convert.ToInt32(reader["Condition"]),
                                Convert.ToSingle(reader["Temperature"])));
                    }
                }
            }

            return weathers;
        }
    }
}
