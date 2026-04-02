# Model Binding & Validation

## What is this concept?

ASP.NET Core Web API-la `Model Binding` na incoming HTTP request-lendhu data eduthu namma C# parameters illa objects-kku map pannura process. `Validation` na andha bound data valid-a illa invalid-a nu check pannura process.

Simple-a sonna:
- Model Binding = request data-ai C# object-a maathudhu
- Validation = andha object use panna safe-a nu check pannudhu

Indha topic-la namma moonu mukkiya parts paakaporom:
- Model Binding
- Data Annotations
- FluentValidation

## Why we use this?

Web API-ku client data anuppumbodhu adhu direct-a trust panna koodadhu.

Why?
- required field miss aagalam
- wrong type varalam
- empty string varalam
- invalid business value varalam
- query string thappu varalam

Adhanala:
- first request data-ai bind pannuvom
- apram validate pannuvom
- valid na process pannuvom
- invalid na `400 Bad Request` return pannuvom

## What problem it solves?

Model binding and validation solve pannura problems:

### 1. Manual parsing avoid pannudhu
Controller-la raw JSON parse panna thevai illa.

### 2. Input errors early-a catch pannudhu
Invalid input service layer-kku pogum munnaadi detect pannalaam.

### 3. Cleaner controller code
Manual `if` checks reduce aagum.

### 4. Predictable API behavior
Client-ku wrong request anuppina structured validation response kidaikkum.

### 5. Security and data quality improve aagum
Garbage input system-kulla pogama stop pannalaam.

## What happens if not used?

Idhu use pannaama API build pannina:
- controller-la full manual parsing
- manual null checks everywhere
- inconsistent validation messages
- some endpoints validate pannum, some endpoints validate panna maattum
- invalid data system-kulla save aagalam

Example:
Customer order create panna:
```json
{
  "customerName": "",
  "productName": " ",
  "quantity": 0,
  "totalAmount": -50
}
```

Validation illa-na:
- bad data order system-kulla pogalam
- report wrong aagalam
- business flow break aagalam

## Internal working (step-by-step flow)

### Step 1: Client request anuppum

Example:
- `POST /api/orders`

Body:
```json
{
  "customerName": "Arun Kumar",
  "productName": "Wireless Mouse",
  "quantity": 2,
  "totalAmount": 1598
}
```

### Step 2: Model binding nadakkum

ASP.NET Core request body/query/route values-a read pannum and corresponding action parameter-kku map pannum.

Examples:
- `[FromRoute] int id`
- `[FromQuery] GetOrdersQueryRequest request`
- `[FromBody] CreateOrderRequest request`

### Step 3: Data Annotations validation nadakkum

`[Required]`, `[StringLength]`, `[Range]` madhiri attributes check pannappadum.

Example:
- `CustomerName` empty-a?
- `Quantity` range-kulla irukka?

### Step 4: FluentValidation rules run aagum

More advanced/custom rules check pannuvom.

Example:
- `Status` allowed values-kulla irukka?
- `TotalAmount` quantity-ku suitable-a irukka?

### Step 5: Invalid na automatic `400 Bad Request`

`[ApiController]` irukkara nala validation fail aana ASP.NET Core automatic-a `400` response anuppum.

### Step 6: Valid na controller execute aagum

Validation pass aana dhaan service layer call pannuvom.

## Deep explanation

## Model Binding deep explanation

ASP.NET Core-la request data pala places-la irukkum:
- Route
- Query String
- Request Body
- Headers
- Form data

Framework enna pannum-na, correct place-lendhu data eduthu namma action parameters-kku assign pannum.

### Route binding

Example:
```csharp
[HttpGet("{id:int}")]
public ActionResult<Order> GetById([FromRoute] int id)
```

Request:
- `GET /api/orders/1`

Illa `1` route-lendhu `id` variable-kku bind aagudhu.

### Query binding

Example:
```csharp
public ActionResult<IEnumerable<Order>> GetAll([FromQuery] GetOrdersQueryRequest request)
```

Request:
- `GET /api/orders?status=Pending&customerName=Arun`

Ippo:
- `status` -> `request.Status`
- `customerName` -> `request.CustomerName`

### Body binding

Example:
```csharp
public ActionResult<Order> Create([FromBody] CreateOrderRequest request)
```

Request body JSON object-a `CreateOrderRequest`-a maathidum.

## Data Annotations deep explanation

Data Annotations na model/property mela potra built-in validation attributes.

Namma project-la use pannirukkom:
- `[Required]`
- `[StringLength]`
- `[Range]`

### `[Required]`
Field mandatory.

### `[StringLength]`
Minimum and maximum length control panna use pannuvom.

### `[Range]`
Numeric value allowed range-kulla irukkanum.

Data Annotations best for:
- simple rules
- quick validations
- readable model-level checks

## FluentValidation deep explanation

FluentValidation na separate validation library. Idhu more expressive and maintainable.

Why use pannuvom?
- complex custom rules easy
- model file clean-a irukkum
- validation logic separate files-la vechikkalaam
- readable rule chain syntax

Namma project-la separate validator classes:
- `CreateOrderRequestValidator`
- `UpdateOrderRequestValidator`
- `UpdateOrderStatusRequestValidator`

### Example custom rules

#### Allowed status values
Status any random text irukka koodadhu.

Allowed:
- Pending
- Confirmed
- Packed
- Shipped
- Delivered
- Cancelled

#### Total amount business rule
Demo purpose-ku:
- `TotalAmount >= Quantity x 100`

Ithu Data Annotation-la elegant-a panna kashtam. FluentValidation-la easy.

## Data Annotations vs FluentValidation

### Data Annotations
- simple
- built-in
- model class-kulla irukkum
- basic validations-ku nalla choice

### FluentValidation
- advanced
- separate validator classes
- cleaner for complex rules
- bigger projects-ku better maintainability

Best practice real-world-la:
- simple structural rules Data Annotations
- richer business validation FluentValidation

## Real-time example (E-Commerce Order System)

Namma same example:
**E-Commerce Order Management System**

### Scenario 1: Route binding

Customer order details paakraar.

Request:
- `GET /api/orders/2`

Binding:
- route value `2` -> `id`

### Scenario 2: Query binding

Admin pending orders filter pannaraar.

Request:
- `GET /api/orders?status=Pending&customerName=Arun`

Binding:
- `status` -> `request.Status`
- `customerName` -> `request.CustomerName`

### Scenario 3: Body binding

Customer new order create pannaraar.

Request:
- `POST /api/orders`

Body:
```json
{
  "customerName": "Divya",
  "productName": "Laptop Stand",
  "quantity": 2,
  "totalAmount": 1499
}
```

Binding:
- JSON -> `CreateOrderRequest`

Validation:
- `CustomerName` required
- `ProductName` required
- `Quantity` at least 1
- `TotalAmount` positive
- FluentValidation custom rule check

### Scenario 4: Invalid status update

Request:
- `PUT /api/orders/1/status`

Body:
```json
{
  "status": "Moving"
}
```

Result:
- FluentValidation fail aagum
- `400 Bad Request`

Because `Moving` allowed status list-kulla illa.

## In our Topic 6 project what changed?

Previous topic project continue panniyirukkom. Ippo:

- controller actions-la explicit binding attributes add panniyirukkom
- query binding-ku `GetOrdersQueryRequest` add panniyirukkom
- request models-la Data Annotations add panniyirukkom
- FluentValidation package integrate panniyirukkom
- validator classes add panniyirukkom
- manual validation `if` blocks remove panniyirukkom

Current examples:
- `[FromRoute] int id`
- `[FromQuery] GetOrdersQueryRequest request`
- `[FromBody] CreateOrderRequest request`

## Without proper validation - sample and problems

Same API validation illaama irundha:
- empty customer name save aagalam
- invalid status save aagalam
- negative amount save aagalam
- service layer-ku bad input pogum
- every controller-la duplicate manual checks varum

Example bad request:
```json
{
  "customerName": " ",
  "productName": "Mouse",
  "quantity": 0,
  "totalAmount": 50
}
```

Problems:
- order data quality corrupt aagum
- client-side bugs detect panna kashtam
- business reports incorrect aagalam

## How this connects with previous topics

- Topic 2-la HTTP request/response purinjom
- Topic 3-la REST endpoints design pannom
- Topic 4-la project structure organize pannom
- Topic 6-la client anuppura data epdi bind and validate pannradhu nu paakrom

Idhu next topics-ku strong base:
- Controllers & Routing detail
- Dependency Injection
- Middleware
- DTO
- Authentication

## Summary

Model Binding and Validation ASP.NET Core Web API-la romba mukkiyam. Model Binding request-lendhu data eduthu C# objects-kku map pannudhu. Data Annotations simple built-in validations handle pannudhu. FluentValidation complex and maintainable custom rules handle pannudhu. E-commerce order management system madhiri real-world project-la indha combination use pannina invalid input early-a stop pannalaam, controller code clean-a irukkum, API predictable-a irukkum.

---

## Interview Preparation (Simple English)

### Short definition

Model Binding in ASP.NET Core maps incoming HTTP request data to action parameters or model objects. Validation checks whether that bound data is correct before the application processes it.

### Key important points

- Model binding can read data from route, query string, body, headers, and forms
- `[FromRoute]`, `[FromQuery]`, and `[FromBody]` make binding explicit
- Data Annotations provide built-in validation attributes
- FluentValidation is used for advanced custom validation rules
- `[ApiController]` can automatically return `400 Bad Request` when validation fails
- Validation protects data quality and keeps controllers clean

### Interview questions with answers

**1. What is model binding in ASP.NET Core?**  
Model binding is the process of taking incoming request data and mapping it to action parameters or model objects.

**2. What is the purpose of validation in Web API?**  
Validation ensures the client sends correct and acceptable data before the server processes it.

**3. What does `[FromRoute]` mean?**  
It means the value should be taken from the route URL segment.

**4. What does `[FromQuery]` mean?**  
It means the value should be taken from the query string.

**5. What does `[FromBody]` mean?**  
It means the value should be read from the request body, usually JSON.

**6. What are Data Annotations?**  
They are built-in attributes like `[Required]`, `[Range]`, and `[StringLength]` used to validate model properties.

**7. Why do we use FluentValidation?**  
We use FluentValidation for more advanced, readable, and maintainable validation rules.

**8. Can Data Annotations and FluentValidation be used together?**  
Yes. Data Annotations can handle simple rules and FluentValidation can handle advanced rules.

**9. What happens when validation fails with `[ApiController]`?**  
ASP.NET Core automatically returns a `400 Bad Request` response with validation details.

**10. Why is validation important in an e-commerce order API?**  
It prevents invalid orders such as missing customer names, wrong quantities, or invalid order statuses from entering the system.
