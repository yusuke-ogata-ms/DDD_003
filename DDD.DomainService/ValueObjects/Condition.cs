namespace DDD.DomainService.ValueObjects
{
    /// <summary>
    /// Condition の ValueObject
    /// </summary>
    public sealed class Condition : ValueObject<Condition>
    {
        /// <summary>
        /// 不明
        /// </summary>
        public static readonly Condition None = new Condition(0);

        /// <summary>
        /// 晴れ
        /// </summary>
        public static readonly Condition Sunny = new Condition(1);

        /// <summary>
        /// 曇り
        /// </summary>
        public static readonly Condition Cloudy = new Condition(2);

        /// <summary>
        /// 雨
        /// </summary>
        public static readonly Condition Rainy = new Condition(3);

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="value">値</param>
        public Condition(int value)
        {
            Value = value;
        }

        /// <summary>
        /// Gets 値のプロパティ
        /// </summary>
        public int Value { get; }

        /// <summary>
        /// Gets 値を状態を表す文字列で表示するプロパティ
        /// </summary>
        public string DisplayValue
        {
            get
            {
                if (this == Sunny)
                {
                    return "晴れ";
                }

                if (this == Cloudy)
                {
                    return "曇り";
                }

                if (this == Rainy)
                {
                    return "雨";
                }

                return "不明";
            }
        }

        /// <inheritdoc/>
        public override bool EqualsCore(Condition other)
        {
            return this.Value == other.Value;
        }

        /// <inheritdoc/>
        public override int GetHashCodeCore()
        {
            return this.GetHashCode();
        }

        /// <inheritdoc/>
        public override string ToStringCore()
        {
            return this.Value.ToString();
        }
    }
}
