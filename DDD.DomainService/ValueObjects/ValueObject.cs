namespace DDD.DomainService.ValueObjects
{
    /// <summary>
    /// ValueObjece の基底クラス
    /// </summary>
    /// <typeparam name="T">ValueObject</typeparam>
    public abstract class ValueObject<T>
        where T : ValueObject<T>
    {
        /// <summary>
        /// == 演算子の定義
        /// </summary>
        /// <param name="vo1">値１</param>
        /// <param name="vo2">値２</param>
        /// <returns>値１と値２が等しい場合true</returns>
        public static bool operator ==(ValueObject<T> vo1, ValueObject<T> vo2)
        {
            return Equals(vo1, vo2);
        }

        /// <summary>
        /// != 演算子の定義
        /// </summary>
        /// <param name="vo1">値１</param>
        /// <param name="vo2">値２</param>
        /// <returns>値１と値２が等しい場合false</returns>
        public static bool operator !=(ValueObject<T> vo1, ValueObject<T> vo2)
        {
            return !Equals(vo1, vo2);
        }

        /// <summary>
        /// Equals 判定の abstract
        /// </summary>
        /// <param name="other">値１</param>
        /// <returns>自身の値が等しい場合trueとなるように継承先で実装</returns>
        public abstract bool EqualsCore(T other);

        /// <summary>
        /// Eqals の定義
        /// </summary>
        /// <param name="obj">値１</param>
        /// <returns>自身の値が等しい場合true</returns>
        public override bool Equals(object obj)
        {
            var vo = obj as T;

            if (vo == null)
            {
                return false;
            }

            return EqualsCore(vo);
        }

        /// <summary>
        /// GetHashCode の abstract
        /// </summary>
        /// <returns>参照型で比較したでも、値が同じ場合同じHashCodeを返すように継承先で定義</returns>
        // Hashについて
        // Dictionaryではハッシュを使って、同じインスタンスかどうかを判定している
        // Hashが異なると、別の値としてられるため、Hashについてもオーバーライドし
        // 同じ値であれば、同じHashを返すようにしておくとよい場合がある。
        // Dictionaryを利用する場合は、Hashを使ってクラスが同一であることを判定している
        // ValueObjectが保持している値が１つだけなら、ものとgetHashCodeをそのまま呼び出してもいいが
        // ２以上だと、排他的論理ををとって379をかけてハッシュを計算するようにしたほうがよい。
        public abstract int GetHashCodeCore();

        /// <summary>
        /// GetHashCode の定義
        /// </summary>
        /// <returns>Hashコード</returns>
        public override int GetHashCode()
        {
            return GetHashCodeCore();
        }

        /// <summary>
        /// ToString の abstract
        /// </summary>
        /// <returns>値の文字列を返すように継承先で定義</returns>
        public abstract string ToStringCore();

        /// <summary>
        /// ToString の定義
        /// </summary>
        /// <returns>値の文字列</returns>
        public override string ToString()
        {
            return ToStringCore();
        }
    }
}
