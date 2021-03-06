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

    // vDMPrep
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class VDmPrepConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<VDmPrep>
    {
        public VDmPrepConfiguration()
            : this("dbo")
        {
        }

        public VDmPrepConfiguration(string schema)
        {
            Property(x => x.Model).IsOptional();
            Property(x => x.Region).IsOptional();
            Property(x => x.Age).IsOptional();
            Property(x => x.IncomeGroup).IsUnicode(false);
            Property(x => x.Amount).HasPrecision(19,4);
        }
    }

}
// </auto-generated>
