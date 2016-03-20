using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Id.domen
{
    public abstract class ViewModel : ObservableObject, IDataErrorInfo
    {
        public string this[string columnName]
        {
            get
            {
                return OnValidate(columnName);
            }
        }

        public string Error
        {
            get
            {
                throw new NotSupportedException();
            }
        }

        protected virtual string OnValidate(string propertyName)
        {
            var context = new ValidationContext(this)
            {
                MemberName = propertyName
            };

            var results = new Collection<ValidationResult>();
            var isVAlid = Validator.TryValidateObject(this, context, results);

            return !isVAlid ? results[0].ErrorMessage : null;
        }
    }
}