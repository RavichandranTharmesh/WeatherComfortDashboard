# 🌤 Weather Comfort Dashboard

A web application built using **ASP.NET Core MVC** that analyzes weather conditions and ranks cities based on a custom **Comfort Index Score**.

This project was developed as part of the **Fidenz Full Stack Assignment** to demonstrate API integration, backend data processing, caching, authentication, and responsive UI design.

---

## 🚀 Project Overview

The application reads a list of cities from a JSON file, retrieves live weather data from the **OpenWeatherMap API**, calculates a custom **Comfort Index Score**, and ranks cities from **Most Comfortable → Least Comfortable**.

The results are displayed in a responsive dashboard that works on both desktop and mobile devices.

---
## 📷 Dashboard Preview

<p align="center">
  <img src="https://github.com/user-attachments/assets/2a5a6b55-d05c-4a16-9de5-dcf24796046c" width="420" height="300"/>
  <img src="https://github.com/user-attachments/assets/586dfdbf-167f-4ebf-b8bd-d6daaff54f39" width="420"height="300"/>
</p>

<p align="center">
  <img src="https://github.com/user-attachments/assets/c3021ae6-08f6-427f-917d-6e71f22606cd" width="420"/>
  <img src="https://github.com/user-attachments/assets/97157bef-8e4a-42be-ab6e-719467396a5d" width="420"/>
</p>

<p align="center">
  <img src="https://github.com/user-attachments/assets/acc5d084-8b8d-4b82-811b-0b7af21ed6fe" width="420"/>
  <img src="https://github.com/user-attachments/assets/6849e12b-de8f-4da1-9771-c5851527a9f8" width="420"/>
</p>

---

## ✨ Key Features

✔ Read city codes from cities.json
✔ Fetch real-time weather data using OpenWeatherMap API
✔ Custom Comfort Index Score calculation
✔ Rank cities based on weather comfort
✔ Server-side caching using IMemoryCache
✔ Secure login using Auth0 authentication
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

# ⚙️ Setup Instructions (Backend & Frontend)
---
**Download the Project**  
Go to your GitHub repository.  
Click Code → Download ZIP.  
Extract the ZIP file to a folder on your computer.

**Open in Visual Studio 2022**  
Launch Visual Studio.  
Click Open a project or solution and select **WeatherComfortDashboard-master.sln**.

**Restore and Build**  
Visual Studio will automatically restore all NuGet packages.  
Build the project to ensure everything is set up correctly.

**Run the Project**  
Press F5 or click Run in Visual Studio.  
The application will start, and you can open it in your browser.

**Frontend and Backend Together**  
Since this is an ASP.NET Core MVC project, the frontend pages (Views) and assets (wwwroot) are already included.  
No separate frontend setup is required, everything runs together.

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
