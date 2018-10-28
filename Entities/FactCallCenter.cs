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

    // FactCallCenter
    [Table("FactCallCenter", Schema = "dbo")]
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class FactCallCenter
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(@"FactCallCenterID", Order = 1, TypeName = "int")]
        [Index(@"PK_FactCallCenter_FactCallCenterID", 1, IsUnique = true, IsClustered = true)]
        [Required]
        [Key]
        [Display(Name = "Fact call center ID")]
        public int FactCallCenterId { get; set; } // FactCallCenterID (Primary key)

        [Column(@"DateKey", Order = 2, TypeName = "int")]
        [Index(@"AK_FactCallCenter_DateKey_Shift", 1, IsUnique = true, IsClustered = false)]
        [Required]
        [Display(Name = "Date key")]
        public int DateKey { get; set; } // DateKey

        [Column(@"WageType", Order = 3, TypeName = "nvarchar")]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(15)]
        [StringLength(15)]
        [Display(Name = "Wage type")]
        public string WageType { get; set; } // WageType (length: 15)

        [Column(@"Shift", Order = 4, TypeName = "nvarchar")]
        [Index(@"AK_FactCallCenter_DateKey_Shift", 2, IsUnique = true, IsClustered = false)]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "Shift")]
        public string Shift { get; set; } // Shift (length: 20)

        [Column(@"LevelOneOperators", Order = 5, TypeName = "smallint")]
        [Required]
        [Display(Name = "Level one operators")]
        public short LevelOneOperators { get; set; } // LevelOneOperators

        [Column(@"LevelTwoOperators", Order = 6, TypeName = "smallint")]
        [Required]
        [Display(Name = "Level two operators")]
        public short LevelTwoOperators { get; set; } // LevelTwoOperators

        [Column(@"TotalOperators", Order = 7, TypeName = "smallint")]
        [Required]
        [Display(Name = "Total operators")]
        public short TotalOperators { get; set; } // TotalOperators

        [Column(@"Calls", Order = 8, TypeName = "int")]
        [Required]
        [Display(Name = "Calls")]
        public int Calls { get; set; } // Calls

        [Column(@"AutomaticResponses", Order = 9, TypeName = "int")]
        [Required]
        [Display(Name = "Automatic responses")]
        public int AutomaticResponses { get; set; } // AutomaticResponses

        [Column(@"Orders", Order = 10, TypeName = "int")]
        [Required]
        [Display(Name = "Orders")]
        public int Orders { get; set; } // Orders

        [Column(@"IssuesRaised", Order = 11, TypeName = "smallint")]
        [Required]
        [Display(Name = "Issues raised")]
        public short IssuesRaised { get; set; } // IssuesRaised

        [Column(@"AverageTimePerIssue", Order = 12, TypeName = "smallint")]
        [Required]
        [Display(Name = "Average time per issue")]
        public short AverageTimePerIssue { get; set; } // AverageTimePerIssue

        [Column(@"ServiceGrade", Order = 13, TypeName = "float")]
        [Required]
        [Display(Name = "Service grade")]
        public double ServiceGrade { get; set; } // ServiceGrade

        [Column(@"Date", Order = 14, TypeName = "datetime")]
        [DataType(DataType.DateTime)]
        [Display(Name = "Date")]
        public System.DateTime? Date { get; set; } // Date

        // Foreign keys

        /// <summary>
        /// Parent DimDate pointed by [FactCallCenter].([DateKey]) (FK_FactCallCenter_DimDate)
        /// </summary>
        [ForeignKey("DateKey"), Required] public virtual DimDate DimDate { get; set; } // FK_FactCallCenter_DimDate
    }

}
// </auto-generated>