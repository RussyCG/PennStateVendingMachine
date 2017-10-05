using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineModels
{
    public class ProductDTO
    {
        #region Fields

        private string productID;
        private string productDescription;

        #endregion

        #region Constructors

        public ProductDTO()
        {

        }

        public ProductDTO(string ProductIDParam, string ProductDescriptionParam)
        {
            this.ProductID = ProductIDParam;
            this.ProductDescription = ProductDescriptionParam;
        }

        #endregion

        #region Properties

        public string ProductDescription
        {
            get { return productDescription; }
            set { productDescription = value; }
        }

        public string ProductID
        {
            get { return productID; }
            set { productID = value; }
        }

        #endregion

        #region Methods

        public override string ToString()
        {
            return string.Format("ID: " + this.ProductID + "\n" + "Description: " + this.ProductDescription);
        }

        #endregion
    }
}
