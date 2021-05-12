using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTreeUniversity
{
    class UniversityTree
    {
        public PositionNode Root;

        public void CreatePosition(PositionNode parent, Position positionToCreate, String parentPositionName)
        {
            PositionNode newNode = new PositionNode();
            newNode.Position = positionToCreate;


            if (Root == null)
            {
                Root = newNode;
                return;
            }


            if (parent == null)
            {
                return;
            }


            if (parent.Position.Name == parentPositionName)
            {
                if (parent.Left == null)
                {
                    parent.Left = newNode;
                    return;

                }

                parent.Right = newNode;
                return;
            }

            CreatePosition(parent.Left, positionToCreate, parentPositionName);
            CreatePosition(parent.Right, positionToCreate, parentPositionName);


        }

        public void printTree(PositionNode from)
        {
            if (from == null)
            {
                return;
            }

            Console.WriteLine($"{from.Position.Name} : ${from.Position.Salary}, Porcentaje: ${from.Position.Salary * from.Position.Porsentaje}");

            printTree(from.Left);
            printTree(from.Right);
        }

        public float Addsalaries(PositionNode from)
        {
            if (from == null)
            {
                return 0;
            }

            return from.Position.Salary + Addsalaries(from.Left) + Addsalaries(from.Right);



        }
        public float CalcNnodo(PositionNode from)
        {
            if (from == null)
            {
                return 0;
            }

            return from.Position.NNodo + CalcNnodo(from.Left) + CalcNnodo(from.Right);



        }
        public float Addpromedios(PositionNode from)
        {
            if (from == null)
            {
                return 0;
            }

            return from.Position.total+ Addpromedios(from.Left) + Addpromedios(from.Right);
        }

    }

}














