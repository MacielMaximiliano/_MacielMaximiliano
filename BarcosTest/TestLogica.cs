using PracticaBarcosEntidades;
using PracticaBarcosLogica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BarcosTest
{
    class TestLogica
    {


        [Fact]
        public void AgregarBarco_DeberiaAsignarIdYAgregarABarco()
        {
           
            var barcosLogica = new BarcosLogica();
            var nuevoBarco = new Barco
            {
                Nombre = "Titanic",
                Antiguedad = 10,
                Tripulacion = 50
            };

           
            barcosLogica.AgregarBarco(nuevoBarco);

           
            Assert.Equal(1, nuevoBarco.IdBarco); // El primer barco debería tener IdBarco = 1
            Assert.Single(barcosLogica.Listado()); // Debería haber un barco en la lista
        }

        [Fact]
        public void AgregarBarco_DeberiaIncrementarElIdBarcoCorrectamente()
        {
          
            var barcosLogica = new BarcosLogica();
            var barco1 = new Barco { Nombre = "Barco 1", Antiguedad = 5, Tripulacion = 30 };
            var barco2 = new Barco { Nombre = "Barco 2", Antiguedad = 7, Tripulacion = 40 };

           
            barcosLogica.AgregarBarco(barco1);
            barcosLogica.AgregarBarco(barco2);

           
            Assert.Equal(1, barco1.IdBarco);
            Assert.Equal(2, barco2.IdBarco);
            Assert.Equal(2, barcosLogica.Listado().Count); // Debería haber dos barcos en la lista
        }
        [Fact]
        public void Listado_DeberiaRetornarBarcosEnOrdenPorId()
        {
          
            var barcosLogica = new BarcosLogica();
            var barco1 = new Barco { Nombre = "Barco 1", Antiguedad = 5, Tripulacion = 30 };
            var barco2 = new Barco { Nombre = "Barco 2", Antiguedad = 7, Tripulacion = 40 };
            var barco3 = new Barco { Nombre = "Barco 3", Antiguedad = 10, Tripulacion = 50 };

            barcosLogica.AgregarBarco(barco2);
            barcosLogica.AgregarBarco(barco1);
            barcosLogica.AgregarBarco(barco3);

           
            var barcosListado = barcosLogica.Listado();

           
            Assert.Equal(1, barcosListado[0].IdBarco); // Verificar que el primer barco es el que tiene Id 1
            Assert.Equal(2, barcosListado[1].IdBarco);
            Assert.Equal(3, barcosListado[2].IdBarco);
        }


    }





}
