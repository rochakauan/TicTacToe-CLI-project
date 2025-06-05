using TicTacToe.Utils;

namespace TicTacToe.Game;

public static class CreatePlayerSettings
{
    
    private static List<string> _playerSettings = [];
    public static void Start()
    {
        ConsoleUtils.Message("Let´s create your player settings...", ConsoleColor.Green, clearConsoleBefore: true);
        ConsoleUtils.Pause();
        
        SavePlayerLanguage();
    }

    private static void SavePlayerLanguage()
    {
        ConsoleUtils.Message("Default language:", ConsoleColor.Green, clearConsoleBefore: true);
        ConsoleUtils.Message("(1) - English - US\n(2) - Portugues - Brasil", ConsoleColor.Yellow);
        ConsoleUtils.Message("-------------------", ConsoleColor.Green);
        HandleSavePlayerLanguageSettings();
    }

    private static void HandleSavePlayerLanguageSettings()
    {
         switch (ConsoleUtils.Ask("Select your language..."))
        {
            case "1":
            {
                var confirmOption =
                    ConsoleUtils.Ask("You´re choosing ENGLISH (US) as your default language, continue? (y) / (n)", ConsoleColor.Yellow)
                        .ToLower();
                if (confirmOption == "y")
                {
                    _playerSettings.Add("English");
                    ConsoleUtils.Message("Great! Now your default language still being English (you can change it later if you want)", ConsoleColor.Green);
                }
                else { SavePlayerLanguage(); }
                break;
            }
            case "2":
            {
                var confirmOption =
                    ConsoleUtils.Ask("PORTUGUES (BRASIL) sera seu idioma padrao, continuar? (s) / (n)", ConsoleColor.Yellow)
                        .ToLower();
                if (confirmOption == "s")
                {
                    _playerSettings.Add("Portugues");
                    ConsoleUtils.Message("Ótimo! Seu idioma padrão foi definido para o português brasileiro (voce pode mudar isso depois se quiser)", ConsoleColor.Green);
                }
                else { SavePlayerLanguage(); }
                break;
            }
            default: SavePlayerLanguage(); break;
        }
    }

    public static void ShowPlayerSettings()
    {
        foreach (var playerSetting in _playerSettings)
            ConsoleUtils.Message($"{playerSetting}", ConsoleColor.Green);
    }
}