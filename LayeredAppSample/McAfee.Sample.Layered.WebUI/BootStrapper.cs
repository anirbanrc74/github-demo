using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using McAfee.Sample.Layered.Model;
using McAfee.Sample.Layered.Repository;
using StructureMap;
using StructureMap.Configuration.DSL;

namespace McAfee.Sample.Layered.WebUI
{
    public class BootStrapper
    {
        public static void ConfigureStructureMap()
        {
            ObjectFactory.Initialize(x =>
            {
                x.AddRegistry<ProductRegistry>();

            });
        }
    }

    public class ProductRegistry : Registry
    {
        public ProductRegistry()
        {
            ForRequestedType<IProductRepository>().TheDefaultIsConcreteType<ProductRepository>();
        }

    }
}