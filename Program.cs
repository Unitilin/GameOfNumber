namespace NumberGames
{
	class Program
	{
		static void Main(string[] args)
		{
			bool replay = true; //Пока replay=true игра начинается заного
			while (replay)
			{
				Console.Write("Введите никнейм 1 игрока: ");
				string nicknameUser1;
				nicknameUser1 = Console.ReadLine();                 //принимаем имя первого игрока
				Console.Write("Введите никнейм 2 игрока: ");
				string nicknameUser2;
				nicknameUser2 = Console.ReadLine();                 //принимаем имя второго игрока

				Random rand = new Random();
				int gameNumber = rand.Next(100);                    //Устаовка рандомного значения в качестве игрового числа
				Console.WriteLine($"Стартовое значение игрового числа: {gameNumber}");
				while (gameNumber >= 0)                             //Пока игровое число больше 0, игра продолжается
				{
					Console.Write($"Ход игрока {nicknameUser1}. Выполните свой ход, введите число от 1 до 4: ");
					int userTry = int.Parse(Console.ReadLine());    //Ход первого игрока
					if (userTry >= 1 && userTry <= 4)               //Если число хода первого игрока входит в заданный диапазон, игрок ходит
					{
						gameNumber -= userTry;                      //Из игрового числа вычитается число хода первого игрока
						if (gameNumber <= 0)                        //Если игровое число меньше либо равно 0, то первый игрок победил
						{
							Console.WriteLine($"Победил игрок {nicknameUser1}");
						}
						else                                        //Если игровое число больше 0, ходит второй игрок
						{
							Console.Write($"Ход игрока {nicknameUser2}. Выполните свой ход, введите число от 1 до 4: ");
							userTry = int.Parse(Console.ReadLine());//Ход второго игрока
							if (userTry >= 1 && userTry <= 4)       //Если число хода второго игрока не входит в заданный диапазон, ходит первый игрок
							{
								gameNumber -= userTry;              //Из игрового числа вычитается число хода второго игрока

								if (gameNumber <= 0)                //Если игровое число меньше либо равно 0, то второй игрок победил
								{
									Console.WriteLine($"Победил игрок {nicknameUser2}");

								}
								else
								{
									Console.WriteLine($"Новое значение игрового числа: {gameNumber}"); //Обновление значения игрового числа после каждого цикла ходов
									continue;
								}
							}
							else
							{
								Console.WriteLine("Вы ввели не верное число, ход переходит сопернику.");
								continue;
							}
						}
					}
					else                                            //Если число хода первого игрока не входит в заданный диапазон, ходит второй игрок
					{
						Console.WriteLine("Вы ввели не верное число, ход переходит сопернику.");

						Console.Write($"Ход игрока {nicknameUser2}. Выполните свой ход, введите число от 1 до 4: "); //Дубль цикла хода второго игрока, начало
						userTry = int.Parse(Console.ReadLine());
						if (userTry >= 1 && userTry <= 4)
						{
							gameNumber -= userTry;

							if (gameNumber <= 0)
							{
								Console.WriteLine($"Победил игрок {nicknameUser2}");

							}
							else
							{
								Console.WriteLine($"Новое значение игрового числа: {gameNumber}");
								continue;
							}
						}
						else
						{
							Console.WriteLine("Вы ввели не верное число, ход переходит сопернику.");
							continue;
						}

					}
				}
				Console.WriteLine("Сыграем еще раз? (да/нет)");
				string _replay = Console.ReadLine();
				if (_replay == "да" ||  _replay == "Да")
				{
					replay = true;
				}
				else
				{
					replay = false;
				}
			}
		}
	}
}

