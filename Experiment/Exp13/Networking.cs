using System;
using System.Net;
using System.Net.NetworkInformation;
using System.Threading;

class Program
{
    static void Main()
    {
        Console.WriteLine("Initial Network Information:");
        DisplayNetworkInformation();

        while (true)
        {
            Thread.Sleep(5000); // Wait for 5 seconds between network checks

            Console.WriteLine("\nChecking for Network Changes...");
            if (NetworkInformationChanged())
            {
                Console.WriteLine("Network Changes Detected!");
                DisplayNetworkInformation();
            }
        }
    }

    static void DisplayNetworkInformation()
    {
        string hostName = Dns.GetHostName();
        Console.WriteLine($"Hostname: {hostName}");

        IPHostEntry hostEntry = Dns.GetHostEntry(hostName);
        foreach (IPAddress ipAddress in hostEntry.AddressList)
        {
            Console.WriteLine($"IP Address: {ipAddress}");
        }

        NetworkInterface[] networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
        Console.WriteLine("Network Interfaces:");
        foreach (NetworkInterface networkInterface in networkInterfaces)
        {
            Console.WriteLine($"Interface: {networkInterface.Name}");
            Console.WriteLine($"Status: {networkInterface.OperationalStatus}");
            Console.WriteLine($"Speed: {networkInterface.Speed} bytes/s");
        }
    }

    static bool NetworkInformationChanged()
    {
        string currentHostName = Dns.GetHostName();
        IPHostEntry currentHostEntry = Dns.GetHostEntry(currentHostName);

        NetworkInterface[] currentNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();

        if (currentHostEntry.AddressList.Length != Dns.GetHostEntry("").AddressList.Length)
        {
            return true; // IP address change detected
        }

        NetworkInterface[] previousNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
        if (currentNetworkInterfaces.Length != previousNetworkInterfaces.Length)
        {
            return true; // Network interface change detected
        }

        return false;
    }
}
