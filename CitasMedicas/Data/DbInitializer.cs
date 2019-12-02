using CitasMedicas.Models;
using System;
using System.Linq;
 
namespace CitasMedicas.Data
{
    public class DbInitializer
    {
        public static void Initializate(CitasContext context){
            context.Database.EnsureCreated();

            if(context.Pacientes.Any()){
                return; //la base de dats ya tiene datos 
            }

            // en caso de usar fechas usar,,,, FilmRelaseDate=DateTime.Parse("1/1/2018")
    //Paciente
            var Paciente = new Paciente[]{
                    new Paciente{ ID=1,Nombres="Juan Jose",Apellidos="Serrano Trujillo",Dirección="Mex,Gdl,juerez 123",Numero=491234312,Edad=29},
                    new Paciente{ ID=2,Nombres="Daniel",Apellidos="Allende Tauma",Dirección="Mex,Slp,Diaz 120",Numero=491245312,Edad=20},
                    new Paciente{ ID=3,Nombres="Franco",Apellidos="Ibarra Lopez",Dirección="Mex,Zac,Ordaz 12",Numero=491233312,Edad=17}
            };
            foreach(Paciente q in Paciente){context.Pacientes.Add(q);}
            context.SaveChanges();
    //Doctor
            var Doctor = new Doctor[]{
                    new Doctor{ ID=1,Nombres="Mario",Apellidos="Muro Barraza",Cedula="Wdw4332FFWs",Dirección="Mex,Zac,orito 4",Numero=491234453,Turno="Matutino",Disponibilidad="Completa"},
                    new Doctor{ ID=2,Nombres="Jaime",Apellidos="Carillo Ovalos",Cedula="Wdw423FEFWs",Dirección="Mex,Zac,guadalupe 65",Numero=491234453,Turno="Matutino",Disponibilidad="Completa"},
                    new Doctor{ ID=3,Nombres="Alfonzo",Apellidos="Sólis Gutierrez",Cedula="FFESC2132FEs",Dirección="Mex,CDMX,Reforma 67",Numero=591541153,Turno="Vespertino",Disponibilidad="Vacaciones"}
            };
            foreach(Doctor q in Doctor){context.Doctors.Add(q);}
            context.SaveChanges();
    //REcepcionista
            var Recepcionista = new Recepcionista[]{
                    new Recepcionista{ID=1,Nombres="Natalia",Apellidos="Sauce guñon",Dirección="Mex,Ags,flor 5",Numero=491234312},
                    new Recepcionista{ID=2,Nombres="Hernesto",Apellidos="Rivera Rayuela",Dirección="Mex,Ags,liberación 6",Numero=491233412},
                    new Recepcionista{ID=3,Nombres="Ramiro",Apellidos="Pascual Ortiz",Dirección="Mex,Ags,paseo 10",Numero=491236542}
            };
            foreach(Recepcionista q in Recepcionista){context.Recepcionistas.Add(q);}
            context.SaveChanges();
    //Registro
            var Registro = new Registro[]{
                    new Registro{ RegistrosID=1,DoctorID=1,RecepcionistaID=1,Fecha=DateTime.Parse("1/1/2018"),Detalles="Ninguno"},
                    new Registro{ RegistrosID=2,DoctorID=2,RecepcionistaID=2,Fecha=DateTime.Parse("2/2/2018"),Detalles="Retraco en la cita"},
                    new Registro{ RegistrosID=3,DoctorID=3,RecepcionistaID=3,Fecha=DateTime.Parse("3/3/2018"),Detalles="paciente discapacitado"}

            };
            foreach(Registro q in Registro){context.Registros.Add(q);}
            context.SaveChanges();
    //Receta
            var Receta = new Receta[]{
                    new Receta{ID=12,Fecha=DateTime.Parse("1/1/2018"),Descripcion="Paracetamol 10 mg cada 8 hrs"},
                    new Receta{ID=12,Fecha=DateTime.Parse("2/2/2018"),Descripcion="Cotarzan 20mg cada 8 hrs"},
                    new Receta{ID=12,Fecha=DateTime.Parse("3/3/2018"),Descripcion="Inyeccion 20 mg insulina cada 24 hrs"}

            };
            foreach(Receta q in Receta){context.Recetas.Add(q);}
            context.SaveChanges();
            
        
        }
    }
}