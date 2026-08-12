using CarServiceTracker_v2.CarServiceTracker_v2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarServiceTracker_v2.Models
{
    public class ServiceList : ICollection<Service>
    {
        private List<Service> _services = new List<Service>();
        
        public int Count => _services.Count;

        public bool IsReadOnly => false;

        public void Add(Service item)
        {
            _services.Add(item);
        }

        public void Clear()
        {
            _services.Clear();
        }

        public bool Contains(Service item)
        {
            return _services.Contains(item);
        }

        public void CopyTo(Service[] array, int arrayIndex)
        {
            _services.CopyTo(array, arrayIndex);
        }

        public IEnumerator<Service> GetEnumerator()
        {
            return _services.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public bool Remove(Service item)
        {
            return _services.Remove(item);
        }
    }
}
