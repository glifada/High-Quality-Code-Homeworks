#Flyweight шаблон

##Мотивация
Някои програми изискват голям брой обекти, които имат споделено състояние помежду си. Примерно игра на война, където има голям брой обекти войници; обектът войник поддържа графичното представяне на войник, поведение на войник като движение и взимането на оръжия, в допълнение здравето войниците и място на война. Създаване на голям брой обекти войници е необходимост и това ще заеме огромно количество памет. Въпреки че представянето и поведението на всеки войник е еднакво, но здравето и местоположението им могат да варират значително .

##Намерение
Целта на този шаблон е да се използва споделянето, за да поддържат голям брой обекти, на които част от състоянието им е еднакво, но другата част може да е различна.

##Структура
![alt tag](http://www.oodesign.com/images/design_patterns/structural/flyweight-design-pattern-implementation-uml-class-diagram.png)
 
**Участници
	* Flyweight - декларира интерфейс, чрез който flyweights могат да получават несвойствено състояние и да действат съгласно него.
	* ConcreteFlyweight - имплементира интерфейса Flyweight и запаметява присъщото състояние. ConcreteFlyweight обектът трябва да бъде общодостъпен. ConcreteFlyweight обектът трябва да поддържа състоянието, което е присъщо за него, и трябва да може да манипулира състоянието, което е неприсъщо.
	* FlyweightFactory - фабриката създава и управлява flyweight обекти. В допълнение фабриката осигурява достъпа до flyweight обектите. Фабриката поддържа резерв от различни flyweight обекти и връща обект от резерва, ако вече е създаден, добавя обект към резерва и го връща в случай, че не е създаван такъв досега. 
	* Client - клиентът поддържа референции към flyweight обектите като допълнение към изчисляване и поддържане неприсъщото състояние

##Последствия
Flyweight шаблонът спестява памет чрез споделяне на flyweight обекти сред клиентите . Количеството спестена памет зависи от броя на запаметените категории flyweight.

##Свързани шаблони
	* Factory и Singleton шаблони
	* State и Strategy шаблони


##Пример

```c#
public enum EnMoneyType
{
  Metallic,
  Paper
}

public interface IMoney
{
  EnMoneyType MoneyType { get; } //IntrinsicState()
  void GetDisplayOfMoneyFalling(int moneyValue); //GetExtrinsicSate()
}

public class MetallicMoney:IMoney
{
   public EnMoneyType MoneyType
   {
     get { return EnMoneyType.Metallic; }
   }

   public void GetDisplayOfMoneyFalling(int moneyValue)
   {
     //This method would display graphical representation of a metallic currency like a    
       gold coin.
       Console.WriteLine(string.Format("Displaying a graphical object of {0} currency of 
                                        value ${1} falling from sky."
                                        , MoneyType.ToString(), moneyValue)
                                      );
   }
}

class PaperMoney:IMoney
{
  public EnMoneyType MoneyType
  {
    get { return EnMoneyType.Paper; }
  }

  public void GetDisplayOfMoneyFalling(int moneyValue) //GetExtrinsicState()
  {
    // This method would display a graphical representation of a paper currency.
       Console.WriteLine(string.Format("Displaying a graphical object of {0} currency                                        of value ${1} falling from sky."
                                       ,MoneyType.ToString(), moneyValue));
  }
}

public class MoneyFactory
{
   public static int ObjectsCount=0;
   private Dictionary<enmoneytype,imoney> _moneyObjects;
   public IMoney GetMoneyToDisplay(EnMoneyType form) // Same as GetFlyWeight()
   {
      if (_moneyObjects == null)
           _moneyObjects = new Dictionary<enmoneytype,>();
      if (_moneyObjects.ContainsKey(form))
            return _moneyObjects[form];
      switch (form)
      {
          case EnMoneyType.Metallic:
              _moneyObjects.Add(form, new MetallicMoney());
               ObjectsCount++;
               break;
          case EnMoneyType.Paper:
              _moneyObjects.Add(form, new PaperMoney());
               ObjectsCount++;
               break;
          default:
               break;
      }
      return _moneyObjects[form];
   }
}
```
