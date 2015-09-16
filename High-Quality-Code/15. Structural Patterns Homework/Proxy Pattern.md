#Proxy ������

##���������
������ ��� ������������ �� �� ���������� �������� �� ����� �����. ���� ���������� �� �� ���������� �������� �� ����� ����� ���� �� �� ������� �� ���-�������� �������: ������������, ������ �������������� � ���������������� �� ��������� ����� � �����, ������� �������� ����� �� ������ �� �����, ����� � ����������� �� ��-��������������� �������� �� ������ � ���������� �� ������ ����� �������, �� ����� ������.

##���������
����� �� ���� ����� � �� ������� ���������� �� ������, ����� �� ���������� ����������� ��� ����.

##���������
![alt tag](http://www.oodesign.com/images/design_patterns/structural/proxy-design-pattern-implementation-uml-class-diagram.png)

##���������
	* Subject � ���������, ������������� �� RealSubject � ���������� �������� ������. ����������� ������ �� ���� ������������� ���� � �� Proxy-��, ���� �� Proxy-�� �� ���� �� �� �������� �� �������, ������ ���� �� �� �������� RealSubject.
	* Proxy 
	    - �������� ����������, ����� ��������� �� Proxy-�� �� �������� RealSubject.
	    - ������������ ����� ���������, ����� � ������������� �� RealSubject, ���� �� Proxy-�� �� ���� �� �������� RealSubject.
	    - ���������� ������� �� RealSubject � ���� �� �� ������� � �������.
	    - ����� ������������ - ������� �� ���� �� Proxy-��.
	* RealSubject - �������� �����, ����� Proxy-�� ������������.

##��������
����� ������ �������� ��������� ��� Proxy, �������� ������ ��������� Proxy-�� �� ����� �����, �� ����� ��������� RealSubject � �� ���� ����� ������� ������ doSomething (). � ���� ������ Proxy-�� ���� �� ������� �������� ���� ����� �� ������ ������ doSomething () �� RealSubject . �������� ���� �� ������� RealSubject ����� � ���� ������, �� ������� �������������, �� ������� ������� �� ������� �� ��������� �� ������, � ���� ���� ������ ������ ����� ������. �������� ���� ���� �� ������� ������������ ��������, ���� ���� ������ ������ doSomething (), ���� �������� ����������� �� ���� �� ����������� ��� ������.

##�������� �������
	* Adapter Design Pattern;
	* Decorator Design Pattern.

##������

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
