using DDD.WinForm.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDD.WinForm.Views
{
    /// <summary>
    /// データグリッドで天気の一覧を表示する
    /// </summary>
    public partial class WeatherListView : Form
    {
        private readonly WeatherListViewModel _viewModel = new WeatherListViewModel();

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public WeatherListView()
        {
            InitializeComponent();

            WeatherListDataGridView.DataBindings.Add("DataSource", _viewModel, nameof(_viewModel.Weathers));
        }
    }
}
