//  The starting array.
int[] inputArray = [1, 2, 3, 4, 5, 6, 7, 8, 9];

//  Randomize the array.
var randomizedArray = RandomizeArray(inputArray);

for(int i=0;i < inputArray.Length;i++){
    Console.WriteLine($"{inputArray[i]}\t-\t{randomizedArray[i]}");
}

int[] RandomizeArray(int[] array){
    // Write the code to randomize the order of the input array and return it.
    var inputList = new List<int>(array);
    var randomizedList = new List<int>();
    // Extra Credit - Optimizatio.  Why?
    // var randomizedList = new List<int>(inputList.Count());

    var randomIndexGenerator = new Random();
    while (inputList.Count() > 0){
        var randomIndex = randomIndexGenerator.Next(0, (inputList.Count() -1));
        var value = inputList[randomIndex];

        randomizedList.Add(value);
        inputList.RemoveAt(randomIndex);
    }
    
    return randomizedList.ToArray();
}
