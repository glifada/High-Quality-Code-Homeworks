#Proxy шаблон

##Мотивация
Когато има необходимост да се контролира достъпът до даден обект. Тази способност да се контролира достъпът до даден обект може да се изисква по най-различни причини: контролиране, когато инстанцирането и инициализирането на конкретен обект е скъпо, давайки различни права на достъп до обект, както и осигуряване на по-усъвършенствани средства за достъп и рефериране на обекти други процеси, на други машини.

##Намерение
Целта на този модел е да осигури заместител на обекта, който да контролира препратките към него.

##Структура
![alt tag](http://www.oodesign.com/images/design_patterns/structural/proxy-design-pattern-implementation-uml-class-diagram.png)

##Участници
	* Subject – интерфейс, имплементиран от RealSubject и представящ неговите услуги. Интерфейсът трябва да бъде имплементиран също и от Proxy-то, така че Proxy-то да може да се използва на всякъде, където може да се използва RealSubject.
	* Proxy 
	    - Поддържа референция, която позволява на Proxy-то да достъпва RealSubject.
	    - Имплементира същия интерфейс, който е имплементиран от RealSubject, така че Proxy-то да може да замества RealSubject.
	    - Контролира достъпа до RealSubject и може да го създава и изтрива.
	    - Други отговорности - зависят от вида на Proxy-то.
	* RealSubject - реалният обект, който Proxy-то представлява.

##Описание
Всеки клиент получава препратка към Proxy, клиентът тогава обработва Proxy-то по същия начин, по който обработва RealSubject и по този начин извиква метода doSomething (). В този момент Proxy-то може да направи различни неща преди да извика метода doSomething () на RealSubject . Клиентът може да създаде RealSubject обект в този момент, да направи инициализация, да провери правата на клиента за извикване на метода, и след това извика метода върху обекта. Клиентът също може да извърши допълнителни действия, след като извика метода doSomething (), като например увеличаване на броя на препратките към обекта.

##Свързани шаблони
	* Adapter Design Pattern;
	* Decorator Design Pattern.

##Пример

```c#
interface IActualPrices
{
    string GoldPrice
    {
        get;
    }
 
    string SilverPrice
    {
        get;
    }
 
    string DollarToRupee
    {
        get;
    }
}

class ActualPrices : IActualPrices
{
    public string GoldPrice
    {
        get
        {
            // This value should come from a DB typically
            return "100";
        }
    }
 
    public string SilverPrice
    {
        get
        {
            // This value should come from a DB typically
            return "5";
        }
    }
 
    public string DollarToRupee
    {
        get
        {
            // This value should come from a DB typically
            return "50";
        }
    }
}

class ActualPricesProxy : IActualPrices
{
    public string GoldPrice
    {
        get
        {
            return GetResponseFromServer("g");
        }
    }
 
    public string SilverPrice
    {
        get
        {
            return GetResponseFromServer("s");
        }
    }
 
    public string DollarToRupee
    {
        get
        {
            return GetResponseFromServer("d");
        }
    }
 
    private string GetResponseFromServer(string input)
    {
        string result = string.Empty;
        using (TcpClient client = new TcpClient())
        {
            client.Connect("127.0.0.1", 9999);
 
            Stream stream = client.GetStream();
 
            ASCIIEncoding asen = new ASCIIEncoding();
            byte[] ba = asen.GetBytes(input.ToCharArray());
 
            stream.Write(ba, 0, ba.Length);
 
            byte[] br = new byte[100];
            int k = stream.Read(br, 0, 100);
 
            
 
            for (int i = 0; i < k; i++)
            {
                result += Convert.ToChar(br[i]);
            }
 
            client.Close();
        }
        return result;
    }
}
```
