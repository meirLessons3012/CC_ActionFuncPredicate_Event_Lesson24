using CC_ActionFucPredicate_Event_Lesson24;
#region College

College college1 = new College("college1");
College college2 = new College("college2");
MailingSystem mailingSystem = new MailingSystem();
SMSSystem SMSSystem = new SMSSystem();

college1.newStudentRegsitered += mailingSystem.SendMail;
college1.newStudentRegsitered += SMSSystem.SendSMS;
college2.newStudentRegsitered += mailingSystem.SendMail;
college2.newStudentRegsitered += SMSSystem.SendSMS;
college2.newStudentRegsitered -= SMSSystem.SendSMS;

//Erro when using with event keyword
//college1.newStudentRegsitered = mailingSystem.SendMail;
//college1.newStudentRegsitered.Invoke(null, null);

Student s1 = new Student
{
    Id = 31412314,
    FullName = "yossi bokobza",
    Mail = "yosyos@gmail.com",
    Phone = "054-21412310",
    BankDetails = new BankDetails { BankNo = 10, Branch = 376, AccountNo = 242422 }
};
Student s2 = new Student
{
    Id = 623453654,
    FullName = "Shmaiya nahari",
    Mail = "shari@gmail.com",
    Phone = "054-13245245",
    BankDetails = new BankDetails { BankNo = 0, Branch = 0, AccountNo = 0 }
};
Student s3 = new Student
{
    Id = 623453654,
    FullName = "dina cohen",
    Mail = "dindino@walla.com",
    Phone = "052-917823137",
    BankDetails = new BankDetails { BankNo = 9, Branch = 127, AccountNo = 8546225 }
};

Console.WriteLine("register first student to college 1");
college1.RegisterNewStudent(s1);
Console.WriteLine("register first student to college 2");
college2.RegisterNewStudent(s1);

Console.WriteLine("register second student to college 1");
college1.RegisterNewStudent(s2);

Console.WriteLine("register third student to college 2");
college2.RegisterNewStudent(s3);
Console.WriteLine("register third student to college 1");
college1.RegisterNewStudent(s3);


#endregion
#region Events

Calculator.MyDel += (n1, n2) => n1 * n2 * n1;
Calculator.MyDel -= (n1, n2) => n1 * n2 * n1;

EventHandler myEvent = (mySndr, myStr) => Console.WriteLine(myStr);
myEvent.Invoke(null, new EventArgs());
EventHandler<MyEventArgs> myEventWithGeneric = (mySndr, myStr) => Console.WriteLine(myStr.Name);
myEventWithGeneric.Invoke(null, new MyEventArgs { Name = "Ran" });
EventHandler<NewStudentRegsiterEventArgs> studentRegisteredEvent = null;
studentRegisteredEvent?.Invoke(null, new NewStudentRegsiterEventArgs(new Student()));
//Calculator.MyDel = (n1, n2) => n1 * n2 * n2;

//Calculator.MyDel.Invoke(3, 4);

#endregion

#region Lambda And Anonymous

List<string> myStrList = new List<string> { "hey", "hackeru", "with", "lambda" };
myStrList.ForEach(str => Console.WriteLine(str));//With Lambda
myStrList.ForEach(MethodForEach);//With Method

foreach (string str in myStrList)
{
    Console.WriteLine(str);
}

Func<int, int, string> funcWithAnonMethod = (x, y) =>
{
    Console.WriteLine(x);
    Console.WriteLine(y);
    Console.WriteLine(x+y);
    return x + y.ToString();
};

Func<int, string> funcWithAnonMethod1 = x =>
{
    Console.WriteLine(x);
    return x.ToString();
};

string res = funcWithAnonMethod.Invoke(13, 21);


#endregion

#region Action Func Predicate
//Action
Action myFirstAction = PrintDate;
Action<int> mySecAction = PrintAge;
Action<double, double, string> calcMethod = PrintCalcOper;

//Func
Func<int> myFirstFunc = GetHour;
Func<int, string> mySecFunc = GetNameById;

//Predicate
Func<Car, bool> checkIfCarExsitFunc;
Predicate<Car> checkIfCarExsitPredicate;


//Exr
Func<string, Func<int, int, int>> calcMethodWithLambda = oper =>
{
    switch (oper)
    {
        case "+":
            return (n1, n2) => n1 + n2;
        case "-":
            return (n1, n2) => n1 - n2;
        case "/":
            return (n1, n2) => n1 / n2;
        case "*":
            return (n1, n2) => n1 * n2;
        default:
            return null;
    }
};

#region Action Methods

static void PrintDate()
{
    Console.WriteLine(DateTime.Now);
}

static void PrintAge(int age)
{
    Console.WriteLine(age);
}

static void PrintCalcOper(double n1, double n2, string oper)
{
    switch (oper)
    {
        case "+":
            Console.WriteLine(n1 + n2);
            break;
        default:
            break;
    }
}

#endregion

#region Func Actions

static int GetHour()
{
    return DateTime.Now.Hour;
}

static string GetNameById(int id)
{
    return "yohel";
}

#endregion


#endregion

#region Lambda And Anonymous

static void MethodForEach(string str)
{
    Console.WriteLine(str);
    Console.WriteLine(str);
    Console.WriteLine(str);
}

#endregion