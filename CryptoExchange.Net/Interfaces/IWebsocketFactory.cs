﻿namespace CryptoExchange.Net.Interfaces
{
    public interface IWebsocketFactory
    {
        IWebsocket CreateWebsocket(string url);
    }
}
