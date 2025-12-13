@@ Wiithout DI
--->A ReportService directly depends on concrete classes like FileLogger and EmailService.

1) ReportService creates objects directly
new FileLogger();
new EmailService();

2) If you change:
FileLogger → DatabaseLogger
EmailService → SmsService

Problems Caused
Low flexibility → Cannot change implementations easily
Code rigidity → Small change causes many changes
Violates SOLID → Breaks Dependency Inversion Principle

---> Direct object creation
new SmsService();
new WhatsAppService();
new DatabaseLogger();

1) ReportService controls all dependencies
Concrete dependency lock-in
If DatabaseLogger changes to FileLogger

2) Any new notification type = modify ReportService

High coupling occurs when a class directly creates and depends on multiple concrete services,
causing tight dependency, low flexibility, and poor testability.


---> Constructor Usage (Still High Coupling)

