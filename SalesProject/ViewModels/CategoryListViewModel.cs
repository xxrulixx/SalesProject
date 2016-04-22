using System;
using System.Linq;
using System.Windows.Controls.Primitives;
using Caliburn.Micro;
using Domain;
using SalesProject.Events;
using SalesProject.Models;

namespace SalesProject.ViewModels
{
    public class CategoryListViewModel : PropertyChangedBase, IHandle<CategoriesLoadedEvent>
    { 
        private IEventAggregator _events;

        public BindableCollection<Category> Categories { get; set; }
        public CategoryListViewModel(IEventAggregator events)
        {
            _events = events;
            _events.Subscribe(this);
        }

        public void CategoryClicked(Category category)
        {
            _events.PublishOnUIThread(new CategoryClickedEvent(category)) ;
        }

        public void Handle(CategoriesLoadedEvent message)
        {
            
            Categories = new 
                BindableCollection<Category>(message.CategoriesLoaded.ToList());
            NotifyOfPropertyChange(() => Categories);
        }
    }

}
