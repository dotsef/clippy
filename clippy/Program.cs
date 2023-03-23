using TextCopy;

var clipboard = new Clipboard();
if (Console.IsInputRedirected)
    clipboard.SetText(Console.In.ReadToEnd());
else
    Console.WriteLine(clipboard.GetText());
