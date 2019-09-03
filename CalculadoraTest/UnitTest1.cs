using System;
using NUnit.Framework;

namespace CalculadoraTest
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void Sumar_UnoMasDos_Test()
        {
            var calculadora = new Calculadora.Calcular();
            int resulatdoesperado = 3;
            int resultado = calculadora.Sumar(1, 2);
            Assert.AreEqual(resulatdoesperado, resultado);

        }

        [Test]
        public void Restar_TresMenosDos_Test()
        {
            var calculadora = new Calculadora.Calcular();
            int resultadoE = 1;
            int resultado = calculadora.Restar(3, 2);
            Assert.AreEqual(resultadoE, resultado);
        }
    }
}
