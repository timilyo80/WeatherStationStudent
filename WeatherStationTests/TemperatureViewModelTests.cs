﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using WeatherApp.ViewModels;
using Xunit;

namespace WeatherStationTests
{
    public class TemperatureViewModelTests : IDisposable
    {
        // System Under Test
        // Utilisez ce membre dans les tests
        TemperatureViewModel _sut = new TemperatureViewModel();

        /// <summary>
        /// Test la fonctionnalité de conversion de Celsius à Fahrenheit
        /// </summary>
        /// <param name="C">Degré Celsius</param>
        /// <param name="expected">Résultat attendu</param>
        /// <remarks>T01</remarks>
        [Theory]
        [InlineData(0, 32)]
        [InlineData(-40, -40)]
        [InlineData(-20, -4)]
        [InlineData(-17.8, 0)]
        [InlineData(37, 98.6)]
        [InlineData(100, 212)]
        public void CelsiusInFahrenheit_AlwaysReturnGoodValue(double C, double expected)
        {
            // Arrange

            // Act       

            // Assert

            /// xTODO : git commit -a -m "T01 CelsisInFahrenheit_AlwaysReturnGoodValue : Done"
        }

        /// <summary>
        /// Test la fonctionnalité de conversion de Fahrenheit à Celsius
        /// </summary>
        /// <param name="F">Degré F</param>
        /// <param name="expected">Résultat attendu</param>
        /// <remarks>T02</remarks>
        [Theory]
        [InlineData(32, 0)]
        [InlineData(-40, -40)]
        [InlineData(-4, -20)]
        [InlineData(0, -17.8)]
        [InlineData(98.6, 37)]
        [InlineData(212, 100)]
        public void FahrenheitInCelsius_AlwaysReturnGoodValue(double F, double expected)
        {
            // Arrange

            // Act       

            // Assert

            /// xTODO : git commit -a -m "T02 FahrenheitInCelsius_AlwaysReturnGoodValue : Done"
        }

        /// <summary>
        /// Lorsqu'exécuté GetTempCommand devrait lancer une NullException
        /// </summary>
        /// <remarks>T03</remarks>
        [Fact]
        public void GetTempCommand_ExecuteIfNullService_ShouldThrowNullException()
        {
            // Arrange

            // Act       

            // Assert

            /// xTODO : git commit -a -m "T03 GetTempCommand_ExecuteIfNullService_ShouldThrowNullException : Done"
        }

        /// <summary>
        /// La méthode CanGetTemp devrait retourner faux si le service est null
        /// </summary>
        /// <remarks>T04</remarks>
        [Fact]
        public void CanGetTemp_WhenServiceIsNull_ReturnsFalse()
        {
            // Arrange

            // Act       

            // Assert

            /// xTODO : git commit -a -m "T04 CanGetTemp_WhenServiceIsNull_ReturnsFalse : Done"
        }

        /// <summary>
        /// La méthode CanGetTemp devrait retourner vrai si le service est instancié
        /// </summary>
        /// <remarks>T05</remarks>
        [Fact]
        public void CanGetTemp_WhenServiceIsSet_ReturnsTrue()
        {
            // Arrange

            // Act       

            // Assert

            /// xTODO : git commit -a -m "T05 CanGetTemp_WhenServiceIsSet_ReturnsTrue : Done"
        }

        /// <summary>
        /// TemperatureService ne devrait plus être null lorsque SetTemperatureService
        /// </summary>
        /// <remarks>T06</remarks>
        [Fact]
        public void SetTemperatureService_WhenExecuted_TemperatureServiceIsNotNull()
        {
            // Arrange

            // Act       

            // Assert

            /// xTODO : git commit -a -m "T06 SetTemperatureService_WhenExecuted_TemperatureServiceIsNotNull : Done"
        }

        /// <summary>
        /// CurrentTemp devrait avoir une valeur lorsque GetTempCommand est exécutée
        /// </summary>
        /// <remarks>T07</remarks>
        [Fact]
        public void GetTempCommand_HaveCurrentTempWhenExecuted_ShouldPass()
        {
            // Arrange

            // Act       

            // Assert

            /// xTODO : git commit -a -m "T07 GetTempCommand_HaveCurrentTempWhenExecuted_ShouldPass : Done"
        }

        /// <summary>
        /// Ne touchez pas à ça, c'est seulement pour respecter les standards
        /// de test qui veulent que la classe de tests implémente IDisposable
        /// Mais ça peut être utilisé, par exemple, si on a une connexion ouverte, il
        /// faut s'assurer qu'elle sera fermée lorsque l'objet sera détruit
        /// </summary>
        public void Dispose()
        {
            // Nothing to here, just for Testing standards
        }
    }
}
