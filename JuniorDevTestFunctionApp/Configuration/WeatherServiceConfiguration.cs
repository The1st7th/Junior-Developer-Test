// -----------------------------------------------------------------------
// 
// <copyright file="WeatherServiceConfiguration.cs" company="Provoke Solutions">
// 
// Copyright (c) Provoke Solutions. All rights reserved.
// 
// </copyright>
// 
// -----------------------------------------------------------------------
namespace JuniorDevTestFunctionApp
{
    /// <summary>
    /// Class WeatherServiceConfiguration.
    /// </summary>
    public class WeatherServiceConfiguration
    {
        /// <summary>
        /// Gets or sets the key.
        /// </summary>
        /// <value>The key.</value>
        public string Key { get; set; } = "5ca126d85a3da75eacf46cca04a6f2c1";

        /// <summary>
        /// Gets or sets the weather URL base.
        /// </summary>
        /// <value>The weather URL base.</value>
        public string WeatherUrlBase { get; set; } = "http://api.openweathermap.org/data/2.5/weather";
    }
}
