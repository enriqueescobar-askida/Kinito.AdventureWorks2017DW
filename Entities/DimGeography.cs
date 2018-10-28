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

    // DimGeography
    [Table("DimGeography", Schema = "dbo")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class DimGeography
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"GeographyKey", Order = 1, TypeName = "int")]
        [Index(@"PK_DimGeography_GeographyKey", 1, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Geography key")]
        public int GeographyKey { get; set; } // GeographyKey (Primary key)

        [Column(@"City", Order = 2, TypeName = "nvarchar")]
        [MaxLength(30)]
        [StringLength(30)]
        [Display(Name = "City")]
        public string City { get; set; } // City (length: 30)

        [Column(@"StateProvinceCode", Order = 3, TypeName = "nvarchar")]
        [MaxLength(3)]
        [StringLength(3)]
        [Display(Name = "State province code")]
        public string StateProvinceCode { get; set; } // StateProvinceCode (length: 3)

        [Column(@"StateProvinceName", Order = 4, TypeName = "nvarchar")]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "State province name")]
        public string StateProvinceName { get; set; } // StateProvinceName (length: 50)

        [Column(@"CountryRegionCode", Order = 5, TypeName = "nvarchar")]
        [MaxLength(3)]
        [StringLength(3)]
        [Display(Name = "Country region code")]
        public string CountryRegionCode { get; set; } // CountryRegionCode (length: 3)

        [Column(@"EnglishCountryRegionName", Order = 6, TypeName = "nvarchar")]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "English country region name")]
        public string EnglishCountryRegionName { get; set; } // EnglishCountryRegionName (length: 50)

        [Column(@"SpanishCountryRegionName", Order = 7, TypeName = "nvarchar")]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Spanish country region name")]
        public string SpanishCountryRegionName { get; set; } // SpanishCountryRegionName (length: 50)

        [Column(@"FrenchCountryRegionName", Order = 8, TypeName = "nvarchar")]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "French country region name")]
        public string FrenchCountryRegionName { get; set; } // FrenchCountryRegionName (length: 50)

        [Column(@"PostalCode", Order = 9, TypeName = "nvarchar")]
        [MaxLength(15)]
        [StringLength(15)]
        [DataType(DataType.PostalCode)]
        [Display(Name = "Postal code")]
        public string PostalCode { get; set; } // PostalCode (length: 15)

        [Column(@"SalesTerritoryKey", Order = 10, TypeName = "int")]
        [Display(Name = "Sales territory key")]
        public int? SalesTerritoryKey { get; set; } // SalesTerritoryKey

        [Column(@"IpAddressLocator", Order = 11, TypeName = "nvarchar")]
        [MaxLength(15)]
        [StringLength(15)]
        [Display(Name = "Ip address locator")]
        public string IpAddressLocator { get; set; } // IpAddressLocator (length: 15)

        // Reverse navigation

        /// <summary>
        /// Child DimCustomers where [DimCustomer].[GeographyKey] point to this entity (FK_DimCustomer_DimGeography)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<DimCustomer> DimCustomers { get; set; } // DimCustomer.FK_DimCustomer_DimGeography
        /// <summary>
        /// Child DimResellers where [DimReseller].[GeographyKey] point to this entity (FK_DimReseller_DimGeography)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<DimReseller> DimResellers { get; set; } // DimReseller.FK_DimReseller_DimGeography

        // Foreign keys

        /// <summary>
        /// Parent DimSalesTerritory pointed by [DimGeography].([SalesTerritoryKey]) (FK_DimGeography_DimSalesTerritory)
        /// </summary>
        [ForeignKey("SalesTerritoryKey")] public virtual DimSalesTerritory DimSalesTerritory { get; set; } // FK_DimGeography_DimSalesTerritory

        public DimGeography()
        {
            DimCustomers = new System.Collections.Generic.List<DimCustomer>();
            DimResellers = new System.Collections.Generic.List<DimReseller>();
        }
    }

}
// </auto-generated>