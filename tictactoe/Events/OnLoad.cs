using System;
using TicTacToe.Game;

namespace TicTacToe.Events;

public class OnLoad
{
    
    private static readonly string SettingsFile = "settings.json";
    public static void PreStart()
    {
        if (!File.Exists(SettingsFile))
            CreatePlayerSettings.Start();
    }
    
    public static void SaveSettings()
    {
        
    }
}