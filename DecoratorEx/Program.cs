using DecoratorEx;

CocerateSell cocerateSell = new CocerateSell();
SellNotification notification = new SellNotification();
notification.setProduct(cocerateSell);
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine(notification.SellProduct("11121", "apple"));