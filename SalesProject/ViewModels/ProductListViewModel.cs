﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using Domain;
using SalesProject.Events;

namespace SalesProject.ViewModels
{
    public class ProductListViewModel : PropertyChangedBase, IHandle<ProductLoadedEvent>
    {
        private IEventAggregator _events;

        public BindableCollection<Product> Products { get; set; }

        public ProductListViewModel(IEventAggregator events)
        {
            _events = events;
            events.Subscribe(this);
        }

        public void Handle(ProductLoadedEvent message)
        {
           Products = new BindableCollection<Product>(message.ProductsLoaded.ToList());
           NotifyOfPropertyChange(() => Products);
        }

        public void ProductClicked(Product product)
        {
            _events.PublishOnUIThread(new ProductClickedEvent(product));
            
        }
    }
}
