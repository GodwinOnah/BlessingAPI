// README.md
# BagSho-API 
### Introduction
BagSho-API  is an e-commerce web API built with ASP.NET Core 7. It allows users to select and add, then pay for these items after adding them into a redis database (Azure Redis Cashe for this project), pay using stripe card payment system. Orders made are save in an SQL database (Azure SQL database for this project) with ease and efficiency.
### Project Support Features
* Users can signup and login to their accounts
* Public (non-authenticated) users can access items but will need to login to buy them on this application
* Authenticated users can access as well as pay for items.
* * Authenticated admin can access, add, update, delete, as well as pay for items when logged in.
### Installation Guide
* Clone this repository [here](https://github.com/GodwinOnah/BlessingAPI.git)
* The main branch is the most stable branch at any given time, ensure you're working from it.
* You can either work with the default postgreSQL database or add connection strings from databases from a cloud service e.g  Azure SQL database. Do configure to your choice in the application entry file.
* Create an .env file in your project root folder and add your variables. See .env.sample for assistance.
### Usage
* Run dotnet watch --no-hot-reload to start the application.
* Connect to the API using Postman using the link https://blessingbagstoe.azurewebsites.net
### API Endpoints
| HTTP Verbs | Endpoints | Action |
| --- | --- | --- |
| POST | /products | To add a product items |
| POST | /products/savePicture | To save item image |
| POST | /delivery | To add a delivery option 
| POST | /advert | To add an advertisment |
| POST | /admin | To add confirmed order to admin table |
| POST | /order | To add a new order |
| GET | /products | To view all product items |
| GET | /products/brands | To view all avilable product brands options |
| GET | /products/types | To view all avilable product types options |
| GET | /admin | To view confirmed orders saved in admin table |
| GET | /advert | To view available adverts |
| GET | /advert/id | To view an adverts |
| GET | /order/id | To a order using order id |
| GET | /order/delivery | To view all available delivery options |
| GET | /user/login | To login user |
| GET | /user/register | To register a user |
| GET | /user/forgotpassword | To retrieve user password |
| PUT | /admin | To edit confirmed order save on admin table |
| PUT | /order | To user order |
| DELETE | /advert/id | To delete an advert |
| DELETE | /order/id | To delete an order |
| DELETE | /admin/id | To delete an order saved on admin table |
| DELETE | /order/delivery | To delete an advert |
### Technologies Used
* [C#](https://en.wikipedia.org/wiki/C_Sharp_(programming_language)) is a general-purpose high-level programming language supporting multiple paradigms. C# encompasses static typing, strong typing, lexically scoped, imperative, declarative, functional, generic, object-oriented, and component-oriented programming disciplines.
* [SQL](https://en.wikipedia.org/wiki/SQL) (Structured Query Language) is a domain-specific language used to manage data, especially in a relational database management system. It is particularly useful in handling structured data, i.e., data incorporating relations among entities and variables.
*  [Azure](https://portal.azure.com) known as Microsoft Azure, often referred to as Azure, is a cloud computing platform run by Microsoft. It offers access, management, and the development of applications and services through global data centers
### Authors
* [Onah Godwin Obande](https://godwinportfolio.azurewebsites.net)
* ![alt text](https://github.com/GodwinOnah/BlessingAPI/blob/main/API/files/Author/godwin-onah.png?raw=true)
### Project Screenshots
#### i
* ![alt text](https://github.com/GodwinOnah/BlessingAPI/blob/main/API/files/projectScreenshots/apiImage1.png?raw=true)
#### ii
* ![alt text](https://github.com/GodwinOnah/BlessingAPI/blob/main/API/files/projectScreenshots/apiImage2.png?raw=true)
#### iii
* ![alt text](https://github.com/GodwinOnah/BlessingAPI/blob/main/API/files/projectScreenshots/apiImage3.png?raw=true)
#### 1
* ![alt text](https://github.com/GodwinOnah/BlessingAPI/blob/main/API/files/projectScreenshots/image1.png?raw=true)
#### 2
* ![alt text](https://github.com/GodwinOnah/BlessingAPI/blob/main/API/files/projectScreenshots/image2.png?raw=true)
#### 3
* ![alt text](https://github.com/GodwinOnah/BlessingAPI/blob/main/API/files/projectScreenshots/image3.png?raw=true)
#### 4
* ![alt text](https://github.com/GodwinOnah/BlessingAPI/blob/main/API/files/projectScreenshots/image3.png?raw=true)
#### 5
* ![alt text](https://github.com/GodwinOnah/BlessingAPI/blob/main/API/files/projectScreenshots/image5.png?raw=true)
#### 6
* ![alt text](https://github.com/GodwinOnah/BlessingAPI/blob/main/API/files/projectScreenshots/image6.png?raw=true)
#### 7
* ![alt text](https://github.com/GodwinOnah/BlessingAPI/blob/main/API/files/projectScreenshots/image7.png?raw=true)
#### 8
* ![alt text](https://github.com/GodwinOnah/BlessingAPI/blob/main/API/files/projectScreenshots/image8.png?raw=true)
#### 9
* ![alt text](https://github.com/GodwinOnah/BlessingAPI/blob/main/API/files/projectScreenshots/image9.png?raw=true)
#### 10
* ![alt text](https://github.com/GodwinOnah/BlessingAPI/blob/main/API/files/projectScreenshots/image10.png?raw=true)
#### 11
* ![alt text](https://github.com/GodwinOnah/BlessingAPI/blob/main/API/files/projectScreenshots/image11.png?raw=true)
#### 12
* ![alt text](https://github.com/GodwinOnah/BlessingAPI/blob/main/API/files/projectScreenshots/image12.png?raw=true)
#### 13
* ![alt text](https://github.com/GodwinOnah/BlessingAPI/blob/main/API/files/projectScreenshots/image13.png?raw=true)
#### 14
* ![alt text](https://github.com/GodwinOnah/BlessingAPI/blob/main/API/files/projectScreenshots/image14.png?raw=true)
#### 15
* ![alt text](https://github.com/GodwinOnah/BlessingAPI/blob/main/API/files/projectScreenshots/image15.png?raw=true)
#### 16
* ![alt text](https://github.com/GodwinOnah/BlessingAPI/blob/main/API/files/projectScreenshots/image16.png?raw=true)
#### 17
* ![alt text](https://github.com/GodwinOnah/BlessingAPI/blob/main/API/files/projectScreenshots/image17.png?raw=true)
#### 18
* ![alt text](https://github.com/GodwinOnah/BlessingAPI/blob/main/API/files/projectScreenshots/image18.png?raw=true)
### License
This project is available for use under my approval.

