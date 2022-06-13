using System;
using System.Text.RegularExpressions;

Dictionary<int,string> CarPark = new Dictionary<int,string>();
InitializeCarPark(3);
AddVehicle(CarPark, "AAA-111");
AddVehicle(CarPark, "BBB-222");
AddVehicle(CarPark, "CCC-333");
VacateStall(CarPark, 2);
LeaveParkade(CarPark, "CCC-333");
Console.WriteLine(Manifest(CarPark));

Dictionary<int, string> InitializeCarPark(int capacity)
{
    for(int i = 0; i < capacity; i++)
    {
        CarPark.Add(i+1, null);
    }
    
    return CarPark;
}

int AddVehicle(Dictionary<int, string> carPark, string licence)
{
    if (!validateLicense(licence))
    {   
        //Console.WriteLine("should stop");
        return -1;
        
    }
    
    for(int i = 0; i < carPark.Count; i++)
    {
        if (carPark[i+1] == null)
        {
            carPark[i+1] = licence;
            return i;
        }        
    }
    return -1;
}

bool VacateStall(Dictionary<int, string> carPark, int stallNumber)
{
    if (carPark[stallNumber] == null || stallNumber > carPark.Count)
    {
        return false;
    }
    else
    {
        carPark[stallNumber] = null;
        return true;
    }
}

bool LeaveParkade(Dictionary<int, string> carPark, string licenceNumber)
{
    if (validateLicense(licenceNumber))
    {
        for (int i = 0; i < carPark.Count; i++)
            {
                if (carPark[i+1] == licenceNumber)
                {
                    carPark[i+1] = null;
                    return true;
                }
            }
            return false;
    }
    return false;
}

String Manifest(Dictionary<int, string> carPark)
{
    string info = "";
    for(int i = 0; i < carPark.Count; i++)
    {
        if(carPark[i+1] == null)
        {
            info += $"Parking stall {i+1} is empty \n";
        }
        else
        {
            info += $"Parking stall {i+1} is occupied by the car {carPark[i+1]} \n";
        }
    }
    return info;
}

bool validateLicense(string license)
{   
    char hyphen = '-';
    
    if (license.Contains(hyphen)&&(license.Length==7))
    {
        string sixValues = license.Substring(0,3)+license.Substring(4,3);
        Regex r = new Regex("^[A-Z0-9]*$");

        if (r.IsMatch(sixValues))
        {
            return true;
        }
        return false;
    }
    else
    {
        return false;
    }
}