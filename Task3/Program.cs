Console.WriteLine("Введите цифру, соответствующую дню недели: ");
int weekdayNumber = Convert.ToInt32(Console.ReadLine());

void WeekDayChecking (int dayNumber) 
{
  if (weekdayNumber == 6 || weekdayNumber == 7) 
    {
  Console.WriteLine("(этот день выходной) -> да");
    }
  else if (weekdayNumber < 1 || weekdayNumber > 7) 
    {
    Console.WriteLine("это не день недели");
    }
  else Console.WriteLine("(это будний день) -> нет");
}

WeekDayChecking(weekdayNumber);
