using HelpApp.Domain.Validation;
using System.Collections.Generic;

namespace HelpApp.Domain.Entities
{
    public class Category
    {
        #region Attributes

        public int Id { get; set; }
        public string Name { get; set; }

        #endregion

        #region Constructors

        public Category(string name)
        {
            ValidateDomain(name);
        }

        public ICollection<Product> Products { get; set; }

        #endregion

        #region Validation

        private void ValidateDomain(string name)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name),
                "Invalid name, name is required");

            DomainExceptionValidation.When(name.Length < 3,
                "Invalid name, too short, minimum 3 characters");

            Name = name;
        }

        #endregion
    }
}
