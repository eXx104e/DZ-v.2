using System.Text;

struct STUDENT
{
    public string IMYA;
    public string FAMILIYA;
    public int IDENTIFICATOR;
    public string DATA;
    public string KATEGORIYA;
    public double ALCOHOL;
    public STUDENT(string imya, string familiya, int identificator, string data, string kategoriya, double alcohol)
    {
        this.IMYA = imya;
        this.FAMILIYA = familiya;
        this.IDENTIFICATOR = identificator;
        this.DATA = data;
        this.KATEGORIYA = kategoriya;
        this.ALCOHOL = alcohol;
    }
    public double drunk()
    {
        return ALCOHOL;
    }
    public void print_()
    {
        Console.WriteLine($"Имя: {IMYA}, Фамилия: {FAMILIYA}, Идентификатор: {IDENTIFICATOR}, Дата рождения: {DATA}, Категория алкоголизма: {KATEGORIYA}, Всего выпито: {ALCOHOL}");
    }

}
struct User
{
    public string _imya;
    public string grad;
    public int age;
    public int pincode;
    public User(int Age, string _IMYA, string _GRAD, int _pincode)
    {
        this._imya = _IMYA;
        this.grad = _GRAD;
        this.age = Age;
        this.pincode = _pincode;
    }
    public void Print()
    {
        Console.WriteLine($"Имя: {_imya}, Город: {grad}, Возраст: {age}, _pincode: {pincode}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Задание №1");
        STUDENT nomer1 = new STUDENT("Никита", "Богомолов", 1, "01.07.2004", "b", 1.0);
        nomer1.print_();
        STUDENT nomer2 = new STUDENT("Радмир", "Салимов", 2, "19.10.2004", "с", 2.0);
        nomer2.print_();
        STUDENT nomer3 = new STUDENT("Илназ", "Мухетдинов", 3, "14.08.2003", "с", 1.8);
        nomer3.print_();
        STUDENT nomer4 = new STUDENT("Мария", "Головина", 4, "18.02.2004", "a", 0.3);
        nomer4.print_();
        STUDENT nomer5 = new STUDENT("Халиль", "Зиганшин", 5, "14.01.2004", "b", 2.5);
        nomer5.print_();
        double all = nomer1.drunk() + nomer2.drunk() + nomer3.drunk() + nomer4.drunk() + nomer5.drunk();
        Console.WriteLine($"Первый студент выпил: {Math.Round((nomer1.drunk() / all) * 100, 1)}%" + "\n" +
        $"Второй студент выпил: {Math.Round((nomer2.drunk() / all) * 100, 1)}%" + "\n" +
        $"Третий студент выпил: {Math.Round((nomer3.drunk() / all) * 100, 1)}%" + "\n" +
        $"Четвёртый студент выпил: {Math.Round((nomer4.drunk() / all) * 100, 1)}%" + "\n" +
        $"Пятый студент выпил: {Math.Round((nomer5.drunk() / all) * 100, 1)}%" + "\n" + $"Общий объём алкоголя: {all} литров");


        Console.WriteLine("Задание №2");
        Console.WriteLine($"sbyte: {sbyte.MinValue} ... {sbyte.MaxValue}" + "\n" +
        $"byte: {byte.MinValue} ... {byte.MaxValue}" + "\n" +
        $"short: {short.MinValue} ... {short.MaxValue}" + "\n" +
        $"ushort: {ushort.MinValue} ... {ushort.MaxValue}" + "\n" +
        $"int: {int.MinValue} ... {int.MaxValue}" + "\n" +
        $"uint: {uint.MinValue} ... {uint.MaxValue}" + "\n" +
        $"long: {long.MinValue} ... {long.MaxValue}" + "\n" +
        $"ulong: {ulong.MinValue} ... {ulong.MaxValue}" + "\n" +
        $"char: U+000 ... U+ffff" + "\n" +
        $"float: {float.MinValue} ... {float.MaxValue}" + "\n" +
        $"double: {double.MinValue} ... {double.MaxValue}" + "\n" +
        "bool: true ... false" + "\n" +
        $"decimal: {decimal.MinValue} ... {decimal.MaxValue}" + "\n" +
        "string: Ограничено только системной памятью" + "\n" +
        "object: Практически всё, что угодно" + "\n");


        Console.WriteLine("Задание №3");
        User new_user = new User();
        Console.WriteLine("Введите имя");
        new_user._imya = Console.ReadLine();
        Console.WriteLine("Введите город");
        new_user.grad = Console.ReadLine();
        Console.WriteLine("Введите возраст");
        new_user.age = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите пинкод");
        new_user.pincode = int.Parse(Console.ReadLine());
        new_user.Print();


        Console.WriteLine("Задание №4");
        string[] name = Console.ReadLine().Split(' ');
        Console.WriteLine($"{name[0][0].ToString().ToUpper()}.{name[1][0].ToString().ToUpper()}");


        Console.WriteLine("Задание №5");
        bool normPrice = false;
        int x = -1, regularPrice = -1, sale = -1;
        while (normPrice == false)
        {
            Console.Write("Планируемая цена вашего отпуска?: ");
            normPrice = int.TryParse(Console.ReadLine(), out x);
        }
        normPrice = false;
        while (normPrice == false)
        {
            Console.Write("Стандартная цена бутылки виски: ");
            normPrice = int.TryParse(Console.ReadLine(), out regularPrice);
        }
        normPrice = false;
        while (normPrice == false)
        {
            Console.Write("Скидка на одну бутылку: ");
            normPrice = int.TryParse(Console.ReadLine(), out sale);
        }
        Console.WriteLine($"Вам надо купить : {x / (regularPrice * sale / 100)}\n");

        Console.WriteLine("Задание №6");
        Console.WriteLine("Введите скорость в км/ч:");
        int S = int.Parse(Console.ReadLine().Replace(".", ","));
        Console.WriteLine($"Скорость в м/с равна: {(S / 3.6) - (S / 3.6) % 1}");



        Console.WriteLine("Задание №7");
        string strInput = Console.ReadLine();
        StringBuilder strOutput = new StringBuilder();
        foreach (Char c in strInput.ToCharArray())
        {
            if (Char.IsLower(c))
            {
                strOutput.Append(Char.ToUpper(c));
            }
            else
            {
                strOutput.Append(Char.ToLower(c));
            }
        }
        Console.WriteLine(strOutput);
        Console.WriteLine("ТАААА ДАААА!");
    }
}