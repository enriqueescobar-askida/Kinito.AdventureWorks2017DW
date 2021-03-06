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

    // FactSurveyResponse
    [Table("FactSurveyResponse", Schema = "dbo")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class FactSurveyResponse
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"SurveyResponseKey", Order = 1, TypeName = "int")]
        [Index(@"PK_FactSurveyResponse_SurveyResponseKey", 1, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Survey response key")]
        public int SurveyResponseKey { get; set; } // SurveyResponseKey (Primary key)

        [Column(@"DateKey", Order = 2, TypeName = "int")]
        [Required]
        [Display(Name = "Date key")]
        public int DateKey { get; set; } // DateKey

        [Column(@"CustomerKey", Order = 3, TypeName = "int")]
        [Required]
        [Display(Name = "Customer key")]
        public int CustomerKey { get; set; } // CustomerKey

        [Column(@"ProductCategoryKey", Order = 4, TypeName = "int")]
        [Required]
        [Display(Name = "Product category key")]
        public int ProductCategoryKey { get; set; } // ProductCategoryKey

        [Column(@"EnglishProductCategoryName", Order = 5, TypeName = "nvarchar")]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "English product category name")]
        public string EnglishProductCategoryName { get; set; } // EnglishProductCategoryName (length: 50)

        [Column(@"ProductSubcategoryKey", Order = 6, TypeName = "int")]
        [Required]
        [Display(Name = "Product subcategory key")]
        public int ProductSubcategoryKey { get; set; } // ProductSubcategoryKey

        [Column(@"EnglishProductSubcategoryName", Order = 7, TypeName = "nvarchar")]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "English product subcategory name")]
        public string EnglishProductSubcategoryName { get; set; } // EnglishProductSubcategoryName (length: 50)

        [Column(@"Date", Order = 8, TypeName = "datetime")]
        [DataType(DataType.DateTime)]
        [Display(Name = "Date")]
        public System.DateTime? Date { get; set; } // Date

        // Foreign keys

        /// <summary>
        /// Parent DimCustomer pointed by [FactSurveyResponse].([CustomerKey]) (FK_FactSurveyResponse_CustomerKey)
        /// </summary>
        [ForeignKey("CustomerKey"), Required] public virtual DimCustomer DimCustomer { get; set; } // FK_FactSurveyResponse_CustomerKey

        /// <summary>
        /// Parent DimDate pointed by [FactSurveyResponse].([DateKey]) (FK_FactSurveyResponse_DateKey)
        /// </summary>
        [ForeignKey("DateKey"), Required] public virtual DimDate DimDate { get; set; } // FK_FactSurveyResponse_DateKey
    }

}
// </auto-generated>
