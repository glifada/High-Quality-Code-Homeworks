#Flyweight ������

##���������
����� �������� �������� ����� ���� ������, ����� ���� ��������� ��������� ������� ��. �������� ���� �� �����, ������ ��� ����� ���� ������ �������; ������� ������ �������� ���������� ����������� �� ������, ��������� �� ������ ���� �������� � ��������� �� ������, � ���������� �������� ��������� � ����� �� �����. ��������� �� ����� ���� ������ ������� � ������������ � ���� �� ����� ������� ���������� �����. ������� �� ������������� � ����������� �� ����� ������ � �������, �� �������� � ���������������� �� ����� �� ������� ���������� .

##���������
����� �� ���� ������ � �� �� �������� �����������, �� �� ��������� ����� ���� ������, �� ����� ���� �� ����������� �� � �������, �� ������� ���� ���� �� � ��������.

##���������
![alt tag](http://www.oodesign.com/images/design_patterns/structural/flyweight-design-pattern-implementation-uml-class-diagram.png)
 
**���������
	* Flyweight - ��������� ���������, ���� ����� flyweights ����� �� ��������� ������������ ��������� � �� �������� �������� ����.
	* ConcreteFlyweight - ������������ ���������� Flyweight � ���������� ��������� ���������. ConcreteFlyweight ������� ������ �� ���� ������������. ConcreteFlyweight ������� ������ �� �������� �����������, ����� � ������� �� ����, � ������ �� ���� �� ���������� �����������, ����� � ���������.
	* FlyweightFactory - ��������� ������� � ��������� flyweight ������. � ���������� ��������� ��������� ������� �� flyweight ��������. ��������� �������� ������ �� �������� flyweight ������ � ����� ����� �� �������, ��� ���� � ��������, ������ ����� ��� ������� � �� ����� � ������, �� �� � �������� ����� ������. 
	* Client - �������� �������� ���������� ��� flyweight �������� ���� ���������� ��� ����������� � ���������� ����������� ���������

##�����������
Flyweight �������� �������� ����� ���� ��������� �� flyweight ������ ���� ��������� . ������������ �������� ����� ������ �� ���� �� ������������ ��������� flyweight.

##�������� �������
	* Factory � Singleton �������
	* State � Strategy �������


##������

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
