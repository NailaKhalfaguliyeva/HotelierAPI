using FluentValidation;
using FluentValidation.AspNetCore;
using Hotelier.Api.DataAccessLayer.Concrete;
using Hotelier.Api.EntityLayer.Concrete;
using Hotelier.Api.WebUI.Dtos.GuestDto;
using Hotelier.Api.WebUI.Mapping;
using Hotelier.Api.WebUI.ValidationRules.GuestValidationRules;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<Context>();
builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<Context>();
builder.Services.AddHttpClient();
builder.Services.AddTransient<IValidator<CreateGuestDto>,GuestCreateValidator>();
builder.Services.AddTransient<IValidator<UpdateGuestDto>, UpdateGuestValidator>();
builder.Services.AddControllersWithViews().AddFluentValidation();
builder.Services.AddAutoMapper(typeof(AutoMapperConfig));
builder.Services.AddMvc(config=>
{
    var policy=new AuthorizationPolicyBuilder()
        .RequireAuthenticatedUser()
        .Build();
        config.Filters.Add(new AuthorizeFilter(policy));
});
builder.Services.ConfigureApplicationCookie(options=>
{
    options.Cookie.HttpOnly = true;
    options.ExpireTimeSpan =TimeSpan.FromMinutes(10);
    options.LoginPath = "/Login/Index";
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStatusCodePagesWithReExecute("/ErrorPage/Error404", "?code={}");
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAuthentication();
app.UseRouting();



app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
