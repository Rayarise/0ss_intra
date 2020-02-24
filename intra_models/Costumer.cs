using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace intra_models
{
    public class Costumer : INotifyPropertyChanged
    {

        private string name;
        private string lastName;
        private string address;
        private string city;
        private string province;
        private string postalCode;
        private string contacInfo;
        private string picturePath;


        public string Info => $"{Name} , {LastName}";


        public string Name { 
            
            
            get=>name;


            set {
                name = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(Info));



            }
        }
        public string LastName
        {


            get => lastName;


            set {
                lastName = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(Info));
            }
        }

               

    
        public string Address { 
            
            
            get=>address;

            set {
                address = value;
                OnPropertyChanged();
            } 
        }
        public string City { 
            
            
            get=>city;

            set {
                city = value;
                 OnPropertyChanged();
            } 
        }
        public string Province { 
            
            get=>province;
            set {
                province = value;
                OnPropertyChanged();

            } }
        public string PostalCode { 
            
            get=>postalCode;

            set {
                postalCode = value;
                OnPropertyChanged();
            } }
        public string ContactInfo { 
            
            
            get=>contacInfo;

            set {
                contacInfo = value;
                OnPropertyChanged();
            } }
        public string PicturePath { 
            
            get=>picturePath;

            set {
                picturePath = value;
                OnPropertyChanged();
            
            } }




        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
