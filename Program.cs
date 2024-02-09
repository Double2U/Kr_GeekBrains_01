Console.WriteLine("Введите длину массива: ");
int lengthArrayString = int.Parse(Console.ReadLine());
string[] arrayString = new string[lengthArrayString];

for (int i = 0; i < lengthArrayString; i++){
    Console.WriteLine($"Введите строку {i + 1}: ");
    arrayString[i] = Console.ReadLine();
}


int count = 0;
int maxLengthString = 3;

for (int i = 0; i < lengthArrayString; i++){
    if (arrayString[i].Length <= maxLengthString){
        count++;
    }
}

int j = 0;
string[] newArrayString = new string[count];

while(j < count) {
    for (int i = 0; i < lengthArrayString; i++) {
        if (arrayString[i].Length <= maxLengthString){
            newArrayString[j] = arrayString[i];
            j++;
        }
    }
}

Console.WriteLine("Результат: ");
for (int i = 0; i < newArrayString.Length; i ++){
Console.Write($"{newArrayString[i]} ");
}
