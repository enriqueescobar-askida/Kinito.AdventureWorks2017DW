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

    // vDMPrep
    [Table("vDMPrep", Schema = "dbo")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class VDmPrep
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"EnglishProductCategoryName", Order = 1, TypeName = "nvarchar")]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Key]
        [Display(Name = "English product category name")]
        public string EnglishProductCategoryName { get; set; } // EnglishProductCategoryName (Primary key) (length: 50)

        [Column(@"Model", Order = 2, TypeName = "nvarchar")]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Model")]
        public string Model { get; set; } // Model (length: 50)

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"CustomerKey", Order = 3, TypeName = "int")]
        [Required]
        [Key]
        [Display(Name = "Customer key")]
        public int CustomerKey { get; set; } // CustomerKey (Primary key)

        [Column(@"Region", Order = 4, TypeName = "nvarchar")]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Region")]
        public string Region { get; set; } // Region (length: 50)

        [Column(@"Age", Order = 5, TypeName = "int")]
        [Display(Name = "Age")]
        public int? Age { get; set; } // Age

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"IncomeGroup", Order = 6, TypeName = "varchar")]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(8)]
        [StringLength(8)]
        [Key]
        [Display(Name = "Income group")]
        public string IncomeGroup { get; set; } // IncomeGroup (Primary key) (length: 8)

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"CalendarYear", Order = 7, TypeName = "smallint")]
        [Required]
        [Key]
        [Display(Name = "Calendar year")]
        public short CalendarYear { get; set; } // CalendarYear (Primary key)

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"FiscalYear", Order = 8, TypeName = "smallint")]
        [Required]
        [Key]
        [Display(Name = "Fiscal year")]
        public short FiscalYear { get; set; } // FiscalYear (Primary key)

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"Month", Order = 9, TypeName = "tinyint")]
        [Required]
        [Key]
        [Display(Name = "Month")]
        public byte Month { get; set; } // Month (Primary key)

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"OrderNumber", Order = 10, TypeName = "nvarchar")]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(20)]
        [StringLength(20)]
        [Key]
        [Display(Name = "Order number")]
        public string OrderNumber { get; set; } // OrderNumber (Primary key) (length: 20)

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"LineNumber", Order = 11, TypeName = "tinyint")]
        [Required]
        [Key]
        [Display(Name = "Line number")]
        public byte LineNumber { get; set; } // LineNumber (Primary key)

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"Quantity", Order = 12, TypeName = "smallint")]
        [Required]
        [Key]
        [Display(Name = "Quantity")]
        public short Quantity { get; set; } // Quantity (Primary key)

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(@"Amount", Order = 13, TypeName = "money")]
        [Required]
        [Key]
        [DataType(DataType.Currency)]
        [Display(Name = "Amount")]
        public decimal Amount { get; set; } // Amount (Primary key)
    }

}
// </auto-generated>