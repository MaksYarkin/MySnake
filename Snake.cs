using System.Collections.Generic;
using System.Numerics;

namespace MySnake
{
    public class Snake
    {
        public Vector2 Direction; //Direction of a snake
        private Vector2 _startPosition;
        private List<Vector2> _snakeCoordinates = new(); 

        //Increases size of a snake
        public void IncreaseSize()
        {
            Vector2 currentLocation = GetPoint(GetSize()-1);
            _snakeCoordinates.Add(currentLocation);
        }

        //Returns snake size
        public int GetSize()
        {
            return _snakeCoordinates.Count;
        }

        
        // returns coordinates of a certain part of a snake. 
        public Vector2 GetPoint(int index)
        {
            return _snakeCoordinates[index];
        }

        //Snake constructor
        public Snake(Vector2 direction, Vector2 startPosition)
        {
            _snakeCoordinates.Add(startPosition);
            Direction = direction;
        }

        //Changes direction left
        public void SetMoveDirectionToLeft()
        {
            Vector2 toLeft = new Vector2(-1, 0);
            Direction = toLeft;
        }

        //Changes direction right
        public void SetMoveDirectionToRight()
        {
            Vector2 toRight = new Vector2(1, 0);
            Direction = toRight;
        }

        //Changes direction up
        public void SetMoveDirectionToUp()
        {
            Vector2 toUp = new Vector2(0, -1);
            Direction = toUp;
        }

        //Changes direction down
        public void SetMoveDirectionToDown()
        {
            Vector2 toDown = new Vector2(0, 1);
            Direction = toDown;
        }

        //Moves snake forward.
        public void MoveForward()
        {
            if (GetSize()-2 == 0)
            {
                _snakeCoordinates[GetSize() - 1] = _snakeCoordinates[0];
                _snakeCoordinates[0] = _snakeCoordinates[0] + Direction;
            }
            else
            {
                for (int i = GetSize() - 1; i >= 1; i--)
                {
                    _snakeCoordinates[i] = _snakeCoordinates[i-1];
                }
                _snakeCoordinates[0] = _snakeCoordinates[0] + Direction;
            }
        }
    }
}