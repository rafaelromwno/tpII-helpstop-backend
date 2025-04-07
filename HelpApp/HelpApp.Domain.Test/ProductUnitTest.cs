using FluentAssertions;
using HelpApp.Domain.Entities;
using Xunit;

namespace HelpApp.Domain.Test
{
    public class ProductUnitTest
    {
        #region Testes Positivos

        [Fact(DisplayName = "Create Product With Valid Parameters")]
        public void CreateCategory_WithValidParameters_ResultObjectValidState()
        {
            Action action = () => new Product(1, "Product Name", "Product Description", 9.99m, 99, "/img/productImage.jpg");
            action.Should().NotThrow<Validation.DomainExceptionValidation>();
        }

        #endregion

        #region Testes Negativos

        [Fact(DisplayName = "Create Product With Null Name")]
        public void CreateProduct_WithNameNull_ResultObjectException()
        {
            Action action = () => new Product(null, "Product Description", 9.99m, 99, "/img/productImage.jpg");
            action.Should().Throw<Validation.DomainExceptionValidation>()
                .WithMessage("Invalid name, name is required.");
        }

        [Fact(DisplayName = "Create Product With Empty Name")]
        public void CreateProduct_WithNameEmpty_ResultObjectException()
        {
            Action action = () => new Product("", "Product Description", 9.99m, 99, "/img/productImage.jpg");
            action.Should().Throw<Validation.DomainExceptionValidation>()
                .WithMessage("Invalid name, name is required.");
        }

        [Fact(DisplayName = "Create Product With Short Name")]
        public void CreateProduct_WithShortName_ResultObjectException()
        {
            Action action = () => new Product("Pr", "Product Description", 9.99m, 99, "/img/productImage.jpg");
            action.Should().Throw<Validation.DomainExceptionValidation>()
                .WithMessage("Invalid name, too short, minimum 3 characters.");
        }

        [Fact(DisplayName = "Create Product With Null Description")]
        public void CreateProduct_WithDescriptionNull_ResultObjectException()
        {
            Action action = () => new Product("Product Name", null, 9.99m, 99, "/img/productImage.jpg");
            action.Should().Throw<Validation.DomainExceptionValidation>()
                .WithMessage("Invalid description, name is required.");
        }

        [Fact(DisplayName = "Create Product With Empty Description")]
        public void CreateProduct_WithDescriptionEmpty_ResultObjectException()
        {
            Action action = () => new Product("Product Name", "", 9.99m, 99, "/img/productImage.jpg");
            action.Should().Throw<Validation.DomainExceptionValidation>()
                .WithMessage("Invalid description, name is required.");
        }

        [Fact(DisplayName = "Create Product With Too Short Description")]
        public void CreateProduct_WithDescriptionTooShort_ResultObjectException()
        {
            Action action = () => new Product("Product Name", "Pro", 9.99m, 99, "/img");
            action.Should().Throw<Validation.DomainExceptionValidation>()
                .WithMessage("Invalid description, too short, minimum 5 characters.");
        }

        [Theory(DisplayName = "Create Product With Negative Price")]
        [InlineData(-1)]
        public void CreateProduct_WithNegativePrice_ResultObjectException(decimal price)
        {
            Action action = () => new Product("Product Name", "Product Description", price, 99, "/img/productImage.jpg");
            action.Should().Throw<Validation.DomainExceptionValidation>()
                .WithMessage("Invalid price negative value.");
        }

        [Theory(DisplayName = "Create Product With Negative Stock")]
        [InlineData(-1)]
        public void CreateProduct_WithNegativeStock_ResultObjectException(int stock)
        {
            Action action = () => new Product("Product Name", "Product Description", 9.99m, stock, "/img/productImage.jpg");
            action.Should().Throw<Validation.DomainExceptionValidation>()
                .WithMessage("Invalid stock negative value.");
        }

        [Theory(DisplayName = "Create Product With Image Name Too Long")]
        [InlineData("a")] 
        public void CreateProduct_WithImageNameTooLong_ResultObjectException(string imageName)
        {
            string longImageName = new string(imageName[0], 251); 
            Action action = () => new Product("Product Name", "Product Description", 9.99m, 99, longImageName);
            action.Should().Throw<Validation.DomainExceptionValidation>()
                .WithMessage("Invalid image name, too long, maximum 250 characters.");
        }

        [Fact(DisplayName = "Create Product With Empty Image")]
        public void CreateProduct_WithImageEmpty_ResultObjectException()
        {
            Action action = () => new Product("Product Name", "Product Description", 9.99m, 99, "");
            action.Should().Throw<Validation.DomainExceptionValidation>()
                .WithMessage("Invalid image address, image is required.");
        }

        [Fact(DisplayName = "Create Product With Negative Id")]
        public void CreateCategory_WithNameNull_ResultObjectException()
        {
            Action action = () => new Product(-1, "Product Name", "Product Description", 9.99m, 99, "/img/productImage.jpg");
            action.Should().Throw<Validation.DomainExceptionValidation>().WithMessage("Update Invalid Id value");
        }

        #endregion
    }
}
