using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using Domain;
using SalesProject.Events;

namespace SalesProject.ViewModels
{
    public class CartItemViewModel : PropertyChangedBase
    {
        private IEventAggregator _events;

        public CartItemViewModel(IEventAggregator events)
        {
            _events = events;
            //_events.Subscribe(this);
        }
    }
}
