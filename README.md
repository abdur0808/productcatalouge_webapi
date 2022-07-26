# Product .net core 3.1 WebApi App

This project was build in .net core V3.1.


## 
Open the .Net core WebApi application

Build the Application & resolve the conflict if any.

## Open Package Manager Console

Make sure you have selected the project 'Project.DB'

And paste the below cmd in PM>

## PM> ADD-MIGRATION initials4

Build started...
Build succeeded.
To undo this action, use Remove-Migration.

And then run the below cmd-

## PM> UPDATE-DATABASE

Build started...
Build succeeded.
Applying migration 'xxxxxxxx_initials4'.
Done.



## API Reference

#### Get products collection

```http
  GET https://localhost:5001/api/product
```

| Parameter  | Type     | Description                    |
| :--------- | :------- | :----------------------------- |
| `` | `` | **Required**. get the product details |

#### Get Search  result

```http
  GET https://localhost:5001/api/product/serachproducts/${payload}
```

| Parameter     | Type  | Description                                   :-------------------------------------------- |
| `SearchValue` | `string` | **Required**. get product collection 

#### Get filter  result

```http
  GET https://localhost:5001/api/product/orderbyproducts/${payload}
```

| Parameter     | Type  | Description                                   :-------------------------------------------- |
| `filterValue` | `string` | **Required**. get product collection 

