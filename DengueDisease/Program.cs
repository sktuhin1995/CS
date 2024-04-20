using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestRepositoryPattern.BL;
using TestRepositoryPattern.DA;

namespace TestRepositoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            DenguePatient denguePatient = new DenguePatient(new PatientRepository());
            bool isRunning = true;
            while (isRunning)
            {
                try
                {
                    Console.Write("\nType 'L' for List, 'S' for Search, 'I' for Insert, 'U' for Update, 'D' for Delete, 'C' for Clear, 'X' for Exit: ");
                    string command = Console.ReadLine();
                    if (command == "L")
                    {
                        List<Patient> _listPatient = denguePatient.Get();
                        Console.WriteLine("List of Patient:");
                        Console.WriteLine("PatientId   |   PatientName    |   PatientAddress  |  PatientEmail");
                        foreach (Patient _patient in _listPatient)
                        {
                            Console.WriteLine(_patient.PatientId + "  |   " + _patient.PatientName + "  |   " + _patient.PatientAddress + "  |  " + _patient.PatientEmail);
                        }
                    }
                    else if (command == "S")
                    {
                        Console.Write("\nInput a PatientId to find a Patient: ");
                        string id = Console.ReadLine();
                        Patient aPatient = denguePatient.Get(Convert.ToInt32(id));
                        Console.WriteLine(aPatient.PatientId + ". " + aPatient.PatientName + " -- " + aPatient.PatientAddress + " -- " + aPatient.PatientEmail);
                    }
                    else if (command == "I")
                    {
                        Console.Write("\nInput a PatientId: ");
                        string id = Console.ReadLine();
                        Console.Write("Input a PatientName: ");
                        string name = Console.ReadLine();
                        Console.Write("Input a PatientAddress: ");
                        string address = Console.ReadLine();
                        Console.Write("Input a PatientEmail: ");
                        string email = Console.ReadLine();
                        Patient aPatient = new Patient();
                        aPatient.PatientId = Convert.ToInt32(id);
                        aPatient.PatientName = name;
                        aPatient.PatientAddress = address;
                        aPatient.PatientEmail = email;
                        bool isExecuted = denguePatient.Add(aPatient);
                        if (isExecuted)
                        {
                            Console.WriteLine("Added successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Failed to add.");
                        }
                    }
                    else if (command == "U")
                    {
                        Console.Write("\nInput a PatientId: ");
                        string id = Console.ReadLine();
                        Console.Write("Input a PatientName: ");
                        string name = Console.ReadLine();
                        Console.Write("Input a PatientAddress: ");
                        string address = Console.ReadLine();
                        Console.Write("Input a PatientEmail: ");
                        string email = Console.ReadLine();
                        Patient aPatient = new Patient();
                        aPatient.PatientId = Convert.ToInt32(id);
                        aPatient.PatientName = name;
                        aPatient.PatientAddress = address;
                        aPatient.PatientEmail = email;
                        bool isExecuted = denguePatient.Update(aPatient);
                        if (isExecuted)
                        {
                            Console.WriteLine("Updated successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Failed to update.");
                        }
                    }
                    else if (command == "D")
                    {
                        Console.Write("\nInput a PatientId: ");
                        string id = Console.ReadLine();
                        bool isExecuted = denguePatient.Delete(Convert.ToInt32(id));
                        if (isExecuted)
                        {
                            Console.WriteLine("Deleted successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Failed to delete.");
                        }
                    }
                    else if (command == "C")
                    {
                        Console.Clear();
                    }
                    else if (command == "X")
                    {
                        isRunning = false;
                    }
                    else
                    {
                        Console.WriteLine("Command not found.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }
    }
}
