using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace RDMWinPhone.MVVM.Views.ViewsModels
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged Membres

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region Méthodes

        protected void RaisePropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion Méthodes
    }
}
