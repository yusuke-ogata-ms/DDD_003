using DDD.DomainService.Entities;
using DDD.DomainService.Repositories;
using DDD.WinForm.ViewModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;

namespace DDDTest.Tests
{
    /// <summary>
    /// WeatherListViewModel のテストコード
    /// </summary>
    [TestClass]
    public class WeatherListViewModelTest
    {
        /// <summary>
        /// 全体のテスト
        /// </summary>
        [TestMethod]
        public void 一覧画面のテスト()
        {
            var viewModelMock = new Mock<IWeatherRepository>();
            var weathers = new List<WeatherEntity>
            {
                new WeatherEntity(
                    1,
                    "東京",
                    Convert.ToDateTime("2021/10/01 12:34:54"),
                    2,
                    12.3f),
                new WeatherEntity(
                    2,
                    "神戸",
                    Convert.ToDateTime("2021/10/02 12:34:54"),
                    4,
                    23.45f),
                new WeatherEntity(
                    3,
                    "沖縄",
                    Convert.ToDateTime("2021/10/02 12:34:54"),
                    3,
                    32.45f)
             };
            viewModelMock.Setup(x => x.GetList()).Returns(weathers);

            var viewModel = new WeatherListViewModel(viewModelMock.Object);
            viewModel.Weathers.Count.Is(3);

            viewModel.Weathers[0].AreaId.Is("0001");
            viewModel.Weathers[0].AreaName.Is("東京");
            viewModel.Weathers[0].DataDate.Is("2021/10/01 12:34:54");
            viewModel.Weathers[0].Condition.Is("曇り");
            viewModel.Weathers[0].Temperature.Is("12.30 ℃");

            viewModel.Weathers[1].AreaId.Is("0002");
            viewModel.Weathers[1].AreaName.Is("神戸");
            viewModel.Weathers[1].DataDate.Is("2021/10/02 12:34:54");
            viewModel.Weathers[1].Condition.Is("不明");
            viewModel.Weathers[1].Temperature.Is("23.45 ℃");

            viewModel.Weathers[2].AreaId.Is("0003");
            viewModel.Weathers[2].AreaName.Is("沖縄");
            viewModel.Weathers[2].DataDate.Is("2021/10/02 12:34:54");
            viewModel.Weathers[2].Condition.Is("雨");
            viewModel.Weathers[2].Temperature.Is("32.45 ℃");
        }
    }
}
