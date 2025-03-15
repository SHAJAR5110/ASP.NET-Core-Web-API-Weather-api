### 📌 **README for Weather API**  

## 🌦️ **Weather API - ASP.NET Core Web API**  

This is a simple Weather Forecasting API built using **ASP.NET Core Web API**. It provides weather information for selected cities in Pakistan.  

---

## 🚀 **How to Run the Project**  

### 1️⃣ **Clone the Repository**  
```sh
git clone https://github.com/SHAJAR5110/ASP.NET-Core-Web-API-Weather-api.git
cd WeatherAPI
```

### 2️⃣ **Build the Project**  
```sh
dotnet build
```

### 3️⃣ **Run the Project**  
```sh
dotnet run
```

---

## 🔥 **Available Endpoints**  

### ✅ **Get All Weather Data**  
```http
GET /weather
```
📌 **Response:**  
```json
[
  { "city": "Karachi", "temperature": "32.0", "condition": "Sunny" },
  { "city": "Lahore", "temperature": "30.5", "condition": "Partly Cloudy" },
  { "city": "Islamabad", "temperature": "28.3", "condition": "Cloudy" }
]
```

### ✅ **Get Weather by City**  
```http
GET /weather/{city}
```
📌 **Example:**  
```http
GET /weather/Chakwal
```
📌 **Response:**  
```json
{ "city": "Chakwal", "temperature": "26.1", "condition": "Rainy" }
```

### ❌ **City Not Found (Error Handling)**  
```http
GET /weather/London
```
📌 **Response:**  
```json
{ "Message": "No city found!" }
```

---

## 🛠 **Tech Stack**  
✅ ASP.NET Core Web API  
✅ C#  
✅ .NET 8  

---

## 💡 **Features**  
✔️ Predefined weather data for **six Pakistani cities**  
✔️ **Error handling** for unknown cities  
✔️ **RESTful API** endpoints  

---

## 📬 **Feedback & Contributions**  
If you find any issues or want to add more features, feel free to contribute! 😊  

---

