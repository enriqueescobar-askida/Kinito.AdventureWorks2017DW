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

    // ProspectiveBuyer
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class ProspectiveBuyerConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ProspectiveBuyer>
    {
        public ProspectiveBuyerConfiguration()
            : this("dbo")
        {
        }

        public ProspectiveBuyerConfiguration(string schema)
        {
            Property(x => x.ProspectAlternateKey).IsOptional();
            Property(x => x.FirstName).IsOptional();
            Property(x => x.MiddleName).IsOptional();
            Property(x => x.LastName).IsOptional();
            Property(x => x.BirthDate).IsOptional();
            Property(x => x.MaritalStatus).IsOptional().IsFixedLength();
            Property(x => x.Gender).IsOptional();
            Property(x => x.EmailAddress).IsOptional();
            Property(x => x.YearlyIncome).IsOptional().HasPrecision(19,4);
            Property(x => x.TotalChildren).IsOptional();
            Property(x => x.NumberChildrenAtHome).IsOptional();
            Property(x => x.Education).IsOptional();
            Property(x => x.Occupation).IsOptional();
            Property(x => x.HouseOwnerFlag).IsOptional().IsFixedLength();
            Property(x => x.NumberCarsOwned).IsOptional();
            Property(x => x.AddressLine1).IsOptional();
            Property(x => x.AddressLine2).IsOptional();
            Property(x => x.City).IsOptional();
            Property(x => x.StateProvinceCode).IsOptional();
            Property(x => x.PostalCode).IsOptional();
            Property(x => x.Phone).IsOptional();
            Property(x => x.Salutation).IsOptional();
            Property(x => x.Unknown).IsOptional();
        }
    }

}
// </auto-generated>
