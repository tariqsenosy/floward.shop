API Gateway Design Pattern
#######################
As mentioned in micro service diagram, that our main pattern is API Gateway Design Pattern.

What's API Gateway Design Pattern
Micro services are built in such a way that each service has its own functionality. But, when an application is broken down into small separated services, then there could be 

few problems that a developer might as follows:
1.	How can I request information from multiple micro services?
2.	How to transform data according to the consumer requirement from reusable Micro services
3.	How to unify the mutable domains / IPs into one general domain?

Well, the solution to these kinds of problems could be the API Gateway Design Pattern.
    1-	API Gateway acts as the entry point for all the micro services
    2-	This pattern routes requests to the concerned micro service.
    3-	Micro services then communicate with each other via a stateless server i.e http
    4-	It can route directly to the service or to load balancer for more stability
 


Implementation
###################
Services

1.	Users Service
    a.	Using ASP IdentityServer4 and OAuth2
    b.	Using ELK for logging and SQL Server as database
    c.	SQL server can be replaced with MYSQL for better performance

3.	Admin Service
    a.	Using .Net Core
    b.	Using SSRS for reporting 
    c.	It will serve mainly admin dashbard 
    d.	Admin sends emails/SMS events to RabbitMQ
3.	Products Service
    a.	Uses .net core and sql server 
    b.	Can use one of NoSQL db for better performance in this case
4.	Card Service
    a.	Uses .net core and sql server 
    b.	Can use one of NoSQL db for better performance in this case
    c.	It Has controller , Repository implementation 
    d.	Checkout service send and event to RabbitMQ 
5.	Payment Service
    a.	Uses .net core and sql server 
    b.	Can use one of NoSQL db for better performance in this case
    c.	Can use spring boot instead for integration with other payment services
Kernel
#########
1.	It Mainly contains common classes 
2.	Logging , Cashing , Helpers
Gateway	
##########
1.	API Gateway
    a.	Using Ocelot ,or Kong
    b.	It Handles routing . adding Auth to request
Tests
#######
1.	It contains the project unit tests
2.	Uses xUnit projects
