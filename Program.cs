using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WebsiteCms.Services;

var builder = WebApplication.CreateBuilder(args);

// Configure EF Core with connection string
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Configure Identity with roles and EF stores
builder.Services
    .AddDefaultIdentity<IdentityUser>(options =>
    {
        options.SignIn.RequireConfirmedAccount = false;
        options.Password.RequireNonAlphanumeric = false;
        options.Password.RequireUppercase = false;
    })
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

// Define the area route first so that it matches area requests
app.MapControllerRoute(
    name: "areas",
    pattern: "{area:exists}/{controller=Documents}/{action=Index}/{id?}");

// Then define the default non-area route
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// Add Razor Pages route (for Identity UI)
app.MapRazorPages();

// Seed the admin user and role asynchronously
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    await SeedIdentityAsync(services);
}

app.Run();

static async Task SeedIdentityAsync(IServiceProvider services)
{
    var userManager = services.GetRequiredService<UserManager<IdentityUser>>();
    var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();

    const string adminRole = "Admin";
    const string adminEmail = "admin@yapt.local";
    const string adminPass = "Admin#12345"; // Change in production

    if (!await roleManager.RoleExistsAsync(adminRole))
        await roleManager.CreateAsync(new IdentityRole(adminRole));

    var user = await userManager.FindByEmailAsync(adminEmail);
    if (user is null)
    {
        user = new IdentityUser
        {
            UserName = adminEmail,
            Email = adminEmail,
            EmailConfirmed = true
        };
        var createResult = await userManager.CreateAsync(user, adminPass);
        if (!createResult.Succeeded)
        {
            throw new Exception("Failed to create admin user: " +
                string.Join(", ", createResult.Errors.Select(e => e.Description)));
        }
    }

    if (!await userManager.IsInRoleAsync(user, adminRole))
        await userManager.AddToRoleAsync(user, adminRole);
}
