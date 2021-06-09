using System;
using System.IO;
using System.IO.Pipes;
using System.Threading;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;

class PipeServer2
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
            new NamedPipeServerStream("pipe2", PipeDirection.InOut, numThreads);

        {
            // Wait for a client to connect
            pipeServer1.WaitForConnection();
            try
            {
                StreamWriter sw = new StreamWriter(pipeServer1);
                {
                    sw.AutoFlush = true;
                    List<string> message = new List<string>();

                    //message.Add("Ширина окна = " + Console.WindowWidth);
                    //message.Add("Высота окна = " + Console.WindowHeight);

                    Size resolution = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size;
                    message.Add("Ширина экрана: " + resolution.Width);
                    message.Add("Высота экрана: " + resolution.Height);

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