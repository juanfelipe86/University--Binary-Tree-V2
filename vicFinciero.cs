using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTreeUniversity
{
    class vicFinciero
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
        public float Addsalaries2(PositionNode from)
        {
            if (from == null)
            {
                return 0;
            }

            return from.Position.Salary + Addsalaries2(from.Left);


        }


    }
}




