using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApp1
{
    public class RelayCommand<T> : ICommand
    {
        /// <summary>
        /// Predicate la 1 delegate co return value la boolen. => Thich hop de gan vao ham CanExecute - Ham kiem tra dieu kien xem co Execute dc ko.
        /// </summary>
        private readonly Predicate<T> _canExecute;

        /// <summary>
        /// Action la 1 deligate co return value la void. Hay noi cach khac Action thuc thi mot hanh dong nao do. => Gan vao Execute la phu hop
        /// </summary>
        private readonly Action<T> _execute;

        public RelayCommand(Predicate<T> canExecute, Action<T> execute)
        {
            if(execute == null)
                throw new ArgumentNullException(nameof(execute));
            _canExecute = canExecute;
            _execute = execute;
        }

        public event EventHandler? CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object? parameter)
        {
            return _canExecute == null ? true : _canExecute((T)parameter);
        }

        public void Execute(object? parameter)
        {
            _execute((T)parameter);
        }
    }
}
