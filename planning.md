# Life Hack That Makes It Worse API
[Back to README](README.md)

## Product Idea

An API that generates worthless "Life Hacks" based on strings we have in our database.

## User Stories (Backlog)

As a system i would like to collect data from the database.
- Create database - Sql 
- Add data 
- Ef Core 
- Get data endpoints
- Connectionstrings stroed in user-secrets
- Add Entities

As a developer i would like to have relevant names on endpoints.
- api/advice
- api/advice/category?=<'search'>

As Admin i can create new advice that stores in the database
- Full CRUD

As a user i would like to receive the id of the advice.
- Set id on advice

As a user i would like to receive the creators name of the advice.
- The advice has a fictive creator "example advice that makes it worse - Albert Einstein"
- Object for creator  

As a user i would like to receive a worthless advice to make my life worse.
- Get endpoint  

As a developer i want to use repository pattern for the code
- Dto for transfering data
- DbContext
- IAdviceRepo + AdviceRepo
- IAdviceService + AdviceService
- AdviceController

As a user i want to get advice from diffrent categories
- search by category endpoint 

As a user i want to get multiple advice with one request
- Get all limit- 10
- returns list object
