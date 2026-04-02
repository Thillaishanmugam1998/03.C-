# ASP.NET Core Structure

## What is this concept?

ASP.NET Core Structure na oru Web API project-la files and folders epdi organize pannuvom, yaar enna responsibility handle pannuvanga, startup flow epdi irukkum nu sollra concept. Simple-a sonna, idhu project architecture-oda basic shape.

Topic 3-la namma REST design paathom. Ippo Topic 4-la, andha REST API project-a clean-a epdi organize panna vendum nu paakaporom. Idhu romba mukkiyam because code work pannradhu mattum pothadhu illa; code easy-a read panna, maintain panna, extend panna mudiyanum.

ASP.NET Core project structure usually indha parts vechurukkum:
- `Program.cs`
- `Controllers/`
- `Models/`
- `Services/`
- `Contracts/`
- `Properties/`
- `appsettings.json`
- project file (`.csproj`)

## Why we use this?

Proper structure use pannina:
- code easy-a understand panna mudiyum
- new developer quickly onboard aaguvaar
- responsibilities clear-a separate aagum
- testing easier aagum
- future growth smooth aagum

Example:

Oru order API-la ella logic-um controller file-kulla irundha:
- route logic
- validation logic
- business logic
- data storage logic

ellam mix aagidum.

Aana structure use pannina:
- controller request handle pannum
- service business/data logic handle pannum
- model data shape represent pannum
- contract abstraction define pannum

## What problem it solves?

ASP.NET Core structure mainly solve pannura problems:

### 1. Code clutter
Ella logic-um one file-la irundha file romba perusaagum.

### 2. Responsibility confusion
Controller enna panna vendum, service enna panna vendum nu mix aagidum.

### 3. Maintainability issue
Small change pannave multiple unrelated code sections touch panna vendiyadhu varum.

### 4. Reusability issue
Business logic controller-kulla irundha, adha reuse panna kashtam.

### 5. Team collaboration problem
Multiple developers same file-la work pannina merge conflict and confusion varum.

## What happens if not used?

Proper structure illaama API build pannina:
- everything `Program.cs` illa controller-la dump panniduvanga
- business logic duplicate aagum
- project grow aagumbodhu read panna kashtam aagum
- debugging time increase aagum
- future topics madhiri DI, middleware, EF Core integrate panna kashtam aagum

Simple-a:
Structure illaadha project start-la okay madhiri theriyum. Scale aana udane weak point theriyum.

## Internal working (step-by-step flow)

Namma current ASP.NET Core structured project-la request epdi flow aagudhu nu paapom.

### Step 1: Application startup

`Program.cs` run aagum.

Ithu:
- services register pannum
- controllers enable pannum
- app build pannum
- routes map pannum

### Step 2: Request controller reach aagum

Example:
- `GET /api/orders`

ASP.NET Core route match panni `OrdersController` action-ku request anuppum.

### Step 3: Controller request handle pannum

Controller job:
- request receive panna
- input accept panna
- service call panna
- correct HTTP response anuppa

Controller heavy business logic vechikka koodadhu.

### Step 4: Service actual work pannum

Namma `OrderService`:
- orders fetch pannudhu
- order create pannudhu
- update pannudhu
- delete pannudhu

Ithu controller-lendhu logic separate pannudhu.

### Step 5: Models data shape represent pannum

Models example:
- `Order`
- `CreateOrderRequest`
- `UpdateOrderRequest`
- `UpdateOrderStatusRequest`

Iva data epdi irukkanum nu represent pannum.

### Step 6: Contract abstraction define pannum

`IOrderService` interface enna methods available nu define pannudhu.

Benefit:
- controller implementation mela direct depend aagaadhu
- interface mela depend aagum

Idhu later testing and cleaner architecture-ku useful.

### Step 7: Response client-kku pogum

Controller final-a:
- `Ok()`
- `CreatedAtAction()`
- `BadRequest()`
- `NotFound()`
- `NoContent()`

madhiri response anuppum.

## Deep explanation

Project structure-na folder arrangement mattum illa. Idhu responsibility separation.

## Folder-by-folder deep explanation

### `Program.cs`

Idhu startup entry point.

Current project-la idhu:
- `AddControllers()` use pannudhu
- `IOrderService` register pannudhu
- `MapControllers()` call pannudhu

Meaning:
- app epdi boot aaganum nu inga decide pannuvom

### `Controllers/`

Controllers are HTTP entry points.

Example:
- `OrdersController`
- `HomeController`

Controller responsibility:
- request accept panna
- service call panna
- response anuppa

Controller responsibility illaadha things:
- database query full-a ezhudhudhu
- long business rule calculate pannudhu
- multiple unrelated infrastructure work handle pannudhu

### `Models/`

Models data structure represent pannum.

Examples:
- `Order` -> actual order data
- `CreateOrderRequest` -> create request body
- `UpdateOrderRequest` -> full update body
- `UpdateOrderStatusRequest` -> status-only update body

Benefit:
- request/response shapes clear aagum
- code readability improve aagum

### `Services/`

Service layer actual application logic hold pannum.

Namma current project-la `OrderService` in-memory data use pannudhu. Future-la idha database logic-a replace pannalam.

Benefit:
- controller lean aagum
- logic reuse panna easy
- testing later easy

### `Contracts/`

`Contracts` folder-la interfaces vechirukkom.

Example:
- `IOrderService`

Why important?
- abstraction create pannudhu
- implementation change aana controller affect kammi aagum
- loose coupling achieve pannalaam

Simple-a:
- Controller solradhu: "enakku order service venum"
- but exact implementation yaar nu hard-code panna maattom

### `Properties/`

Usually `launchSettings.json` irukkum.

Idhu mainly development-time settings:
- local URLs
- profiles
- environment settings

### `appsettings.json`

Configuration values store panna use pannuvom.

Topic 4-la deep config pogala. But structure understanding-ku idhu important.

Future-la:
- connection strings
- logging config
- custom app settings

inga varum.

### `.csproj`

Project file.

Idhu project metadata hold pannum:
- target framework
- package references
- build settings

## Real-time example (E-Commerce Order System)

Namma same example continue:
**E-Commerce Order Management System**

### Scenario: Customer order create pannaraar

1. Client `POST /api/orders` anuppum
2. `OrdersController` request receive pannum
3. `CreateOrderRequest` body bind aagum
4. Controller `IOrderService.Create()` call pannum
5. `OrderService` new order create pannum
6. `Order` model return pannum
7. Controller `201 Created` response anuppum

### Scenario: Admin pending orders paakraar

1. Client `GET /api/orders?status=Pending`
2. Controller query parameter receive pannum
3. Controller service-a call pannum
4. Service filtered list return pannum
5. Controller `200 OK` response anuppum

### Scenario: Warehouse status update pannudhu

1. Client `PUT /api/orders/1/status`
2. `UpdateOrderStatusRequest` bind aagum
3. Controller service call pannum
4. Service order update pannum
5. Updated order response thirumbi varum

Idhu dhaan proper structure-oda flow.

## Without proper structure - sample and problems

Same code-a poor structure-la panni irundha ipdi irukkalam:

- all routes inside `Program.cs`
- controller-kulla direct list maintain pannuvanga
- service layer separate-a irukkadhu
- request models use pannaama raw values use pannuvanga
- interface abstraction irukkadhu

Example problems:

### 1. `Program.cs` overload
Startup code-um business logic-um same file-la mix aagum.

### 2. Fat controller
Controller romba perusaagum.

### 3. Tight coupling
Controller exact implementation mela depend aagum.

### 4. Low readability
New developer-ku "logic enga irukku?" nu immediate-a puriyadhu.

### 5. Hard to extend
Authentication, repository, EF Core, logging add panna file structure weak-a irukkum.

## How this connects with Topic 3

Topic 3-la namma REST endpoints correct-a design pannom.

Topic 4-la:
- andha same REST API-a
- nalla project structure-kulla
- responsibilities split panni
- more maintainable-a organize panniyirukkom

Connection:
- Topic 3 = endpoint design
- Topic 4 = project organization

## In our Topic 4 project what changed?

Previous topic-lendhu same project continue panniyirukkom. New improvements:

- `OrderStore`-a rename panni `OrderService` aakkirukkom
- service contract-a `IOrderService` interface-a `Contracts/` folder-la add panniyirukkom
- `Program.cs`-la interface-based registration use panniyirukkom
- `OrdersController` exact class mela depend aagaama interface mela depend aagudhu
- same REST endpoints maintain panniyirukkom
- `#region` blocks continue panniyirukkom

Current structure:

- `Program.cs`
- `Controllers/`
- `Models/`
- `Services/`
- `Contracts/`
- `Properties/`
- `appsettings.json`

## Why this structure is good for future topics

Indha structure nala next topics easy aagum:
- Controllers & Routing
- Model Binding & Validation
- Dependency Injection
- Middleware
- Configuration
- Logging
- EF Core
- Repository Pattern

Namma current structure future expansion-ku ready-a irukku.

## Summary

ASP.NET Core Structure na project files and responsibilities clean-a organize pannura approach. Idhu just folder naming illa; controller, service, model, contract, config nu responsibilities split pannura design. E-commerce order API madhiri project-la indha structure use pannina code readable-a, maintainable-a, extensible-a maari future topics integrate panna easy aagum.

---

## Interview Preparation (Simple English)

### Short definition

ASP.NET Core structure means organizing a Web API project into clear parts such as Program, Controllers, Models, Services, and configuration files so the application is easy to understand, maintain, and extend.

### Key important points

- `Program.cs` is the startup entry point
- Controllers handle HTTP requests and responses
- Models represent data and request bodies
- Services hold business logic
- Interfaces in contracts improve loose coupling
- `appsettings.json` stores configuration
- Good structure improves maintainability and scalability

### Interview questions with answers

**1. What is the role of `Program.cs` in ASP.NET Core?**  
`Program.cs` is the startup file where services are registered, middleware is configured, and the application is built and run.

**2. What is the purpose of the `Controllers` folder?**  
The `Controllers` folder contains classes that handle incoming HTTP requests and return HTTP responses.

**3. Why do we use a `Services` folder?**  
We use a `Services` folder to move business logic out of controllers and keep the code clean and reusable.

**4. What is the purpose of models in a Web API project?**  
Models define the shape of data used in requests, responses, and domain entities.

**5. Why do we use interfaces like `IOrderService`?**  
Interfaces create abstraction and reduce tight coupling between controllers and service implementations.

**6. What is stored in `appsettings.json`?**  
Configuration values such as connection strings, logging settings, and custom application settings are stored there.

**7. Why is proper project structure important?**  
It improves readability, maintainability, teamwork, and makes future enhancements easier.

**8. What happens if all logic is written inside controllers?**  
Controllers become large, hard to maintain, hard to test, and responsibilities get mixed together.
