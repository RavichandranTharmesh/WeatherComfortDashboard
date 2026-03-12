Introduction

This project is a weather analytics web application developed using ASP.NET Core MVC.
The system reads city codes from a JSON file, retrieves weather data from the OpenWeatherMap API, calculates a custom Comfort Index Score, and ranks cities based on their weather comfort level.

The application is designed to demonstrate backend data processing, API integration, server-side caching, and responsive UI development.



Comfort Index Formula

The Comfort Index Score represents how comfortable the weather conditions are in a city.

The score is calculated using four weather parameters:
* Temperature
* Humidity
* Wind Speed
* Cloudiness

The formula used in this project is:
Comfort Score =
100
− |Temperature − 24| × 2.5
− |Humidity − 50| × 0.4
− |WindSpeed − 4| × 2
− (Cloudiness × 0.1)

The final score is limited between **0 and 100**.

A higher score indicates more comfortable weather conditions.



Reasoning Behind Variable Weights

Different weather factors affect comfort in different ways.

Temperature has the highest weight because extreme heat or cold quickly affects human comfort.

Humidity also affects comfort because high humidity can make the temperature feel warmer than it actually is.

Wind speed has a moderate effect since a gentle breeze can improve comfort but strong winds can be unpleasant.

Cloudiness has a smaller weight because it has less direct impact on how comfortable the weather feels.



Cache Design Explanation

The application uses **IMemoryCache** to implement server-side caching.

When weather data for a city is requested, the system first checks whether the data is already stored in the cache.

If the data exists in the cache, it is returned directly without calling the API.

If the data is not available in the cache, the system calls the OpenWeatherMap API and stores the result in the cache.

The cache duration is set to 5 minutes

This reduces repeated API calls and improves application performance.



Trade offs Considered

Several design decisions were made while developing the application.

A simple Comfort Index formula was used instead of a complex meteorological model. This makes the system easier to understand and maintain.

The application uses IMemoryCache instead of a distributed cache because the system runs as a single application instance.

Cities are stored in a JSON file instead of a database because the assignment specifically required reading from `cities.json`.

Authentication and authorization are implemented using Auth0, which simplifies login management and secure access control.



Known Limitations

The Comfort Index formula used in this project is a simplified model and does not represent a scientific weather comfort measurement.

IMemoryCache stores data only while the application is running. Cached data will be cleared if the application restarts.

The list of authorized users is currently stored in the application code instead of a database or external configuration.

The application depends on the availability of the OpenWeatherMap API. If the API service is unavailable, weather data cannot be retrieved.



Conclusion

The Weather Comfort Dashboard demonstrates how weather data can be processed and analyzed to produce meaningful insights.
The system integrates external APIs, performs backend calculations, and presents the results through a responsive web interface.

The project also includes caching and authentication mechanisms to improve performance and security.
