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

namespace Entities
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;

    // FactCurrencyRate
    [Table("FactCurrencyRate", Schema = "dbo")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class FactCurrencyRate
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"CurrencyKey", Order = 1, TypeName = "int")]
        [Index(@"PK_FactCurrencyRate_CurrencyKey_DateKey", 1, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Currency key")]
        public int CurrencyKey { get; set; } // CurrencyKey (Primary key)

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"DateKey", Order = 2, TypeName = "int")]
        [Index(@"PK_FactCurrencyRate_CurrencyKey_DateKey", 2, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Date key")]
        public int DateKey { get; set; } // DateKey (Primary key)

        [Column(@"AverageRate", Order = 3, TypeName = "float")]
        [Required]
        [Display(Name = "Average rate")]
        public double AverageRate { get; set; } // AverageRate

        [Column(@"EndOfDayRate", Order = 4, TypeName = "float")]
        [Required]
        [Display(Name = "End of day rate")]
        public double EndOfDayRate { get; set; } // EndOfDayRate

        [Column(@"Date", Order = 5, TypeName = "datetime")]
        [DataType(DataType.DateTime)]
        [Display(Name = "Date")]
        public System.DateTime? Date { get; set; } // Date

        // Foreign keys

        /// <summary>
        /// Parent DimCurrency pointed by [FactCurrencyRate].([CurrencyKey]) (FK_FactCurrencyRate_DimCurrency)
        /// </summary>
        [ForeignKey("CurrencyKey"), Required] public virtual DimCurrency DimCurrency { get; set; } // FK_FactCurrencyRate_DimCurrency

        /// <summary>
        /// Parent DimDate pointed by [FactCurrencyRate].([DateKey]) (FK_FactCurrencyRate_DimDate)
        /// </summary>
        [ForeignKey("DateKey"), Required] public virtual DimDate DimDate { get; set; } // FK_FactCurrencyRate_DimDate
    }

}
// </auto-generated>