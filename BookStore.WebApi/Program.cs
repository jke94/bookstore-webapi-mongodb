namespace BookStore.WebApi
{
    #region using

    using BookStore.WebApi.Configurations;
    using BookStore.WebApi.Services;

    #endregion

    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services
                .Configure<BookStoreDatabaseSettings>(
            builder.Configuration.GetSection("BookStoreDatabase"));

            builder.Services.AddSingleton<BooksService>();

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            app.UseSwagger();
            app.UseSwaggerUI();

            // TODO: Temporally.
            // app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}