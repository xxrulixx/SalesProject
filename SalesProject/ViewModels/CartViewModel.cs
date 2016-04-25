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
        public float Taxes { get; set; }
        public float Subtotal { get; set; }
        

        public CartViewModel(IEventAggregator events)
        {
            _events = events;
            events.Subscribe(this);
            CartProducts = new BindableCollection<Product>();
            Taxes = (float)0.00;
            Subtotal = (float) 0.00;
        }

        public void ProductRemoved(Product product)
        {
            _events.PublishOnUIThread(new CartProductRemovedEvent(product));
        }

    }
}
