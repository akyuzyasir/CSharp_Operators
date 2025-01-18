
#region Limitations

// Arrays have some limitations: When we create an array, we must specify the size of the array.
#endregion

#region Creating an Array

int[] ages = new int[25];

string[] names = new string[13];
#endregion

#region Assigning Value

ages[5] = 18;
ages[ages.Length - 1] = 99;
#endregion

#region Read Value
Console.WriteLine(ages[5]);
#endregion

#region Navigate through the Array
// we can navigate through the array using a loop

for(int i = 0; i < ages.Length; i++)
{
    ages[i] = i * 10;
    Console.WriteLine(ages[i]);
}

#endregion

#region Array Create Variations

int[] x = new int[] {13, 53, 23, 43, 63, 73, 83, 93, 103, 113 };

int[] y = { 13, 53, 23, 43, 63, 73, 83, 93, 103, 113 };

int[] z = new int[10] { 13, 53, 23, 43, 63, 73, 83, 93, 103, 113 };

int[] w = new int[10];
w = new int[] { 13, 53, 23, 43, 63, 73, 83, 93, 103, 113 };

#endregion