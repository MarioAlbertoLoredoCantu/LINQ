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

// using LINQ2;

//  var personas = new List<Persona>(){
//        new Persona { Nombre = "Eduardo", Edad = 30, FechaIngresoAlaEmpresa = new DateTime(2023,1,2), Soltero = true},
//        new Persona { Nombre = "Nidia", Edad = 19, FechaIngresoAlaEmpresa = new DateTime(2023,1,2), Soltero = true},
//        new Persona { Nombre = "Alejandro", Edad = 19, FechaIngresoAlaEmpresa = new DateTime(2023,1,2), Soltero = true},
//        new Persona { Nombre = "Valentina", Edad = 24, FechaIngresoAlaEmpresa = new DateTime(2023,1,2), Soltero = true},
//        new Persona { Nombre = "Roberto", Edad = 61, FechaIngresoAlaEmpresa = new DateTime(2023,1,2), Soltero = true},
//    };

//    var personasOrdernadasPorEdad = personas.OrderBy(x => x.Edad).ThenByDescending(x=>x.Nombre);

//    foreach (var persona in personasOrdernadasPorEdad)
//    {
//     Console.WriteLine($"{persona.Nombre} tiene {persona.Edad} años de edad");

//    }

//    //Sintaxis de queries
//    var personasOrdenadasPorEdad_2 = from p in personas orderby p.Edad, p.Nombre descending select p;

// int[] numeros = {1,5,12,2,3,111,6};

// foreach (var numero in numeros.OrderBy(x => x))
// {
//     Console.WriteLine(numero);
// }

// //sintaxis de queries

// var numeros_2 = from n in numeros orderby n select n;

// var personasOrdernadasPorEdad_2 = from p in personas orderby p.Edad descending select p;

// using LINQ2;

//  var personas = new List<Persona>(){
//        new Persona { Nombre = "Eduardo", Edad = 30, FechaIngresoAlaEmpresa = new DateTime(2023,1,2), Soltero = true},
//        new Persona { Nombre = "Nidia", Edad = 19, FechaIngresoAlaEmpresa = new DateTime(2023,1,2), Soltero = true},
//        new Persona { Nombre = "Alejandro", Edad = 19, FechaIngresoAlaEmpresa = new DateTime(2023,1,2), Soltero = false},
//        new Persona { Nombre = "Valentina", Edad = 24, FechaIngresoAlaEmpresa = new DateTime(2023,1,2), Soltero = false},
//        new Persona { Nombre = "Roberto", Edad = 61, FechaIngresoAlaEmpresa = new DateTime(2023,1,2), Soltero = false},
//    };

// var nombres = personas.Select(p=>p.Nombre).ToList();

// var nombresYEdades = personas.Select(p=> new {Nombre =p.Nombre, Edad = p.Edad}).ToList();

// var nombresYedadesDTO = personas.Select(p=> new PersonaDTO {Nombre =p.Nombre, Edad = p.Edad}).ToList();


// var numeros = Enumerable.Range(1,5).ToList()
// ;

// var numerosduplicados = numeros.Select(n=> 2*n).ToList();

// var personasConIndice = personas.Select((p, indice)=> new {Persona =p, Indice = indice}).ToList();

// foreach (var item in personasConIndice)
// {
//     Console.WriteLine($"{item.Indice}) {item.Persona.Nombre}");
// }
//    var a = 3;

// //Sintaxis de Queries

// var nombre_2 = (from p in personas select p.Nombre).ToList();

// var nombreYEdades_2 = from p in personas select new {Nombre = p.Nombre, Edad = p.Edad};

// var numerosDuplicados_2 = from n in numeros select 2*n;


// using LINQ2;
// var personas = new List<Persona>(){
//     new Persona {Nombre = "Eduardo", Soltero = true},
//     new Persona {Nombre = "Nidia", Soltero = true},
//     new Persona {Nombre = "Alejandro", Soltero = true},
//     new Persona {Nombre = "Valentina", Soltero = false}
//     };

// Console.WriteLine($"La cantidad de personas es {personas.Count()}");

// Console.WriteLine($"La cantidad de personas Soltera es {personas.Count(p=>p.Soltero)}");

// //Sintaxis de Queries

// var ConteoSolteros = (from p in personas where p.Soltero select 0).Count();




// using LINQ2;
// var personas = new List<Persona>(){
//     new Persona {Nombre = "Eduardo", Edad=19,},
//     new Persona {Nombre = "Nidia", Edad=25,},
//     new Persona {Nombre = "Alejandro", Edad=30,},
//     new Persona {Nombre = "Valentina", Edad=22,}
//     };


// var numeros = Enumerable.Range(1,5);

// Console.WriteLine($"La suma de los numeros es {numeros.Sum()}");
// Console.WriteLine($"La suma de los numeros es {personas.Sum(x=>x.Edad)}");

// Console.WriteLine($"La suma de los numeros es {personas.Max(x=>x.Edad)}");
// Console.WriteLine($"La suma de los numeros es {personas.Min(x=>x.Edad)}");

// using LINQ2;

// var numeros = Enumerable.Range(1,5);

// var resultados = numeros.Aggregate((a,b)=>a*b);

// Console.WriteLine("Resultado es" + resultados);

// var reusltadoConValorInicial = numeros.Aggregate(10, (a,b)=>a*b);


// Console.WriteLine("El resultado con el valor semilla es " + reusltadoConValorInicial);

// using LINQ2;

// var numeros = Enumerable.Range(1,5);


// var estaElNumero3 = numeros.Contains(3); //verdadero

// var estaElNumero20 = numeros.Contains(20); // falso

// using LINQ2;
// var personas = new List<Persona>(){
//     new Persona {Nombre = "Eduardo", Edad=19, Soltero = true},
//     new Persona {Nombre = "Nidia", Edad=25,Soltero = true},
//     new Persona {Nombre = "Alejandro", Edad=30,Soltero = true},
//     new Persona {Nombre = "Valentina", Edad=22,Soltero = false}
//     };

//     var existeMenor = personas.Any(p=>p.Edad<18 ); //falso

//     var existeMayorDe20 = personas.Any(p=>p.Edad>20); // verdadero

//     var a=2;

// using LINQ2;
// var personas = new List<Persona>(){
//     new Persona {Nombre = "Eduardo", Edad=19, Soltero = true},
//     new Persona {Nombre = "Nidia", Edad=25,Soltero = true},
//     new Persona {Nombre = "Alejandro", Edad=30,Soltero = true},
//     new Persona {Nombre = "Valentina", Edad=22,Soltero = false},
//       new Persona {Nombre = "Roberto", Edad=30,Soltero = true},
//       new Persona {Nombre = "Eugenia", Edad=30,Soltero = true},
//         new Persona {Nombre = "Esmerin", Edad=30,Soltero = true}
//     };

//     var agrupamientoPorSolteria = personas.GroupBy(p=> p.Soltero);
// //sintaxis de queries
// var agrupamientoPorSoltera_2 = from p in personas group p by p.Soltero into grupos select grupos;


//     foreach (var grupo in agrupamientoPorSolteria)
//     {
//         Console.WriteLine($"Grupo de las personas donde Soltero = {grupo.Key} (Total: {grupo.Count()})");
//         foreach(var persona in grupo)
//         {
//             Console.WriteLine($"- {persona.Nombre}");
//         }
//     }


// using System.Data.Common;
// using LINQ2;
// var personas = new List<Persona>(){
//     new Persona {Nombre = "Eduardo", EmpresaId =1},
//     new Persona {Nombre = "Nidia",  EmpresaId =1},
//     new Persona {Nombre = "Alejandro",  EmpresaId =3},
//     new Persona {Nombre = "Valentina",  EmpresaId =2},
//       new Persona {Nombre = "Roberto",  EmpresaId =3},
//       new Persona {Nombre = "Eugenia"},
//         new Persona {Nombre = "Esmerin",  EmpresaId =3}
//     };

// var empresas = new List<Empresa> ()
// {
//     new Empresa{Id = 1, Nombre="Electrodomésticos Felipe"},
//     new Empresa{Id = 2, Nombre ="Bicicletas Valentina"},
//     new Empresa{Id = 3, Nombre="Gimnasio Esmerlin"}

// };

// var personasYEmpresas = personas.Join(empresas, p=> p.EmpresaId, e=> e.Id, (persona, empresa) => new
// {
//     Persona = persona,
//     Empresa = empresa
// });

// //Sintaxis de queries
// var personasYEmpresas_2 = from p in personas join e in empresas on p.EmpresaId equals e.Id select new{
//     Persona = p,
//     Empresa = e
// };

// foreach (var item in personasYEmpresas)
// {
//     Console.WriteLine($"{item.Persona.Nombre}trabaja en {item.Empresa.Nombre}");
// }

// using System.Data.Common;
// using LINQ2;
// var personas = new List<Persona>(){
//     new Persona {Nombre = "Eduardo", EmpresaId =1},
//     new Persona {Nombre = "Nidia",  EmpresaId =1},
//     new Persona {Nombre = "Alejandro",  EmpresaId =3},
//     new Persona {Nombre = "Valentina",  EmpresaId =2},
//       new Persona {Nombre = "Roberto",  EmpresaId =3},
//       new Persona {Nombre = "Eugenia"},
//         new Persona {Nombre = "Esmerin",  EmpresaId =3}
//     };

// var empresas = new List<Empresa> ()
// {
//     new Empresa{Id = 1, Nombre="Electrodomésticos Felipe"},
//     new Empresa{Id = 2, Nombre ="Bicicletas Valentina"},
//     new Empresa{Id = 3, Nombre="Gimnasio Esmerlin"},
//         new Empresa{Id = 4, Nombre="Ferreteria Lorenzo"}
// };

// var empresasYSusEmpleados = empresas.GroupJoin(personas, e=> e.Id, p=> p.EmpresaId,
// (empresa, personas) => new {Empresa = empresa, Personas = personas});

// //sintaxis de queries
// var empresasYSusEmpleados_2 = from empresa in personas join persona in personas on empresa.EmpresaId equals persona.EmpresaId into personas2 select new{
//     Empresa = empresa,
//     Personas = personas2
// };


// foreach(var item in empresasYSusEmpleados)
// {
// Console.WriteLine($"las siguientes personas trabajan en {item.Empresa.Nombre}");
// foreach(var persona in item.Personas)
// {
// Console.WriteLine($"- {persona.Nombre}");
// }
// }

// using System.Data.Common;
// using LINQ2;
// var personas = new List<Persona>(){
//     new Persona {Nombre = "Eduardo", EmpresaId =1},
//     new Persona {Nombre = "Nidia",  EmpresaId =1},
//     new Persona {Nombre = "Eduardo",  EmpresaId =3},
//     new Persona {Nombre = "Esmerlin",  EmpresaId =2}
//     };

//     int[] numeros = {1, 2, 3, 1, 1, 6};
    // var numerosSinRepeticiones = numeros.Distinct();

    // var PersonasSinNombresRepetidos = personas.DistinctBy(x=>x.Nombre);

    // //sintaxis de queries
    // var numerosSinRepeticiones_2 = from n in numeros.Distinct()
    // select n;

    // var PersonasSinNombresRepetidos_2 = from p in personas.DistinctBy(x => x.Nombre)
    // select p;

//     using System.Data.Common;
// using LINQ2;
// var personasA = new List<Persona>(){
//     new Persona {Nombre = "Eduardo", EmpresaId =1},
//     new Persona {Nombre = "Nidia",  EmpresaId =1},
//     new Persona {Nombre = "Esmerlin",  EmpresaId =3},
//     };
//     var personasB = new List<Persona>()
//     {
//            new Persona {Nombre = "Eduardo", Edad =25},
//              new Persona {Nombre = "Eduardo", EmpresaId =1,},
//     };

//     int[] numerosA = {1, 2, 3, 1, 1, 6};

//     int[] numerosB = {1, 2,15};

//     var unionNumeros = numerosA.Union(numerosB);

//     var unionPersonas = personasA.UnionBy(personasB, p=> p.Nombre);


int[] A = {1, 2, 3};
int[] B = {4, 5, 6};

var resultado = A.Concat(B);
