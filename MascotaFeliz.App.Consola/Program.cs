using System;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;
using System.Collections.Generic;

namespace MascotaFeliz.App.Consola
{
    class Program
    {
        //////////////////////////////// Dueños ////////////////////////////////////////
        private static IRepositorioDueno _repoDueno = new RepositorioDueno(new Persistencia.AppContext()); // Constructor App context es la variable de la BD
        static void Main(string[] args)
        {
            Console.WriteLine("Listones!!!");
            //AddDueno();
            //ListarDuenos();
            //BuscarDueno(1);

            //AddVeterinario();
            //ListarVeterinarios();

            //AddMascota();
            //ListarMascotas();
            //BuscarMascota(1);
        }

        private static void AddDueno()
        {
          var dueno = new Dueno // Crea un objeto de la clase Dueno
           {
               // Atributos del objeto
               //Cedula = "1212",
               Nombres = "Juan",
               Apellidos = "Sin Miedo",
               Direccion = "Bajo un puente",
               Telefono = "1234567891",
               Correo = "juansinmiedo@gmail.com"
           };
           _repoDueno.AddDueno(dueno); // Método _repoDueno agregar dueño y manda el dueño que acabo de crear //_repoDueno tiene todos los métodos de Dueno
        }

        private static void BuscarDueno(int idDueno)
        {
            var dueno = _repoDueno.GetDueno(idDueno);
            Console.WriteLine(dueno.Id + " " + dueno.Nombres + " " + dueno.Apellidos + " " + dueno.Direccion + " " + dueno.Telefono + " " + dueno.Correo);
        }

        private static void ListarDuenos()
        {
            var duenos = _repoDueno.GetAllDuenos();
            foreach (Dueno d in duenos)
            {
                Console.WriteLine(d.Nombres + " " + d.Apellidos);
            }
        }

        //////////////////////////////// Veterinarios ////////////////////////////////////////
        private static IRepositorioVeterinario _repoVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());
        private static void AddVeterinario()
        {
           var veterinario = new Veterinario // Crea un objeto de la clase Dueno
            {
                // Atributos del objeto
                //Cedula = "1212",
                Nombres = "Miguel",
                Apellidos = "Rojas",
                Direccion = "Cerca___clínica",
                Telefono = "3135456",
                TarjetaProfesional = "1230"
            };
            _repoVeterinario.AddVeterinario(veterinario);
            
        }

        private static void ListarVeterinarios()
        {
            var veterinarios = _repoVeterinario.GetAllVeterinarios();
            foreach (Veterinario v in veterinarios)
            {
                Console.WriteLine(v.Nombres + " " + v.Apellidos);
            }
        }

        //////////////////////////////// Mascotas ////////////////////////////////////////
        private static IRepositorioMascota _repoMascota = new RepositorioMascota(new Persistencia.AppContext());
        private static void AddMascota()
        {
           var mascota = new Mascota // Crea un objeto de la clase mascota
            {
                // Atributos del objeto
                //Cedula = "1212",
                Nombre = "Luna",
                Color = "Blanco",
                Especie = "Perro",
                Raza = "French poodle",
            };
            _repoMascota.AddMascota(mascota);
            
        }

        private static void ListarMascotas()
        {
            var mascotas = _repoMascota.GetAllMascotas();
            foreach (Mascota m in mascotas)
            {
                Console.WriteLine("Nombre de la mascota: "+ m.Nombre + "    Especie: " + m.Especie + "  Raza: " + m.Raza + "  Color: " + m.Color);
            }
        }

        private static void BuscarMascota(int idMascota)
        {
            var mascota = _repoMascota.GetMascota(idMascota);
            Console.WriteLine(mascota.Id + "    Nombre de la mascota: " + mascota.Nombre+ "    Especie: " + mascota.Especie + "    Raza: " + mascota.Raza + "  Color: " + mascota.Color);
        }
    }
}
