using System;

namespace DDD.DomainService.Helpers
{
    /// <summary>
    /// Floatのヘルパークラス
    /// </summary>
    public static class FloatHelper
    {
        /// <summary>
        /// 小数点以下decimalPointで、四捨五入する
        /// </summary>
        /// <param name="value">小数値</param>
        /// <param name="decimalPoint">小数点以下の桁数</param>
        /// <returns>四捨五入した値の文字列</returns>
        public static string RoundString(this float value, int decimalPoint)
        {
            var temp = Convert.ToSingle(Math.Round(value, decimalPoint));

            return temp.ToString("F" + decimalPoint);
        }
    }
}
