using DDD.DomainService.Entities;
using DDD.WinForm.ViewModels;
using System;
using System.Windows.Forms;

namespace DDD.WinForm.Views
{
    /// <summary>
    /// 最新の地域の天気を表示するフォーム
    /// </summary>
    public partial class WeatherLatestView : Form
    {
        private readonly WeatherLatestViewModel _viewModel = new WeatherLatestViewModel();

        /// <summary>
        /// 天気画面
        /// </summary>
        public WeatherLatestView()
        {
            InitializeComponent();

            this.AreasComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.AreasComboBox.DataBindings.Add("SelectedValue", _viewModel, nameof(_viewModel.SelectedAreaId));
            this.AreasComboBox.DataBindings.Add("DataSource", _viewModel, nameof(_viewModel.Areas));
            this.AreasComboBox.ValueMember = nameof(AreaEntity.AreaId);
            this.AreasComboBox.DisplayMember = nameof(AreaEntity.AreaName);

            this.DataDateLabel.DataBindings.Add("Text", _viewModel, nameof(_viewModel.DataDateText));
            this.ConditionLabel.DataBindings.Add("Text", _viewModel, nameof(_viewModel.ConditionText));
            this.TemperatureLabel.DataBindings.Add("Text", _viewModel, nameof(_viewModel.TemperatureText));
        }

        private void LatestButton_Click(object sender, EventArgs e)
        {
            _viewModel.Search();
        }

        private void WeatherListViewButton_Click(object sender, EventArgs e)
        {
            using (var f = new WeatherListView())
            {
                f.ShowDialog();
            }
        }
    }
}
