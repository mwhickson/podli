using Terminal.Gui;

Application.Init(); // need to set the stage, before we can play...

//
// functions
//

static bool TODO() {
    return true;
}

static bool ConfirmQuit() {
    int answer = MessageBox.Query(50, 5, "Quit", "Really quit?", "Yes", "No");
    return (answer == 0);
}

//
// setup
//

Window MainWindow = new Window("podli"){
    X = 0,
    Y = 1,
    Width = Dim.Fill(),
    Height = Dim.Fill()
};

// TODO: Add time to menu... (or somewhere...)
MenuBar MainMenu = new MenuBar(
    new MenuBarItem[] {
        new MenuBarItem("_File", new MenuItem[] {
            new MenuItem("_Quit", "", () => { if (ConfirmQuit()) {Application.Top.Running = false; } })
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

//
// main
//

Application.Top.Add(MainWindow);
Application.Top.Add(MainMenu);

Application.Run();
