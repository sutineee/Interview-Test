# Question
- Implement method `GetUserById` in [UserRepository](#question) file to return the model similar to the `ExpectResult1.json` and `ExpectResult2.json`
as following:


  `ExpectResult1.json`
```json
{
  "id": "user01",
  "username": "John.D.Smith",
  "firstName": "John",
  "lastName": "Smith",
  "age": null,
  "roles": [
    {
      "roleId": 1,
      "roleName": "pick operation"
    },
    {
      "roleId": 2,
      "roleName": "pack operation"
    },
    {
      "roleId": 3,
      "roleName": "document operation"
    }
  ],
  "permissions": [
    "1-01-picking-info",
    "1-02-picking-start",
    "1-03-picking-confirm",
    "1-04-picking-report",
    "2-01-packing-info",
    "2-02-packing-start",
    "2-03-packing-confirm",
    "2-04-packing-report",
    "3-01-printing-label"
  ]
}
```

`ExpectResult2.json`
```json
{
  "id": "user02",
  "username": "Bob.M.Jackson",
  "firstName": "Bob",
  "lastName": "Jackson",
  "age": 28,
  "roles": [
    {
      "roleId": 3,
      "roleName": "document operation"
    }
  ],
  "permissions": [
    "1-04-picking-report",
    "2-04-packing-report",
    "3-01-printing-label"
  ]
}
```

- Implement API by using `dependency injection` for interface `IUserRepositoy` file to return the model similar to the `ExpectResult1.json` and `ExpectResult2.json` as following:
  - `GET /api/user/GetUserById/{id}` in `UserController` file. as below:

```csharp
[HttpGet("GetUserById/{id}")]
public ActionResult GetUserById(string id)
{
    //Todo: Implement this method
    return Ok();
}
```