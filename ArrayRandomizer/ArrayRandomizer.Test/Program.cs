//  The starting array.
int[] inputArray = [1, 2, 3, 4, 5, 6, 7, 8, 9];

//  Randomize the array.
var randomizedArray = RandomizeArray(inputArray);

for(int i=0;i < inputArray.Length;i++){
    Console.WriteLine($"{inputArray[i]}\t-\t{randomizedArray[i]}");
}

int[] RandomizeArray(int[] array){
    // Write the code to randomize the order of the input array and return it.
    var randomizedArray = array;

    return randomizedArray;
}
