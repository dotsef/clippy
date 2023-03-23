using TextCopy;

var clipboard = new Clipboard();

if (Console.IsInputRedirected)
    clipboard.SetText(Console.In.ReadToEnd());

if (Console.IsOutputRedirected || !Console.IsInputRedirected)
    Console.WriteLine(clipboard.GetText());
