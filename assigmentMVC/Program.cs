using assigmentMVC.Models;

namespace lession1MVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            //add service to the container
            builder.Services.AddControllersWithViews();
            builder.Services.AddMvc();

            builder.Services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(20);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });

            var app = builder.Build();

            //Configure the HTTP request pipline
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                //The default HSTS value is 30 days. You may so change this for the production senarios
                app.UseHsts();
            }

            //This will use the https "requset"
            app.UseHttpsRedirection();
            //To use css and html root from root
            //app.UseDefaultFiles();
            //Allow to use static file using css from root
            app.UseStaticFiles();

            app.UseSession();
            //use the routing 
            app.UseRouting();
            //for the authorization
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapControllerRoute(
                //   name: "PrefLangCustomRoute",
                //   pattern: "PreferdLanguage",
                //   defaults: new { controller = "Demo", action = "PreferdLanguageCookie" }
                //   );
                endpoints.MapControllerRoute(
                    name: "FeverRoute",
                    pattern: "FeverCheck",
                    defaults: new {controller = "Doctor", action = "FeverCheck"}
                    );
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}"
                    );
            });

            //app.MapGet("/Home", () => "Hello Happy hacker!"); comment out
            app.Run();
        }
    }
}