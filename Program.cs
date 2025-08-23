using CapySystem;
using CapyFileSystem;
CapyFileConsole.GetPaper();
CapyConsole.Talk("Write the path and the content");
string path = CapyConsole.Answer();
string content = CapyConsole.Answer();
CapyFileConsole.Write(path, content);

