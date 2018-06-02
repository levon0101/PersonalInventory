using PersonalInventory.UI.ViewModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace PersonalInventory.UI.Wrapper
{
    public class NotifyDataErrorInfoBase:ViewModelBase,INotifyDataErrorInfo
    {
        Dictionary<string, List<string>> _errorsByProertyName = new Dictionary<string, List<string>>();

        public bool HasErrors => _errorsByProertyName.Any();

        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;

        public IEnumerable GetErrors(string propertyName)
        {

            return _errorsByProertyName.ContainsKey(propertyName)
                ? _errorsByProertyName[propertyName]
                : null;

        }
        protected virtual void OnErrorsChanged(string propertyName)
        {
            ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs(propertyName));
            base.OnPropertyChanged(nameof(HasErrors));
        }

        protected void AddError(string propertyName, string error)
        {
            if (!_errorsByProertyName.ContainsKey(propertyName))
            {
                _errorsByProertyName[propertyName] = new List<string>();
            }
            if (!_errorsByProertyName[propertyName].Contains(error))
            {
                _errorsByProertyName[propertyName].Add(error);
                OnErrorsChanged(propertyName);
            }
        }
        protected void ClearErrors(string propertyName)
        {
            if (_errorsByProertyName.ContainsKey(propertyName))
            {
                //_errorsByProertyName[propertyName]?.Clear();
                //or
                _errorsByProertyName.Remove(propertyName);
                OnErrorsChanged(propertyName);
            }
        }
    }
}
