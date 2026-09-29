using eShop.DataStore.HardCode;
using eShop.ShoppingCart.LocalStorage;
using eShop.Usecases;
using eShop.Usecases.PluginInterfaces.DataStore;
using eShop.Usecases.PluginInterfaces.UI;
using eShop.Usecases.SearchProductScreen;
using eShop.Usecases.ShoppingCartScreen;
using eShop.Usecases.ShoppingCartScreen.interfaces;
using eShop.Usecases.ViewProductScreen;
using eShop.Usecases.ViewProductScreen.interfaces;
using eShop.Usecases.ShoppingCartScreen;
using eShop.Usecases.ShoppingCartScreen.interfaces;
using eShop.Web1.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using eShop.Usecases.PluginInterfaces.StateStore;
using eShop.StateStore.DI;
using eShop.CoreBusiness.Services.interfaces;
using eShop.CoreBusiness.Services;
using eShop.Usecases.OrderConfirmationScreen;
using eShop.Usecases.AdminPortal.OutstandingOrderScreen;
using eShop.Usecases.AdminPortal.OrderDetailScreen.Interfaces;
using eShop.Usecases.AdminPortal.OrderDetailScreen;
using eShop.Usecases.AdminPortal.ProcessedOrdersScreen;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

builder.Services.AddSingleton<IProductReponsitory, ProductReponsitory>();
builder.Services.AddSingleton<IOrderRePonsitory, OrderReponsitory>();

builder.Services.AddScoped<IShoppingCart, ShoppingCart>();
builder.Services.AddScoped<IShoppingCartStateStore, ShoppingCartStateStore>();

builder.Services.AddTransient<IViewShoppingCartUseCase, ViewShoppingCartUseCase>();

builder.Services.AddTransient<IOrderSevice, OrderSevice>();
builder.Services.AddTransient<IViewProductUseCases, ViewProductUseCases>();
builder.Services.AddTransient<ISearchProductUseCases,  SearchProductUseCases>();
builder.Services.AddTransient<IAddProductToCartUseCase, AddProductToCartUseCase>();
builder.Services.AddTransient<IDeleteProductUseCase, DeleteProductUseCase>();
builder.Services.AddTransient<IUpdateQuantityUseCase, UpdateQuantityUseCase>();
builder.Services.AddTransient<IPlaceOrderUseCase, PlaceOrderUseCase>();

builder.Services.AddTransient<IViewOrderConfirmationUseCase, ViewOrderConfirmationUseCase>();

builder.Services.AddTransient<IViewOutstandingOrdersUseCase, ViewOutstandingOrdersUseCase>();
builder.Services.AddTransient<IViewOrderDetailUseCase, ViewOrderDetailUseCase>();
builder.Services.AddTransient<IProcessOrderUseCase, ProcessOrderUseCase>();
builder.Services.AddTransient<IViewProcessedOrdersUseCase, ViewProcessedOrdersUseCase>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
