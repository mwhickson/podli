using Terminal.Gui;

Application.Init();

var top = Application.Top;

var win = new Window("podli"){
    X = 0,
    Y = 1,
    Width = Dim.Fill(),
    Height = Dim.Fill()
};

top.Add(win);

// TODO: Add time to menu... (or somewhere...)
var menu = new MenuBar(
    new MenuBarItem[] {
        new MenuBarItem("_File", new MenuItem[] {
            new MenuItem("_Quit", "", () => { if (Quit()) top.Running = false; })
        }),
        new MenuBarItem("_Podcasts", new MenuItem[] {
            new MenuItem("_Subscriptions", "", () => { TODO(); }),
            new MenuItem("_New", "", () => { TODO(); }),
            new MenuItem("_Import OPML", "", () => { TODO(); }),
            new MenuItem("_Export OPML", "", () => { TODO(); }),
            new MenuItem("Now _Playing", "", () => { TODO(); })
        }),
        new MenuBarItem("_Search", new MenuItem[] {
            new MenuItem("_iTunes Store", "", () => { TODO(); })
        }),
        new MenuBarItem("_Help", new MenuItem[] {
            new MenuItem("_About", "", () => { TODO(); }),
            new MenuItem("_Tools", "", () => { TODO(); }),
            new MenuItem("_Source Code", "", () => { TODO(); })
        })
    }
);

top.Add(menu);

static bool TODO() {
    return true;
}

static bool Quit() {
    var result = MessageBox.Query(50, 5, "Quit", "Really quit?", "Yes", "No");
    return (result == 0);
}

Application.Run();