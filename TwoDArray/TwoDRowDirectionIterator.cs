//
// ICT2106 Software Design - 2D array example
//
// Concrete row-major iterator for two-dimensional arrays.
//
// Author: Nicholas Sheppard
//
namespace TwoDArray
{
    class TwoDRowDirectionIterator<T> : ITwoDIterator<T>
    {
        // the collection being iterated through
        TwoDArrayGeneric<T> collection;

        // counters
        private int i, j;

        // constructor
        public TwoDRowDirectionIterator(TwoDArrayGeneric<T> collectionIn)
        {
            collection = collectionIn;
            i = 0;
            j = 0;
        }

        // get the current element of the iteration
        public T Current()
        {
            return collection.Get(i, j);
        }

        // move to the next element of the iteration
        public void Next()
        {
            if (i % 2 == 0) {
              j++;
              if (j >= collection.Columns())
              {
                  i++;
              }
            }
            else if (i % 2 != 0) {
              j--;
              if (j == 0)
              {
                  i++;
              }
            }

            // skip nulls
            if (!IsDone() && collection.Get(i, j) == null) {
              Next();
            }
        }

        // test whether or not the iteration has finished
        public bool IsDone()
        {
            return i >= collection.Rows();
        }
    }
}
