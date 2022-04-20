/*
void PrintJaggedArray(string[][] elementsPrintJaggedArray, int sizeFiltrElements)
{
    for (int i = 0; i < elementsPrintJaggedArray.Length; i++)
    {
        int counterFiltrElements = 0;
        
        Console.Write("[");

        for (int j = 0; j < elementsPrintJaggedArray[i].Length; j++)
        {
            if (elementsPrintJaggedArray[i][j].Length <= sizeFiltrElements)
            {
                counterFiltrElements++;

                if (elementsPrintJaggedArray[i].Length == 1 || counterFiltrElements == 1) Console.Write($"\"{elementsPrintJaggedArray[i][j]}\"");
                else if (j == elementsPrintJaggedArray[i].Length - 1) Console.Write($",\"{elementsPrintJaggedArray[i][j]}\"");
                     else Console.Write($",\"{elementsPrintJaggedArray[i][j]}\"");
            }
        }
        Console.Write("]");
        Console.WriteLine();
    }
}

int sizeRowsArray = 3;
int sizeFiltrElementsArray = 3;

string[][] elementsJaggedArray = new string[sizeRowsArray][];

elementsJaggedArray[0] = new string[] { "hello", "2", "world", ":-)" };
elementsJaggedArray[1] = new string[] { "1234", "1567", "-2", "computer science" };
elementsJaggedArray[2] = new string[] { "Russia", "Denmark", "Kazan" };

PrintJaggedArray(elementsJaggedArray, sizeFiltrElementsArray);
*/