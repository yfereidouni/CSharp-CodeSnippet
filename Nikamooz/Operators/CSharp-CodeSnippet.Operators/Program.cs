// See https://aka.ms/new-console-template for more information

using CSharp_CodeSnippet.Operators;

//Operator : CompoundOperators --------------------------------------------------------------
Console.WriteLine("\r\nOperator (Compound): ".PadRight(60, '-'));
Compounds fundamentals = new Compounds();
fundamentals.CompoundOperators();

//Operator : ConditionalExpressions ---------------------------------------------------------
Console.WriteLine("\r\nOperator (ConditionalExpressions): ".PadRight(60, '-'));
ConditionalsExpressions conditionalsExpressions =new ConditionalsExpressions();
var result = conditionalsExpressions.ConditionalExpressions(1);
Console.WriteLine(result);

//Operator : Checked ------------------------------------------------------------------------
Console.WriteLine("\r\nOperator (Checked): ".PadRight(60, '-'));
Checked checked01 = new Checked();
checked01.CheckedTypesOverflow();

//Operator : SizeOF -------------------------------------------------------------------------
Console.WriteLine("\r\nOperator (SizeOF): ".PadRight(60, '-'));
SizeOF sizeOF = new SizeOF();
sizeOF.SizeOfTypes();

//Operator : TypeOF -------------------------------------------------------------------------
Console.WriteLine("\r\nOperator (TypeOF): ".PadRight(60, '-'));
TypeOF typeOF = new TypeOF();
typeOF.Typeof();

//Operator : NameOF -------------------------------------------------------------------------
Console.WriteLine("\r\nOperator (NameOF): ".PadRight(60, '-'));
NameOF nameOF = new NameOF();
nameOF.Nameof();

//Operator : IS or AS -----------------------------------------------------------------------
Console.WriteLine("\r\nOperator (IS or AS): ".PadRight(60,'-'));
IsOrAs isOrAs = new IsOrAs();
Person person = new Person() { FirstName = "Yasser", LastName = "Fereidouni" };
Student student = new Student() { FirstName = "Shervin", LastName = "Souri", StudentNumber = "ST-10" };
Teacher teacher = new Teacher() { FirstName = "Sroush", LastName = "Sarabi", TeacherNumber = "TC-22" };

isOrAs.CheckIsPerson(person);  //Output: True
isOrAs.CheckIsPerson(student); //Output: True
isOrAs.CheckIsPerson(teacher); //Output: false , because not inherited from person

isOrAs.CheckAsPerson(person);  //Output: IS Person
isOrAs.CheckAsPerson(student); //Output: IS Person , because inherited from person
isOrAs.CheckAsPerson(teacher); //Output: IS NOT a Person , because not inherited from person

//Operator : Null ----------------------------------------------------------------------------
Console.WriteLine("\r\nOperator (Null): ".PadRight(60, '-'));
Nulls nulls = new Nulls();
nulls.NullOperators02(null);

//Operator : BinaryOperators -----------------------------------------------------------------
Console.WriteLine("\r\nOperator (Binary): ".PadRight(60, '-'));
BinaryOperators binaryOperators = new BinaryOperators();
binaryOperators.And();
binaryOperators.Or();
binaryOperators.XOr();
binaryOperators.NOT();
binaryOperators.ShiftLeft();
binaryOperators.ShiftRight();

//TypeCasting : TypeSafe ---------------------------------------------------------------------
Console.WriteLine("\r\nTypeCasting (TypeSafe): ".PadRight(60, '-'));
TypeCasting typeCasting = new TypeCasting();
typeCasting.TypeSafe();
typeCasting.ImplicitTypeCast();
typeCasting.ExplicitTypeCast();

//TypeCasting : Boxing and Unboxing ----------------------------------------------------------
Console.WriteLine("\r\nTypeCasting (BoxingAndUnboxing): ".PadRight(60, '-'));
BoxingAndUnboxing boxingAndUnboxing = new BoxingAndUnboxing();
boxingAndUnboxing.Boxing();
boxingAndUnboxing.Unboxing();

//Operator : OperatorOverloading -------------------------------------------------------------
Console.WriteLine("\r\nOperator (OperatorOverloading): ".PadRight(60, '-'));
OperatorsOverloading operatorsOverloading01 = new OperatorsOverloading() { InnerValue = 10 };
OperatorsOverloading operatorsOverloading02 = new OperatorsOverloading() { InnerValue = 20 };
OperatorsOverloading operatorsOverloading03 = operatorsOverloading01 + operatorsOverloading02;
Console.WriteLine(operatorsOverloading03);
Console.WriteLine(operatorsOverloading01 == operatorsOverloading02);
Console.WriteLine(operatorsOverloading01 != operatorsOverloading02);

//TypeCasting : ImplicitAndExplicit Casting --------------------------------------------------
Console.WriteLine("\r\nTypeCasting (ImplicitAndExplicit Casting): ".PadRight(60, '-'));
Person personTest = new Person(10);
Console.WriteLine(personTest.Age);
personTest.Age = 50;
Console.WriteLine(personTest.Age);
int moneyValue = personTest;         //Implicit Cast
byte byteValye = (byte)personTest;   //Explicit Casting
double a = 100;
personTest = (int)a;
Console.WriteLine(moneyValue);

