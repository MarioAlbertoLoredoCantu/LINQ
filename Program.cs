// See https://aka.ms/new-console-template for more information

//Ejemplo 1 video 1
// int[]numeros = Enumerable.Range(1,5).ToArray();

// //Sintaxis 1: sintaxis de métodos
// var numerosPares = numeros.Where(n=>n% 2 ==0).ToList();
// //Sintaxis 2: Sintaxis de queries
// var numerosPares2= (from n in numeros where n % 2 ==0 select n).ToList();

//////////////////////////////////

// //Ejemplo 2 video 2
// int[]numeros = Enumerable.Range(1,5).ToArray();

// //Sintaxis 1: sintaxis de métodos
// var numerosPares = numeros.Where(n=>{Console.WriteLine($"Evaluando si {n} es par");return n% 2 ==0;}).ToList();

// foreach (var numero in numerosPares)
// {
//     Console.WriteLine("$Sí, el "+ numero + " es par.");
// }

///////////////////////////////////

//Ejemplo 3 video 3
// using System.Windows.Markup;

// int[]numeros = Enumerable.Range(1,20).ToArray();

// var numerosImpares = numeros.Where (n=> n% 2==1).ToList();
// // Console.WriteLine("Los numeros Impares son:");
// // foreach (var numero in numerosImpares)
// // {
// //     Console.WriteLine(numero);
// // }
// //Sintaxis de metodos
// var numerosImparesMayoresQue10 = numerosImpares.Where (n => n % 2 ==1 && n>10).ToList();
// //Sintaxis de query
// var numerosImparesMayoresQue10_2 = from n in numeros where n % 2 ==1 && n > 10 select n;
// Console.WriteLine("Los numeros impares Mayores Que 10 son:");
// foreach (var numero in numerosImparesMayoresQue10) 
// {
//     Console.WriteLine(numero);
// }

//////////////////////////////////////////

//Ejemplo 4 video 4
// using LINQ2;

// var personas = new List<Persona>(){
//     new Persona { Nombre = "Eduardo", Edad = 30, FechaIngresoAlaEmpresa = new DateTime(2023,1,2), Soltero = true},
//     new Persona { Nombre = "Nidia", Edad = 19, FechaIngresoAlaEmpresa = new DateTime(2023,1,2), Soltero = true},
//     new Persona { Nombre = "Alejandro", Edad = 45, FechaIngresoAlaEmpresa = new DateTime(2023,1,2), Soltero = true},
//     new Persona { Nombre = "Valentina", Edad = 24, FechaIngresoAlaEmpresa = new DateTime(2023,1,2), Soltero = true},
//     new Persona { Nombre = "Roberto", Edad = 61, FechaIngresoAlaEmpresa = new DateTime(2023,1,2), Soltero = true},
// };

// // var personasde25añosOMenos = personas.Where(p=> p.Edad <= 25).ToList();

// // foreach (var persona in personasde25añosOMenos)
// // {
// //     Console.WriteLine($"{persona.Nombre} tiene {persona.Edad} años.");

// // }

// var solteros = personas.Where(p => p.Soltero && p.Edad <= 25).ToList();

// foreach (var persona in solteros)
// {
//     Console.WriteLine($"{persona.Nombre} es soltero/a");
// }

// var personaConMenosde3MesesEnLaEmpresa = personas.Where(p => p.FechaIngresoAlaEmpresa>=DateTime.Now.AddMonths(-3)).ToList();
// //Sintaxis de queries
// var personaConMenosde3MesesEnLaEmpresa_2= from p in personas where p.FechaIngresoAlaEmpresa >=DateTime.Now.AddMonths(-3) select p;

// foreach (var persona in personaConMenosde3MesesEnLaEmpresa_2)
// {
//     Console.WriteLine($"{persona.Nombre} tiene menos de 3 meses en la empresa.");
// }

/////////////////////////////////////////

//Ejemplo 5 video 5

// using LINQ2;

//  var personas = new List<Persona>(){
//      new Persona { Nombre = "Eduardo", Edad = 30, FechaIngresoAlaEmpresa = new DateTime(2023,1,2), Soltero = true},
//      new Persona { Nombre = "Nidia", Edad = 19, FechaIngresoAlaEmpresa = new DateTime(2023,1,2), Soltero = true},
//      new Persona { Nombre = "Alejandro", Edad = 45, FechaIngresoAlaEmpresa = new DateTime(2023,1,2), Soltero = true},
//      new Persona { Nombre = "Valentina", Edad = 24, FechaIngresoAlaEmpresa = new DateTime(2023,1,2), Soltero = true},
//      new Persona { Nombre = "Roberto", Edad = 61, FechaIngresoAlaEmpresa = new DateTime(2023,1,2), Soltero = true},
//  };

// var primeraPersona = personas.First();
// var primeraPersona2 = personas.FirstOrDefault();

// var paises = new List<string>();
// try{
//     var primerPais = paises.First();
// }
// catch(Exception ex)
// {
//     Console.WriteLine("Ha ocurrido un error");
// }

// var primerpais2= paises.FirstOrDefault();

// var numeros = new List<int>();
// var primeraNumero = numeros.FirstOrDefault();

// var primeraPersonaNoSoltera= personas.FirstOrDefault(p=>!p.Soltero);
// //Sintaxis de query
// var primeraPersonaNoSoltera_2=(from p in personas where !p.Soltero select p).FirstOrDefault();
// var a = 1;

////////////////////////////////////////////

//Ejemplo 6 video 6

//  using LINQ2;

// var personas = new List<Persona>(){
//       new Persona { Nombre = "Eduardo", Edad = 30, FechaIngresoAlaEmpresa = new DateTime(2023,1,2), Soltero = true},
//       new Persona { Nombre = "Nidia", Edad = 19, FechaIngresoAlaEmpresa = new DateTime(2023,1,2), Soltero = true},
//       new Persona { Nombre = "Alejandro", Edad = 45, FechaIngresoAlaEmpresa = new DateTime(2023,1,2), Soltero = true},
//       new Persona { Nombre = "Valentina", Edad = 24, FechaIngresoAlaEmpresa = new DateTime(2023,1,2), Soltero = true},
//       new Persona { Nombre = "Roberto", Edad = 61, FechaIngresoAlaEmpresa = new DateTime(2023,1,2), Soltero = true},
//   };

//   var ultimaPersona =personas.Last();
//   var ultimaPersona2 = personas.LastOrDefault();
//   var ultimaPersona3 = personas.Last(p=>p.Soltero);

//   //Sintexis de queries
//   var ultimaPersonaSoltera_2 = (from p in personas where p.Soltero select p).Last();

////////////////////////////////////////////

//Ejemplo 7 video 7

//  using LINQ2;

// var personas = new List<Persona>(){
//       new Persona { Nombre = "Eduardo", Edad = 30, FechaIngresoAlaEmpresa = new DateTime(2023,1,2), Soltero = true},
//       new Persona { Nombre = "Nidia", Edad = 19, FechaIngresoAlaEmpresa = new DateTime(2023,1,2), Soltero = true},
//       new Persona { Nombre = "Alejandro", Edad = 45, FechaIngresoAlaEmpresa = new DateTime(2023,1,2), Soltero = true},
//       new Persona { Nombre = "Valentina", Edad = 24, FechaIngresoAlaEmpresa = new DateTime(2023,1,2), Soltero = true},
//       new Persona { Nombre = "Roberto", Edad = 61, FechaIngresoAlaEmpresa = new DateTime(2023,1,2), Soltero = true},
//   };

//   var terceraPerosna = personas.ElementAt(2);
//   var sextapersona = personas.ElementAt(5);

// //sintaxis de queries
// var sextaPersona_2 = (from p in personas select p).ElementAtOrDefault(5);

//   var a = 1;

////////////////////////////////////////////

//Ejemplo 8 video 8

//  using LINQ2;

// var personas = new List<Persona>(){
//       new Persona { Nombre = "Eduardo", Edad = 30, FechaIngresoAlaEmpresa = new DateTime(2023,1,2), Soltero = true},
//       new Persona { Nombre = "Nidia", Edad = 19, FechaIngresoAlaEmpresa = new DateTime(2023,1,2), Soltero = true},
//       new Persona { Nombre = "Alejandro", Edad = 45, FechaIngresoAlaEmpresa = new DateTime(2023,1,2), Soltero = true},
//       new Persona { Nombre = "Valentina", Edad = 24, FechaIngresoAlaEmpresa = new DateTime(2023,1,2), Soltero = true},
//       new Persona { Nombre = "Roberto", Edad = 61, FechaIngresoAlaEmpresa = new DateTime(2023,1,2), Soltero = true},
//   };
//   var personaMayorDe60 = personas.Single(p=>p.Edad > 60);

//   //sintaxis de queries
//   var personaMayorde60_2=(from p in personas where p.Edad>60select p).Single();
//   try
//   {
//     var personaMayorDe100 = personas.SingleOrDefault(p=>p.Edad > 100);
//   }
//   catch (Exception ex)
//   {
//     Console.WriteLine("hubo un error, arreglo vacio");

//   }
//   try
//   {
//     var personaMayorA5 = personas.SingleOrDefault(p=>p.Edad > 5);
//   }
//  catch (Exception ex)
//   {
//     Console.WriteLine("hubo un error, arreglo con mas de un elemento");

//   }

////////////////////////////////////////////

//Ejemplo 9 video 9

// using System.Runtime.InteropServices.Marshalling;
// using System.Windows.Markup;

// var listado = new List<Object>(){"Felipe",1,2,"Claudia", true};

// var strings = listado.OfType<string>();
// var numeros = listado.OfType<int>();

// //Sintaxis de queries
// var strings_2 = from s in listado.OfType<string>() select s;
// //ejemplo 2: herencia


// var listadoAnimales = new List<Animal>()
// {
//     new Perro(){Nombre = "Firulais"},
//     new Perro(){Nombre = "Felix"},
// };

// var perros = listadoAnimales.OfType<Perro>();
// public abstract class Animal
// {
//     public abstract string? Nombre { get; set;}
    
// }

// public class Perro : Animal
// {
//     public override String? Nombre { get; set;}
// }

// public class Gato : Animal
// {
//     public override string? Nombre { get; set;}
// }

////////////////////////////////////////////

//Ejemplo 10 video 10

using LINQ2;

 var personas = new List<Persona>(){
       new Persona { Nombre = "Eduardo", Edad = 30, FechaIngresoAlaEmpresa = new DateTime(2023,1,2), Soltero = true},
       new Persona { Nombre = "Nidia", Edad = 19, FechaIngresoAlaEmpresa = new DateTime(2023,1,2), Soltero = true},
       new Persona { Nombre = "Alejandro", Edad = 45, FechaIngresoAlaEmpresa = new DateTime(2023,1,2), Soltero = true},
       new Persona { Nombre = "Valentina", Edad = 24, FechaIngresoAlaEmpresa = new DateTime(2023,1,2), Soltero = true},
       new Persona { Nombre = "Roberto", Edad = 61, FechaIngresoAlaEmpresa = new DateTime(2023,1,2), Soltero = true},
   };

//    var personasOrdernadasPorEdad = personas.OrderByDescending(x => x.Edad);

//    foreach (var persona in personasOrdernadasPorEdad)
//    {
//     Console.WriteLine($"{persona.Nombre} tiene {persona.Edad} años de edad");

//    }

int[] numeros = {1,5,12,2,3,111,6};

foreach (var numero in numeros.OrderBy(x => x))
{
    Console.WriteLine(numero);
}

//sintaxis de queries

var numeros_2 = from n in numeros orderby n select n;

var personasOrdernadasPorEdad_2 = from p in personas orderby p.Edad descending select p;














