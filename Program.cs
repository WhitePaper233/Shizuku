using Fleck;

var server = new WebSocketServer("ws://0.0.0.0:8081");

server.Start(socket =>
{
    socket.OnOpen = () => { Console.WriteLine("Client Connected"); };

    socket.OnClose = () => { Console.WriteLine("Client Disconnected"); };

    socket.OnMessage = message =>
    {
        Console.WriteLine("Received: " + message);
        socket.Send(message);
    };
});

Console.WriteLine("WebSocket Server is running on ws://0.0.0.0:8081");
Console.WriteLine("Press Enter to stop the server...");
Console.ReadLine();
