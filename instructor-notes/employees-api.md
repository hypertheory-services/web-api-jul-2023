# Employees


## GET /employees

Collection Resource


```json
{
    "employees": [
        {
            "id": "1",
            "firstName": "Dale",
            "lastName": "Cooper",
            "email": "dcooper@fbi.gov",
            "department": "Special Agent"
        },
        {
            "id": "2",
            "firstName": "Gordon",
            "lastName": "Cole",
            "email": "gcole@fbi.gov",
            "department": "Director"
        }
    ],
    "showingDepartment": "All"
}
```

## GET /employees/{id}

```json
{
    "id": "1",
    "firstName": "Dale",
    "lastName": "Cooper",
    "email": "dcooper@fbi.gov",
    "department": "Special Agent",
    "phoneExtension": "555"
}
```

## Hiring an Employee

1. An HR Person creates a hiring request.
2. The department head reviews those requests, and decides if they will offer a job or not.
3. Telecom will assign a phone extension. (spoiler - we are going to build an API for this tomorrow.)

"Almost every API design challenge is solved by adding another resource" - Steve Klabnik


## POST /hiring-requests

```json

{
    "firstName": "Jenny",
    "lastName": "Cooper",
    "homeEmail": "jenny@aol.com",
    "homePhone": "867-5309",
    "requestedDepartment": "DEV",
    "requiredSalary": 80000
}
```

### Response

201 Created
Location: http://localhost:1337/hiring-requests/32

```json
{
    "id": 32,
    "firstName": "Jenny",
    "lastName": "Cooper",
    "homeEmail": "jenny@aol.com",
    "homePhone": "867-5309",
    "requestedDepartment": "DEV",
    "requiredSalary": 80000,
    "status": "WaitingForJobAssignment"
}
```
