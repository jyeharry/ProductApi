# C# test for Kolmeo

At the commandline, navigate to the `ProductApi` directory then run `dotnet run` then, using your favourite API tool, make requests to `localhost:5069`.

If `localhost:5069` doesn't work try `localhost:7262`

## Routes

```
GET       /api/Products
POST      /api/Products
GET       /api/Products/{id}
PUT       /api/Products/{id}
DELETE    /api/Products/{id}
```

An example curl request to get you started:

```
curl --location --request POST 'http://localhost:5069/api/Products' \
--header 'accept: text/plain' \
--header 'Content-Type: application/json' \
--data-raw '{
  "name": "Chair",
  "description": "A chair for sitting on",
  "price": 75
}'
```
