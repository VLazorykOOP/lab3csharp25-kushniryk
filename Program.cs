using LR3;

void Task1()
{
    Trapeze[] trapezes = new Trapeze[]
        {
            new Trapeze(5, 7, 4, "Red"),
            new Trapeze(6, 6, 3, "Blue"),
            new Trapeze(8, 10, 5, "Green"),
            new Trapeze(4, 4, 4, "Yellow"),
            new Trapeze(10, 12, 6, "Black")
        };

    foreach (var trapeze in trapezes)
    {
        trapeze.printTrapeze();
        trapeze.P();
        trapeze.S();
        trapeze.isSquare();
        trapeze.GetC();
        Console.WriteLine();
    }
}
void Task2()
{
    Exam exam = new Exam("Mathematics", 100, "2024-05-15");
    GraduationExam graduationExam = new GraduationExam("Physics", 100, "2024-06-15");
    Trial trial = new Trial("Chemistry", 50, "Practical");

    exam.ConductTest();
    graduationExam.ConductTest();
    trial.ConductTest();
}

Task1();
