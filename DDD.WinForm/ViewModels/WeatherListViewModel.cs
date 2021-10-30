using System.ComponentModel;
using DDD.DomainService.Entities;
using DDD.DomainService.Repositories;
using DDD.Infrastracture.SQLite;

namespace DDD.WinForm.ViewModels
{
    /// <summary>
    /// 一覧画面の ViewModel
    /// </summary>
    public sealed class WeatherListViewModel : ViewModelBase
    {
        private readonly IWeatherRepository _weatherRepository;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public WeatherListViewModel()
            : this(new WeatherSQLite())
        {
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="weatherRepository">リポジトリ</param>
        public WeatherListViewModel(IWeatherRepository weatherRepository)
        {
            _weatherRepository = weatherRepository;

            foreach (WeatherEntity weather in _weatherRepository.GetList())
            {
                Weathers.Add(new WeatherListViewModelWeathers(weather));
            }
        }

        /// <summary>
        /// Gets or sets 一覧に表示するデータ
        /// </summary>
        public BindingList<WeatherListViewModelWeathers> Weathers { get; set; }
        = new BindingList<WeatherListViewModelWeathers>();
    }
}