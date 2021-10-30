using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DDD.WinForm.ViewModels
{
    /// <summary>
    /// ViewModel の基底クラス
    /// </summary>
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        /// <summary>
        /// データバインディングのためのイベントハンドラー
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// 値に変化がある場合、値の更新後PropertyChagedを呼ぶ。
        /// </summary>
        /// <typeparam name="T">バインディングしたい値の型</typeparam>
        /// <param name="field">更新したい値</param>
        /// <param name="value">代入する値</param>
        /// <param name="propertyName">プロパティ名</param>
        /// <returns>値に変更がある場合true</returns>
        protected bool SetProperty<T>(
            ref T field,
            T value,
            [CallerMemberName] string propertyName = null)
        {
            if (Equals(field, value))
            {
                return false;
            }

            field = value;
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

            return true;
        }
    }
}
