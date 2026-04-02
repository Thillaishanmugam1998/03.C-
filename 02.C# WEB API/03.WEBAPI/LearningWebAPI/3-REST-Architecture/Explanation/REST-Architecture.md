# REST Architecture

## What is this concept?

REST na `Representational State Transfer`. Idhu oru protocol illa, oru architectural style. Simple-a sonna, web-la resources-ah clean-a expose panni, standard HTTP methods use panni, stateless-a communicate panna follow pannura design approach dhaan REST.

Important point:
- HTTP is protocol
- REST is design style

Topic 2-la namma HTTP epdi work aagudhu nu paathom. Topic 3-la, andha HTTP-a use panni professional, clean, predictable API epdi design panna vendum nu paakaporom.

REST architecture-la main focus:
- resources
- URLs
- HTTP methods
- representations
- stateless communication

## Why we use this?

API just work aaganum nu build pannalaam. Aana real-world-la API clean, predictable, scalable, maintainable-a irukkanum. Adhukkudhaan REST use pannuvom.

REST use panna reasons:
- URL design clean aagum
- Client-ku API puriya easy aagum
- Standard conventions follow panna mudiyum
- Multiple teams parallel-a work panna easy
- Documentation simpler aagum
- Integrations smooth aagum
- Future scalability improve aagum

Example:

Ithu REST illaadha style:
- `/getAllOrders`
- `/createOrder`
- `/updateOrderStatus`
- `/deleteOrderById`

Ithu REST style:
- `GET /api/orders`
- `GET /api/orders/1`
- `POST /api/orders`
- `PUT /api/orders/1`
- `DELETE /api/orders/1`

Second style paatha udane resource and action clear-a puriyudhu.

## What problem it solves?

REST architecture mainly solve pannura problem: API design chaos.

REST illaama APIs build pannina common issues:
- inconsistent URLs
- verbs mix panniduvanga
- same type operation-ku different patterns
- client-ku confusion
- maintenance kashtam
- documentation mismatch

REST solve pannudhu:

### 1. Resource clarity
Order-na order dhaan main concept. Action name URL-la overload pannaama resource base panni design pannalam.

### 2. Standard behavior
`GET`, `POST`, `PUT`, `DELETE` standard meaning use pannuvom.

### 3. Better consistency
All endpoints same pattern follow pannum.

### 4. Better scalability
Stateless nature nala distributed systems-la use panna easy.

### 5. Better client experience
Frontend team, mobile team, third-party team ellarum same clean contract use panna mudiyum.

## What happens if not used?

REST principles ignore pannina, API work aagalam. But nalla architecture varadhu.

Problems:
- `POST /api/orders/getall`
- `POST /api/orders/delete`
- `GET /api/update-status`

Madhiri confusing routes varum.

Consequences:
- new developer onboard panna time edukum
- frontend integration bugs varum
- testing and documentation mismatch aagum
- API usage predictable-a irukkadhu
- versioning and scaling later kashtam aagum

Simple-a sonna:
REST illaadha API use panna, road sign illadha city-la drive pannara madhiri irukkum.

## Internal working (step-by-step flow)

REST API internally epdi think pannudhu-nu step-by-step paapom.

### Step 1: Business domain-la resources identify pannuvom

Namma e-commerce system-la resources:
- orders
- customers
- products
- payments

Ippo namma learning project-la current resource:
- `orders`

### Step 2: Resource-ku clean URI define pannuvom

Examples:
- `/api/orders`
- `/api/orders/1`

Idhu collection and single resource difference-a kaattudhu.

### Step 3: HTTP method action decide pannuvom

- `GET /api/orders` -> orders fetch
- `GET /api/orders/1` -> one order fetch
- `POST /api/orders` -> new order create
- `PUT /api/orders/1` -> full order update
- `PUT /api/orders/1/status` -> status related sub-resource update
- `DELETE /api/orders/1` -> order remove

### Step 4: Representation exchange pannuvom

Resource direct memory/database object-a illa, representation form-la travel aagum.

Usually:
- JSON request
- JSON response

Example:
```json
{
  "id": 1,
  "customerName": "Arun Kumar",
  "productName": "Wireless Mouse",
  "quantity": 2,
  "totalAmount": 1598.00,
  "status": "Pending"
}
```

Indha JSON dhaan order-oda representation.

### Step 5: Stateless request handle pannuvom

Ovvoru request-um complete information kudukkanum.

Example:
- `PUT /api/orders/1`
- body-la updated data

Server previous request context mela rely panna koodadhu.

### Step 6: Proper status code anuppuvom

REST design-la action mattum correct-a irundha pothadhu. Response-um semantically correct-a irukkanum.

Examples:
- `200 OK`
- `201 Created`
- `204 No Content`
- `400 Bad Request`
- `404 Not Found`

## Deep explanation

REST-na many developers "URL-la noun use pannradhu" nu mattum ninaippanga. Aana adhu full meaning illa. REST architecture-ku deeper principles irukku.

## REST core ideas

### 1. Resource-oriented design

REST-la main hero action illa, resource.

Wrong thinking:
- create order
- cancel order
- update order

REST thinking:
- order resource mela enna operation?

Adhanala URL:
- `/api/orders`
- `/api/orders/1`

Nu resource-centric aagum.

### 2. Representation

Client direct database row receive pannadhu illa. Resource-oda representation receive pannum.

Example:
- Order object server memory-la irukkalam
- Client receive pannradhu JSON representation

Adhanala REST-la `R` na resource mattum illa, `representation`-um important.

### 3. Statelessness

REST request self-contained-a irukkanum.

Server inga ipdi yosikkadhu:
- "indha client நேத்து என்ன request anuppinan?"

Instead:
- current request-la thevaiyana details ellam irukkanum

Indha stateless nature nala:
- server scale panna easy
- retry panna easy
- load balancer use panna easy

### 4. Uniform interface

REST-oda strongest point idhu.

Same style everywhere:
- collection => `/orders`
- single item => `/orders/1`
- create => `POST`
- read => `GET`
- update => `PUT`
- delete => `DELETE`

Indha uniformity nala client-ku learning curve korayum.

### 5. Self-descriptive messages

Request and response paatha udane meaning puriyanum.

Example:
- `GET /api/orders?status=Pending`

Idhu paatha udane:
- orders collection
- status filter

Nu puriyudhu.

## Real-time example (E-Commerce Order System)

Namma single example:
**E-Commerce Order Management System**

### Use case 1: Get all orders

Admin dashboard orders list venum.

REST endpoint:
- `GET /api/orders`

### Use case 2: Filter by status

Warehouse team pending orders mattum venum.

REST endpoint:
- `GET /api/orders?status=Pending`

Idhu important because filtering-ku separate weird URL create panna thevai illa.

Bad:
- `/api/getPendingOrders`

Better:
- `/api/orders?status=Pending`

### Use case 3: Get one order

Customer specific order details paakraar.

REST endpoint:
- `GET /api/orders/1`

### Use case 4: Create order

Customer checkout pannaraar.

REST endpoint:
- `POST /api/orders`

### Use case 5: Replace full order details

Admin or internal process order details full-a update pannudhu.

REST endpoint:
- `PUT /api/orders/1`

Example body:
```json
{
  "customerName": "Arun Kumar",
  "productName": "Wireless Mouse",
  "quantity": 3,
  "totalAmount": 2397.00,
  "status": "Confirmed"
}
```

### Use case 6: Update order status

Warehouse packed/shipped update pannudhu.

REST endpoint:
- `PUT /api/orders/1/status`

### Use case 7: Delete order

Wrongly created order remove pannalaam.

REST endpoint:
- `DELETE /api/orders/1`

## Same code without REST - sample and problems

Ithu romba important comparison. Same `E-Commerce Order Management System`-a REST style illaama build pannina epdi irukkum-nu paapom.

### Non-REST sample endpoints

```text
GET    /api/getAllOrders
GET    /api/getOrderById/1
POST   /api/createOrder
POST   /api/updateOrder
POST   /api/updateOrderStatus
POST   /api/deleteOrder
GET    /api/getPendingOrders
```

Ithu first glance-la work aagara madhiri theriyum. Aana architecture and maintainability angle-la paatha niraya problems varum.

## Why this style looks easy initially

Beginner perspective-la indha style easy-a thonum because:
- method name madhiri route name podalaam
- URL paatha action direct-a theriyum-nu feel varum
- controller method peru and route same madhiri irukkum

But scale aagumbodhu indha approach weak aayidum.

## Problems in non-REST style

### 1. URL-la verbs overload aagidum

REST-la URL resource-a represent pannum.

Correct:
- `/api/orders`
- `/api/orders/1`

Non-REST-la:
- `/api/getAllOrders`
- `/api/createOrder`
- `/api/deleteOrder`

Problem:
- HTTP method-um action solludhu
- URL-um innum adhe action solludhu
- duplication varudhu

Example:
- `POST /api/createOrder`

Already `POST` means create. Appo `createOrder` nu marubadiyum solla thevai illa.

### 2. Consistency break aagum

One developer:
- `/api/getAllOrders`

Another developer:
- `/api/order/create`

Another developer:
- `/api/updateOrderStatus`

Nu design pannalaam.

Result:
- project-la uniformity irukkadhu
- new developer-ku confusion
- frontend team-ku endpoint naming guess panna mudiyadhu

### 3. Filtering-ku separate routes create panna aarambichuduvanga

Example:
- `/api/getPendingOrders`
- `/api/getConfirmedOrders`
- `/api/getShippedOrders`

Idhu scalable-a illa.

REST style:
- `/api/orders?status=Pending`
- `/api/orders?status=Confirmed`
- `/api/orders?status=Shipped`

Same endpoint, flexible query filtering.

### 4. Delete operation semantically weak aagum

Non-REST style:
- `POST /api/deleteOrder`

Body:
```json
{
  "id": 1
}
```

Problem:
- delete-ku dedicated HTTP verb already irukku: `DELETE`
- every operation-ku `POST` use pannina API intent weak aagidum
- client side understanding korayum

### 5. Update operations confusing aagum

Non-REST style:
- `POST /api/updateOrder`
- `POST /api/updateOrderStatus`

Problem:
- id URL-la clear-a theriyadhu
- resource path visible-a irukkadhu
- one route full update-ku, one route partial update-ku inconsistent pattern varum

REST style-la:
- `PUT /api/orders/1`
- `PUT /api/orders/1/status`

Idhu paatha udane specific order mela update nu puriyudhu.

### 6. Documentation and testing kashtam aagum

Non-REST route names random-a irundha:
- Postman collections messy aagum
- Swagger docs later clutter aagum
- team discussions-la endpoint names confuse aagum

Example:
One person solraar:
- "pending orders endpoint use pannunga"

Question:
- `/api/getPendingOrders` ah?
- `/api/orders/pending` ah?
- `/api/order/pending/list` ah?

REST style-la mostly ambiguity kammi.

### 7. Client-ku API learn panna kashtam

REST API learn panna client-ku oru pattern purinjirundha pothum:
- collection -> `/orders`
- single item -> `/orders/{id}`
- filter -> query string
- create -> `POST`
- update -> `PUT`
- delete -> `DELETE`

Non-REST API-la ovvoru endpoint-um separate-a memorize panna vendiyadhu varum.

### 8. Future growth-la route explosion varum

E-commerce system grow aagumbodhu:
- get cancelled orders
- get delivered orders
- create express order
- update shipping address
- update payment status

Non-REST style-la routes ipdi perusaagum:
- `/api/getCancelledOrders`
- `/api/getDeliveredOrders`
- `/api/createExpressOrder`
- `/api/updateShippingAddress`
- `/api/updatePaymentStatus`

Konjam naal-la route naming chaos aagidum.

REST style-la:
- `/api/orders?status=Cancelled`
- `/api/orders?status=Delivered`
- `/api/orders/{id}`
- `/api/orders/{id}/status`

Nu manageable-a irukkum.

## Side-by-side comparison

### Get all orders

Non-REST:
- `GET /api/getAllOrders`

REST:
- `GET /api/orders`

### Get one order

Non-REST:
- `GET /api/getOrderById/1`

REST:
- `GET /api/orders/1`

### Create order

Non-REST:
- `POST /api/createOrder`

REST:
- `POST /api/orders`

### Update full order

Non-REST:
- `POST /api/updateOrder`

REST:
- `PUT /api/orders/1`

### Update only status

Non-REST:
- `POST /api/updateOrderStatus`

REST:
- `PUT /api/orders/1/status`

### Delete order

Non-REST:
- `POST /api/deleteOrder`

REST:
- `DELETE /api/orders/1`

### Filter pending orders

Non-REST:
- `GET /api/getPendingOrders`

REST:
- `GET /api/orders?status=Pending`

## Real understanding point

REST-na just stylish URL illa.

REST follow pannumbodhu:
- URL resource represent pannum
- HTTP method action represent pannum
- query string filtering represent pannum
- status code result represent pannum

Indha separation nala API clean-a irukkum.

Non-REST style-la:
- URL-eh action, filter, operation, naming ellathayum carry panna try pannum

Adhanala route names bulky-a, inconsistent-a, hard-to-scale-a aagidum.

## If we had written our current project without REST

Namma current Topic 3 project-oda same features non-REST style-la irundha roughly ipdi irukkum:

- `GET /api/getAllOrders`
- `GET /api/getOrderById/1`
- `POST /api/createOrder`
- `POST /api/updateOrder`
- `POST /api/updateOrderStatus`
- `POST /api/deleteOrder`
- `GET /api/getOrdersByStatus/Pending`

Ithu technically run aagalam. But disadvantages:
- standard follow panna maattom
- frontend integration harder aagum
- route naming grow aagumbodhu mess aagum
- HTTP verbs power full-a use panna mudiyadhu
- API professional design feel korayum

## Summary of the problem

Non-REST API usually:
- works for small demo
- but scale panna weak
- naming inconsistent
- harder to document
- harder to maintain
- harder to predict

REST API:
- cleaner
- standard
- easier to understand
- easier to extend
- easier to integrate

## REST constraints simplified

Official-a REST-ku sila constraints irukku. Beginner-friendly-a paatha:

### Client-server separation
Frontend and backend separate responsibilities.

### Stateless
Ovvoru request-um independent.

### Cacheable
Certain responses cache panna mudiyum.

### Uniform interface
Consistent URL + method usage.

### Layered system
Client-ku backend direct-a single server dhaana, gateway dhaana, middleware dhaana theriyanum nu thevai illa.

### Code on demand
Optional concept. APIs-la daily use-la romba focus panna maatom.

## How this connects with Topic 2

Topic 2-la namma HTTP methods and status codes paathom.

Topic 3-la namma andha HTTP tools-a structured-a use pannrom.

Connection simple:
- Topic 2 = communication rules
- Topic 3 = andha rules use panni nalla API design panna architecture

## In our Topic 3 project what changed?

Previous topic-lendhu same project continue panniyirukkom. Ippo REST concept visible-a irukka konjam improve panniyirukkom:

- controller-based structure continue panniyirukkom
- routes resource-based-a vechirukkom
- `GET /api/orders?status=Pending` nu filter support add panniyirukkom
- `PUT /api/orders/{id}` nu full resource update add panniyirukkom
- `PUT /api/orders/{id}/status` nu sub-resource style update maintain panniyirukkom
- `#region` blocks add panni code sections easy-a identify panna vechirukkom

Current endpoints:
- `GET /api/orders`
- `GET /api/orders?status=Pending`
- `GET /api/orders/{id}`
- `POST /api/orders`
- `PUT /api/orders/{id}`
- `PUT /api/orders/{id}/status`
- `DELETE /api/orders/{id}`

## `#region` use pannadhoda purpose

Code-la `#region` and `#endregion` use pannina editor-la sections collapse/expand panna mudiyum.

Example:
- Builder
- App
- Read Actions
- Write Actions
- Query Methods
- Command Methods

Learning phase-la idhu useful because:
- file structure easy-a puriyum
- related code group panna mudiyum
- big files scan panna easy

## Common beginner mistakes in REST

- URL-la verbs use pannradhu
- `POST /getOrders` madhiri design pannradhu
- status code semantically wrong-a use pannradhu
- collection and single resource routes confuse pannradhu
- filtering-ku weird custom endpoints use pannradhu
- statelessness concept ignore pannradhu

## Summary

REST architecture na HTTP mela build aana clean API design style. Idhu resources-ah central-a vachitu, standard HTTP methods use panni, stateless-a, predictable-a API build panna help pannudhu. E-commerce order management system madhiri real-world-la REST follow pannina URL clean aagum, integrations easy aagum, maintenance simple aagum, team collaboration improve aagum.

---

## Interview Preparation (Simple English)

### Short definition

REST is an architectural style used to design web APIs around resources. It uses standard HTTP methods and stateless communication to make APIs simple, scalable, and predictable.

### Key important points

- REST is an architectural style, not a protocol
- It is built commonly on top of HTTP
- It uses resource-based URLs
- It uses HTTP methods like GET, POST, PUT, DELETE
- It follows stateless communication
- It returns representations such as JSON
- Proper status codes are important in REST APIs

### Interview questions with answers

**1. What is REST?**  
REST is an architectural style for designing web APIs using resources, standard HTTP methods, and stateless communication.

**2. Is REST a protocol?**  
No. REST is not a protocol. It is an architectural style.

**3. What is a resource in REST?**  
A resource is any business entity exposed by the API, such as an order, customer, or product.

**4. Give an example of a RESTful URL.**  
`/api/orders` and `/api/orders/1` are RESTful URLs because they represent a collection and a specific resource.

**5. Why is REST called resource-oriented?**  
Because the API is designed around resources rather than action names.

**6. What does stateless mean in REST?**  
It means each request must contain all the information needed to process it, without depending on previous requests.

**7. Why do we use query parameters in REST?**  
We use query parameters for filtering, sorting, and pagination. Example: `/api/orders?status=Pending`.

**8. What is the difference between `/api/orders` and `/api/orders/1`?**  
`/api/orders` represents the order collection, while `/api/orders/1` represents a single specific order.

**9. Why are HTTP methods important in REST?**  
They provide standard meaning for operations like read, create, update, and delete.

**10. What representation is commonly used in REST APIs?**  
JSON is the most common representation used in REST APIs.
