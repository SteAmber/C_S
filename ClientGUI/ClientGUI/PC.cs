using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Security.Principal;

class PipeClient
{
    public List<string> GetInfoFromPipe(string pipename)
    {
        NamedPipeClientStream pipeClient1 =
            new NamedPipeClientStream("localhost", pipename,
            PipeDirection.InOut, PipeOptions.None,
            TokenImpersonationLevel.Impersonation);

        List<string> List1 = new List<string>();
        try
        {
            pipeClient1.Connect(5);

            StreamReader sr1 = new StreamReader(pipeClient1);

            string temp1;
            while ((temp1 = sr1.ReadLine()) != null)
            {
                List1.Add(temp1);
            }
            return List1;
        } catch (IOException e)
        {
            return List1;
        }
    }

}