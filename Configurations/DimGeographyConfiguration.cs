// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable EmptyNamespace
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.6
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Configurations
{
    using Entities;
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;

    // DimGeography
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class DimGeographyConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<DimGeography>
    {
        public DimGeographyConfiguration()
            : this("dbo")
        {
        }

        public DimGeographyConfiguration(string schema)
        {
            Property(x => x.City).IsOptional();
            Property(x => x.StateProvinceCode).IsOptional();
            Property(x => x.StateProvinceName).IsOptional();
            Property(x => x.CountryRegionCode).IsOptional();
            Property(x => x.EnglishCountryRegionName).IsOptional();
            Property(x => x.SpanishCountryRegionName).IsOptional();
            Property(x => x.FrenchCountryRegionName).IsOptional();
            Property(x => x.PostalCode).IsOptional();
            Property(x => x.SalesTerritoryKey).IsOptional();
            Property(x => x.IpAddressLocator).IsOptional();

        }
    }

}
// </auto-generated>
