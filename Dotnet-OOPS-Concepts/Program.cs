using Dotnet_OOPS_Concepts.Models;
using Dotnet_OOPS_Concepts.Notifications;
using Dotnet_OOPS_Concepts.Services;

Console.WriteLine("=== OOPs Concepts in .NET ===\n");

// Encapsulation Example
User user = new User("lata.k", "secret123");
Console.WriteLine($"Username: {user.Username}");
Console.WriteLine("Password Valid: " + user.ValidatePassword("secret123"));
Console.WriteLine();

// Abstraction, Inheritance, Polymorphism Example
var email = new EmailNotification();
var sms = new SMSNotification();

var notificationService = new NotificationService(new List<INotificationService> { email, sms });
notificationService.NotifyUser("lata@example.com", "Welcome to our application!");