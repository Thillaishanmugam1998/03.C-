# Web API Introduction

## What is this concept?

Web API na enna-na, oru application-oda functionality-ai internet moolama vera applications use panna kudukkara interface. Simple-a sonna, frontend app, mobile app, desktop app, illa even vera backend system kuda namma server kitte data கேக்கவும், அனுப்பவும், update pannavum use pannara bridge dhaan Web API.

ASP.NET Core Web API context-la, namma `.NET` use panni HTTP requests receive panni, athukku proper response anuppura server-side application build pannuvom. Indha API mostly JSON format-la data exchange pannum.

Example:
- Mobile app order details கேக்கும்
- Admin panel new order create pannum
- Warehouse system shipped status update pannum

Indha ellathukkum middle-la pesura common communication layer dhaan Web API.

## Why we use this?

Innikki applications mostly single system illa. Oru e-commerce business eduthukkonga:
- Customer mobile app irukkum
- Admin web panel irukkum
- Payment gateway integration irukkum
- Delivery partner integration irukkum
- Inventory system irukkum

Indha ellam direct database-a access panna koodadhu. Athukku badhila, secure-a, controlled-a, structured-a pesanum. Adhanala Web API use pannuvom.

Web API use pannradhoda main reasons:
- Different clients kitta same backend functionality expose panna
- Data exchange standardize panna
- Business logic centralize panna
- Security and validation control panna
- Scalability easy aagum

## What problem it solves?

Web API illama irundha, ovvoru client-um direct database connect pannanum illa custom communication mechanism use pannanum. Adhu romba dangerous and messy.

Web API solve pannura problems:

### 1. Tight coupling problem
Frontend direct database kitta depend aagidum. Database schema change aana frontend break aagum.

### 2. Security problem
Direct DB access kudutha username/password expose aagum. Sensitive data leak aagalam.

### 3. Reusability problem
Same logic multiple apps-la duplicate panniduvanga. Example: order total calculate logic mobile app-la onnu, web app-la onnu.

### 4. Maintenance problem
Business rule change aana எல்லா clients-யும் update pannanum.

### 5. Integration problem
External systems namma system-oda structured-a interact panna mudiyadhu.

Web API indha problems ellathukkum oru clean entry point provide pannudhu.

## What happens if not used?

Web API use pannaama system build pannina, konjam naal work aagalam. But scale aana udane problems varum.

Possible issues:
- Frontend and backend strongly tied aagidum
- Mobile app, website, admin panel-ku separate logic maintain panna vendiyadhu varum
- Security weak aagum
- Testing kashtam aagum
- External integration complex aagum
- Future-la microservices, mobile apps, third-party integrations panna tough aagum

Real-world-la e-commerce company-ku Web API illa-na:
- Android app-ku separate backend logic
- iOS app-ku separate backend logic
- Website-ku separate backend logic
- Order tracking-ku separate mechanism

Result:
- Duplicate work
- Inconsistent behavior
- Bugs அதிகம்
- Development speed slow

## Internal working (step-by-step flow)

Ippo Web API internally epdi work aagudhu-nu step-by-step paapom.

### Step 1: Client request anuppum
Oru client, for example mobile app, server-ku HTTP request anuppum.

Example:
- `GET /api/orders/101`

Idhu meaning:
- `GET` = data retrieve panna
- `/api/orders/101` = order id 101 details venum

### Step 2: Request internet moolama server reach aagum
Request network moolama namma ASP.NET Core application run aagura server-a reach aagum.

### Step 3: Web server request accept pannum
Usually Kestrel nu sollra web server request-a accept pannum. Adhu ASP.NET Core application-kku pass pannum.

### Step 4: Middleware pipeline-la request travel pannum
Request direct controller kitte pogadhu. First middle-la irukkara pipeline components moolama pogum.

Examples:
- Logging middleware
- Authentication middleware
- Exception handling middleware
- Routing middleware

Ivanga request-a inspect pannuvanga, modify pannuvanga, validate pannuvanga, next stage-ku anuppuvanga.

### Step 5: Routing correct endpoint find pannum
Request URL and HTTP method base panni, yentha controller/action execute panna vendum-nu framework identify pannum.

Example:
- `GET /api/orders/101` -> `OrdersController` -> `GetOrderById(101)`

### Step 6: Model binding nadakkum
URL-la irukkara values, query string values, body-la irukkara JSON values ellam .NET objects-a convert pannappadum.

Example:
- JSON body -> `CreateOrderRequest` object

### Step 7: Business logic execute aagum
Controller or service layer actual work pannum:
- Order fetch pannum
- Stock check pannum
- Validation pannum
- Total calculate pannum

### Step 8: Response prepare pannum
Result-a mostly JSON format-la prepare pannum.

Example response:
```json
{
  "orderId": 101,
  "customerName": "Arun",
  "status": "Confirmed"
}
```

### Step 9: HTTP response client-kku thirumbi pogum
Server response status code-oda send pannum:
- `200 OK`
- `201 Created`
- `400 Bad Request`
- `404 Not Found`
- `500 Internal Server Error`

### Step 10: Client response-a use pannum
Frontend app andha response base panni UI update pannum.

Example:
- Order found na details show pannum
- Order illa na error message show pannum

## Deep explanation

Web API concept surface level-la paatha "request vandha response anuppudhu" nu theriyum. But architect point of view-la idhu adhukku mela.

### Web API is a contract
API na just code illa, idhu oru contract.

Contract-na:
- Client enna request anuppanum
- Server enna format-la accept pannum
- Response epdi varum
- Error epdi varum

Indha contract clear-a irundha dhaan different teams independent-a work panna mudiyum.

Example:
- Mobile team backend complete aagura varaikkum wait panna vendam
- API contract irundha mock data vachu UI build pannalam

### Web API hides internal complexity
Client-ku database table structure theriyanum nu avasiyam illa.

Client just:
- order create panna
- order fetch panna
- order cancel panna

nu dhaan therinjirundha pothum.

Backend internal-a:
- multiple tables join pannalam
- business rules apply pannalam
- inventory validate pannalam
- audit log save pannalam

Indha complexity ellam API behind-the-scenes handle pannum.

### Web API promotes separation of concerns
Nalla architecture-la responsibilities split pannuvom:
- Client -> display and user interaction
- API -> request handling and response generation
- Business layer -> domain logic
- Data layer -> database communication

Indha separation nala:
- code clean aagum
- test panna easy aagum
- changes isolated aagum

### Web API is stateless by design in most cases
Generally HTTP-based APIs stateless pattern follow pannum. Adhu meaning, ovvoru request-um self-contained-a irukkanum.

Server usually previous request memory-la vechindu depend panna koodadhu.

Example:
- `GET /api/orders/101`

Indha request handle panna server-ku adha vida munadi enna request vandhuchu-nu theriyanum nu avasiyam illa.

Indha stateless nature nala:
- scaling easy
- load balancing easy
- reliability improve aagum

### Web API is the foundation for distributed systems
Monolith irundhalum, microservices irundhalum, frontend-backend separation irundhalum, communication-ku API romba mukkiyam.

Future topics-la namma பார்க்க போறது:
- Controllers
- Routing
- Validation
- Authentication
- EF Core
- Caching
- Versioning

Indha ellam oru Web API backbone mela dhaan build aagum.

## Real-time example (E-Commerce Order System)

Namma entire learning journey-ku use panna pora single example:
**E-Commerce Order Management System**

Scenario:

Customer website-la order place pannrar. Appo enna nadakkum?

### Without Web API
- Website direct database-la order insert pannum
- Mobile app vera method use pannum
- Admin panel manual SQL use pannalam
- Warehouse app separate integration use pannalam

Idhu full chaos.

### With Web API
Common endpoints irukkum:
- `GET /api/orders` -> all orders
- `GET /api/orders/101` -> specific order
- `POST /api/orders` -> new order create
- `PUT /api/orders/101/status` -> status update
- `DELETE /api/orders/101` -> order cancel

Ippo:
- Website same API use pannum
- Mobile app same API use pannum
- Admin panel same API use pannum
- Future third-party integration same API use pannum

### Practical flow

1. Customer checkout button click pannrar
2. Frontend order details-a API-kku anuppum
3. API request receive pannum
4. API validate pannum:
   - customer valid-a?
   - products available-a?
   - quantity okay-a?
5. Order save pannum
6. Response send pannum:
   - order created
   - order id generated
   - current status = Pending

Adhukkapparam:
- Admin fetch orders
- Warehouse update packed/shipped status
- Customer track order

Ellame same central API moolama nadakkum.

## Web API vs Normal Website

Romba perukku initial confusion idhula dhaan irukkum.

### Normal website
Server mostly HTML generate panni browser-kku anuppum.

### Web API
Server mostly data anuppum, usually JSON format-la.

Browser/mobile app அந்த data-ai use panni UI render pannum.

Example:

Normal MVC app:
- Server returns HTML page for order details

Web API:
- Server returns order data as JSON

## Why ASP.NET Core Web API?

ASP.NET Core Web API use panna reasons:
- High performance
- Cross-platform
- Clean middleware pipeline
- Built-in dependency injection
- Strong routing support
- Validation support
- Authentication/authorization support
- Swagger integration easy
- Cloud deployment friendly

Enterprise-grade APIs build panna idhu romba strong framework.

## Key building blocks we will learn later

Ippo just introduction dhaan. But full Web API system usually indha parts irukkum:
- Endpoints
- Controllers
- Routing
- Models
- DTOs
- Services
- Repository
- Middleware
- Configuration
- Logging
- Authentication
- Database integration
- Exception handling

Indha journey-la namma idha step-by-step connect panni build pannaporom.

## Summary

Web API na applications kulla communicate panna use pannara structured HTTP-based interface. Idhu frontend, mobile app, admin systems, third-party integrations ellam same backend business logic use panna help pannudhu. E-commerce order management madhiri real-world systems-la Web API illama scalable, secure, maintainable architecture build panna romba kashtam.

Topic 1-la namma foundation purinjukittom:
- Web API enna
- Yen use pannuvom
- Enna problem solve pannudhu
- Internally epdi work aagudhu
- E-commerce order system-la epdi apply aagudhu

Next topics-la indha theory-ai actual ASP.NET Core project-a convert panna start pannuvom.

---

## Interview Preparation (Simple English)

### Short definition

ASP.NET Core Web API is a framework used to build HTTP services that allow different applications to communicate with each other using standard web protocols. It usually sends and receives data in JSON format.

### Key important points

- Web API is used for communication between client and server
- It commonly uses HTTP methods like GET, POST, PUT, DELETE
- It usually returns JSON data
- It helps separate frontend from backend
- It improves scalability, maintainability, and integration
- ASP.NET Core Web API is fast, cross-platform, and modern

### Interview questions with answers

**1. What is a Web API?**  
A Web API is an interface that allows applications to communicate over HTTP. It exposes data and operations in a standard way.

**2. Why do we use Web API?**  
We use Web API to let different clients such as web apps, mobile apps, and third-party systems access backend functionality safely and consistently.

**3. What kind of data format is commonly used in Web API?**  
JSON is the most commonly used data format because it is lightweight and easy to read.

**4. What problem does Web API solve?**  
It avoids direct database access from clients, centralizes business logic, improves security, and supports multiple clients using the same backend.

**5. What is the difference between a website and a Web API?**  
A website usually returns HTML for display, while a Web API mainly returns data such as JSON for other applications to use.

**6. Can multiple clients use the same Web API?**  
Yes. A web app, mobile app, admin panel, and third-party systems can all use the same Web API.

**7. What are common HTTP methods used in Web API?**  
GET, POST, PUT, DELETE are the most common methods.

**8. Why is ASP.NET Core good for Web API development?**  
It is high-performance, cross-platform, supports dependency injection, middleware, routing, security, and works well for modern enterprise applications.
