using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DAL.Models
{
    public partial class Invoice_ElectronicContext : DbContext
    {
        public Invoice_ElectronicContext()
        {
        }

        public Invoice_ElectronicContext(DbContextOptions<Invoice_ElectronicContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ActivityType> ActivityTypes { get; set; }
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<AddressProperty> AddressProperties { get; set; }
        public virtual DbSet<AddressPropertyEvent> AddressPropertyEvents { get; set; }
        public virtual DbSet<AddressPropertyValidation> AddressPropertyValidations { get; set; }
        public virtual DbSet<Branch> Branches { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Delivery> Deliveries { get; set; }
        public virtual DbSet<Discount> Discounts { get; set; }
        public virtual DbSet<Document> Documents { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<InputController> InputControllers { get; set; }
        public virtual DbSet<InvoiceLine> InvoiceLines { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Signature> Signatures { get; set; }
        public virtual DbSet<TaxSubType> TaxSubTypes { get; set; }
        public virtual DbSet<TaxableItem> TaxableItems { get; set; }
        public virtual DbSet<TaxableType> TaxableTypes { get; set; }
        public virtual DbSet<UniteType> UniteTypes { get; set; }
        public virtual DbSet<UniteValue> UniteValues { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Validation> Validations { get; set; }
        public virtual DbSet<ValidationType> ValidationTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=CSHARP55;Initial Catalog=Invoice_Electronic;Integrated Security=True;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Arabic_CI_AS");

            modelBuilder.Entity<ActivityType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Adescription)
                    .HasMaxLength(1000)
                    .HasColumnName("ADescription");

                entity.Property(e => e.Code)
                    .HasMaxLength(200)
                    .HasColumnName("code");

                entity.Property(e => e.Edescription)
                    .HasMaxLength(1000)
                    .HasColumnName("EDescription");
            });

            modelBuilder.Entity<Address>(entity =>
            {
                entity.ToTable("Address");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AddressPropId).HasColumnName("address_prop_id");

                entity.Property(e => e.BranchId).HasColumnName("branch_Id");

                entity.Property(e => e.CountryId).HasColumnName("country_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.AddressProp)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.AddressPropId)
                    .HasConstraintName("FK_Address_Address_Property");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_Address_Branches");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_Address_Countries");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Address_Users");
            });

            modelBuilder.Entity<AddressProperty>(entity =>
            {
                entity.ToTable("Address_Property");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Caption)
                    .HasMaxLength(500)
                    .HasColumnName("caption");

                entity.Property(e => e.ControllerId).HasColumnName("controller_id");

                entity.Property(e => e.HasValidation).HasColumnName("hasValidation");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name");

                entity.Property(e => e.Notes)
                    .HasMaxLength(1000)
                    .HasColumnName("notes");

                entity.Property(e => e.Type)
                    .HasMaxLength(500)
                    .HasColumnName("type");

                entity.HasOne(d => d.Controller)
                    .WithMany(p => p.AddressProperties)
                    .HasForeignKey(d => d.ControllerId)
                    .HasConstraintName("FK_Address_Property_Controllers");
            });

            modelBuilder.Entity<AddressPropertyEvent>(entity =>
            {
                entity.ToTable("AddressProperty_Events");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AddressPropertyId).HasColumnName("addressProperty_id");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.Notes)
                    .HasMaxLength(500)
                    .HasColumnName("notes");

                entity.HasOne(d => d.AddressProperty)
                    .WithMany(p => p.AddressPropertyEvents)
                    .HasForeignKey(d => d.AddressPropertyId)
                    .HasConstraintName("FK_AddressProperty_Events_Address_Property");

                entity.HasOne(d => d.Event)
                    .WithMany(p => p.AddressPropertyEvents)
                    .HasForeignKey(d => d.EventId)
                    .HasConstraintName("FK_AddressProperty_Events_Events");
            });

            modelBuilder.Entity<AddressPropertyValidation>(entity =>
            {
                entity.ToTable("AddressProperty_Validations");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AddressPropertyId).HasColumnName("addressProperty_id");

                entity.Property(e => e.Name)
                    .HasMaxLength(500)
                    .HasColumnName("name");

                entity.Property(e => e.ValidationId).HasColumnName("validation_id");

                entity.Property(e => e.Value)
                    .HasMaxLength(1000)
                    .HasColumnName("value");

                entity.HasOne(d => d.AddressProperty)
                    .WithMany(p => p.AddressPropertyValidations)
                    .HasForeignKey(d => d.AddressPropertyId)
                    .HasConstraintName("FK_AddressProperty_Validations_Address_Property");

                entity.HasOne(d => d.Validation)
                    .WithMany(p => p.AddressPropertyValidations)
                    .HasForeignKey(d => d.ValidationId)
                    .HasConstraintName("FK_AddressProperty_Validations_Validations");
            });

            modelBuilder.Entity<Branch>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Identification)
                    .HasMaxLength(1000)
                    .HasColumnName("identification");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Desc_ar)
                    .HasMaxLength(1000)
                    .HasColumnName("Desc_ar");

                entity.Property(e => e.Code)
                    .HasMaxLength(200)
                    .HasColumnName("code");

                entity.Property(e => e.Desc_en)
                    .HasMaxLength(1000)
                    .HasColumnName("Desc_en");
            });

            modelBuilder.Entity<Delivery>(entity =>
            {
                entity.ToTable("Delivery");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Approach)
                    .HasMaxLength(500)
                    .HasColumnName("approach");

                entity.Property(e => e.CountryOfOrigin)
                    .HasMaxLength(500)
                    .HasColumnName("countryOfOrigin");

                entity.Property(e => e.DateValidity)
                    .HasColumnType("datetime")
                    .HasColumnName("dateValidity");

                entity.Property(e => e.ExportPort)
                    .HasMaxLength(500)
                    .HasColumnName("exportPort");

                entity.Property(e => e.GrossWeight)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("grossWeight");

                entity.Property(e => e.NetWeight)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("netWeight");

                entity.Property(e => e.Packaging)
                    .HasMaxLength(500)
                    .HasColumnName("packaging");

                entity.Property(e => e.Terms)
                    .HasMaxLength(200)
                    .HasColumnName("terms");
            });

            modelBuilder.Entity<Discount>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("amount");

                entity.Property(e => e.Rate)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("rate");
            });

            modelBuilder.Entity<Document>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DateTimeIssued)
                    .HasColumnType("datetime")
                    .HasColumnName("dateTime_issued");

                entity.Property(e => e.DeliveryId).HasColumnName("delivery_id");

                entity.Property(e => e.DocumentType)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("document_type");

                entity.Property(e => e.DocumentTypeVersion)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("document_type_version");

                entity.Property(e => e.ExtraDiscAmount)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("extra_disc_amount");

                entity.Property(e => e.InternalId)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("internalId");

                entity.Property(e => e.IssuerId).HasColumnName("issuer_id");

                entity.Property(e => e.NetAmount)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("net_amount");

                entity.Property(e => e.PaymentId).HasColumnName("payment_id");

                entity.Property(e => e.ProformaInvoiceNumber)
                    .HasMaxLength(500)
                    .HasColumnName("proformaInvoiceNumber");

                entity.Property(e => e.PurchaseOrderDescrip)
                    .HasMaxLength(1000)
                    .HasColumnName("purchase_order_descrip");

                entity.Property(e => e.PurchaseOrderRef)
                    .HasMaxLength(200)
                    .HasColumnName("purchase_order_ref");

                entity.Property(e => e.ReceiverId).HasColumnName("receiver_id");

                entity.Property(e => e.SalesOrderDescrip)
                    .HasMaxLength(1000)
                    .HasColumnName("sales_order_descrip");

                entity.Property(e => e.SalesOrderRef)
                    .HasMaxLength(200)
                    .HasColumnName("sales_order_ref");

                entity.Property(e => e.TaxpayerActivCode)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnName("taxpayer_activ_code");

                entity.Property(e => e.TotaSalesAmount)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("tota_sales_amount");

                entity.Property(e => e.TotalAmount)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("total_amount");

                entity.Property(e => e.TotalDiscAmount)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("total_disc_amount");

                entity.Property(e => e.TotalItemDiscAmount)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("total_item_disc_amount");

                entity.HasOne(d => d.Delivery)
                    .WithMany(p => p.Documents)
                    .HasForeignKey(d => d.DeliveryId)
                    .HasConstraintName("FK_Documents_Delivery");

                entity.HasOne(d => d.Issuer)
                    .WithMany(p => p.DocumentIssuers)
                    .HasForeignKey(d => d.IssuerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Documents_Users");

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.Documents)
                    .HasForeignKey(d => d.PaymentId)
                    .HasConstraintName("FK_Documents_Payments");

                entity.HasOne(d => d.Receiver)
                    .WithMany(p => p.DocumentReceivers)
                    .HasForeignKey(d => d.ReceiverId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Documents_Users1");
            });

            modelBuilder.Entity<Event>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Action)
                    .HasMaxLength(2000)
                    .HasColumnName("action");

                entity.Property(e => e.Name)
                    .HasMaxLength(500)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<InputController>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .HasColumnName("description");

                entity.Property(e => e.Name)
                    .HasMaxLength(500)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<InvoiceLine>(entity =>
            {
                entity.ToTable("Invoice_Line");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .HasColumnName("description");

                entity.Property(e => e.DiscountId).HasColumnName("discount_id");

                entity.Property(e => e.DocumentId).HasColumnName("document_id");

                entity.Property(e => e.InternalCode)
                    .HasMaxLength(500)
                    .HasColumnName("internalCode");

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(500)
                    .HasColumnName("itemCode");

                entity.Property(e => e.ItemType)
                    .HasMaxLength(500)
                    .HasColumnName("itemType");

                entity.Property(e => e.ItemsDiscount)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("itemsDiscount");

                entity.Property(e => e.NetTotal)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("netTotal");

                entity.Property(e => e.Quantity)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("quantity");

                entity.Property(e => e.SalesTotal)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("salesTotal");

                entity.Property(e => e.Total)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("total");

                entity.Property(e => e.TotalTaxableFees)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("totalTaxableFees");

                entity.Property(e => e.UnitTypeId).HasColumnName("unitType_id");

                entity.Property(e => e.UnitValueId).HasColumnName("unitValue_id");

                entity.Property(e => e.ValueDifference)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("valueDifference");

                entity.HasOne(d => d.Discount)
                    .WithMany(p => p.InvoiceLines)
                    .HasForeignKey(d => d.DiscountId)
                    .HasConstraintName("FK_Invoice_Line_Discounts");

                entity.HasOne(d => d.Document)
                    .WithMany(p => p.InvoiceLines)
                    .HasForeignKey(d => d.DocumentId)
                    .HasConstraintName("FK_Invoice_Line_Documents");

                entity.HasOne(d => d.UnitType)
                    .WithMany(p => p.InvoiceLines)
                    .HasForeignKey(d => d.UnitTypeId)
                    .HasConstraintName("FK_Invoice_Line_Unite_Types");

                entity.HasOne(d => d.UnitValue)
                    .WithMany(p => p.InvoiceLines)
                    .HasForeignKey(d => d.UnitValueId)
                    .HasConstraintName("FK_Invoice_Line_UniteValues");
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BankAccountIban)
                    .HasMaxLength(500)
                    .HasColumnName("bankAccountIBAN");

                entity.Property(e => e.BankAddress)
                    .HasMaxLength(500)
                    .HasColumnName("bankAddress");

                entity.Property(e => e.BankName)
                    .HasMaxLength(500)
                    .HasColumnName("bankName");

                entity.Property(e => e.SwiftCode)
                    .HasMaxLength(500)
                    .HasColumnName("swiftCode");

                entity.Property(e => e.Terms)
                    .HasMaxLength(500)
                    .HasColumnName("terms");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Signature>(entity =>
            {
                entity.ToTable("Signature");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IssureId).HasColumnName("issure_id");

                entity.Property(e => e.RecieverId).HasColumnName("reciever_id");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .HasColumnName("type");

                entity.Property(e => e.Value)
                    .HasMaxLength(500)
                    .HasColumnName("value")
                    .IsFixedLength(true);

                entity.HasOne(d => d.Issure)
                    .WithMany(p => p.SignatureIssures)
                    .HasForeignKey(d => d.IssureId)
                    .HasConstraintName("FK_Signature_Users");

                entity.HasOne(d => d.Reciever)
                    .WithMany(p => p.SignatureRecievers)
                    .HasForeignKey(d => d.RecieverId)
                    .HasConstraintName("FK_Signature_Users1");
            });

            modelBuilder.Entity<TaxSubType>(entity =>
            {
                entity.ToTable("Tax_SubTypes");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Adescription)
                    .HasMaxLength(500)
                    .HasColumnName("ADescription");

                entity.Property(e => e.Code)
                    .HasMaxLength(100)
                    .HasColumnName("code");

                entity.Property(e => e.Edescription)
                    .HasMaxLength(500)
                    .HasColumnName("EDescription");

                entity.Property(e => e.TaxTypeId).HasColumnName("taxType_id");

                entity.HasOne(d => d.TaxType)
                    .WithMany(p => p.TaxSubTypes)
                    .HasForeignKey(d => d.TaxTypeId)
                    .HasConstraintName("FK_Tax_SubTypes_Taxable_Types");
            });

            modelBuilder.Entity<TaxableItem>(entity =>
            {
                entity.ToTable("Taxable_Item");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("amount");

                entity.Property(e => e.InvoiceLineId).HasColumnName("invoiceLine_id");

                entity.Property(e => e.Rate)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("rate");

                entity.Property(e => e.SubTypeId).HasColumnName("subType_id");

                entity.Property(e => e.TaxTypeId).HasColumnName("taxType_id");

                entity.HasOne(d => d.InvoiceLine)
                    .WithMany(p => p.TaxableItems)
                    .HasForeignKey(d => d.InvoiceLineId)
                    .HasConstraintName("FK_Taxable_Item_Invoice_Line");

                entity.HasOne(d => d.SubType)
                    .WithMany(p => p.TaxableItems)
                    .HasForeignKey(d => d.SubTypeId)
                    .HasConstraintName("FK_Taxable_Item_Tax_SubTypes");

                entity.HasOne(d => d.TaxType)
                    .WithMany(p => p.TaxableItems)
                    .HasForeignKey(d => d.TaxTypeId)
                    .HasConstraintName("FK_Taxable_Item_Taxable_Types");
            });

            modelBuilder.Entity<TaxableType>(entity =>
            {
                entity.ToTable("Taxable_Types");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Adescription)
                    .HasMaxLength(1000)
                    .HasColumnName("ADescription");

                entity.Property(e => e.Code)
                    .HasMaxLength(100)
                    .HasColumnName("code");

                entity.Property(e => e.Edescription)
                    .HasMaxLength(1000)
                    .HasColumnName("EDescription");
            });

            modelBuilder.Entity<UniteType>(entity =>
            {
                entity.ToTable("Unite_Types");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aname)
                    .HasMaxLength(500)
                    .HasColumnName("AName");

                entity.Property(e => e.Code)
                    .HasMaxLength(500)
                    .HasColumnName("code");

                entity.Property(e => e.Ename)
                    .HasMaxLength(500)
                    .HasColumnName("EName");
            });

            modelBuilder.Entity<UniteValue>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AmountEgp)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("amountEGP");

                entity.Property(e => e.AmountSold)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("amountSold");

                entity.Property(e => e.CurrencyExchangeRate)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("currencyExchangeRate");

                entity.Property(e => e.CurrencySold)
                    .HasMaxLength(500)
                    .HasColumnName("currencySold");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ActivityTypeId).HasColumnName("activityType_id");

                entity.Property(e => e.Identification)
                    .HasMaxLength(500)
                    .HasColumnName("identification");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name");

                entity.Property(e => e.RoleId).HasColumnName("role_id");

                entity.Property(e => e.SignatureId).HasColumnName("signature_id");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .HasColumnName("type");

                entity.HasOne(d => d.ActivityType)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.ActivityTypeId)
                    .HasConstraintName("FK_Users_ActivityTypes");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_Users_Roles");
            });

            modelBuilder.Entity<Validation>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ControllerNames)
                    .HasMaxLength(3900)
                    .HasColumnName("controllerNames");

                entity.Property(e => e.HasValue).HasColumnName("hasValue");

                entity.Property(e => e.Name)
                    .HasMaxLength(500)
                    .HasColumnName("name");

                entity.Property(e => e.ValidationTypeId).HasColumnName("validationType_id");

                entity.HasOne(d => d.ValidationType)
                    .WithMany(p => p.Validations)
                    .HasForeignKey(d => d.ValidationTypeId)
                    .HasConstraintName("FK_Validations_Validation_Types");
            });

            modelBuilder.Entity<ValidationType>(entity =>
            {
                entity.ToTable("Validation_Types");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .HasColumnName("description");

                entity.Property(e => e.Name)
                    .HasMaxLength(500)
                    .HasColumnName("name");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
