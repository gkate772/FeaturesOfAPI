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
---> Property Usage (Still High Coupling)
--->Method Usage (Still High Coupling)
1)Why still high coupling?
Method signature locked to concrete classes
Every call must know all implementations

Using constructor, property, or method alone does NOT reduce coupling.


@@ With DI
Order Processing System
DI style (constructor / property / method) WITHOUT interfaces,
so it’s easy to understand and remember.

OrderProcessor → main business class
SmsNotifier → sends SMS
WhatsAppNotifier → sends WhatsApp message
DatabaseAuditLogger → logs to database
(No interfaces, no DI framework)

--->1 Constructor Injection (Without Interfaces)
--->2 Property Injection (Without Interfaces)
--->3 Method Injection (Without Interfaces)

* Constructor / Property / Method injection without interfaces only moves object creation outside the class.
Coupling is reduced slightly but NOT eliminated.


@@ ONE SINGLE CLASS that demonstrates all three types of injection
(Constructor, Property, Method) WITHOUT interfaces.

Single-Class Example

Class Name: PaymentProcessor
Dependencies:
SmsNotifier
EmailNotifier
DatabaseLogger

ONE CLASS WITH ALL 3 INJECTION TYPES

* Using constructor, property,
and method injection without interfaces only changes how dependencies are supplied;
it does not remove tight coupling.


---> PaymentProcessor class and demonstrates constructor, property, 
and method injection using interfaces.


@@ DI Container
A Dependency Injection (DI) Container is a framework/component that:
✔ Creates objects
✔ Manages their dependencies
✔ Controls object lifetime
✔ Injects dependencies automatically

👉 You don’t use `new` everywhere.
👉 The container resolves and injects dependencies for you.

* Built-in DI Container in .NET

Step 1 Install Package (if needed)
Microsoft.Extensions.DependencyInjection

Step 2 Configure Container (Service Registration)

Step 3 Resolve Services

* Service Lifetimes (Very Important)

| Lifetime    | Meaning                       |
| ----------- | ----------------------------- |
| `Transient` | New instance every time       |
| `Scoped`    | Same instance per request     |
| `Singleton` | One instance for app lifetime |


** Note :- The built-in .NET DI container does not support property injection automatically.
temporary remove  property injection in code.

@@ Service Lifetime

1 Transient
👉 New instance every time
Meaning
A new object is created each time it is requested
Even within the same request, you get different instances

2 Scoped
👉 Same instance per request
Meaning
One instance is created per scope
In ASP.NET Core → scope = HTTP request
Same instance shared within that request
New request → new instance

3 Singleton
👉 One instance for entire application
Meaning
Only one instance is created
Shared across all requests & users
Created once and reused

| Lifetime  | Instances Created | Shared             | Common Use         |
| --------- | ----------------- | ------------------ | ------------------ |
| Transient | Every request     | ❌                 | Helpers, utilities |
| Scoped    | Per request       | ✔ (within request) | DbContext          |
| Singleton | Once              | ✔ (global)         | Cache, config      |

Note : A Singleton must NOT depend on a Scoped service

