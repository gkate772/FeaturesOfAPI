A ReportService directly depends on concrete classes like FileLogger and EmailService.

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

