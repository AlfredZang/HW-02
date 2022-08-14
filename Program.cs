// See https://aka.ms/new-console-template for more information
Console.Write("Введите число для проверки: ");
var s1 = Console.ReadLine();

//byte
if (byte.TryParse(s1, out byte byte1))
    Console.WriteLine($"Введенное число конвертируется в byte.");
else
    Console.WriteLine($"Введенное число {s1} не конвертируется в byte. Оно должно быть больше {byte.MinValue} и меньше {byte.MaxValue}.");

//sbyte
if (sbyte.TryParse(s1, out sbyte sbyte1))
    Console.WriteLine($"Введенное число конвертируется в sbyte.");
else
    Console.WriteLine($"Введенное число {s1} не конвертируется в sbyte. Оно должно быть больше {sbyte.MinValue} и меньше {sbyte.MaxValue}.");

//short
if (short.TryParse(s1, out short short1))
    Console.WriteLine($"Введенное число конвертируется в short.");
else
    Console.WriteLine($"Введенное число {s1} не конвертируется в short. Оно должно быть больше {short.MinValue} и меньше {short.MaxValue}.");

//int
if (int.TryParse(s1, out int int1))
    Console.WriteLine($"Введенное число конвертируется в int.");
else
    Console.WriteLine($"Введенное число {s1} не конвертируется в int. Оно должно быть больше {int.MinValue} и меньше {int.MaxValue}.");

//long
if (long.TryParse(s1, out long long1))
    Console.WriteLine($"Введенное число конвертируется в long.");
else
    Console.WriteLine($"Введенное число {s1} не конвертируется в long. Оно должно быть больше {long.MinValue} и меньше {long.MaxValue}.");

//ushort
if (ushort.TryParse(s1, out ushort ushort1))
    Console.WriteLine($"Введенное число конвертируется в ushort.");
else
    Console.WriteLine($"Введенное число {s1} не конвертируется в ushort. Оно должно быть больше {ushort.MinValue} и меньше {ushort.MaxValue}.");

//uint
if (uint.TryParse(s1, out uint uint1))
    Console.WriteLine($"Введенное число конвертируется в uint.");
else
    Console.WriteLine($"Введенное число {s1} не конвертируется в uint. Оно должно быть больше {uint.MinValue} и меньше {uint.MaxValue}.");

//ulong
if (ulong.TryParse(s1, out ulong ulong1))
    Console.WriteLine($"Введенное число конвертируется в ulong.");
else
    Console.WriteLine($"Введенное число {s1} не конвертируется в ulong. Оно должно быть больше{ulong.MinValue} и меньше {ulong.MaxValue}.");