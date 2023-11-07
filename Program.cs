Console.WriteLine("Enter your marks :");

//calculate between two points

double lat1 = 52.2296756;
double lon1 = 21.0122287;

double lat2 = 55.406374;
double lon2 = 16.9251681;

double distance = CalculateDistance(lat1, lon1, lat2, lon2);

Console.WriteLine($"Distance between two points is {distance} meters");

// show in km
Console.WriteLine($"Distance between two points is {distance/1000} km");


static double CalculateDistance(double lat1, double lon1, double lat2, double lon2) 
{
    double R = 6371e3; // Earth's radius in m
    double φ1 = lat1 * (Math.PI/180); // Convert degrees to radians
    double φ2 = lat2 * (Math.PI/180);
    double Δφ = (lat2-lat1) * (Math.PI/180);
    double Δλ = (lon2-lon1) * (Math.PI/180);

    double a = Math.Sin(Δφ/2) * Math.Sin(Δφ/2) +
               Math.Cos(φ1) * Math.Cos(φ2) *
               Math.Sin(Δλ/2) * Math.Sin(Δλ/2);
    double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1-a));

    double distanceInMeters = R * c;
    return distanceInMeters;
}