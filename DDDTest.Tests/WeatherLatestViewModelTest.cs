using DDD.DomainService.Entities;
using DDD.DomainService.Repositories;
using DDD.DomainService.ValueObjects;
using DDD.WinForm.ViewModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;

namespace DDDTest.Tests
{
    /// <summary>
    /// WeatherLatestViewModelTest
    /// </summary>
    [TestClass]
    public class WeatherLatestViewModelTest
    {
        /// <summary>
        /// シナリオ
        /// </summary>
        [TestMethod]
        public void シナリオ()
        {
            var weatherMock = new Mock<IWeatherRepository>();
            var areasMock = new Mock<IAreasRepository>();

            var areas = new List<AreaEntity>
            {
                new AreaEntity(1, "東京"),
                new AreaEntity(2, "神戸"),
                new AreaEntity(3, "沖縄")
            };
            areasMock.Setup(x => x.GetAreas()).Returns(areas);

            var viewModel = new WeatherLatestViewModel(weatherMock.Object, areasMock.Object);

            weatherMock.Setup(x => x.GetLatest(1)).Returns(new WeatherEntity(
                1,
                Convert.ToDateTime("2021/10/01 12:34:54"),
                2,
                12.3f));
            weatherMock.Setup(x => x.GetLatest(2)).Returns(new WeatherEntity(
                2,
                Convert.ToDateTime("2021/01/01 12:34:54"),
                1,
                22.3f));
            viewModel.SelectedAreaId = 1;
            viewModel.Search();

            viewModel.SelectedAreaId.Is(1);
            viewModel.DataDateText.Is("2021/10/01 12:34:54");
            viewModel.ConditionText.Is("曇り");
            viewModel.TemperatureText.Is("12.30 ℃");

            viewModel.SelectedAreaId = 2;
            viewModel.Search();
            viewModel.SelectedAreaId.Is(2);
            viewModel.DataDateText.Is("2021/01/01 12:34:54");
            viewModel.ConditionText.Is("晴れ");
            viewModel.TemperatureText.Is("22.30 ℃");

            viewModel.SelectedAreaId = 3;
            viewModel.Search();
            viewModel.SelectedAreaId.Is(3);
            viewModel.DataDateText.Is("");
            viewModel.ConditionText.Is("");
            viewModel.TemperatureText.Is("");

            viewModel.Areas.Count.Is(3);
        }
    }
}
