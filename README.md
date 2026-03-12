# 🌤 Weather Comfort Dashboard

A web application built using **ASP.NET Core MVC** that analyzes weather conditions and ranks cities based on a custom **Comfort Index Score**.

This project was developed as part of the **Fidenz Full Stack Assignment** to demonstrate API integration, backend data processing, caching, authentication, and responsive UI design.

---

## 🚀 Project Overview

The application reads a list of cities from a JSON file, retrieves live weather data from the **OpenWeatherMap API**, calculates a custom **Comfort Index Score**, and ranks cities from **Most Comfortable → Least Comfortable**.

The results are displayed in a responsive dashboard that works on both desktop and mobile devices.

---
## 📷 Dashboard Preview
<img width="882" height="805" alt="Screenshot (2050)" src="https://github.com/user-attachments/assets/94eb7da5-8dfa-4efb-b864-7b4ac8150faf" />
<img width="664" height="659" alt="Screenshot (2053)" src="https://github.com/user-attachments/assets<img width="1785" height="815" alt="Screenshot (2051)" src="https://github.com/user-attachments/assets/65e10a50-8b33-4be5-b9ae-9deec978d209" />
/81c3af5b-31df-4295-9a67-a0f7c17b37d1" />
<img width="1804" height="822" alt="Screenshot (2055)" src="https://github.com/user-attachments/assets/e01b1c54-33a2-4a97-b68e-90fb06d3c4a1" />
<img width="1735" height="834" alt="Screenshot (2052)" src="https://github.com/user-attachments/assets/1a452e45-19a0-49e0-ac48-a55763d730da" />
<img width="1808" height="822" alt="Screenshot (2056)" src="https://github.com/user-attachments/assets/8c164428-06d2-460b-a4e1-c0152f210afd" />

---
## ✨ Key Features

✔ Read city codes from `cities.json`
✔ Fetch real-time weather data using OpenWeatherMap API
✔ Custom **Comfort Index Score** calculation
✔ Rank cities based on weather comfort
✔ Server-side caching using **IMemoryCache**
✔ Secure login using **Auth0 authentication**
✔ Mobile responsive dashboard

---

## ⭐ Bonus Features

* 🌙 Dark Mode toggle
* 🔎 Frontend city search filter
* 📊 Temperature graph using **Chart.js**

---

## 🧠 Comfort Index Concept

The **Comfort Index Score** estimates how comfortable the weather conditions are in a city.

The score is calculated using:

* Temperature
* Humidity
* Wind Speed
* Cloudiness

The result is normalized to a **0 – 100 scale**.

Higher score → More comfortable weather.

---

## 🛠 Technology Stack

* ASP.NET Core MVC
* C#
* css
* Chart.js
* OpenWeatherMap API
* IMemoryCache
* Auth0 Authentication

---

## ⚙ How to Run the Project

### 1️⃣ Clone the repository

```bash
git clone https://github.com/YOUR-USERNAME/weather-comfort-dashboard
```

### 2️⃣ Open in Visual Studio

Open the solution file and restore packages.

### 3️⃣ Configure API Keys

Update `appsettings.json`:

```json
"OpenWeather": {
  "ApiKey": "YOUR_API_KEY"
}

"Auth0": {
  "Domain": "YOUR_DOMAIN",
  "ClientId": "YOUR_CLIENT_ID",
  "ClientSecret": "YOUR_CLIENT_SECRET"
}
```

### 4️⃣ Run the Application

Start the project from Visual Studio.

---

## 🔐 Test Login

Use the following credentials:

```
Email: careers@fidenz.com
Password: Pass#fidenz
```

---

## 📊 Example Output

| Rank | City    | Weather | Temperature | Comfort Score |
| ---- | ------- | ------- | ----------- | ------------- |
| 1    | Colombo | Clouds  | 33°C        | 78            |
| 2    | Tokyo   | Clear   | 8°C         | 70            |
| 3    | Paris   | Clear   | 22°C        | 65            |

Cities are ranked from **Most Comfortable → Least Comfortable**.

---

## 👨‍💻 Author

**Ravichandran Tharmesh**

ASP.NET Full Stack Developer
