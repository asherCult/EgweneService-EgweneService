using Gtk;
using Microsoft.AspNetCore.Http.HttpResults;
using MonoMac.OpenGL;

namespace EgweneService.TrayIcon;

using H.NotifyIcon.Core;

public class TrayBuilder
{

    private TrayIcon _trayIcon;

    public TrayBuilder()
    {


    }

#pragma warning disable CA1416
    public TrayIcon CreateIcon()
    {

        var icon = new System.Drawing.Icon(Path.Combine(AppContext.BaseDirectory, "Resources", "icon.ico"));

        var trayIcon = new TrayIconWithContextMenu
        {
            Icon = icon.Handle,
            ToolTip = "Egwene Service",
        };

        trayIcon.ContextMenu = new PopupMenu
        {
            Items =
            {
                new PopupMenuItem("Exit", (sender, args) =>
                {
                    trayIcon.Dispose();
                    Environment.Exit(0);
                }),
            },
        };

        return trayIcon;
    }
#pragma warning restore CA1416
}
