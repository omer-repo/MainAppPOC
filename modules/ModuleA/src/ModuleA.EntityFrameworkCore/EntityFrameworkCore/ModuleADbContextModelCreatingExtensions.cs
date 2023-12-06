using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace ModuleA.EntityFrameworkCore;

public static class ModuleADbContextModelCreatingExtensions
{
    public static void ConfigureModuleA(
        this ModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));

        /* Configure all entities here. Example:

        builder.Entity<Question>(b =>
        {
            //Configure table & schema name
            b.ToTable(ModuleADbProperties.DbTablePrefix + "Questions", ModuleADbProperties.DbSchema);

            b.ConfigureByConvention();

            //Properties
            b.Property(q => q.Title).IsRequired().HasMaxLength(QuestionConsts.MaxTitleLength);

            //Relations
            b.HasMany(question => question.Tags).WithOne().HasForeignKey(qt => qt.QuestionId);

            //Indexes
            b.HasIndex(q => q.CreationTime);
        });
        */

        builder.Entity<Reservation>(b =>
        {
            b.ToTable(ModuleADbProperties.DbTablePrefix + "Reservations", ModuleADbProperties.DbSchema);
            b.ConfigureByConvention();
        });
    }
}
