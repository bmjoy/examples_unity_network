﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobbyServer
{
    class LobbyManager
    {
        List<Lobby> LobbyList = new List<Lobby>();

        public void CreateRooms()
        {
            var maxLobbyCount = LobbyServer.ServerOpt.LobbyMaxCount;
            var startNumber = LobbyServer.ServerOpt.LobbyStartNumber;
            var maxUserCount = LobbyServer.ServerOpt.LobbyMaxUserCount;

            for(int i = 0; i < maxLobbyCount; ++i)
            {
                var lobbyNumber = (startNumber + i);
                var lobby = new Lobby();
                lobby.Init(i, lobbyNumber, maxUserCount);

                LobbyList.Add(lobby);
            }                                   
        }


        public List<Lobby> GetLobbyList() { return LobbyList; }
    }
}
