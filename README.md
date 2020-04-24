# iOS Simulator Push Notifications

A simple MacOS application that can send a push notification to the iOS Simulator

## Requirements

You need Xcode 11.4 or above. This application uses the new `simctl` command to make this possible .

## Getting Started

Make sure that your application have the following code:

### C# (Xamarin.iOS)

```
var notificationCenter = UNUserNotificationCenter.Current;
notificationCenter.RequestAuthorization (UNAuthorizationOptions.Alert | UNAuthorizationOptions.Sound, IsGranted);

void IsGranted (bool granted, NSError error)
{
    if (granted) {
        Console.WriteLine ("The simulator can now receive push notifications");
    }
}
```

### Swift

```
let notificationCenter = UNUserNotificationCenter.current()
notificationCenter.requestAuthorization(options: [.alert, .sound]) { granted, error in
    // If `granted` is `true`, the simulator can now receive push notifications!!
}
```

## Built With

-   [Visuel Studio for Mac](https://visualstudio.microsoft.com/vs/mac/)
-   [Xamarin.Mac](https://docs.microsoft.com/en-us/xamarin/mac/)
-   [ReactiveUI](https://maven.apache.org/)

## Credits

-   [Avanderlee](https://www.avanderlee.com/workflow/testing-push-notifications-ios-simulator)

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details
