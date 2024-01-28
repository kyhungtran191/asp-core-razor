namespace razor_asp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllers();
            builder.Services.AddRazorPages();
            var app = builder.Build();
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.MapControllers();
            app.MapRazorPages();
            app.Run();
        }
    }
}