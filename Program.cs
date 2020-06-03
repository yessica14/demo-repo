using System;
using System.Collections;
using System.Collections.Generic;
using firstApp.models;
using System.Text;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
namespace firstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Persona>lista =new List<Persona>();

           lista.Add(new Profesor(){id=1,
           nombre="yessica gimenez",
           edad=30,
           tel=153288081,
           legajo=31143
           });
           lista.Add(new Profesor(){
           id=2,
           nombre="juan Arce",
           edad=33,
           tel=153288083,
           legajo=31144   
           });
           lista.Add(new Profesor(){
           id=3,
           nombre="david gimenez",
           edad=25,
           tel=15478222,
           legajo=35443
           });
           lista.Add(new Profesor(){
           id=4,
           nombre="sergio gimenez",
           edad=30,
           tel=153288081,
           legajo=31143
           });
           lista.Add(new Profesor(){
           id=5,
           nombre="jose arce",
           edad=29,
           tel=153288081,
           legajo=34578
           });
           lista.Add(new Profesor(){
           id=6,
           nombre="Omar bruno gimenez",
           edad=30,
           tel=153288081,
           legajo=34579
           });
           //esto es linq que es como hacer una consulta a la db, como una consulta sql, y el operador para negar es el "!"
           //var consulta= from profe in lista where profe.edad==30 && ! profe.nombre.StartsWith("j") select profe.id;
           //tambien puede hacer un nuevo profesor
            var consulta= from profe in lista where profe.edad==30 || ! profe.nombre.StartsWith("j")
            select new { 
                   idprofesor=profe.id, 
                   nombreProfesor=profe.nombre.ToUpper()
                   };

           foreach(var profe in consulta){
             Console.WriteLine($"idprofesor={profe.idprofesor}-nombreProfesor={profe.nombreProfesor}"
             );
           }
           //para comentar varias lineas en el teclado es ctrl+k+c
        //    foreach(var profe in consulta){
        //        Console.WriteLine(profe.nombre);
        //    }
           
         



          Console.ReadLine();
        }
        private void rutina8(){
             var listaProfesor=new List<Persona>();
          
          string[] lineas =File.ReadAllLines("./file/profesores.txt");
         
         
          foreach(var linea in lineas){
              listaProfesor.Add(new Profesor(){
                  nombre=linea
              });
          }
              
            foreach(var profe in listaProfesor){
                Console.WriteLine(profe.nombre);
            }
            var archivo= File.Open("profesBinarios.bin",FileMode.OpenOrCreate);
            var binFile=new BinaryWriter(archivo);
            foreach(var profe in listaProfesor){
                //var bytesNombre= Encoding.UTF8.GetBytes(profe.nombre);
               // archivo.Write(bytesNombre,0,bytesNombre.Length);
                binFile.Write(profe.nombre);
            }
            binFile.Close();
            archivo.Close();
          
        }
        private void rutina6(){
         List<Persona>listaPersona=new List<Persona>();

         listaPersona.Add(new Alumno(){
             id=0,
             nombre="yessica",
             edad=20,
             tel=1548798,
             email="jessica2@gmail.com"
         });

         

       
         listaPersona.Add(new Profesor(){
             id=1,
             nombre="sergio",
             edad=26,
             tel=15487981,
             legajo=23154
         });
          listaPersona.Add(new Profesor(){
             id=2,
             nombre="david",
             edad=25,
             tel=15487981,
             legajo=23155
         });
          listaPersona.Add(new Alumno(){
             id=3,
             nombre="omar",
             edad=1,
             tel=15487981,
             email="omar2@gmail.com"
         });
          listaPersona.Add(new Alumno(){
             id=4,
             nombre="cuchi",
             edad=2,
       
             email="corazon2@gmail.com"
         });
         foreach(var obj in listaPersona){
              if(obj is Alumno){
                var al=(Alumno)obj;
                Console.WriteLine(al.email);
            } else{
                var pro=(Profesor)obj;
                Console.WriteLine(pro.legajo);
            }
         }
        }
        private void Rutina5(){
              ArrayList listaPersona=new ArrayList();

         listaPersona.Add(new Alumno(){
             id=0,
             nombre="yessica",
             edad=20,
             tel=1548798,
             email="jessica2@gmail.com"
         });

         

        listaPersona.Add(new Alumno(){
             id=0,
             nombre="yessica",
             edad=20,
             tel=1548798,
             email="jessica2@gmail.com"
         });
         listaPersona.Add(new Profesor(){
             id=1,
             nombre="sergio",
             edad=26,
             tel=15487981,
             legajo=23154
         });
          listaPersona.Add(new Profesor(){
             id=2,
             nombre="david",
             edad=25,
             tel=15487981,
             legajo=23154
         });
          listaPersona.Add(new Alumno(){
             id=3,
             nombre="omar",
             edad=1,
             tel=15487981,
             email="omar2@gmail.com"
         });
          listaPersona.Add(new Alumno(){
             id=0,
             nombre="cuchi",
             edad=2,
       
             email="corazon2@gmail.com"
         });
         for (int i = 0; i < listaPersona.Count; i++)
         {
            if(listaPersona[i] is Alumno){
                var al=(Alumno)listaPersona[i];
                Console.WriteLine(al.email);
            } else{
                var pro=(Profesor)listaPersona[i];
                Console.WriteLine(pro.legajo);
            }
         } 
        }

        private void Rutina4(){
             Persona[] arregloPersona=new Persona[5];

         arregloPersona[0]=new Alumno(){
             id=0,
             nombre="yessica",
             edad=20,
             tel=1548798,
             email="jessica2@gmail.com"
         };
         arregloPersona[1]=new Profesor(){
             id=1,
             nombre="sergio",
             edad=26,
             tel=15487981,
             legajo=23154
         };
          arregloPersona[2]=new Profesor(){
             id=2,
             nombre="david",
             edad=25,
             tel=15487981,
             legajo=23154
         };
          arregloPersona[3]=new Alumno(){
             id=3,
             nombre="omar",
             edad=1,
             tel=15487981,
             email="omar2@gmail.com"
         };
          arregloPersona[4]=new Alumno(){
             id=0,
             nombre="cuchi",
             edad=2,
       
             email="corazon2@gmail.com"
         };
         for (int i = 0; i < arregloPersona.Length; i++)
         {
            if(arregloPersona[i] is Alumno){
                var al=(Alumno)arregloPersona[i];
                Console.WriteLine(al.email);
            } else{
                var pro=(Profesor)arregloPersona[i];
                Console.WriteLine(pro.legajo);
            }
         }


        
        }
       
        private static void Rutina3(){
          var alumno=new Alumno();
          var profesor=new Profesor();
          Persona persona=profesor;
          
          //metodo de casteo
          alumno=(Alumno)persona;


          var tmpProfe=persona as Profesor;
          Console.WriteLine(tmpProfe);
        }

        public void Rutina1(){
            Persona[] lista=new Persona[3];
            
            lista[0]= new Alumno(){
                id=1,
                nombre="yessica gimenez",
                edad=29,
                tel=1568562,
                email="jessica.1@gmail.com"

            };
            lista[1]=new Profesor(){
              id=1,
              nombre="Ibarra daniel",
              edad=29,
              tel=1568562,
              legajo=31143
            };
             lista[2] = new Alumno(){
                id=1,
                nombre="monica vazquez",
                edad=29,
                tel=1568562,
                email="jessica.1@gmail.com"

            };
            
            foreach (Persona p in lista)
            {
                Console.WriteLine(p.nombre);
                Instituto ente=p;
                
                
                var r = ente.construirLlavesecreta("HOLA");
                Console.WriteLine(r);

             
                
            }
             Console.WriteLine(Persona.contadorPersona);
             Console.WriteLine("E N U M E R A C I O N E S");


             var alu=new Alumno(){
                  id=4,
                nombre="david gimenez",
                edad=26,
                tel=156856122,
                email="wal.gimenez14@gmail.com"
                

             };
             Console.WriteLine("estado del alumno ");
             Console.WriteLine($"Tipo:{typeof(Alumno)}");
             Console.WriteLine($"Tipo:{sizeof(int)}");

            
            
            Console.ReadLine();
            
        }
    }
}
