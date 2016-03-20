using System.ComponentModel.DataAnnotations;
using Id.domen;

namespace IdAdminka.ViewModels
{
    public class CustomerViewModel:ViewModel
    {
        private string _customerName;
        [Required]
        public string CustomerName
        {
            get { return _customerName; }
            set
            {
                _customerName = value;
                NotifyPropertyChanged();
            }
        }

        protected override string OnValidate(string propertyName)
        {
            if (CustomerName!=null && CustomerName.Length<10)
            {
                return "Name must be longer then 10 characters";
            }
            return base.OnValidate(propertyName);
        }
    }
}