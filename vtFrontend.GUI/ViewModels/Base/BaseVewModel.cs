using System.ComponentModel;
using System.Runtime.CompilerServices;

using vtFrontend.GUI.Annotations;

namespace vtFrontend.GUI.ViewModels.Base
{
    public class BaseVewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}