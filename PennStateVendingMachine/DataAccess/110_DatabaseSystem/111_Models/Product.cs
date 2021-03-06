﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess._110_DatabaseSystem._111_Models
{
    public class Product : Base.BaseModel
    {
        public static string TableName = "Product";

        private int iD;
        private string name;
        private ProductType productType;

        public Product()
            :base()
        {

        }

        public Product(int IDParam, string NameParam, ProductType ProductTypeParam)
            : base()
        {
            this.ID = IDParam;
            this.Name = NameParam;
            this.ProductType = ProductTypeParam;
        }

        public ProductType ProductType
        {
            get { return productType; }
            set { productType = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }

    }
}
