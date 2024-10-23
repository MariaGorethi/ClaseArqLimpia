using Xunit;
using UserManagement.Models;
using UserManagement.Services;

namespace UserManagement.Tests
{
    public class UsuarioServiceTests
    {
        //Ejecutar pruebas 

        //--dotnet restore
        //--dotnet test

        [Fact]//indicar que es un metodo de prueba unitaria
        public void InsertUserTest() { 
            //ARRANQUE
            var servicio = new UsuarioService();

            //fabrica de objetos para hacer pruebas unitarias
            var usuario = new Usuario(1, "Gorethi","maria.villanueva@cenace.gob.mx");

            //ACCIÓN
            servicio.CrearUsuario(usuario);
            var result = servicio.ObtenerUsuarioPorId(usuario.Id);

            //ASERCIÓN
            Assert.NotNull(result);//revisar que se inserto correctamente
            //Validacion de Resultado de la operación
            Assert.Equal(usuario.Nombre, result.Nombre);
            Assert.Equal(usuario.Email, result.Email);

            //si implemente el Equals en el modelo solo quedaria en esta linea
            Assert.Equal(usuario, result);

        }
    }
}