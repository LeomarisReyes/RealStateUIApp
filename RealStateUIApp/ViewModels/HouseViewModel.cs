using System;
using System.Collections.ObjectModel;
using RealStateUIApp.Models;

namespace RealStateUIApp.ViewModels
{
    public class HouseViewModel
    {
        public ObservableCollection<Features> features { get; set; }

        public HouseViewModel()
        {
            features = new ObservableCollection<Features>
            {
                new Features
                {
                    Quantity = "1.416",
                    Name = "Square foot"
                },
                new Features
                {
                    Quantity = "4",
                    Name = "Bedrooms"
                },
                 new Features
                {
                    Quantity = "2",
                    Name = "Bathrooms"
                },
                  new Features
                {
                    Quantity = "2",
                    Name = "Garage"
                }
            };
        }
    }
}
