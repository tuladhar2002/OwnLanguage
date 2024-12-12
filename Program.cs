using Antlr4.Runtime;
using OwnLanguage;
using OwnLanguage.Content;

var filename = Path.Combine(Directory.GetCurrentDirectory(), "testOwnLanguageFile.txt");

if (!File.Exists(filename))
{
    // Adjust if running from the bin directory (debugger)
    filename = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory())!.FullName, "../../testOwnLanguageFile.txt");
}

var fileCOntent = File.ReadAllText(filename);

// Boiler plate stuffs for Antlr
var inputStream = new AntlrInputStream(fileCOntent);
var grammerLexer = new GrammerLexer(inputStream);
var commonTokenStream = new CommonTokenStream(grammerLexer);
var grammerParser = new GrammerParser(commonTokenStream);
// grammerParser.AddErrorListener(new ErrorListener()); // need to implement error listener
var grammerContext = grammerParser.program();
var visitor = new SimpleVisitor();
visitor.Visit(grammerContext);












