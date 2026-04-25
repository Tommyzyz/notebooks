#:property TargetFramework=net10.0-windows10.0.19041.0
#:property  WindowsPackageType=None

#:package Microsoft.WindowsAppSDK@1.8.260416003



using Microsoft.Windows.AppNotifications;
using Microsoft.Windows.AppNotifications.Builder;

Console.WriteLine("Console App Notification Test");

// Step 1: Register for notification activation
AppNotificationManager.Default.NotificationInvoked += (sender, args) =>
{
    Console.WriteLine($"Notification activated! Arguments: {args.Argument}");
};

AppNotificationManager.Default.Register();

// Step 2: Send a notification
var notification = new AppNotificationBuilder()
    .AddArgument("action", "viewItem")
    .AddText("Console Notification")
    .AddText("This was sent from a console app using Windows App SDK.")
    .AddButton(new AppNotificationButton("Acknowledge")
        .AddArgument("action", "acknowledge"))
    .BuildNotification();

AppNotificationManager.Default.Show(notification);

// Step 3: Wait for user interaction
Console.WriteLine("Notification sent! Click it to test activation.");
Console.WriteLine("Press Enter to exit.");
Console.ReadLine();

AppNotificationManager.Default.Unregister();