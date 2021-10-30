using DDD.DomainService.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DDDTest.Tests
{
    /// <summary>
    /// 温度のテスト
    /// </summary>
    [TestClass]
    public class TemperatureTest
    {
        /// <summary>
        /// テストコード
        /// </summary>
        [TestMethod]
        public void 小数点以下2桁で表示する()
        {
            var temperature = new Temperature(12.5f);
            temperature.Value.Is(12.5f);
            temperature.DisplayValueWithSpaceUnit.Is("12.50 ℃");
        }

        /// <summary>
        /// テストコード
        /// </summary>
        [TestMethod]
        public void 温度が等しい()
        {
            var t1 = new Temperature(1.0f);
            var t2 = new Temperature(1.0f);

            // 参照型なので、単純に比較しても同じにならない。
            // ValueObjectには値の比較が必要
            t1.Equals(t2).Is(true);
            (t1 == t2).Is(true);
            (t1 != t2).Is(false);
        }
    }
}
