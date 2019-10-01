using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Text;

namespace YozuBasicAlgebra.ObserverFun
{
    public class ObserverManager
    {
        public ObservableCollection<ObserverThing> SelectedCollection { get; private set; }

        public void DoYourThing()
        {
            var collection = new ObservableCollection<ObserverThing>();
            SelectedCollection = new ObservableCollection<ObserverThing>();

            collection.CollectionChanged += Collection_CollectionChanged;
            SelectedCollection.CollectionChanged += SelectedCollection_CollectionChanged;

            {
                var first = new ObserverThing("First");
                var second = new ObserverThing("Second");
                var third = new ObserverThing("Third");
                collection.Add(first);
                collection.Add(second);
                collection.Add(third);

                first.IsSelected = true;
                second.IsSelected = true;
                third.IsSelected = true;


                first.IsSelected = false;
                second.IsSelected = false;
                third.IsSelected = false;
            }
        }


        private void Collection_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    var newThing = (ObserverThing)e.NewItems[0];
                    newThing.PropertyChanged += Thing_PropertyChanged;
                    break;
                case NotifyCollectionChangedAction.Remove:
                    var oldThing = (ObserverThing)e.OldItems[0];
                    oldThing.PropertyChanged -= Thing_PropertyChanged;
                    break;
                case NotifyCollectionChangedAction.Move:
                case NotifyCollectionChangedAction.Replace:
                case NotifyCollectionChangedAction.Reset:
                    throw new NotImplementedException($"Collection_CollectionChanged, Action:{e.Action}");
            }
        }

        private void Thing_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            var thing = (ObserverThing)sender;

            if (thing.IsSelected == true)
                SelectedCollection.Add(thing);
            else
                SelectedCollection.Remove(thing);
        }

        private void SelectedCollection_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    var newThing = (ObserverThing)e.NewItems[0];
                    Console.WriteLine($"{newThing.FriendlyName} added to selection");
                    break;
                case NotifyCollectionChangedAction.Remove:
                    var oldThing = (ObserverThing)e.OldItems[0];
                    Console.WriteLine($"{oldThing.FriendlyName} removed from selection");

                    break;
                case NotifyCollectionChangedAction.Move:
                case NotifyCollectionChangedAction.Replace:
                case NotifyCollectionChangedAction.Reset:
                    throw new NotImplementedException($"Collection_CollectionChanged, Action:{e.Action}");
            }
        }
    }
}