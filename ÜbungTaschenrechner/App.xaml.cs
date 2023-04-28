using ControlzEx.Theming;            // Die ControlzEx.Theming Namespace wird normalerweise verwendet, um die Benutzeroberfläche einer WPF-Anwendung mit verschiedenen Designs zu versehen. Es enthält verschiedene Klassen, die für die Verwendung von Themes in einer WPF-Anwendung hilfreich sind, einschließlich der ThemeManager Klasse, die das Verwalten und Anwenden von Designs auf eine WPF-Anwendung erleichtert.
using System;
using System.Collections.Generic;
using System.Configuration;    // Die System.Configuration Namespace enthält Typen, die das Lesen von Konfigurationsinformationen aus der Konfigurationsdatei ermöglichen, einschließlich von Typen, die die Verwendung von Konfigurationsdateien mit .NET Framework-Anwendungen vereinfachen. Es ermöglicht auch das Schreiben von Konfigurationsinformationen in eine benutzerdefinierte Konfigurationsdatei.
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using ÜbungTaschenrechner.WPF;     // importiert den Namesraum "ÜbungTaschenrechner.WPF", was bedeutet, dass alle im Namespace definierten Klassen und Ressourcen in der aktuellen Datei verwendet werden können. Dies ist nützlich, wenn Sie auf eine Klasse oder Ressource in einem anderen Teil Ihrer Anwendung zugreifen müssen.
using ResX = ÜbungTaschenrechner.Resources.Resources;   // Die Anweisung "ResX = ÜbungTaschenrechner.Resources.Resources" erstellt eine Alias-Referenz mit dem Namen "ResX" für die Klasse "Resources" im Namespace "ÜbungTaschenrechner.Resources". Mit dieser Alias-Referenz können wir auf die Ressourcen unserer Anwendung zugreifen und diese in XAML-Dateien und im Code verwenden.


namespace ÜbungTaschenrechner
{
    /// <summary>
    /// Interaktionslogik für "App.xaml"
    /// </summary>
    public partial class App : Application    // Die Klasse App ist die Standardanwendungsklasse in einer WPF-Anwendung und wird automatisch beim Starten der Anwendung erstellt.
                                              // Diese Klasse stellt eine zentrale Stelle zur Verfügung, um Anwendungsweite Ereignisbehandlungsroutinen, Ressourcen und Einstellungen zu definieren. Die partial-Anweisung zeigt an, dass die Klasse in mehrere Quellcodedateien aufgeteilt wurde, um die Lesbarkeit und Wartbarkeit des Codes zu verbessern.
    {
        protected override void OnStartup(StartupEventArgs args)     // Die Methode OnStartup wird in der App-Klasse aufgerufen, wenn die Anwendung gestartet wird. Sie überschreibt die Standardimplementierung der OnStartup-Methode in der Application-Klasse und kann verwendet werden, um benutzerdefinierte Initialisierungsaufgaben auszuführen, bevor die Anwendung angezeigt wird
        {
            if(args.Args.Contains("de"))    // prüft, ob das Argument "de" in den beim Starten der Anwendung übergebenen Argumenten enthalten ist. Wenn ja, wird die Anwendung mit der deutschen Lokalisierung gestartet.
            {
                ResX.Culture = new System.Globalization.CultureInfo("de");    // setzt die Kultur des Programms auf Deutsch, wenn der Anwendungsstartparameter "de" enthält. Hier wird die Sprache für die Ressourcendatei "Resources.resx" auf "de" gesetzt. Dadurch werden die in der Ressourcendatei gespeicherten Texte, wie z.B. der Titel des Hauptfensters oder die Beschriftungen von Schaltflächen, in Deutsch angezeigt.
            }            
            
            ThemeManager.Current.ThemeSyncMode = ThemeSyncMode.SyncAll;     // sorgt dafür, dass das ControlzEx-Theme-System im gesamten Anwendungsprojekt synchronisiert wird. Dies bedeutet, dass das gleiche Theme automatisch auf alle Fenster, Steuerelemente und UI-Elemente in der Anwendung angewendet wird, sofern dies möglich ist.
            ThemeManager.Current.SyncTheme();     // synchronisiert das aktuelle Theme mit dem Betriebssystem-Theme. Wenn ThemeSyncMode auf SyncAll gesetzt ist, wird auch der Accent (Farbton) des Betriebssystem-Themes verwendet.

            CalculatorWindow window = new CalculatorWindow();    // erstellt eine neue Instanz des CalculatorWindow-Fensters. Das Fenster wird mithilfe des Standardkonstruktors (ohne Parameter) erstellt und dann der Variable window zugewiesen.

            window.Show();    // Dieser Code öffnet ein neues Fenster (CalculatorWindow) und zeigt es an. Der Typ des Fensters ist im vorherigen Code definiert worden. Die Show()-Methode wird aufgerufen, um das Fenster anzuzeigen.
        }
    }
}
