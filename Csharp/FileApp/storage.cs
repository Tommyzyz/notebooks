#:property TargetFramework=net10.0-windows10.0.19041.0
#:property  WindowsPackageType=None

#:package Microsoft.WindowsAppSDK@1.8.260416003


using Microsoft.UI.Windowing;
using Microsoft.Windows.Storage.Pickers;


var window = AppWindow.Create();
window.Resize(new Windows.Graphics.SizeInt32(900, 400));
window.Title = "hello";
window.Show(true);



var openPicker = new FileOpenPicker(window.Id)
{
    // (Optional) Specify the initial location for the picker. 
    //     If the specified location doesn't exist on the user's machine, it falls back to the DocumentsLibrary.
    //     If not set, it defaults to PickerLocationId.Unspecified, and the system will use its default location.
    SuggestedStartLocation = PickerLocationId.DocumentsLibrary,
    
    // (Optional) specify the text displayed on the commit button. 
    //     If not specified, the system uses a default label of "Open" (suitably translated).
    CommitButtonText = "Choose selected files",

    // (Optional) specify file extension filters. If not specified, defaults to all files (*.*).
    FileTypeFilter = { ".txt", ".pdf", ".doc", ".docx" },

    // (Optional) specify the view mode of the picker dialog. If not specified, defaults to List.
    ViewMode = PickerViewMode.List,
};

var result = await openPicker.PickSingleFileAsync();
if (result is not null)
{
    var content = System.IO.File.ReadAllText(result.Path);
}
else
{
    // Add your error handling here.
}


