using System;
using System.Collections.Generic;
using System.Data.SQLite;
using DDD.DomainService.Entities;
using DDD.DomainService.Repositories;

namespace DDD.Infrastracture.SQLite
{
    /// <summary>
    /// AreasSQLite クラス
    /// </summary>
    public sealed class AreasSQLite : IAreasRepository
    {
        /// <summary>
        /// Areas テーブルの内容を取得する
        /// </summary>
        /// <returns>地域の情報リスト</returns>
        public IReadOnlyList<AreaEntity> GetAreas()
        {
            string sql = @"
                        select AreaId,
                               AreaName
                        from Areas";

            var result = new List<AreaEntity>();

            using (var connection = new SQLiteConnection(SQLiteHelper.ConnectionString))
            using (var command = new SQLiteCommand(sql, connection))
            {
                connection.Open();

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result.Add(new AreaEntity(
                            Convert.ToInt32(reader["AreaId"]),
                            Convert.ToString(reader["AreaName"])));
                    }
                }
            }

            return result.AsReadOnly();
        }
    }
}
