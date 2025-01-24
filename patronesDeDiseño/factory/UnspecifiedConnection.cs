class UnspicifiedConnection: IConnection {
    public void Connect() {
        Console.WriteLine("Connecting to unspecified database...");
    }
    public void Disconnect() {
        Console.WriteLine("Disconnecting from unspecified database...");
    }
}