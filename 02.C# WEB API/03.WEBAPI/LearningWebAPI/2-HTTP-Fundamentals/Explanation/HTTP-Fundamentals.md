# HTTP Fundamentals

## What is this concept?

HTTP na `HyperText Transfer Protocol`. Idhu web-la client and server communicate panna use pannura standard protocol. Simple-a sonna, browser, mobile app, frontend app, Postman, vera backend service nu yaar irundhalum server kitte "request" anuppum; server "response" thiruppi anuppum. Indha communication rules set pannirukkara protocol dhaan HTTP.

Web API world-la HTTP dhaan backbone. Topic 1-la namma Web API enna nu paathom. Ippo Topic 2-la, andha Web API actual-a epdi pesudhu, yentha rules follow pannudhu, request/response epdi structure-a irukkum, methods and status codes enna meaning-nu deep-a purinjukanum.

HTTP illama Web API nu yosikka kooda mudiyadhu. API oru building-na, HTTP adhu use pannura road system madhiri.

## Why we use this?

Different systems consistent-a communicate panna oru common language venum. Adhan HTTP.

HTTP use panna reasons:
- Standard protocol, so almost every platform support pannum
- Client-server communication easy aagum
- Request and response format predictable aagum
- Methods use panni action intent clear-a solla mudiyum
- Status codes use panni result clear-a communicate panna mudiyum
- Headers use panni metadata send panna mudiyum
- Stateless nature nala scalable systems build panna easy

Example:
Namma `E-Commerce Order Management System`-la mobile app oru order details கேக்குது. App epdi server kitte sollum?

HTTP moolama:
- `GET /api/orders/1`

Server response:
- `200 OK`
- JSON body with order details

Idhu ellam standard. App .NET-la irundhalum, frontend React-la irundhalum, mobile Flutter-la irundhalum same communication pattern.

## What problem it solves?

HTTP illa-na systems random custom format-la communicate panna try pannum. Adhu maintenance-ku romba kashtam.

HTTP solve pannura main problems:

### 1. Communication standardization
Client and server rendu perum common rules follow pannuvanga.

### 2. Intent clarity
`GET` na fetch, `POST` na create, `PUT` na update, `DELETE` na delete nu oru clear meaning irukkum.

### 3. Result communication
Operation success-a illa fail-a nu status code-la immediately theriyum.

### 4. Platform independence
Java app, .NET API, Angular frontend, Python script, mobile app ellam same protocol use pannalaam.

### 5. Scalable architecture support
Stateless request model nala servers horizontal scale panna easy aagum.

## What happens if not used?

HTTP fundamentals puriyama API build pannina, technically endpoints work aagalam. But proper API design varadhu.

Problems:
- எல்லாத்துக்கும் `POST` use panniduvanga
- Success/failure-ku correct status code kudukka maattanga
- Client-ku confusion varum
- API predictable-a irukkadhu
- Integration tough aagum
- Debug panna kashtam

Example:
Order delete panna `GET /deleteOrder/10` nu build pannina:
- Semantic wrong
- Caching/proxy behavior unexpected aagalam
- Client side maintain panna kashtam

Adhe madhiri order create pannitu `200 OK` mattum anuppi விட்டா, `201 Created` use panna vendiya place miss aagum. API meaning weak aagidum.

## Internal working (step-by-step flow)

HTTP request-response cycle epdi nadakkudhu-nu detailed-a paapom.

### Step 1: Client request create pannum
Client-ku edho oru need irukkum.

Example:
- customer order list பார்க்கணும்
- admin order status update pannaணும்

Client HTTP request build pannum.

Request-la usually irukkum:
- Method
- URL
- Headers
- Optional body

### Step 2: HTTP method action intent sollum

Method pathi first purinjukanum:

#### GET
Data fetch panna use pannuvom.

Example:
- `GET /api/orders`
- `GET /api/orders/1`

#### POST
New resource create panna use pannuvom.

Example:
- `POST /api/orders`

#### PUT
Existing resource full-a update panna commonly use pannuvom. Namma current topic project-la order status update use pannuvom for simplicity.

Example:
- `PUT /api/orders/1/status`

#### DELETE
Resource remove panna use pannuvom.

Example:
- `DELETE /api/orders/1`

### Step 3: URL resource identify pannum

HTTP-la URL romba mukkiyam.

Example:
- `/api/orders` -> all orders collection
- `/api/orders/1` -> specific order
- `/api/orders/1/status` -> order status related action

URL-la nouns use pannradhu better. Verbs use pannaama resource-based design panna easy aagum.

### Step 4: Headers metadata carry pannum

Headers na extra information.

Common headers:
- `Content-Type: application/json`
- `Accept: application/json`
- `Authorization: Bearer <token>`

Topic 2-la auth deep-a pogala. But header concept ippove purinjirukkanum.

### Step 5: Body actual data carry pannum

GET request usually body illama irukkum.

POST/PUT requests often body use pannum.

Example order create request body:
```json
{
  "customerName": "Karthik",
  "productName": "USB Hub",
  "quantity": 1,
  "totalAmount": 899
}
```

### Step 6: Server request process pannum

Server:
- request receive pannum
- route match pannum
- data parse pannum
- logic execute pannum
- result decide pannum

### Step 7: Response prepare pannum

Response-la irukkum:
- Status code
- Headers
- Optional body

Example:
```http
HTTP/1.1 201 Created
Location: /api/orders/3
Content-Type: application/json
```

Body:
```json
{
  "id": 3,
  "customerName": "Karthik",
  "productName": "USB Hub",
  "quantity": 1,
  "totalAmount": 899,
  "status": "Pending"
}
```

## Deep explanation

HTTP fundamentals-na just methods memorize pannradhalla. API architect perspective-la, idhu meaning, predictability, interoperability pathi.

## Request structure deep dive

Oru HTTP request-ku core parts:

### 1. Method
Enna action venum nu sollum.

### 2. URL
Yentha resource mela action nu sollum.

### 3. Headers
Extra context kudukkum.

### 4. Body
Server process panna vendiya data kudukkum.

Indha naalu parts correct-a irundha dhaan request meaningful aagum.

## Response structure deep dive

Response-ku core parts:

### 1. Status code
Operation result enna nu quick-a theriyum.

### 2. Headers
Metadata, caching rules, location, content type etc.

### 3. Body
Actual result or error details.

## HTTP status codes deep explanation

Status code correct-a kudukkaradhu mature API design-oda sign.

### 200 OK
Request success.

Use cases:
- order fetch success
- status update success

### 201 Created
New resource create aana use pannuvom.

Use case:
- new order created

Usually `Location` header-um set pannuvom. Adhu new resource yenga irukku nu sollum.

### 204 No Content
Operation success, but body anuppa thevai illa.

Use case:
- order delete success

### 400 Bad Request
Client anuppina data invalid.

Use case:
- quantity 0
- customer name empty

### 404 Not Found
Requested resource illa.

Use case:
- order id 999 not found

### 500 Internal Server Error
Server side unexpected issue.

Use case:
- unhandled exception

Namma Topic 2 project-la mainly `200`, `201`, `204`, `400`, `404` use pannuvom.

## Safe methods and idempotent methods

Indha concept interview-la romba important.

### Safe method
Server state change pannaadhu.

Example:
- `GET`

GET use panni data fetch pannalaam. Adhu database-la update panna koodadhu.

### Idempotent method
Same request-a multiple times anuppina final result same-a irukkum.

Examples:
- `GET`
- `PUT`
- `DELETE` (practical sense-la final state same)

Example:
- `DELETE /api/orders/5`
Once delete aana appram repeated delete same final state-ai indicate pannum: resource removed.

`POST` usually idempotent illa because same request multiple times anuppina multiple resources create aagalam.

## Stateless nature

HTTP-based Web APIs mostly stateless design follow pannum.

Meaning:
- Ovvoru request-um independent
- Server previous request memory base panni depend panna koodadhu

Example:
`GET /api/orders/1`

Indha request handle panna, server-ku yesterday yaar call pannanga nu theriyanum nu avasiyam illa.

Stateless design nala:
- load balancing easy
- scale-out easy
- retry logic simple

## Real-time example (E-Commerce Order System)

Namma single consistent example:
**E-Commerce Order Management System**

### Scenario 1: Get all orders

Admin dashboard-la all orders load aaganum.

Request:
- `GET /api/orders`

Response:
- `200 OK`
- all orders JSON

### Scenario 2: Get one order

Customer order details பார்க்கணும்.

Request:
- `GET /api/orders/1`

If exists:
- `200 OK`

If not exists:
- `404 Not Found`

### Scenario 3: Create order

Customer checkout pannumbodhu new order create ஆகும்.

Request:
- `POST /api/orders`

Body:
```json
{
  "customerName": "Divya",
  "productName": "Laptop Stand",
  "quantity": 1,
  "totalAmount": 1499
}
```

Success response:
- `201 Created`
- created order body
- location header

If invalid quantity:
- `400 Bad Request`

### Scenario 4: Update order status

Warehouse team order packed nu mark pannum.

Request:
- `PUT /api/orders/1/status`

Body:
```json
{
  "status": "Shipped"
}
```

If success:
- `200 OK`

If order missing:
- `404 Not Found`

If status empty:
- `400 Bad Request`

### Scenario 5: Delete order

Order created by mistake. Admin remove pannaraar.

Request:
- `DELETE /api/orders/1`

Success:
- `204 No Content`

If order missing:
- `404 Not Found`

## How this connects with Topic 1

Topic 1-la namma Web API oru communication bridge nu paathom.

Topic 2-la purinjadhu:
- Andha bridge HTTP protocol use pannudhu
- Request epdi varudhu
- Response epdi pogudhu
- Method enna meaning
- Status code enna importance

Simple-a sonna:
- Topic 1 = "Why API?"
- Topic 2 = "API epdi communicate pannudhu?"

## In our project what we are building now

Ippo namma first evolving project start panniyirukkom:
- Controller-based ASP.NET Core Web API
- In-memory order list
- Proper HTTP methods
- Proper status codes

Current endpoints:
- `GET /api/orders`
- `GET /api/orders/{id}`
- `POST /api/orders`
- `PUT /api/orders/{id}/status`
- `DELETE /api/orders/{id}`

Idhu romba important foundation. Future topics-la idha base panni:
- REST design improve pannuvom
- ASP.NET Core structure organize pannuvom
- Validation improve pannuvom
- DI, middleware, EF Core ellam step-by-step integrate pannuvom

## Code terms used in this project

Ippo code-la paakra sila ASP.NET Core words-ku meaning purinjirundha learning innum strong aagum. Indha section direct-a namma current project code-a explain pannudhu.

### `Program.cs` na enna?

`Program.cs` na application startup file.

Ithu enna pannum?
- services register pannum
- app build pannum
- middleware/endpoint mapping configure pannum
- application run pannum

Current project-la:

#### `builder.Services.AddControllers();`
Idhu controller support register pannudhu.

Meaning:
- `Controllers` folder-la irukkara controller classes discover panna framework-ku solludhu
- attribute routing enable pannudhu
- controller actions execute panna infrastructure ready pannudhu

Idhu illa-na controller-based Web API work aagadhu.

#### `builder.Services.AddSingleton<OrderStore>();`
Idhu `OrderStore` service-a dependency injection container-la register pannudhu.

Simple meaning:
- app run aagura full time same `OrderStore` instance use aagum
- namma sample in-memory order data retain aagum

#### `app.MapControllers();`
Idhu controller-la define pannirukkara endpoints-a actual route-a expose pannudhu.

Idhu illa-na:
- controller files irundhalum
- URL call panna mudiyadhu

## `ActionResult` na enna?

`ActionResult` na controller action return pannura HTTP result type.

Idhu use pannina:
- success-ku `Ok()`
- invalid input-ku `BadRequest()`
- data illa-na `NotFound()`
- create success-ku `CreatedAtAction()`

nu flexible-a different responses return panna mudiyum.

### `ActionResult<Order>`

Example:
```csharp
public ActionResult<Order> GetById(int id)
```

Meaning:
- usually `Order` object return pannuvom
- but necessary-na `404 Not Found` madhiri vera result-um return pannalaam

### `IActionResult`

Example:
```csharp
public IActionResult Delete(int id)
```

Ithu generic HTTP response type.

Use pannuvom when:
- exact response body type fix panna thevai illa
- `NoContent()`, `NotFound()` madhiri different result varum

## `IEnumerable<Order>` na enna?

`IEnumerable<Order>` na `Order` objects collection.

Example:
```csharp
public ActionResult<IEnumerable<Order>> GetAll()
```

Meaning:
- single order illa
- multiple orders return aagudhu

Simple-a sonna, "orders list" nu artham.

## `[ApiController]` na enna?

Indha attribute class API controller nu ASP.NET Core-kku solludhu.

Benefits:
- request handling API-friendly aagum
- parameter binding easier aagum
- validation behavior improve aagum

Simple meaning:
Normal class illa, idhu API endpoints handle pannura controller.

## `[Route("api/[controller]")]` na enna?

Idhu base route template.

`[controller]` placeholder controller name base panni replace aagum.

Example:
- controller name = `OrdersController`
- `[controller]` => `orders`
- final route => `api/orders`

So:
- `[HttpGet]` => `GET /api/orders`
- `[HttpPost]` => `POST /api/orders`

## `[HttpGet("{id:int}")]` na enna?

Meaning:
- indha action `GET` request handle pannum
- URL-la `id` varanum
- `id` integer-a irukkanum

Example:
- `GET /api/orders/1` -> valid
- `GET /api/orders/abc` -> indha route-ku match aagadhu

`{id:int}` nu solradhu route constraint.

## `[HttpPut("{id:int}/status")]` na enna?

Meaning:
- indha action `PUT` request handle pannum
- specific order status-a update pannum
- URL example: `PUT /api/orders/1/status`

Idhu namma e-commerce example-la warehouse/admin order status update panna use aagudhu.

## `NotFound()` na enna?

`NotFound()` means HTTP `404 Not Found`.

Use case:
- client oru order ketta
- andha order exist aagala

Example:
```csharp
return NotFound(new { message = $"Order with id {id} was not found." });
```

Meaning:
- request server reach aayiduchu
- but requested resource illa

## `BadRequest()` na enna?

`BadRequest()` means HTTP `400 Bad Request`.

Use case:
- client invalid data anuppina

Examples:
- empty customer name
- quantity 0
- empty status

Meaning:
- server side problem illa
- request input thappu

## `CreatedAtAction()` na enna?

`CreatedAtAction()` create operation-ku use pannura best practice response.

Example:
```csharp
return CreatedAtAction(nameof(GetById), new { id = order.Id }, order);
```

Idhu enna pannum?
- `201 Created` return pannum
- newly created resource details return pannum
- `GetById` action base panni resource URL generate pannum

So client-ku:
- order create aagiduchu
- appo next yenga fetch panna mudiyum nu kooda theriyum

## Quick mapping from code to meaning

- `Program.cs` = app startup and configuration
- `AddControllers()` = controllers support enable pannudhu
- `MapControllers()` = controller routes activate pannudhu
- `[ApiController]` = API controller nu mark pannudhu
- `[Route("api/[controller]")]` = base URL template
- `[HttpGet]` = get/fetch action
- `[HttpGet("{id:int}")]` = one specific order fetch
- `[HttpPut("{id:int}/status")]` = specific order status update
- `ActionResult<T>` = typed response + flexible HTTP results
- `IActionResult` = generic HTTP result
- `IEnumerable<Order>` = order collection
- `NotFound()` = 404 response
- `BadRequest()` = 400 response
- `CreatedAtAction()` = 201 created response with resource link hint

## Common beginner mistakes

- எல்லாத்துக்கும் `POST` use pannradhu
- Status code ignore pannradhu
- `404` kudukka vendiya place-la `200` kudukkaradhu
- Invalid request-ku meaningful error kudukkaama generic response anupparadhu
- URL-la verbs overload pannradhu
- Request body and response body structure pathi clarity illaama build pannradhu

## Summary

HTTP fundamentals purinjikama Web API master panna mudiyadhu. HTTP dhaan client and server epdi pesanum nu rules define pannudhu. Methods action meaning kudukkudhu, URLs resource identify pannudhu, headers metadata carry pannudhu, body actual data carry pannudhu, status codes result communicate pannudhu. E-commerce order management madhiri real-world system-la correct HTTP usage API-a predictable, clean, and professional-a maathudhu.

---

## Interview Preparation (Simple English)

### Short definition

HTTP is the standard protocol used for communication between clients and servers on the web. In Web API development, it defines how requests are sent and how responses are returned.

### Key important points

- HTTP is request-response based
- Common methods are GET, POST, PUT, DELETE
- Status codes tell whether the request succeeded or failed
- Headers carry metadata such as content type and authorization
- Body carries data for create or update operations
- HTTP APIs are usually stateless
- Correct method and status code usage makes APIs clear and predictable

### Interview questions with answers

**1. What is HTTP?**  
HTTP is a protocol used for communication between a client and a server over the web.

**2. What are the main parts of an HTTP request?**  
An HTTP request usually contains a method, URL, headers, and optionally a body.

**3. What is the difference between GET and POST?**  
GET is used to retrieve data. POST is used to create a new resource.

**4. When do we use 201 Created?**  
We use 201 Created when a new resource is successfully created on the server.

**5. When do we use 204 No Content?**  
We use 204 No Content when the request is successful but there is no response body to return, such as after a successful delete.

**6. What does 400 Bad Request mean?**  
It means the client sent invalid data or the request format is wrong.

**7. What does 404 Not Found mean?**  
It means the requested resource does not exist.

**8. What does stateless mean in HTTP APIs?**  
It means each request is independent and the server should not rely on previous requests to process the current one.

**9. Is POST idempotent?**  
Usually no. Sending the same POST request multiple times may create multiple resources.

**10. Why are HTTP status codes important in APIs?**  
They help clients understand the result of the request clearly and handle success or failure correctly.
