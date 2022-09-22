Imports Microsoft.AspNetCore.Builder
Imports Microsoft.Extensions.DependencyInjection
Imports Microsoft.Extensions.Hosting

Module Program
    Sub Main(args As String())
        Dim Builder = WebApplication.CreateBuilder(args)

        Builder.Services.AddEndpointsApiExplorer()
        Builder.Services.AddSwaggerGen()

        Dim App = Builder.Build()

        If App.Environment.IsDevelopment Then
            App.UseSwagger()
            App.UseSwaggerUI()
        End If

        App.UseHttpsRedirection()

        Dim summaries As String() = {"Freezing", "Bracing", "Chilly", "Cool",
            "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"}

        App.MapGet("/weatherforecast", Function() New WeatherForecast() With {
            .Date = DateTime.Now,
            .TemperatureC = New Random().Next(-20, 55),
            .Summary = summaries(New Random().Next(summaries.Length))
        }).WithName("GetWeatherForecast")

        App.Run()
    End Sub

    Public Class WeatherForecast
        Public Property [Date] As DateTime
        Public Property TemperatureC As Integer
        Public Property Summary As String
        Public ReadOnly Property TemperatureF As Integer
            Get
                Return 32 + CInt((TemperatureC / 0.5556))
            End Get
        End Property
    End Class

End Module
