//Sintaxis básica 
using System; // Librería básica para entrada / salida..puede usar las herramientas del sist

class Persona{
     //variables publicas que se contienen en cada class
     public int edad; // Numeros enteros
     public string nombre; // Texto o palabras
     public bool estudiante;// Verdadero Falso
     public double altura; //Numeros decimales
     public char letra; //Un solo caracter
     
     //activa el SALUDO
     public void Saludo(){
          
          Console.WriteLine("Hola, mi nombre es " + nombre + " y tengo " + edad + " años " );
 
     }
     
}

 //Clase principal
class Programa{
      public static string nombreGlobal = "Vanna";
      public static int edadGlobal = 17;
      public static bool estudiante = true;
      public static double altura = 1.54;
      
      
      //Metodo principal
     public static void Main(string[] args){
          Persona alumno = new Persona();
          alumno.nombre = "Vanna";
          alumno.edad = 17;
          alumno.Saludo();
          
          Persona profesor = new Persona();
          profesor.nombre = "Mariana";
          profesor.edad = 43;
          profesor.Saludo();
          
          Console.WriteLine();
          Console.WriteLine("Fin del programa");
     
     }
      
      
}




// define una class, como una caja
//class MensajeAVanna {

  //static void Main() {//Punto de inicio del programa. Donde empieza
  
    //Console.WriteLine("Hello World"); //acción : Imprime en consola
    
  //}
  
//}

