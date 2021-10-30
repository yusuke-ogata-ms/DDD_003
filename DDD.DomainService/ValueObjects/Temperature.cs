using DDD.DomainService.Helpers;

namespace DDD.DomainService.ValueObjects
{
    /// <summary>
    /// 温度のValueObject
    /// </summary>
    public sealed class Temperature : ValueObject<Temperature>
    {
        private const int DecimalPoint = 2;
        private const string TemperatureUnitName = "℃";

        /// <summary>
        /// 温度のプロパティ
        /// </summary>
        /// <param name="value">温度</param>
        public Temperature(float value)
        {
            Value = value;
        }

        /// <summary>
        /// Gets 値のプロパティ
        /// </summary>
        public float Value { get; }

        /// <summary>
        /// Gets 温度をスペースあり単位付きで表示する" ℃"
        /// </summary>
        public string DisplayValueWithSpaceUnit
        {
            get
            {
                return Value.RoundString(DecimalPoint) + " " + TemperatureUnitName;

                // return FloatHelper.RoundString(Value, DecimalPoint) + " " + TemperatureUnitName;
            }
        }

        /// <summary>
        /// Eqals の override定義
        /// </summary>
        /// <param name="other">値</param>
        /// <returns>値が等しい場合true</returns>
        public override bool EqualsCore(Temperature other)
        {
            return Value == other.Value;
        }

        /// <summary>
        /// GetHashCode の override定義
        /// </summary>
        /// <returns>ハッシュ値</returns>
        public override int GetHashCodeCore()
        {
            return Value.GetHashCode();
        }

        /// <summary>
        /// ToString の override定義
        /// </summary>
        /// <returns>値の文字列</returns>
        public override string ToStringCore()
        {
            return Value.ToString();
        }
    }
}
