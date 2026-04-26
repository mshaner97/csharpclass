/*int invoiceNumber = 1201;
decimal productShares = 25.4568m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;

Console.WriteLine($"Invoice Number: {invoiceNumber}");
Console.WriteLine($"   Shares: {productShares:N3} Product");
Console.WriteLine($"     Sub Total: {subtotal:C}");
Console.WriteLine($"           Tax: {taxPercentage:P2}");
Console.WriteLine($"     Total Billed: {total:C}");

string paymentId = "769C";
 string payeeName = "Mr. Stephen Ortega";
 string paymentAmount = "$5,000.00";

 var formattedLine = paymentId.PadRight(6);
 formattedLine += payeeName.PadRight(24);
 formattedLine += paymentAmount.PadLeft(10);

 Console.WriteLine("1234567890123456789012345678901234567890");
 Console.WriteLine(formattedLine); */

 string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

Console.WriteLine($"Dear {customerName}, \nAs a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return. \n\nCurrently, you own {currentShares:N2} shares at a return of {currentReturn:P2}. \n\nOur new product, {newProduct} offers a return of {newReturn:P2}.  Given your current volume, your potential profit would be {newProfit:C}.\n");


Console.WriteLine("Here's a quick comparison:\n");

// var formattedLine = currentProduct.PadRight(10);
// string comparisonMessage = "";
// Console.WriteLine(comparisonMessage);
// Console.WriteLine($"{currentProduct}{currentReturn:P2}{currentProfit:C}");
// Console.WriteLine($"{newProduct}{newReturn:P2}{newProfit:C}");
 var comparisonMessage = currentProduct.PadRight(20);
 comparisonMessage += String.Format("{0:P}", currentReturn).PadRight(10);
 comparisonMessage += String.Format("{0:C}", currentProfit).PadRight(10);

 Console.WriteLine(comparisonMessage);
