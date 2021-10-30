using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.DomainService.ValueObjects
{
    /// <summary>
    /// AreaId の ValueObject
    /// </summary>
    public sealed class AreaId : ValueObject<AreaId>
    {
        /// <summary>
        /// AreaId の ValueObject
        /// </summary>
        /// <param name="areaId">areaId</param>
        public AreaId(int areaId)
        {
            Value = areaId;
        }

        /// <summary>
        /// Gets 値プロパティ
        /// </summary>
        public int Value { get; }

        /// <summary>
        /// Gets 4桁、左0埋めでareaIdを表示する
        /// </summary>
        public string DisplayValue
        {
            get
            {
                return string.Format("{0:0000}", Value);
            }
        }

        /// <summary>
        /// イコールの定義
        /// </summary>
        /// <param name="other">値</param>
        /// <returns>値が等しいときTrue</returns>
        public override bool EqualsCore(AreaId other)
        {
            return Value == other.Value;
        }

        /// <summary>
        /// ハッシュコード
        /// </summary>
        /// <returns>ハッシュコード</returns>
        public override int GetHashCodeCore()
        {
            return Value.GetHashCode();
        }

        /// <summary>
        /// 文字列
        /// </summary>
        /// <returns>文字列</returns>
        public override string ToStringCore()
        {
            return Value.ToString();
        }
    }
}
