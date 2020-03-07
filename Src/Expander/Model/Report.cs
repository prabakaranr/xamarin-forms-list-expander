using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Expander.Model
{
    public class Report : INotifyPropertyChanged
    {
        Random random = new Random();

        private bool isExpanded;

        private double product1;
        private double product2;
        private double product3;

        public string ID { get; set; }

        public string Description { get; set; }

        public string Name { get; set; }

        public string Image { get; set; }

        public double Product1
        {
            get => product1;

            set {
                if (product1 == value) return;
                product1 = value;
                OnPropertyChanged("Total");
            }
        }

        public double Product2
        {
            get => product2;

            set
            {
                if (product2 == value) return;
                product2 = value;
                OnPropertyChanged("Total");
            }
        }

        public double Product3
        {
            get => product3;

            set
            {
                if (product3 == value) return;
                product3 = value;
                OnPropertyChanged("Total");
            }
        }

        public double Total
        {
            get
            {
                return Product1 + Product2 + Product3;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public bool IsExpanded
        {
            get
            {
                return isExpanded;
            }
            set
            {
                if (value != isExpanded)
                {
                    isExpanded = value;
                    OnPropertyChanged();
                }
            }
        }

        public Report(string id, string description, string image)
        {
            ID = id;
            Description = description;
            Image = image;

            product1 = random.Next(20, 100);
            product2 = random.Next(20, 100);
            product3 = random.Next(20, 100);
        }

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
