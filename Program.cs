using System;
using System.Net.NetworkInformation;

NetworkInterface[] netintfaces = NetworkInterface.GetAllNetworkInterfaces();

foreach (NetworkInterface nif in netintfaces)
{
    Console.WriteLine($"Interface: {nif.Name}");
    Console.WriteLine($"Description: {nif.Description}");
    Console.WriteLine($"NI Type: {nif.NetworkInterfaceType}");
    Console.WriteLine($"Operational Status: {nif.OperationalStatus}");
    Console.WriteLine($"Speed: {nif.Speed / 1_000_000} Мбіт/с");

    IPv4InterfaceStatistics stats = nif.GetIPv4Statistics();
    Console.WriteLine($"Bytes Received: {stats.BytesReceived}");
    Console.WriteLine($"Bytes Sent: {stats.BytesSent}");
    Console.WriteLine("_____________________________________________");
}