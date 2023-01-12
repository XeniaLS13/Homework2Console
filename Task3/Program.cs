Console.WriteLine("Введите цифру, соответствующую дню недели: ");
int weekdayNumber = Convert.ToInt32(Console.ReadLine());
WeekDayChecking(weekdayNumber);



void WeekDayChecking (int dayNumber) 
{
  if (dayNumber == 6 || dayNumber == 7) 
    {
  Console.WriteLine("(этот день выходной) -> да");
    }
  else if (dayNumber < 1 || dayNumber > 7) 
    {
    Console.WriteLine("это не день недели");
    }
  else Console.WriteLine("(это будний день) -> нет");
}

