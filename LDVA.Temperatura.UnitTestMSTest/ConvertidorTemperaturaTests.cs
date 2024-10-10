using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using JDVA.Temperatura;

namespace JDVA.Temperatura.UnitTestMSTest
{
    [TestClass]
    public class ConvertidorTemperaturaTests
    {
        private ConvertidorTemperatura _convertidor;

        [TestInitialize]
        public void Setup()
        {
            _convertidor = new ConvertidorTemperatura();
        }

        [TestMethod]
        public void ConvertirCelsiusAFahrenheit_ValorCorrecto()
        {
            // Arrange
            double celsius = 100;
            double resultadoEsperado = 212;

            // Act
            double resultado = _convertidor.CelsiusAFahrenheit(celsius); // Cambiado a CelsiusAFahrenheit

            // Assert
            Assert.AreEqual(resultadoEsperado, resultado, 0.001);
        }


        [TestMethod]
        public void ConvertirFahrenheitACelsius_ValorCorrecto()
        {
            // Arrange
            double fahrenheit = 32;
            double resultadoEsperado = 0;

            // Act
            double resultado = _convertidor.FahrenheitACelsius(fahrenheit);

            // Assert
            Assert.AreEqual(resultadoEsperado, resultado, 0.001);
        }

        [TestMethod]
        public void ConvertirCelsiusAFahrenheit_ValorBajo()
        {
            // Arrange
            double celsius = -40;
            double resultadoEsperado = -40;

            // Act
            double resultado = _convertidor.FahrenheitACelsius(celsius);

            // Assert
            Assert.AreEqual(resultadoEsperado, resultado, 0.001);
        }

        [TestMethod]
        public void ConvertirFahrenheitACelsius_ValorBajo()
        {
            // Arrange
            double fahrenheit = -40;
            double resultadoEsperado = -40;

            // Act
            double resultado = _convertidor.FahrenheitACelsius(fahrenheit);

            // Assert
            Assert.AreEqual(resultadoEsperado, resultado, 0.001);
        }
    }

}
