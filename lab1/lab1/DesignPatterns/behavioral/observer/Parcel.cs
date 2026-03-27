using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.behavioral.observer
{
    public class Parcel : ISubject
    {
        private List<IObserver> observers = new List<IObserver>();
        private string status = "";

        public string ParcelId { get; private set; }

        public Parcel(string parcelId)
        {
            ParcelId = parcelId;
        }

        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in observers)
            {
                observer.Update(ParcelId, status);
            }
        }

        public void SetStatus(string newStatus)
        {
            status = newStatus;
            Console.WriteLine($"\nParcel {ParcelId} status changed to: {status}");
            Notify();
        }
    }
}
