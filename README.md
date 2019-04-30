<a href="www.linkedin.com/in/brayan-lópez-chaves-78823557"><img src="https://media.licdn.com/dms/image/C5603AQGplS3YeUyMsA/profile-displayphoto-shrink_200_200/0?e=1561593600&v=beta&t=EyD1Wqa5-vob3vLym-akjL3ultDtFgarkkbApsrMlxM" title="ArbolesBinarios" alt="ArbolesBinarios"></a>

<a href="#"><img src="https://github.com/brayanlopez8/ApiArbolesBinarios/blob/master/ImagenAPIArbolBinario.PNG?raw=true" title="api swagger" alt="api Swagger"></a>


# Arboles Binarios API

> Brayan López Technical Test
>https://www.linkedin.com/in/brayan-l%C3%B3pez-chaves-78823557
>https://techprofile.microsoft.com/es-es/brayanlopez8
## Observations

- This project is developed with .Net Framework 4.7.1 (C#)
- This project uses Swagger for the documentation of the API, it allows you to perform the tests
- This project uses the injection of dependencies with Unity.WebApi

### Clone

- Clone this repo to your local machine using `https://github.com/brayanlopez8/ApiArbolesBinarios.git`

### Setup

### Step 1

- **Option 1**
    Fork this repo!

- **Option 2**
    Clone this repo to your local machine using `https://github.com/brayanlopez8/ApiArbolesBinarios.git`

### Step 2

	Build or Rebuild the solution verifying that all the packages are downloaded correctly, If not, download the packages through the Nuget package Manager

### Step 3

	Verify that the project named as (BrayanTechnicalTest.API) is a startup project

### Step 4

	Run the application, by default you will start the Swagger interface which will allow you to consume the services.

### Step 5

	The api/get method will allow you to perform an API test.

### Step 6
	The POST Api / CreateTree method will allow you to create binary trees by entering in the values field the following data as an example [70,49,84,37,54,78,85,22,40,51,76,80]  this method will return an object with the corresponding binary tree (object that will be used in the later method)

 ### Step 7
	The POST / api/AncestroComun method receives three parameters, the first an object of type binary tree returned in the previous method and two integer values, when running the test the result will be the common ancestor closer to the two entered integer values.
