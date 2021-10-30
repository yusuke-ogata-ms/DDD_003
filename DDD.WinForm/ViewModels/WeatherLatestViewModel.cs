using System;
using System.ComponentModel;
using DDD.DomainService.Entities;
using DDD.DomainService.Repositories;
using DDD.Infrastracture.SQLite;

namespace DDD.WinForm.ViewModels
{
    /// <summary>
    /// 天気のViewModel
    /// </summary>
    public sealed class WeatherLatestViewModel : ViewModelBase
    {
        private readonly IWeatherRepository _weatherRepository;
        private readonly IAreasRepository _areasRepository;
        private object _selectedAreaId;
        private string _dataDateText = string.Empty;
        private string _conditionText = string.Empty;
        private string _temperatureText = string.Empty;

        /// <summary>
        /// コンストラクタ（SQLiteに接続）
        /// </summary>
        public WeatherLatestViewModel()
            : this(new WeatherSQLite(), new AreasSQLite())
        {
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="weatherRepository">天気のリポジトリ</param>
        /// <param name="areasRepository">地域のリポジトリ</param>
        public WeatherLatestViewModel(IWeatherRepository weatherRepository, IAreasRepository areasRepository)
        {
            _weatherRepository = weatherRepository;
            _areasRepository = areasRepository;

            foreach (var area in _areasRepository.GetAreas())
            {
                Areas.Add(new AreaEntity(area.AreaId, area.AreaName));
            }
        }

        /// <summary>
        /// Gets or sets 地域の表示用のプロパティ
        /// </summary>
        public object SelectedAreaId
        {
            get { return _selectedAreaId; }
            set { SetProperty(ref _selectedAreaId, value); }
        }

        /// <summary>
        /// Gets or sets 期間の表示用のプロパティ
        /// </summary>
        public string DataDateText
        {
            get { return _dataDateText; }
            set { SetProperty(ref _dataDateText, value); }
        }

        /// <summary>
        /// Gets or sets 状態の表示用のプロパティ
        /// </summary>
        public string ConditionText
        {
            get { return _conditionText; }
            set { SetProperty(ref _conditionText, value); }
        }

        /// <summary>
        /// Gets or sets 温度の表示用のプロパティ
        /// </summary>
        public string TemperatureText
        {
            get { return _temperatureText; }
            set { SetProperty(ref _temperatureText, value); }
        }

        /// <summary>
        /// Gets or sets 地域の種類
        /// </summary>
        public BindingList<AreaEntity> Areas { get; set; }
        = new BindingList<AreaEntity>();

        /// <summary>
        /// 最新の情報を取得する
        /// </summary>
        public void Search()
        {
            var weatherEntity = _weatherRepository.GetLatest(Convert.ToInt32(_selectedAreaId));

            if (weatherEntity == null)
            {
                DataDateText = string.Empty;
                ConditionText = string.Empty;
                TemperatureText = string.Empty;
            }
            else
            {
                DataDateText = weatherEntity.DataDate.ToString();
                ConditionText = weatherEntity.Condition.DisplayValue;
                TemperatureText = weatherEntity.Temperature.DisplayValueWithSpaceUnit;
            }
        }
    }
}
