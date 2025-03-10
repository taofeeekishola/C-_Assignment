namespace Inheritance
{
    class Stack
    {
        private List<object> elements = new List<object>(); 
        public void Push(object obj)
        { 
            if (obj  == null) // exception for null cases
            {
                throw new InvalidOperationException("Null value not allowed");
            }

            elements.Add(obj);
        }


        public object Pop()
        { 
            if (elements.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty, Pop operation not valid");
            }

            int lastIndex = elements.Count - 1; // retrieves the last element index
            object topElement = elements[lastIndex]; // retrieves the last element
            elements.RemoveAt(lastIndex); // Remove last element from the stack
            return topElement; // return the poped element
        }


        public void Clear()
        {
            elements.Clear(); // remove all elemnts from the stack
        }
    }
}