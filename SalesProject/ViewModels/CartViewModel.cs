using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Documents;
using Caliburn.Micro;
using Domain;
using SalesProject.Events;

namespace SalesProject.ViewModels
{
    public class CartViewModel : PropertyChangedBase
    {
        private IEventAggregator _events;

        public BindableCollection<Product> CartProducts { get; set; }

        public CartViewModel(IEventAggregator events)
        {
            _events = events;
            events.Subscribe(this);
            CartProducts = new BindableCollection<Product>();
        }

        public void ProductRemoved(Product product)
        {
            _events.PublishOnUIThread(new CartProductRemovedEvent(product));
        }

    }
}
