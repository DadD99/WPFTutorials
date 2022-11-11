using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp
{
    public class NotifiableCollection<T> : Collection<T>, INotifyCollectionChanged
    {
        public event NotifyCollectionChangedEventHandler? CollectionChanged;
        protected void NotifyCollectionChanged(NotifyCollectionChangedEventArgs e)
        {
            if (CollectionChanged != null)
                CollectionChanged(this, e);
        }
        public NotifiableCollection() { }
        protected override void InsertItem(int index, T item)
        {
            base.InsertItem(index, item);
            NotifyCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, index, item));          
        }
        protected override void RemoveItem(int index)
        {
            T item = base[index];
            base.RemoveItem(index);
            NotifyCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, item));
        }
        protected override void ClearItems()
        {
            base.ClearItems();
            NotifyCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
        }
        public void Move(int oldIndex, int newIndex)
        {
            T item = base[oldIndex];
            base.SetItem(newIndex, item);
            NotifyCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Move,
                item, newIndex, oldIndex));
        }
        protected override void SetItem(int index, T item)
        {
            T oldValue = base[index];
            base.SetItem(index, item);

            NotifyCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Replace,
                    item, oldValue));
        }

    }
}
