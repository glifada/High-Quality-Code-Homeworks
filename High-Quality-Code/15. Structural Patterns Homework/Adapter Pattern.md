#Adapter шаблон

##Мотивация
Adapter шаблонът действа като адаптер между класове и обекти. Като всеки адаптер в реалния свят той се използва, като интерфейс, мост между два обекта. 

##Намерение
	* Конвертиране на интерфейса на клас в друг интерфейс, който клиентите очакват.
	* Adapter позволява класовете да работят заедно, което иначе не би било възможно поради несъвместими интерфейси.

##Структура
![alt tag](http://www.oodesign.com/images/structural/adapter-pattern.png)
 
##Участници:
	* Target – дефинира домейн-специфичен интерфейс, който клиентът използва.
	* Adapter - адаптира интерфейса Adaptee към Target интерфейс.
	* Adaptee - определя съществуващ интерфейс, който се нуждае от адаптиране.
	* Client – работи с обекти, съответстващи на Target интерфейса.

##Приложимост
Adapter шаблонът се използва, когато:
	* Когато има клас (Target), който се позовава на методите, определени в един интерфейс и има друг клас (Adapteе), който не изпълнява интерфейса, но изпълнява операции, които трябва да бъдат използвани от първия клас чрез интерфейса, но не можете да променяте съществуващия код. Адаптерът ще реализира интерфейса и ще бъде мост между двата класа.
	* Когато класът  (Target) е създаден за общите нужди, имплементиращ общи интерфейси и има някои имплементирани класове, но не е имплементиран интерфейса, който трябва да бъде използван от Target класа.

##Пример

```c#
interface ITarget
{
  List<string> GetProducts();
}


public class VendorAdaptee
{
   public List<string> GetListOfProducts()
   {
      List<string> products = new List<string>();
      products.Add("Gaming Consoles");
      products.Add("Television");
      products.Add("Books");
      products.Add("Musical Instruments");
      return products;
   }
}


class VendorAdapter:ITarget
{
   public List<string> GetProducts()
   {
      VendorAdaptee adaptee = new VendorAdaptee();
      return adaptee.GetListOfProducts();
   }
}


class ShoppingPortalClient
{
   static void Main(string[] args)
   {
      ITarget adapter = new  VendorAdapter();
      foreach (string product in adapter.GetProducts())
      {
        Console.WriteLine(product);
      }
      Console.ReadLine();
   }
}
```
