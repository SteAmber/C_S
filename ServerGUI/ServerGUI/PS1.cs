using System;
using System.IO;
using System.IO.Pipes;
using System.Threading;
using System.Collections.Generic;
using System.Diagnostics;

class PipeServer1
{
    static int numThreads = 4;

    /*static void Main()
    {
        bool onlyInstance;
        Mutex mtx = new Mutex(true, "PC", out onlyInstance);
        if (onlyInstance)
            Start();
        else
            Console.WriteLine("An error occured");
    }*/

    public void Start()
    {
        for (int i = 0; i < numThreads; i++)
        {
            Thread newThread = new Thread(new ThreadStart(ServerThread));
            newThread.Start();
        }
    }
    private static string Priority(int number)
    {

        switch (number)
        {
            case 4:
                {
                    return ("Приоритет маленький");
                }
            case 8:
                {
                    return ("Приоритет нормальный");
                }
            case 13:
                {
                    return ("Приоритет высокий");
                }
            case 24:
                {
                    return ("Приоритет реального времени");
                }
            case 10:
                {
                    return ("Приоритет выше нормального");
                }
            case 6:
                {
                    return ("Приоритет ниже нормального");
                }
            default:
                {
                    return ("Приоритет неизвестен");
                }
        }
    }
    private static void ServerThread()
    {
        NamedPipeServerStream pipeServer1 =
            new NamedPipeServerStream("pipe1", PipeDirection.InOut, numThreads);

        {
            // Wait for a client to connect
            pipeServer1.WaitForConnection();
            try
            {
                StreamWriter sw = new StreamWriter(pipeServer1);
                {
                    sw.AutoFlush = true;
                    List<string> message = new List<string>();

                    Process[] serverProc = Process.GetProcessesByName("ServerGUI");

                    for (int i = 0; i < serverProc.Length; i++)
                    {
                        ProcessThreadCollection ListServer = serverProc[i].Threads;
                        message.Add("Сервер N" + i + ": " + Priority(serverProc[i].BasePriority));
                        message.Add("Количество потоков в сервере " + ListServer.Count);
                        for (int j = 0; j < ListServer.Count; j++)
                            message.Add("    Поток №" + j + ": " + Priority(ListServer[j].BasePriority));
                    }

                    Process[] clientProc = Process.GetProcessesByName("ServerGUI2");

                    for (int i = 0; i < clientProc.Length; i++)
                    {
                        ProcessThreadCollection ListServer = clientProc[i].Threads;
                        message.Add("Клиент N" + i + ": " + Priority(clientProc[i].BasePriority));
                        message.Add("Количество потоков в клиенте " + ListServer.Count);
                        for (int j = 0; j < ListServer.Count; j++)
                            message.Add("    Поток №" + j + ": " + Priority(ListServer[j].BasePriority));
                    }
                    SendAll(sw, message);

                    //работа сервера на этом заканчивается
                    pipeServer1.Disconnect();
                }
            }
            // Catch the IOException that is raised if the pipe is broken
            // or disconnected.
            catch (IOException e)
            {
                Console.WriteLine("ERROR: {0}", e.Message);
                Console.ReadKey();
            }
        }
    }
    public static void SendAll(StreamWriter handler, List<string> message)
    {
        for (int i = 0; i < message.Count;)
        {
            Send(message[i], handler);
            message.RemoveAt(i);
        }
    }
    public static void Send(string message, StreamWriter handler)
    {
        try
        {
            handler.WriteLine(message, 0);
        }
        catch
        {
        }
    }
}