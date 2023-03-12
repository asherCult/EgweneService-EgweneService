using Gtk;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Server.Kestrel.Transport.Quic;
using MonoMac.OpenGL;

namespace EgweneService.TrayIcon;

using H.NotifyIcon.Core;

public class TrayBuilder
{

    private TrayIcon _trayIcon;

    public TrayBuilder() {}

#pragma warning disable CA1416
    public TrayIconWithContextMenu CreateIcon()
    {

        var icon = new System.Drawing.Icon(Path.Combine(AppContext.BaseDirectory, "Resources", "icon.ico"));

        var trayIcon = new TrayIconWithContextMenu
        {
            UseStandardTooltip = true,
            ContextMenu = GenerateContextMenu(),
            Icon = icon.Handle,
            ToolTip = "Egwene Service"
        };

        _trayIcon = trayIcon;

        return trayIcon;
    }



    private PopupMenu GenerateContextMenu()
    {
        return new PopupMenu()
        {
            Items =
            {
                new PopupMenuSeparator(),
                new PopupMenuItem("About", (_,_) => About()),
                new PopupMenuItem("Config", (_,_) => Config()),
                new PopupMenuSeparator(),
                new PopupMenuItem("Exit", (_,_) => Quit()),
                new PopupMenuSeparator(),
            }
        };
    }
#pragma warning restore CA1416

    private void Quit()
    {
        _trayIcon.Dispose();
        Environment.Exit(0);
    }

    private void About()
    {
        
    }

    private void Config()
    {
        
    }

    
}
