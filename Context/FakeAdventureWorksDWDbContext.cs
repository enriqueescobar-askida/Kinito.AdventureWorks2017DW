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


namespace Context
{
    using Configurations;
    using Entities;
    using Interfaces;
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;

    using System.Linq;

    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.2.0")]
    public class FakeAdventureWorksDWDbContext : IAdventureWorksDWDbContext
    {
        public System.Data.Entity.DbSet<DatabaseLog> DatabaseLogs { get; set; }
        public System.Data.Entity.DbSet<DimAccount> DimAccounts { get; set; }
        public System.Data.Entity.DbSet<DimCurrency> DimCurrencies { get; set; }
        public System.Data.Entity.DbSet<DimCustomer> DimCustomers { get; set; }
        public System.Data.Entity.DbSet<DimDate> DimDates { get; set; }
        public System.Data.Entity.DbSet<DimDepartmentGroup> DimDepartmentGroups { get; set; }
        public System.Data.Entity.DbSet<DimEmployee> DimEmployees { get; set; }
        public System.Data.Entity.DbSet<DimGeography> DimGeographies { get; set; }
        public System.Data.Entity.DbSet<DimOrganization> DimOrganizations { get; set; }
        public System.Data.Entity.DbSet<DimProduct> DimProducts { get; set; }
        public System.Data.Entity.DbSet<DimProductCategory> DimProductCategories { get; set; }
        public System.Data.Entity.DbSet<DimProductSubcategory> DimProductSubcategories { get; set; }
        public System.Data.Entity.DbSet<DimPromotion> DimPromotions { get; set; }
        public System.Data.Entity.DbSet<DimReseller> DimResellers { get; set; }
        public System.Data.Entity.DbSet<DimSalesReason> DimSalesReasons { get; set; }
        public System.Data.Entity.DbSet<DimSalesTerritory> DimSalesTerritories { get; set; }
        public System.Data.Entity.DbSet<DimScenario> DimScenarios { get; set; }
        public System.Data.Entity.DbSet<FactAdditionalInternationalProductDescription> FactAdditionalInternationalProductDescriptions { get; set; }
        public System.Data.Entity.DbSet<FactCallCenter> FactCallCenters { get; set; }
        public System.Data.Entity.DbSet<FactCurrencyRate> FactCurrencyRates { get; set; }
        public System.Data.Entity.DbSet<FactFinance> FactFinances { get; set; }
        public System.Data.Entity.DbSet<FactInternetSale> FactInternetSales { get; set; }
        public System.Data.Entity.DbSet<FactInternetSalesReason> FactInternetSalesReasons { get; set; }
        public System.Data.Entity.DbSet<FactProductInventory> FactProductInventories { get; set; }
        public System.Data.Entity.DbSet<FactResellerSale> FactResellerSales { get; set; }
        public System.Data.Entity.DbSet<FactSalesQuota> FactSalesQuotas { get; set; }
        public System.Data.Entity.DbSet<FactSurveyResponse> FactSurveyResponses { get; set; }
        public System.Data.Entity.DbSet<ProspectiveBuyer> ProspectiveBuyers { get; set; }
        public System.Data.Entity.DbSet<VAssocSeqLineItem> VAssocSeqLineItems { get; set; }
        public System.Data.Entity.DbSet<VAssocSeqOrder> VAssocSeqOrders { get; set; }
        public System.Data.Entity.DbSet<VDmPrep> VDmPreps { get; set; }
        public System.Data.Entity.DbSet<VTargetMail> VTargetMails { get; set; }
        public System.Data.Entity.DbSet<VTimeSery> VTimeSeries { get; set; }

        public FakeAdventureWorksDWDbContext()
        {
            _changeTracker = null;
            _configuration = null;
            _database = null;

            DatabaseLogs = new FakeDbSet<DatabaseLog>("DatabaseLogId");
            DimAccounts = new FakeDbSet<DimAccount>("AccountKey");
            DimCurrencies = new FakeDbSet<DimCurrency>("CurrencyKey");
            DimCustomers = new FakeDbSet<DimCustomer>("CustomerKey");
            DimDates = new FakeDbSet<DimDate>("DateKey");
            DimDepartmentGroups = new FakeDbSet<DimDepartmentGroup>("DepartmentGroupKey");
            DimEmployees = new FakeDbSet<DimEmployee>("EmployeeKey");
            DimGeographies = new FakeDbSet<DimGeography>("GeographyKey");
            DimOrganizations = new FakeDbSet<DimOrganization>("OrganizationKey");
            DimProducts = new FakeDbSet<DimProduct>("ProductKey");
            DimProductCategories = new FakeDbSet<DimProductCategory>("ProductCategoryKey");
            DimProductSubcategories = new FakeDbSet<DimProductSubcategory>("ProductSubcategoryKey");
            DimPromotions = new FakeDbSet<DimPromotion>("PromotionKey");
            DimResellers = new FakeDbSet<DimReseller>("ResellerKey");
            DimSalesReasons = new FakeDbSet<DimSalesReason>("SalesReasonKey");
            DimSalesTerritories = new FakeDbSet<DimSalesTerritory>("SalesTerritoryKey");
            DimScenarios = new FakeDbSet<DimScenario>("ScenarioKey");
            FactAdditionalInternationalProductDescriptions = new FakeDbSet<FactAdditionalInternationalProductDescription>("ProductKey", "CultureName");
            FactCallCenters = new FakeDbSet<FactCallCenter>("FactCallCenterId");
            FactCurrencyRates = new FakeDbSet<FactCurrencyRate>("CurrencyKey", "DateKey");
            FactFinances = new FakeDbSet<FactFinance>("FinanceKey", "DateKey", "OrganizationKey", "DepartmentGroupKey", "ScenarioKey", "AccountKey", "Amount");
            FactInternetSales = new FakeDbSet<FactInternetSale>("SalesOrderNumber", "SalesOrderLineNumber");
            FactInternetSalesReasons = new FakeDbSet<FactInternetSalesReason>("SalesOrderNumber", "SalesOrderLineNumber", "SalesReasonKey");
            FactProductInventories = new FakeDbSet<FactProductInventory>("ProductKey", "DateKey");
            FactResellerSales = new FakeDbSet<FactResellerSale>("SalesOrderNumber", "SalesOrderLineNumber");
            FactSalesQuotas = new FakeDbSet<FactSalesQuota>("SalesQuotaKey");
            FactSurveyResponses = new FakeDbSet<FactSurveyResponse>("SurveyResponseKey");
            ProspectiveBuyers = new FakeDbSet<ProspectiveBuyer>("ProspectiveBuyerKey");
            VAssocSeqLineItems = new FakeDbSet<VAssocSeqLineItem>("OrderNumber", "LineNumber");
            VAssocSeqOrders = new FakeDbSet<VAssocSeqOrder>("OrderNumber", "CustomerKey", "IncomeGroup");
            VDmPreps = new FakeDbSet<VDmPrep>("EnglishProductCategoryName", "CustomerKey", "IncomeGroup", "CalendarYear", "FiscalYear", "Month", "OrderNumber", "LineNumber", "Quantity", "Amount");
            VTargetMails = new FakeDbSet<VTargetMail>("CustomerKey", "CustomerAlternateKey", "BikeBuyer");
            VTimeSeries = new FakeDbSet<VTimeSery>("CalendarYear", "Month");
        }

        public int SaveChangesCount { get; private set; }
        public int SaveChanges()
        {
            ++SaveChangesCount;
            return 1;
        }

        public System.Threading.Tasks.Task<int> SaveChangesAsync()
        {
            ++SaveChangesCount;
            return System.Threading.Tasks.Task<int>.Factory.StartNew(() => 1);
        }

        public System.Threading.Tasks.Task<int> SaveChangesAsync(System.Threading.CancellationToken cancellationToken)
        {
            ++SaveChangesCount;
            return System.Threading.Tasks.Task<int>.Factory.StartNew(() => 1, cancellationToken);
        }

        protected virtual void Dispose(bool disposing)
        {
        }

        public void Dispose()
        {
            Dispose(true);
        }

        private System.Data.Entity.Infrastructure.DbChangeTracker _changeTracker;
        public System.Data.Entity.Infrastructure.DbChangeTracker ChangeTracker { get { return _changeTracker; } }
        private System.Data.Entity.Infrastructure.DbContextConfiguration _configuration;
        public System.Data.Entity.Infrastructure.DbContextConfiguration Configuration { get { return _configuration; } }
        private System.Data.Entity.Database _database;
        public System.Data.Entity.Database Database { get { return _database; } }
        public System.Data.Entity.Infrastructure.DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class
        {
            throw new System.NotImplementedException();
        }
        public System.Data.Entity.Infrastructure.DbEntityEntry Entry(object entity)
        {
            throw new System.NotImplementedException();
        }
        public System.Collections.Generic.IEnumerable<System.Data.Entity.Validation.DbEntityValidationResult> GetValidationErrors()
        {
            throw new System.NotImplementedException();
        }
        public System.Data.Entity.DbSet Set(System.Type entityType)
        {
            throw new System.NotImplementedException();
        }
        public System.Data.Entity.DbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            throw new System.NotImplementedException();
        }
        public override string ToString()
        {
            throw new System.NotImplementedException();
        }

    }
}
// </auto-generated>
