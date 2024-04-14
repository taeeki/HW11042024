
using Treatment;
using Patients;

TreatmentPlan trPlan = new TreatmentPlan(3);
Patient patient = new Patient(trPlan);
patient.AssigntDoctor();

public abstract class Doctor
{
    public abstract void Treat();
}

public class Therapist : Doctor
{
    public override void Treat()
    {
        Console.WriteLine("Терапевт");
    }
}

public class Dentist : Doctor
{
    public override void Treat()
    {
        Console.WriteLine("Дантист");
    }
}

public class Surgeon : Doctor
{
    public override void Treat()
    {
        Console.WriteLine("Хирург");
    }
}

