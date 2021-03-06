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

    // DimReseller
    [Table("DimReseller", Schema = "dbo")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class DimReseller
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"ResellerKey", Order = 1, TypeName = "int")]
        [Index(@"PK_DimReseller_ResellerKey", 1, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Reseller key")]
        public int ResellerKey { get; set; } // ResellerKey (Primary key)

        [Column(@"GeographyKey", Order = 2, TypeName = "int")]
        [Display(Name = "Geography key")]
        public int? GeographyKey { get; set; } // GeographyKey

        [Column(@"ResellerAlternateKey", Order = 3, TypeName = "nvarchar")]
        [Index(@"AK_DimReseller_ResellerAlternateKey", 1, IsUnique = true, IsClustered = false)]
        [MaxLength(15)]
        [StringLength(15)]
        [Display(Name = "Reseller alternate key")]
        public string ResellerAlternateKey { get; set; } // ResellerAlternateKey (length: 15)

        [Column(@"Phone", Order = 4, TypeName = "nvarchar")]
        [MaxLength(25)]
        [StringLength(25)]
        [Phone]
        [Display(Name = "Phone")]
        public string Phone { get; set; } // Phone (length: 25)

        [Column(@"BusinessType", Order = 5, TypeName = "varchar")]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "Business type")]
        public string BusinessType { get; set; } // BusinessType (length: 20)

        [Column(@"ResellerName", Order = 6, TypeName = "nvarchar")]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Reseller name")]
        public string ResellerName { get; set; } // ResellerName (length: 50)

        [Column(@"NumberEmployees", Order = 7, TypeName = "int")]
        [Display(Name = "Number employees")]
        public int? NumberEmployees { get; set; } // NumberEmployees

        [Column(@"OrderFrequency", Order = 8, TypeName = "char")]
        [MaxLength(1)]
        [StringLength(1)]
        [Display(Name = "Order frequency")]
        public string OrderFrequency { get; set; } // OrderFrequency (length: 1)

        [Column(@"OrderMonth", Order = 9, TypeName = "tinyint")]
        [Display(Name = "Order month")]
        public byte? OrderMonth { get; set; } // OrderMonth

        [Column(@"FirstOrderYear", Order = 10, TypeName = "int")]
        [Display(Name = "First order year")]
        public int? FirstOrderYear { get; set; } // FirstOrderYear

        [Column(@"LastOrderYear", Order = 11, TypeName = "int")]
        [Display(Name = "Last order year")]
        public int? LastOrderYear { get; set; } // LastOrderYear

        [Column(@"ProductLine", Order = 12, TypeName = "nvarchar")]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Product line")]
        public string ProductLine { get; set; } // ProductLine (length: 50)

        [Column(@"AddressLine1", Order = 13, TypeName = "nvarchar")]
        [MaxLength(60)]
        [StringLength(60)]
        [Display(Name = "Address line 1")]
        public string AddressLine1 { get; set; } // AddressLine1 (length: 60)

        [Column(@"AddressLine2", Order = 14, TypeName = "nvarchar")]
        [MaxLength(60)]
        [StringLength(60)]
        [Display(Name = "Address line 2")]
        public string AddressLine2 { get; set; } // AddressLine2 (length: 60)

        [Column(@"AnnualSales", Order = 15, TypeName = "money")]
        [DataType(DataType.Currency)]
        [Display(Name = "Annual sales")]
        public decimal? AnnualSales { get; set; } // AnnualSales

        [Column(@"BankName", Order = 16, TypeName = "nvarchar")]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Bank name")]
        public string BankName { get; set; } // BankName (length: 50)

        [Column(@"MinPaymentType", Order = 17, TypeName = "tinyint")]
        [Display(Name = "Min payment type")]
        public byte? MinPaymentType { get; set; } // MinPaymentType

        [Column(@"MinPaymentAmount", Order = 18, TypeName = "money")]
        [DataType(DataType.Currency)]
        [Display(Name = "Min payment amount")]
        public decimal? MinPaymentAmount { get; set; } // MinPaymentAmount

        [Column(@"AnnualRevenue", Order = 19, TypeName = "money")]
        [DataType(DataType.Currency)]
        [Display(Name = "Annual revenue")]
        public decimal? AnnualRevenue { get; set; } // AnnualRevenue

        [Column(@"YearOpened", Order = 20, TypeName = "int")]
        [Display(Name = "Year opened")]
        public int? YearOpened { get; set; } // YearOpened

        // Reverse navigation

        /// <summary>
        /// Child FactResellerSales where [FactResellerSales].[ResellerKey] point to this entity (FK_FactResellerSales_DimReseller)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<FactResellerSale> FactResellerSales { get; set; } // FactResellerSales.FK_FactResellerSales_DimReseller

        // Foreign keys

        /// <summary>
        /// Parent DimGeography pointed by [DimReseller].([GeographyKey]) (FK_DimReseller_DimGeography)
        /// </summary>
        [ForeignKey("GeographyKey")] public virtual DimGeography DimGeography { get; set; } // FK_DimReseller_DimGeography

        public DimReseller()
        {
            FactResellerSales = new System.Collections.Generic.List<FactResellerSale>();
        }
    }

}
// </auto-generated>
