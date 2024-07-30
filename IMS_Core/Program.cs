using IMS_Core.DA;
using IMS_Core.Services;
using IMS_Core.Services.Interface;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddMvc(service => service.EnableEndpointRouting = false);
builder.Services.AddMvc().AddJsonOptions(o =>
{
    o.JsonSerializerOptions.PropertyNamingPolicy = null;
    o.JsonSerializerOptions.DictionaryKeyPolicy = null;
});
builder.Services.AddScoped<IClaimsData, ClaimsServices>();
builder.Services.AddDbContextPool<orcl_DbContext>(options =>
           options.UseOracle(builder.Configuration.GetConnectionString("IMSCoreString"),
           b => b.MigrationsAssembly("IMS_Core")));



var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.UseHttpsRedirection();
app.UseRouting();

app.UseMvc();
app.UseCors("AllowSpecificOrigin");

app.UseStaticFiles();
app.UseAuthorization();
app.UseAuthentication();



app.MapControllers();

app.UseAntiforgery();
app.Run();
