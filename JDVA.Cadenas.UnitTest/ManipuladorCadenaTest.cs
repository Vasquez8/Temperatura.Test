using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDVA.Cadenas.UnitTest
{
    public class ManipuladorCadenaTest
    {
        public class ManipuladorCadenasTests
        {
            private readonly ManipuladorCadena _manipulador;

            public ManipuladorCadenasTests()
            {
                // Instanciamos la clase que vamos a probar
                _manipulador = new ManipuladorCadena();
            }

            // Prueba unitaria para concatenar dos cadenas
            [Fact]
            public void Concatenar_DosCadenas_DevuelveCadenaConcatenada()
            {
                // Arrange
                string cadena1 = "Hola";
                string cadena2 = "Mundo";
                string resultadoEsperado = "HolaMundo";

                // Act
                string resultado = _manipulador.Concatenar(cadena1, cadena2);

                // Assert
                Assert.Equal(resultadoEsperado, resultado);
            }

            // Prueba unitaria para convertir una cadena a mayúsculas
            [Fact]
            public void ConvertirAMayusculas_CadenaMinusculas_DevuelveMayusculas()
            {
                // Arrange
                string cadena = "hola";
                string resultadoEsperado = "HOLA";

                // Act
                string resultado = _manipulador.ConvertirAMayusculas(cadena);

                // Assert
                Assert.Equal(resultadoEsperado, resultado);
            }

            // Prueba unitaria para contar palabras en una cadena
            [Fact]
            public void ContarPalabras_CadenaConDosPalabras_DevuelveNumeroCorrecto()
            {
                // Arrange
                string cadena = "Hola Mundo";
                int resultadoEsperado = 2;

                // Act
                int resultado = _manipulador.ContarPalabras(cadena);

                // Assert
                Assert.Equal(resultadoEsperado, resultado);
            }

            // Prueba unitaria para contar palabras en una cadena vacía
            [Fact]
            public void ContarPalabras_CadenaVacia_DevuelveCero()
            {
                // Arrange
                string cadena = "";
                int resultadoEsperado = 0;

                // Act
                int resultado = _manipulador.ContarPalabras(cadena);

                // Assert
                Assert.Equal(resultadoEsperado, resultado);
            }
        }
    }
}
