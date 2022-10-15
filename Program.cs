using Microsoft.AspNetCore.Http;
using NorthwindData;

namespace VuePlanner
{
    public class Program
    {
        public static string result = "";
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            
            #region READ
            using (var db = new NorthwindContext())
            {
                result = db.ContextId.ToString();
                Console.WriteLine($"[DB_ID][{db.ContextId}]");
                foreach (var con in db.Customers)
                {
                    //Console.WriteLine($"[CustomerID][{con.CustomerId}][Name][{con.ContactName}][City][{con.City}]");
                    //Console.WriteLine(con.ToString());
                }
                //db.Customers.ToList().ForEach(c => Console.WriteLine(c));
            }
            #endregion
            
            app.Run();
        }
    }
}