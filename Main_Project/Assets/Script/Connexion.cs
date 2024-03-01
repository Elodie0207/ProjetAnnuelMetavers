using UnityEngine;
using System.Net;
using System.Net.Sockets;
using System.Text;

public class PythonUnityCommunication : MonoBehaviour
{
    // Variables for socket connection
    private TcpListener listener;
    private TcpClient client;
    private NetworkStream stream;

    void Start()
    {
        ConnectToPython();
    }

    void ConnectToPython()
    {
       
        client = new TcpClient("localhost", 5050);
        stream = client.GetStream();

    
        byte[] data = new byte[1024];
        int bytesRead = stream.Read(data, 0, data.Length);
        string messageFromPython = Encoding.ASCII.GetString(data, 0, bytesRead);

      
        Debug.Log("Unity: Message from Python: " + messageFromPython);

        
        stream.Close();
        client.Close();
    }
}