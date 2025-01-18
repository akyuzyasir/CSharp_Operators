

int[] numbers = new int[5] {3,1,7,82,4 };
#region Array Properties

// IsFixedSize: Gets a value indicating whether the Array has a fixed size.
// IsReadOnly: Gets a value indicating whether the Array is read-only.
// Length: Gets a 32-bit integer that represents the total number of elements in all the dimensions of the Array.
// Rank: Gets the rank (number of dimensions) of the Array.
#endregion

#region Array Methods

// Clear: Sets a range of elements in the Array to zero, to false, or to null, depending on the element type.
Array.Clear(numbers, 0, numbers.Length);

// Copy: Copies a range of elements from an Array starting at the first element and pastes them into another Array starting at the first element. The length is specified as a 32-bit integer.
int[] copy = new int[5];

Array.Copy(numbers, copy, numbers.Length);

// IndexOf: Searches for the specified object and returns the index of its first occurrence in a one-dimensional array.

int index = Array.IndexOf(numbers, 7); // returns 2

// Reverse: Reverses the sequence of the elements in the entire one-dimensional Array.

Array.Reverse(numbers); // numbers = {4, 82, 7, 1, 3}

// Sort: Sorts the elements in an entire one-dimensional Array using the IComparable implementation of each element of the Array.

Array.Sort(numbers); // numbers = {1, 3, 4, 7 , 82}
#endregion