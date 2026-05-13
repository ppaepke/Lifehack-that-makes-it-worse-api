# Life Hack That Makes It Worse API
[Back to README](README.md)

## Product Idea

An API that generates worthless "Life Hacks" based on strings we have in our database.

## User Stories (Backlog)

As a system i would like to collect data from the database.
- Create database - Sql [x] 
- Add data [x]
- Ef Core [x]
- Get data endpoints [x]
- Connectionstrings stroed in user-secrets [x]
- Add Entities [x]

As a developer i would like to have relevant names on endpoints.
- api/advice [x]
- api/advice/category?=<'search'> [x]

As Admin i can create new advice that stores in the database
- Full CRUD [x]

As a user i would like to receive the id of the advice.
- Set id on advice [x]
 

As a user i would like to receive a worthless advice to make my life worse.
- Get endpoint  [x]

As a developer i want to use repository pattern for the code
- Dto for transfering data 
- DbContext [x]
- IAdviceRepo + AdviceRepo [x]
- IAdviceService + AdviceService [x]
- AdviceController [x]

As a user i want to get advice from diffrent categories
- search by category endpoint [x] 

As a user i want to get multiple advice with one request
- Get all limit- 10 [x]
- returns list object [x]
