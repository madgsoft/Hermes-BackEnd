# Hermes-BackEnd

This is a **.NET 8 Web API** project called **Hermes-Backend**.

## 🚀 Installation and Execution

### 1️⃣ Clone the repository

```sh
git clone https://github.com/your-username/Hermes-Backend.git
cd Hermes-Backend
```
### 2️⃣ Restore Dependencies
Run the following command to install the necessary packages:
```sh
dotnet restore
```

### 3️⃣ Run the project
To start the API, use the following command:
```sh
dotnet run
```

## 📌 Test the endpoint

```sh
http://localhost:xxxx/weatherforecast
```

## 🛠️ Build and Run the Docker Container

1️⃣ Build the image:
```sh
dotnet publish -c Release -p:PublishProfile=DefaultContainer
```
2️⃣ Run the container:
```sh
docker run -d -p 5000:8080 --name hermes-backend hermes-backend
```
📌 This will run the webapi and make it accessible at http://localhost:5000/weatherforecast.





