using System;

namespace BinaryTreeUniversity
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Position rectorPosition = new Position();
            rectorPosition.Name = "rector";
            rectorPosition.Salary = 1000;
            rectorPosition.Porsentaje = 0.10f ;
            rectorPosition.NNodo = 1;
            rectorPosition.total = 100;

            Position vicFinPosition = new Position();
            vicFinPosition.Name = "Vicerector finaciero";
            vicFinPosition.Salary = 750;
            vicFinPosition.Porsentaje = 0.05f;
            vicFinPosition.NNodo = 1;
            vicFinPosition.total = 37.5f;


            Position contadorPosition = new Position();
            contadorPosition.Name = "contador";
            contadorPosition.Salary = 500;
            contadorPosition.Porsentaje = 0.15f;
            contadorPosition.NNodo = 1;
            contadorPosition.total = 75;
            

            Position jefeFinPosition = new Position();
            jefeFinPosition.Name = "jefe Financiero";
            jefeFinPosition.Salary = 610;
            jefeFinPosition.Porsentaje = 0.20f;
            jefeFinPosition.NNodo = 1;
            jefeFinPosition.total = 122;
            

         Position secreFin1Position = new Position();
            secreFin1Position.Name = "secretaria finaciera 1";
            secreFin1Position.Salary = 350;
            secreFin1Position.Porsentaje = 0.07f;
            secreFin1Position.NNodo = 1;
            secreFin1Position.total = 24.5f;


            Position secreFin2Position = new Position();
            secreFin2Position.Name = "secretaria finaciera 2";
            secreFin2Position.Salary = 310;
            secreFin2Position.Porsentaje = 0.07f;
            secreFin2Position.NNodo = 1;
            secreFin2Position.total = 21.7f;
            


            Position vicAcadPosition = new Position();
            vicAcadPosition.Name = "Vicerector Academico";
            vicAcadPosition.Salary = 780;
            vicAcadPosition.Porsentaje = 0.25f;
            vicAcadPosition.NNodo = 1;
            vicAcadPosition.total = 195;

            Position jefeRegPosition = new Position();
            jefeRegPosition.Name = "Jefe de Registro";
            jefeRegPosition.Salary = 640;
            jefeRegPosition.Porsentaje = 0.16f;
            jefeRegPosition.NNodo = 1;
            jefeRegPosition.total = 102.3f;

            Position secreReg1Position = new Position();
            secreReg1Position.Name = "Secretaria de Registro 1";
            secreReg1Position.Salary = 400;
            secreReg1Position.Porsentaje = 0.08f;
            secreReg1Position.NNodo = 1;
            secreReg1Position.total = 32;

          Position asist1Position = new Position();
            asist1Position.Name = "Asistente 1 ";
            asist1Position.Salary = 250;
            asist1Position.Porsentaje = 0.09f;
            asist1Position.NNodo = 1;
            asist1Position.total = 22.5f;


            Position asist2Position = new Position();
            asist2Position.Name = "Asistente 2 ";
            asist2Position.Salary = 170;
            asist2Position.Porsentaje = 0.06f;
            asist2Position.NNodo = 1;
            asist2Position.total = 10.2f;

            Position mensajPosition = new Position();
            mensajPosition.Name = "Mensajero ";
            mensajPosition.Salary = 90;
            mensajPosition.Porsentaje = 0.02f;
            mensajPosition.NNodo = 1;
            mensajPosition.total = 1.8f;

            Position secreReg2Position = new Position();
            secreReg2Position.Name = "Secretaria de Registro 2";
            secreReg2Position.Salary = 360;
            secreReg2Position.Porsentaje = 0.03f;
            secreReg2Position.NNodo = 1;
            secreReg2Position.total = 10.8f;

            UniversityTree universityTree = new UniversityTree();
            universityTree.CreatePosition(null,rectorPosition,null);
            universityTree.CreatePosition(universityTree.Root, vicFinPosition, rectorPosition.Name);
            universityTree.CreatePosition(universityTree.Root, contadorPosition, vicFinPosition.Name);
            universityTree.CreatePosition(universityTree.Root, secreFin1Position, contadorPosition.Name);
            universityTree.CreatePosition(universityTree.Root, secreFin2Position, contadorPosition.Name);
            universityTree.CreatePosition(universityTree.Root, jefeFinPosition, vicFinPosition.Name);
            universityTree.CreatePosition(universityTree.Root, vicAcadPosition, rectorPosition.Name);
            universityTree.CreatePosition(universityTree.Root, jefeRegPosition, vicAcadPosition.Name);
            universityTree.CreatePosition(universityTree.Root, secreReg1Position, jefeRegPosition.Name);
          
            universityTree.CreatePosition(universityTree.Root, asist1Position, secreReg1Position.Name);
            universityTree.CreatePosition(universityTree.Root, asist2Position, secreReg1Position.Name);
            universityTree.CreatePosition(universityTree.Root, mensajPosition, asist2Position.Name);
            universityTree.CreatePosition(universityTree.Root, secreReg2Position, jefeRegPosition.Name);

            vicFinciero vicFinciero = new vicFinciero();
            vicFinciero.CreatePosition(null, vicFinPosition,null);
            universityTree.CreatePosition(vicFinciero.Root, contadorPosition, vicFinPosition.Name);
            universityTree.CreatePosition(vicFinciero.Root, jefeFinPosition, vicFinPosition.Name);

            universityTree.printTree(vicFinciero.Root);

            float totalSalary2 = universityTree.Addsalaries(vicFinciero.Root);
            Console.WriteLine($"total de salarios:{totalSalary2} ");

            Console.WriteLine("----------------------------------------------------------------");

            universityTree.printTree(universityTree.Root);

            float totalSalary = universityTree.Addsalaries(universityTree.Root);
            Console.WriteLine($"total de salarios:{totalSalary} ");

            Console.WriteLine("----------------------------------------------------------------");

            

            float calculoNodo = universityTree.CalcNnodo(universityTree.Root);
            Console.WriteLine($"cantidad de nodo :{ calculoNodo} ");
            Console.ReadLine();

            Console.WriteLine("----------------------------------------------------------------");

            

            float PromedioSalario = totalSalary/ calculoNodo;
            Console.WriteLine($"El promedio del salario es :{ PromedioSalario} ");

            Console.WriteLine("----------------------------------------------------------------");



            float totalpromedio = universityTree.Addpromedios(universityTree.Root);
            Console.WriteLine($"El total de los impuestos recaudados es :{totalpromedio} ");
            






        }
    }
}
